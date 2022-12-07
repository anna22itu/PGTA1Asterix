

using Library;
using Asterix_Decoder;
using AsterixDecoder;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Data;
using System.Xml;
using System.Text;

namespace Interfaz
{
    public partial class MENU : Form
    {

        public bool result = true;
        public bool result2 = false;

        public bool mapSatelite = false;

        public bool resLoadMap = true;

        GMarkerGoogle marker;
        GMapOverlay overlay;


        DataTable dtInf;

        String targetID;

        double LatLEBL = 41.29839;
        double LongLEBL = 2.08331;

        bool loadMap = false;

        static bool dataLoaded = false;

        bool Selected = false;
        String IDSelected;
        Aircraft aircraftSelected;

        String timescale;

        TableData dt = new TableData();

        List<Aircraft> listAircraftADSB = new List<Aircraft>(); // Guardaremos aquí todos los aviones ADSB
        List<Aircraft> listAircraftMLAT = new List<Aircraft>(); // Guardaremos aquí todos los aviones MLAT
        List<Aircraft> listAircraftSMR = new List<Aircraft>(); // Guardaremos aquí todos los aviones SMR




        public MENU()
        {
            InitializeComponent();
            BtnParar.Hide();
            gMapControl1.Hide();
            pictureBoxMapaDifuminado.Show();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            labelAsterixReLoadMap.Hide();
            labelStopPlay.Hide();
            labelAircraftInfo.Hide();
            labelZoomLEBL.Hide();
            labelHora.Hide();
            labelSateliteView.Hide();
            labelZoomBCN.Hide();
            label6ZoomCAT.Hide();
            guna2PanelShowList.Visible = false;
        }



        // LOAD & EXPORT FILE
        bool fileimported = false;
        bool dataRead = false;
        bool isFirstTime = true;
        bool calledFromLoad = false;
        private void loadFile()
        {
            if (readGoing == false)
            {
                dt = new TableData();
                if (dataLoaded || isFirstTime)
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        checksreset();

                        dataLoaded = false;
                        dataRead = false;
                        fileimported = true;
                        string filename = openFileDialog1.FileName;
                        byte[] fileBytes = File.ReadAllBytes(filename);
                        string bitString = BitConverter.ToString(fileBytes);
                        var loadingended = new Progress<int>(stoploadingRead);
                        var loadingDTstarted = new Progress<int>(loadingDataTable);
                        var loadingDTended = new Progress<int>(stoploadingDataTable);
                        loadingRead();
                        Thread readThread = new Thread(() =>
                        {
                            Read.main(bitString, loadingended);
                            dataRead = true;
                            System.Windows.MessageBox.Show("The file has been loaded successfully.");
                            dt.LoadData(loadingDTstarted, loadingDTended);
                            dataLoaded = true;
                        });
                        readThread.Start();

                        labelCurrentFilenameResponse.Text = filename[(filename.LastIndexOf("\\") + 1)..];


                        if (filename.EndsWith("adsb.ast") && filename[filename.Length - 10] != 't')
                        {
                            checkBoxMLAT.Enabled = false;
                            checkBoxSMR.Enabled = false;
                            checkBoxADSB.Checked = true;
                        }
                        else if (filename.EndsWith("mlat.ast"))
                        {
                            checkBoxADSB.Enabled = false;
                            checkBoxSMR.Enabled = false;
                            checkBoxMLAT.Checked = true;
                        }
                        else if (filename.EndsWith("smr.ast"))
                        {
                            checkBoxMLAT.Enabled = false;
                            checkBoxADSB.Enabled = false;
                            checkBoxSMR.Checked = true;
                        }
                        else if (filename.EndsWith("smr_mlat_adsb.ast"))
                        {
                            checkBoxMLAT.Enabled = true;
                            checkBoxADSB.Enabled = true;
                            checkBoxSMR.Enabled = true;
                            checkBoxADSB.Checked = true;
                            checkBoxMLAT.Checked = true;
                            checkBoxSMR.Checked = true;
                        }


                    }
                }
                else if (dataLoaded == false)
                {
                    MessageBox.Show("Please wait until the current file has been completely loaded.", "File currently loading.");
                }

                else
                {
                    MessageBox.Show("ERROR: The file has not been loaded successfully.");
                }
            }

            else
            {
                if (mapPaused == false)
                {
                    MessageBox.Show("Please, first pause the simulation.");
                }
                else if (MessageBox.Show("Do you want to stop this running and start another one?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    calledFromLoad = true;
                    CancelThread = true;
                }
            }
        }
        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            loadFile();
        }
        private void checksreset()
        {
            this.Invoke(resetchecks);

        }

        private void loadingExport(int i)
        {
            iconPictureBox3.Hide();
            pictureBox4.Show();
        }
        private void stoploadingExport(int i)
        {
            pictureBox4.Hide();
            iconPictureBox3.Show();
        }
        private void BtnExportFile_Click(object sender, EventArgs e)
        {
            if (dataRead == true)
            {
                saveFileDialog1.FileName = "Save Here";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var loadingExportstarted = new Progress<int>(loadingExport);
                    var loadingExportended = new Progress<int>(stoploadingExport);
                    Thread export = new Thread(() => { bool result = Data.export(Path.GetDirectoryName(saveFileDialog1.FileName), loadingExportstarted, loadingExportended); });
                    export.Start();

                    if (result == true)
                    {
                        MessageBox.Show("The file has been exported correctly./n You can find it in the selected folder as an excel file");
                    }
                    else
                    {
                        MessageBox.Show("ERROR: The file has not been exported correctly.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a destination for the exported file.");
                }
            }
            else if (fileimported)
            {
                MessageBox.Show("The file is processing. This could take a few minutes.", "Please wait.");
            }
            else
            {
                MessageBox.Show("No file has been imported yet.", "Please open a file.");
            }



        }


        // TABLA

        private void loadingRead()
        {
            this.Invoke(readloading);
        }
        private void stoploadingRead(int i)
        {
            pictureBox2.Hide();
            iconPictureBox2.Show();
        }

        private void loadingDataTable(int i)
        {
            iconPictureBox6.Hide();
            pictureBox3.Show();
        }
        private void stoploadingDataTable(int i)
        {
            pictureBox3.Hide();
            iconPictureBox6.Show();
        }
        private void BtnDataView_Click(object sender, EventArgs e)
        {
            if (dataLoaded == false)
            {
                if (fileimported == true)
                {
                    MessageBox.Show("The data table is being loaded. This could take a few minutes.", "Please wait.");
                }
                else
                {
                    MessageBox.Show("No file has been imported yet.", "Please open a file.");
                }
            }
            else
            {
                dt.Show();
            }

        }


        // SIMULATOR (MAP)

        List<Aircraft> targetList = new List<Aircraft>();
        List<string> targetNames = new List<string>();
        List<GMarkerGoogle> markersList = new List<GMarkerGoogle>();
        bool readGoing = false;

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom = 13;

            if (dataRead == false)
            {
                MessageBox.Show("No file has been imported yet.", "Please open a file.");
            }
            else if (loadMap == false)
            {
                MessageBox.Show("First load the map --> on the MAP VIEW button");
            }
            else if (loadMap && readGoing == false) //que nomes funcionin si el mapa esta loaded
            {
                MessageBox.Show("This simulation could take a few minutes. Please wait until you are told thatit's over, or pause it and play it whenever you want . Thanks for waiting :)");
                BtnParar.Show();
                BtnPlay.Hide();
                Thread.Sleep(1000);
                ReadTargets();

            }
            else if (loadMap && readGoing)
            {
                BtnParar.Show();
                BtnPlay.Hide();
                Hora.Start();
                mapPaused = false;
            }
        }
        bool mapPaused = false;
        private void BtnParar_Click(object sender, EventArgs e)
        {
            if (loadMap)
            {
                BtnParar.Hide();
                BtnPlay.Show();
                Hora.Stop(); //parem el timer i es parara el thread
                mapPaused = true;
            }

        }

        Thread readTargetThread;
        bool ableToLoad = true;
        bool CancelThread = false;
        private void ReadTargets() //aqui anirem llegint al ritme del timer del primer temps, segon a segon, 
        {
            gMapControl1.Overlays.Clear();
            targetList.Clear();
            targetNames.Clear();
            markersList.Clear();
            setTimer(Data.TotalItems[0][Data.columns["Time of Day"]].ToString());
            isFirstTime = false;
            labelHora.Show();
            CancelThread = false;

            readTargetThread = new Thread(reading);
            readTargetThread.SetApartmentState(System.Threading.ApartmentState.STA);
            readTargetThread.Start();
        }
        private void reading()
        {
            readGoing = true;
            int testLen = 1000; //per que funcioni caldra que i < Data.TotalItems.Count
            for (int i = 0; i < testLen; i++)
            {
                object[] item = Data.TotalItems[i];
                string dataTime = item[Data.columns["Time of Day"]].ToString();
                bool waiting = true;
                while (waiting)
                {
                    if ((int)TimeSpan.Parse(labelHora.Text).TotalSeconds >= (int)TimeSpan.Parse(dataTime).TotalSeconds && ableToLoad)
                    {
                        Thread plotTargetThread = new Thread(() => plotTarget(item));
                        plotTargetThread.Start();
                        waiting = false;
                    }
                    Thread.Sleep(20);
                    if (CancelThread)
                    {
                        break;
                    }
                }
                if (CancelThread)
                {
                    break;
                }
                //Thread.Sleep(1000);
            }
            Hora.Stop();
            readGoing = false;

            if (CancelThread == false)
            {
                MessageBox.Show("Simulation ended");
            }
            else
            {
                gMapControl1.Overlays.Clear();
                targetList.Clear();
                targetNames.Clear();
                markersList.Clear();
                if (calledFromLoad)
                {
                    this.Invoke(showdif);
                    loadMap = false;
                    labelHora.Hide();
                    resetLoad();
                }

            }

        }
        private void resetLoad()
        {
            this.Invoke(loadFile);

        }
        private void plotTarget(object[] item)
        {
            ableToLoad = false;
            double longitude = double.NaN;
            double latitude = double.NaN;
            double z = 0;
            double groundSpeed = double.NaN;
            string callsing = null;
            double FL = double.NaN;
            double trackNumber = double.NaN;
            string packets = null;
            string ID = null;
            string type = null;
            int cat = 0;

            if (item[Data.columns["Geometric Height"]] != null)
            {
                z = Convert.ToDouble(item[Data.columns["Geometric Height"]]);
            }
            else if (item[Data.columns["Height"]] != null)
            {
                z = Convert.ToDouble(item[Data.columns["Height"]]);
            }


            if (item[Data.columns["Ground Speed"]] != null)
            {
                groundSpeed = Convert.ToDouble(item[Data.columns["Ground Speed"]]);
            }
            //if (item[Data.columns["Callsing"]] != null)
            //{
            //    callsing = Convert.ToString(item[Data.columns["Callsing"]]);
            //}
            if (item[Data.columns["FL"]] != null)
            {
                FL = Convert.ToDouble(item[Data.columns["FL"]]);
            }
            if (item[Data.columns["Track Number"]] != null)
            {
                trackNumber = Convert.ToDouble(item[Data.columns["Track Number"]]);
            }
            //if (item[Data.columns["Packets"]] != null)
            //{
            //    packets = Convert.ToString(item[Data.columns["Packets"]]);
            //}


            if (item[Data.columns["Latitude WGS84"]] == null && item[Data.columns["Longitude WGS84"]] == null && item[Data.columns["MessageType"]] != null) //té nomes cartesianes
            {
                if (item[Data.columns["MessageType"]].ToString() == "Target Report")
                {
                    cat = 10;
                    double latRadar;
                    double longRadar;
                    if (item[Data.columns["Target Address"]] != null)
                    {
                        type = "MLAT";
                        latRadar = 41.297;
                        longRadar = 2.07845;
                    }

                    else
                    {
                        type = "SMR";
                        latRadar = 41.2956;
                        longRadar = 2.095;
                    }

                    GeoUtils g = new GeoUtils();
                    CoordinatesWGS84 radarWGS84 = new CoordinatesWGS84(Functions.degtorad(latRadar), Functions.degtorad(longRadar));
                    CoordinatesXYZ cartesian = new CoordinatesXYZ(Convert.ToDouble(item[Data.columns["X Cartesian"]]), Convert.ToDouble(item[Data.columns["Y Cartesian"]]), z);
                    CoordinatesXYZ geocentric = g.change_radar_cartesian2geocentric(radarWGS84, cartesian);
                    CoordinatesWGS84 geodesic = g.change_geocentric2geodesic(geocentric);
                    latitude = Functions.radtodeg(geodesic.Lat);
                    longitude = Functions.radtodeg(geodesic.Lon);
                    z = geodesic.Height;
                }

            }
            else if (item[Data.columns["Latitude WGS84"]] != null && item[Data.columns["Longitude WGS84"]] != null)
            {
                cat = 21;
                type = "ADSB";

                latitude = Convert.ToDouble(item[Data.columns["Latitude WGS84"]]);
                longitude = Convert.ToDouble(item[Data.columns["Longitude WGS84"]]);
            }

            //CAL AFEGIR LA CAT21 I QUE SI LA DISTANCIA ENTRE EL VELL I EL NOU ES MOLTA, BORREM EL VELL I QUE APAREIXI EL NOU NOMES
            if (cat != 0)
            {
                if (item[Data.columns["Target Identification"]] != null)
                {

                    ID = item[Data.columns["Target Identification"]].ToString();
                }

                else if (item[Data.columns["Track Number"]] != null)
                {
                    ID = item[Data.columns["Track Number"]].ToString();
                }


                if (longitude != double.NaN && latitude != double.NaN && ID != null && type != null && groundSpeed != double.NaN && FL != double.NaN && trackNumber != double.NaN) //podem carregar dades
                {
                    if (targetNames.Contains(ID)) //comprobem si aquest target ja existeix
                    {
                        targetList[targetNames.IndexOf(ID)].setLat(latitude);
                        targetList[targetNames.IndexOf(ID)].setLong(longitude);
                        targetList[targetNames.IndexOf(ID)].setHeight(z);
                        targetList[targetNames.IndexOf(ID)].setGroundSpeed(groundSpeed);
                        targetList[targetNames.IndexOf(ID)].setCallsing(callsing);
                        targetList[targetNames.IndexOf(ID)].setFL(FL);
                        targetList[targetNames.IndexOf(ID)].setPackets(packets);
                        targetList[targetNames.IndexOf(ID)].setTrackNumber(trackNumber);
                        markersList[targetNames.IndexOf(ID)].Position = new PointLatLng(targetList[targetNames.IndexOf(ID)].getLat(), targetList[targetNames.IndexOf(ID)].getLong());
                    }
                    else //si no existeix, creem un i l'afegim
                    {
                        Aircraft a = new Aircraft(ID, longitude, latitude, z, type, groundSpeed, FL,trackNumber,packets);
                        GMapOverlay targets = new GMapOverlay(ID);
                        GMarkerGoogle markerTarget = new GMarkerGoogle(new PointLatLng(a.getLat(), a.getLong()), a.getbmp());

                        targetList.Add(a);
                        targetNames.Add(ID);
                        markersList.Add(markerTarget);
                        targets.Markers.Add(markerTarget);
                        gMapControl1.Overlays.Add(targets);
                    }
                }
            }
            ableToLoad = true;
        }


        private void BtnMapView_Click(object sender, EventArgs e)
        {
       
            // Avion
            try
            {
                if (dataRead && loadMap == false)
                {
                    gMapControl1_Load(sender, e);
                    //loadAircraftInfoTable(); //desde loadAircraftInfoData es podra show la data de l'avio quan es faci click sobre l'avio o es busqui el seu id
                }
                else if (fileimported)
                {
                    MessageBox.Show("The file is processing. This could take a few minutes.", "Please wait.");
                }
                else
                {
                    MessageBox.Show("Please, first import a file.", "File not loaded.");
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("The data has not been loaded correctly");
            }
            catch (Exception)
            {
                MessageBox.Show("The data has not been loaded correctly");
            }


        }


        private void btnClearAicraft_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewInfoAircraft.RowCount; i++)
            {
                dataGridViewInfoAircraft.Rows[i].Cells[1].Value = "";
            }
        }

 


        private void gMapControl1_Load(object sender, EventArgs e)
        {

            gMapControl1.Show();
            pictureBoxMapaDifuminado.Hide();
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MarkersEnabled = true;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatLEBL, LongLEBL);
            gMapControl1.MinZoom = 7;
            gMapControl1.MaxZoom = 23;
            gMapControl1.Zoom = 14;
            gMapControl1.AutoScroll = true;
            gMapControl1.OnMarkerClick += new MarkerClick(gMapControl1_OnMarkerClick);

            loadMap = true;

        }


        // ABOUT US
        private void BtnAboutUs_Click(object sender, EventArgs e)
        {
            Form f = new AboutUs();
            f.Show();
        }


        // EXTRAS
        private void iconBtnMenuBars_Click(object sender, EventArgs e)
        {

            if (result == true)
            {
                panelMENU.Hide();
                result = false;
            }
            else
            {
                panelMENU.Show();
                result = true;
            }
        }
        private void setTimer(string initialtime)
        {
            Hora.Enabled = true;
            labelHora.Text = initialtime;
            if (isFirstTime)
            {
                Hora.Tick += new System.EventHandler(this.Hora_Tick);
            }
        }
        private void Hora_Tick(object sender, EventArgs e)
        {
            TimeSpan time = TimeSpan.FromSeconds(TimeSpan.Parse(labelHora.Text).TotalSeconds + 1);
            string str = time.ToString(@"hh\:mm\:ss");
            labelHora.Text = str;
        }

        private void iconBtnCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void iconBtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void iconBtnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Form f = new SeguridadClose();
            f.Show();
        }

        private void iconBtnReLoadMap_Click(object sender, EventArgs e)
        {
            if (dataRead == false)
            {
                MessageBox.Show("No file has been imported yet.", "Please open a file.");
            }
            else if (loadMap == false)
            {
                MessageBox.Show("First load the map --> on the MAP VIEW button");
            }
            else if (loadMap && readGoing == false)
            {
                MessageBox.Show("Please, first start the map with the PLAY button.");
            }
            else if (loadMap && readGoing) //que nomes funcionin si el mapa esta loaded i running
            {
                if (mapPaused == false)
                {
                    MessageBox.Show("Please, first pause the simulation.");
                }
                else if (MessageBox.Show("Do you want to restart this simulation?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CancelThread = true;
                    MessageBox.Show("This could take a few minutes. Please wait until you are told that all aircrafts have been loaded. Thanks for waiting :)");
                    BtnParar.Show();
                    BtnPlay.Hide();
                    Thread.Sleep(1000);
                    Hora.Start();
                    ReadTargets();
                }

            }
        }

        private void iconBtnReLoadMap_MouseEnter(object sender, EventArgs e)
        {
            labelAsterixReLoadMap.Show();
        }

        private void iconBtnReLoadMap_MouseLeave(object sender, EventArgs e)
        {
            labelAsterixReLoadMap.Hide();
        }

        private void BtnParar_MouseEnter(object sender, EventArgs e)
        {
            labelStopPlay.Show();
        }

        private void BtnParar_MouseLeave(object sender, EventArgs e)
        {
            labelStopPlay.Hide();
        }

        private void BtnPlay_MouseEnter(object sender, EventArgs e)
        {
            labelStopPlay.Show();
        }

        private void BtnPlay_MouseLeave(object sender, EventArgs e)
        {
            labelStopPlay.Hide();
        }



        private void iconPictureBox7_MouseEnter(object sender, EventArgs e)
        {
            labelAircraftInfo.Show();
        }

        private void iconPictureBox7_MouseLeave(object sender, EventArgs e)
        {
            labelAircraftInfo.Hide();
        }


        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            labelZoomLEBL.Hide();
        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            labelZoomLEBL.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (this.loadMap)
            {
                gMapControl1.CanDragMap = true;
                gMapControl1.Position = new PointLatLng(LatLEBL, LongLEBL);
                gMapControl1.MinZoom = 3;
                gMapControl1.MaxZoom = 22;
                gMapControl1.Zoom = 14;
                gMapControl1.AutoScroll = true;
                gMapControl1.OnMarkerClick += new MarkerClick(gMapControl1_OnMarkerClick);
            }
            else
            {
                MessageBox.Show("First load the map --> on the MAP VIEW button");
            }
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            bool Selected = true;

            if (Selected)
            {
                MessageBox.Show("You have selected the " + item.Overlay.Id + " aircraft.");
                Selected = false;
            }

            loadAircraftInfoTable(item, e.X,e.Y);

        }

        private void loadAircraftInfoTable(GMapMarker item, int X, int Y)
        {
            // Data de información
            dtInf = new DataTable();
            dataGridViewInfoAircraft.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewInfoAircraft.Font, FontStyle.Bold);
            dataGridViewInfoAircraft.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtInf.Columns.Add("Field");
            dtInf.Columns.Add("Value");

            dtInf.Rows.Add("Callsing");
            dtInf.Rows.Add("ICAO");
            dtInf.Rows.Add("FL");
            dtInf.Rows.Add("Track Nº");
            dtInf.Rows.Add("Ground Speed");
            dtInf.Rows.Add("Packets");
            dataGridViewInfoAircraft.DataSource = dtInf;



            try
            {
                foreach (Aircraft a in targetList) 
                {
                    if (a.getID().Equals(item.Overlay.Id))
                    {
                        aircraftSelected = a;
                        IDSelected = a.getID();
                        break;
                    }
                }


                //dataGridViewInfoAircraft.Rows[0].Cells[1].Value = aircraftSelected.getCallsing();  // Callsing
                dataGridViewInfoAircraft.Rows[1].Cells[1].Value = IDSelected;  // ICAO
                dataGridViewInfoAircraft.Rows[2].Cells[1].Value = aircraftSelected.getFL();  // FL
                dataGridViewInfoAircraft.Rows[3].Cells[1].Value = aircraftSelected.getTrackNumber();  // Track Nº
                //dataGridViewInfoAircraft.Rows[4].Cells[1].Value = aircraftSelected.getGroundSpeed();  // Ground Speed
                                                                                                      //dataGridViewInfoAircraft.Rows[5].Cells[1].Value = aircraftSelected.getPackets();  // Packets


                textBoxLATAircraft.Text = aircraftSelected.getLat().ToString();
                textBoxLongAircraft.Text = aircraftSelected.getLong().ToString();

            }
            catch
            {
                MessageBox.Show("Please selected an aircraft");
            }

            resLoadMap = false;
        }




        // TIME SCALE
        private void iconBtnBackwards_Click(object sender, EventArgs e)
        {
            this.timescale = labelTimeScale.Text;

            if (timescale == "x1")
            {
                this.Hora.Interval = 1250;
                labelTimeScale.Text = "x0.5";
            }
            else if (timescale == "x1.25")
            {
                this.Hora.Interval = 1000;
                labelTimeScale.Text = "x1";
            }
            else
            {
                MessageBox.Show("You can not move backward the timescale");
            }
        }


        private void iconBtnForward_Click(object sender, EventArgs e)
        {
            this.timescale = labelTimeScale.Text;

            if (timescale == "x1")
            {
                this.Hora.Interval = 500;
                labelTimeScale.Text = "x1.25";
            }
            else if (timescale == "x0.5")
            {
                this.Hora.Interval = 1000;
                labelTimeScale.Text = "x1";
            }
            else if (timescale == "x1.25")
            {
                this.Hora.Interval = 250;
                labelTimeScale.Text = "x1.5";
            }
            else
            {
                MessageBox.Show("You can not move forward the timescale");
            }
        }

        private void iconBtnSearchAircraft_Click(object sender, EventArgs e)
        {
            String IdAicraftSelected = textBoxAircraft.Text;

            if (IdAicraftSelected.Equals(""))
            {
                MessageBox.Show("Please enter the Id of an aircraft");
            }
            else
            {
                try
                {
                    for (int a = 0; a < markersList.Count; a++)
                    {
                        if (markersList[a].Overlay.Id.Contains(IdAicraftSelected))
                        {
                            markersList[a].IsVisible = true;

                            foreach (Aircraft aircraft in targetList) 
                            {
                                if (markersList[a].Overlay.Id.Equals(aircraft.getID()))
                                {
                                    gMapControl1.Position = new PointLatLng(aircraft.getLat(), aircraft.getLong());
                                    gMapControl1.Zoom = 14;
                                }  
                            }
                        }
                        else
                        {
                            markersList[a].IsVisible = false;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("There is no aircraft with this ID, please make sure it is correct");
                }

            }
        }

        private void textBoxAircraft_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxAircraft.Text = "";
            iconButton1_Click(sender, e);
            if (this.loadMap)
            {
                for (int i = 0; i < markersList.Count; i++)
                {
                    markersList[i].IsVisible = true;
                }
            }
            else
            {
                MessageBox.Show("Please load the map first");
            }
        }

        private void checkBoxADSB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                
                foreach (Aircraft a in targetList)
                {
                    if (a.getType().Equals("ADSB"))
                    {
                        listAircraftADSB.Add(a);
                    }
                }


                if (checkBoxADSB.Checked.Equals(false))
                {
                    for (int i = 0; i < markersList.Count; i++)
                    {
                        foreach (Aircraft a in listAircraftADSB)
                        {
                            if (markersList[i].Overlay.Id.Equals(a.getID()))
                            {
                                markersList[i].IsVisible = false;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < markersList.Count; i++)
                    {
                        foreach (Aircraft a in listAircraftADSB)
                        {
                            if (markersList[i].Overlay.Id.Equals(a.getID()))
                            {
                                markersList[i].IsVisible = true;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a compilation problem, please restart the simulator and try again");
            }
        }

        private void checkBoxMLAT_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                foreach (Aircraft a in targetList)
                {
                    if (a.getType().Equals("MLAT"))
                    {
                        listAircraftMLAT.Add(a);
                    }
                }


                if (checkBoxMLAT.Checked.Equals(false))
                {
                    for (int i = 0; i < markersList.Count; i++)
                    {
                        foreach (Aircraft a in listAircraftMLAT)
                        {
                            if (markersList[i].Overlay.Id.Equals(a.getID()))
                            {
                                markersList[i].IsVisible = false;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < markersList.Count; i++)
                    {
                        foreach (Aircraft a in listAircraftMLAT)
                        {
                            if (markersList[i].Overlay.Id.Equals(a.getID()))
                            {
                                markersList[i].IsVisible = true;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a compilation problem, please restart the simulator and try again");
            }
        }

        private void checkBoxSMR_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Aircraft a in targetList)
                {
                    if (a.getType().Equals("SMR"))
                    {
                        listAircraftSMR.Add(a);
                    }
                }


                if (checkBoxSMR.Checked.Equals(false))
                {
                    for (int i = 0; i < markersList.Count; i++)
                    {
                        foreach (Aircraft a in listAircraftSMR)
                        {
                            if (markersList[i].Overlay.Id.Equals(a.getID()))
                            {
                                markersList[i].IsVisible = false;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < markersList.Count; i++)
                    {
                        foreach (Aircraft a in listAircraftSMR)
                        {
                            if (markersList[i].Overlay.Id.Equals(a.getID()))
                            {
                                markersList[i].IsVisible = true;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a compilation problem, please restart the simulator and try again");
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
             
        }

        private void iconBtnSateliteView_MouseEnter(object sender, EventArgs e)
        {
            labelSateliteView.Show();
        }

        private void iconBtnSateliteView_MouseLeave(object sender, EventArgs e)
        {
            labelSateliteView.Hide();
        }

        private void iconBtnSateliteView_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.loadMap && this.mapPaused)
                {
                    if (mapSatelite)
                    {
                        gMapControl1.MapProvider = GMapProviders.GoogleMap;
                        mapSatelite = false;
                    }
                    else
                    {
                        gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
                        mapSatelite = true;
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure the map is loaded and stopped.");
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("There was a problem with the program, restart and try again.");
            }
            
        }

        private void iconButton2_MouseEnter(object sender, EventArgs e)
        {
            labelZoomBCN.Show();
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            labelZoomBCN.Hide();
        }

        private void iconBtnZoomBcn_Click(object sender, EventArgs e)
        {
            if (this.loadMap)
            {
                gMapControl1.CanDragMap = true;
                gMapControl1.Position = new PointLatLng(41.403046, 2.162958);
                gMapControl1.MinZoom = 3;
                gMapControl1.MaxZoom = 22;
                gMapControl1.Zoom = 13;
                gMapControl1.AutoScroll = true;
                gMapControl1.OnMarkerClick += new MarkerClick(gMapControl1_OnMarkerClick);
            }
            else
            {
                MessageBox.Show("First load the map --> on the MAP VIEW button");
            }
        }

        private void iconBtnZoomCAT_MouseEnter(object sender, EventArgs e)
        {
            label6ZoomCAT.Show();
        }

        private void iconBtnZoomCAT_MouseLeave(object sender, EventArgs e)
        {
            label6ZoomCAT.Hide();
        }

        private void iconBtnZoomCAT_Click(object sender, EventArgs e)
        {
            if (this.loadMap)
            {
                gMapControl1.CanDragMap = true;
                gMapControl1.Position = new PointLatLng(41.827016, 1.576821);
                gMapControl1.MinZoom = 3;
                gMapControl1.MaxZoom = 22;
                gMapControl1.Zoom = 8.5;
                gMapControl1.AutoScroll = true;
                gMapControl1.OnMarkerClick += new MarkerClick(gMapControl1_OnMarkerClick);
            }
            else
            {
                MessageBox.Show("First load the map --> on the MAP VIEW button");
            }
        }

        private void iconBtnShowList_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.loadMap)
                {
                    guna2PanelShowList.Visible = true;
                    listBoxShowList.Items.Add("The aircraft loaded on the map are:");

                    foreach (Aircraft aircraft in targetList)
                    {
                        listBoxShowList.Items.Add(aircraft.getID());
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure the map is loaded.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }
    }
}
