
using System;
using System.IO;
using Library;
using Asterix_Decoder;
using AsterixDecoder;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Data;
using System.Windows.Media.Effects;
using System.Media;
using System.Drawing;
using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Xml;
using System.Text;
using Apache.Arrow.Types;

namespace Interfaz
{
    public partial class MENU : Form
    {
        public bool result = true;
        public bool result2 = false;

        public bool resLoadMap = true;

        GMarkerGoogle marker;
        GMarkerGoogle markerAircraft;
        GMapOverlay overlay;
        GMapOverlay overlay2;

        GMarkerGoogle marker3;
        GMarkerGoogle markerAircraft3;
        GMapOverlay overlay3;
        GMapOverlay overlayAir3;

        GMapControl gmap = new GMapControl();

        GMapOverlay targets = new GMapOverlay("targets");

        double LatInicial = 41.27575;
        double LongInicial = 1.98721;
        DataTable dtInf;

        Bitmap BmpaircraftSMR = (Bitmap)Image.FromFile(@"..\..\aircraftSMR.png");
        Bitmap BmpAircraftR_SMR;
        Bitmap BmpaircraftMLAT = (Bitmap)Image.FromFile(@"..\..\aircraftMLAT.png");
        Bitmap BmpAircraftR_MLAT;
        Bitmap BmpaircraftADSB = (Bitmap)Image.FromFile(@"..\..\aircraftADSB.png");
        Bitmap BmpAircraftR_ADSB;

        String targetID;

        double LatLEBL = 41.29839;
        double LongLEBL = 2.08331;

        bool loadMap = false;

        MarkerClick AircraftSelected;
        String IDSelected;
        String CallsignSelected;
        String ICAOSelected;
        String FLSelected;
        String TrackNumSelected;
        String GroundSeppedSElected;
        String PacketsSelected;

        public MENU()
        {
            InitializeComponent();
            BtnParar.Hide();
            gMapControl1.Hide();
            pictureBoxMapaDifuminado.Show();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            labelAsterixReLoadMap.Hide();
            labelStopPlay.Hide();
            labelExportFileKML.Hide();
            labelInfoPinGreenDot.Hide();
            labelAircraftInfo.Hide();
            labelZoomLEBL.Hide();
        }



        // LOAD & EXPORT FILE
        bool fileimported = false;
        bool dataRead = false;
        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            dt = new TableData();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
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

            }

            else
            {
                MessageBox.Show("ERROR: The file has not been loaded successfully.");
                //caldrà printar en un dialogbox que no s'ha importat bé el fitxer (tb si dona error o lo q sigui)
            }
        }


        private void BtnExportFile_Click(object sender, EventArgs e)
        {
            bool result = Data.export();

            if (result == true)
            {
                MessageBox.Show("The file has been exported correctly./n You can find it in Interface/bin/Debug/net6.0-windows/ as an excel file");
            }
            else
            {
                MessageBox.Show("ERROR: The file has not been exported correctly.");
            }
        }


        // TABLA
        static bool dataLoaded = false;
        TableData dt = new TableData();

        private void loadingRead()
        {
            iconPictureBox2.Hide();
            pictureBox2.Show();
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
        int currentItem = 0; //the last item read when pause pressed, to continue from here


        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (loadMap) //que nomes funcionin si el mapa esta loaded
            {
                BtnParar.Show();
                BtnPlay.Hide();
                readTargetsThread.Start();
            }
            else
            {
                MessageBox.Show("No file has been imported yet.", "Please open a file.");
            }
            
        }

        private void BtnParar_Click(object sender, EventArgs e)
        {
            if (loadMap)
            {
                //BtnParar.Hide();
                //BtnPlay.Show();
            }
            
        }

        //ReadTargets s'ahuria de fer com un thread que quan es doni a apausa es pausi, i quan es doni al play, si ja shavia començat a llegir, faci resume.
        

        private static Thread readTargetsThread = new Thread(() =>
        {
            int testLen = 100; //per que funcioni caldra que i < Data.TotalItems.Count
            for (int i = 0; i < testLen; i++)
            {
                object[] item = Data.TotalItems[i];
                plotTargetThread2(item);
                Thread.Sleep(100);
            }
            MessageBox.Show("All aircraft Shown");

        });

        private static Thread plotTargetThread2(object[] item)
        {
            var t = new Thread(() => {
                double longitude = double.NaN;
                double latitude = double.NaN;
                double z = 0;
                string ID = null;
                int cat = 0;

                if (item[Data.columns["Geometric Height"]] != null)
                {
                    z = Convert.ToDouble(item[Data.columns["Geometric Height"]]);
                }
                else if (item[Data.columns["Height"]] != null)
                {
                    z = Convert.ToDouble(item[Data.columns["Height"]]);
                }

                if (item[Data.columns["Latitude WGS84"]] == null && item[Data.columns["Longitude WGS84"]] == null) //té nomes cartesianes
                {
                    if (item[Data.columns["MessageType"]].ToString() == "Target Report")
                    {
                        cat = 10;
                        double latRadar = LatLEBL;
                        double longRadar = LongLEBL;
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

                //CAL AFEGIR LA CAT21 I QUE SI LA DISTANCIA ENTRE EL VELL I EL NOU ES MOLTA, BORREM EL VELL I QUE APAREIXI EL NOU NOMES
                if (cat != 0)
                {
                    if (cat == 10)
                    {
                        if (item[Data.columns["Target Identification"]] != null) //es mlat
                        {
                            ID = item[Data.columns["Target Identification"]].ToString();
                        }
                        else
                        {
                            ID = item[Data.columns["Track Number"]].ToString();
                        }
                    }

                    else
                    {
                        if (item[Data.columns["Target Identification"]] != null) //es mlat
                        {
                            ID = item[Data.columns["Target Identification"]].ToString();
                        }
                    }

                    if (longitude != double.NaN && latitude != double.NaN && ID != null) //podem carregar dades
                    {
                        if (targetNames.Contains(ID)) //comprobem si aquest target ja existeix
                        {
                            targetList[targetNames.IndexOf(ID)].setLat(latitude);
                            targetList[targetNames.IndexOf(ID)].setLong(longitude);
                            targetList[targetNames.IndexOf(ID)].setHeight(z);
                            markersList[targetNames.IndexOf(ID)].Position = new PointLatLng(targetList[targetNames.IndexOf(ID)].getLat(), targetList[targetNames.IndexOf(ID)].getLong());
                        }
                        else //si no existeix, creem un i l'afegim
                        {
                            Aircraft a = new Aircraft(ID, longitude, latitude, z);
                            targetList.Add(a);
                            targetNames.Add(ID);

                            GMarkerGoogle markerTarget = new GMarkerGoogle(new PointLatLng(a.getLat(), a.getLong()), a.getbmp());
                            markersList.Add(markerTarget);
                            targets.Markers.Add(markerTarget);
                            gMapControl1.Overlays.Add(targets);
                        }
                    }
                }
            });
            t.Start();
            return t;
        }


        private void ReadTargets() //aqui anirem llegint al ritme del timer del primer temps, segon a segon, 
        {
            int testLen = 100; //per que funcioni caldra que i < Data.TotalItems.Count

            Thread readTargetThread = new Thread(() =>
            {
                for (int i = 0; i < testLen; i++)
                {
                    object[] item = Data.TotalItems[i];
                    plotTargetThread2(item);
                    Thread.Sleep(100);
                }
                MessageBox.Show("All aircraft Shown");
            });
            readTargetThread.Start();
        }
        private void plotTarget(object[] item)
        {
            Thread plotTargetThread = new Thread(() =>
            {
                double longitude = double.NaN;
                double latitude = double.NaN;
                double z = 0;
                string ID = null;
                int cat = 0;

                if (item[Data.columns["Geometric Height"]] != null)
                {
                    z = Convert.ToDouble(item[Data.columns["Geometric Height"]]);
                }
                else if (item[Data.columns["Height"]] != null)
                {
                    z = Convert.ToDouble(item[Data.columns["Height"]]);
                }

                if (item[Data.columns["Latitude WGS84"]] == null && item[Data.columns["Longitude WGS84"]] == null) //té nomes cartesianes
                {
                    if (item[Data.columns["MessageType"]].ToString() == "Target Report")
                    {
                        cat = 10;
                        double latRadar = LatLEBL;
                        double longRadar = LongLEBL;
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

                //CAL AFEGIR LA CAT21 I QUE SI LA DISTANCIA ENTRE EL VELL I EL NOU ES MOLTA, BORREM EL VELL I QUE APAREIXI EL NOU NOMES
                if (cat != 0)
                {
                    if (cat == 10)
                    {
                        if (item[Data.columns["Target Identification"]] != null) //es mlat
                        {
                            ID = item[Data.columns["Target Identification"]].ToString();
                        }
                        else
                        {
                            ID = item[Data.columns["Track Number"]].ToString();
                        }
                    }

                    else
                    {
                        if (item[Data.columns["Target Identification"]] != null) //es mlat
                        {
                            ID = item[Data.columns["Target Identification"]].ToString();
                        }
                    }

                    if (longitude != double.NaN && latitude != double.NaN && ID != null) //podem carregar dades
                    {
                        if (targetNames.Contains(ID)) //comprobem si aquest target ja existeix
                        {
                            targetList[targetNames.IndexOf(ID)].setLat(latitude);
                            targetList[targetNames.IndexOf(ID)].setLong(longitude);
                            targetList[targetNames.IndexOf(ID)].setHeight(z);
                            markersList[targetNames.IndexOf(ID)].Position = new PointLatLng(targetList[targetNames.IndexOf(ID)].getLat(), targetList[targetNames.IndexOf(ID)].getLong());
                        }
                        else //si no existeix, creem un i l'afegim
                        {
                            Aircraft a = new Aircraft(ID, longitude, latitude, z);
                            targetList.Add(a);
                            targetNames.Add(ID);

                            GMarkerGoogle markerTarget = new GMarkerGoogle(new PointLatLng(a.getLat(), a.getLong()), a.getbmp());
                            markersList.Add(markerTarget);
                            targets.Markers.Add(markerTarget);
                            gMapControl1.Overlays.Add(targets);
                        }
                    }
                }
            });
            plotTargetThread.Start();
            

        }


        private void BtnMapView_Click(object sender, EventArgs e)
        {
            if (dataRead && loadMap==false)
            {
                gMapControl1_Load(sender, e);
                loadAircraftInfoTable(); //desde loadAircraftInfoData es podra show la data de l'avio quan es faci click sobre l'avio o es busqui el seu id
            }
            else
            {
                MessageBox.Show("Please, first import a file.", "File not loaded.");
            }
            

            // Avion
            //try
            //{
            //    // MarcadorGreenDot
            //    overlay = new GMapOverlay("Marker");
            //    marker = new GMarkerGoogle(new PointLatLng(LatLEBL, LongLEBL), GMarkerGoogleType.green);
            //    overlay.Markers.Add(marker); // lo agregamos al mapa
            //    gMapControl1.Overlays.Add(overlay); // lo agregamos a nuestro mapa

            //    // MarcadorGAircraft
            //    //this.BmpAircraftR = new Bitmap(Bmpaircraft, new Size(Bmpaircraft.Width / 10, Bmpaircraft.Height / 10));
            //    //overlay2 = new GMapOverlay("Marker");
            //    //markerAircraft = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), BmpAircraftR);
            //    //overlay2.Markers.Add(markerAircraft); // lo agregamos al mapa
            //    //gMapControl1.Overlays.Add(overlay2); // lo agregamos a nuestro mapa

            //}
            //catch (NullReferenceException)
            //{
            //    MessageBox.Show("The data has not been loaded correctly");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("The data has not been loaded correctly");
            //}


        }
        private void loadAircraftInfoTable()
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


            resLoadMap = false;
        }
        public void loadAircraftInfoData()
        {

            if (targetList != null)
            {
                //textBoxAircraft.Text = targetList.GetHashCode;

                dataGridViewInfoAircraft.Rows[0].Cells[1].Value = dataLoaded;  // Callsing
                dataGridViewInfoAircraft.Rows[1].Cells[1].Value = dataLoaded;  // ICAO
                dataGridViewInfoAircraft.Rows[2].Cells[1].Value = dataLoaded;  // FL
                dataGridViewInfoAircraft.Rows[3].Cells[1].Value = dataLoaded;  // Track Nº
                dataGridViewInfoAircraft.Rows[4].Cells[1].Value = dataLoaded;  // Ground Speed
                dataGridViewInfoAircraft.Rows[5].Cells[1].Value = dataLoaded;  // Packets

               
            }
            else 
            {
                MessageBox.Show("Please selected an aicraft");
            };
        }


        private void btnClearAicraft_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewInfoAircraft.RowCount; i++)
            {
                dataGridViewInfoAircraft.Rows[i].Cells[1].Value = "";
            }
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // para obtener los datos de la lat y long donde el user ha presionado
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            textBoxLATGreenDot.Text = lat.ToString();
            textBoxLongGreenDot.Text = lng.ToString();

            marker.Position = new PointLatLng(lat, lng);

            resLoadMap = false;
        }


        private void gMapControl1_MouseClick(object sender, MouseEventArgs e) //caldra veure que fa
        {
            // Datos del avion seleccionado los asginamos al avion seleccionado
            /**
            for (int i=0;i<markersList.Count;i++)
            {
                if (markersList[i].Mo)
                {
                    markersList[i].OnMarkerClick
                }
            }*/
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
            gMapControl1.MinZoom = 3;
            gMapControl1.MaxZoom = 22;
            gMapControl1.Zoom = 14;
            gMapControl1.OnMarkerClick += new MarkerClick(gMapControl1_OnMarkerClick);
            gMapControl1.AutoScroll = true;

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
        private void Hora_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void iconBtnCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            String param = "...";
            try
            {
                if (resLoadMap == true)
                {
                    param = "";
                }
                else
                {
                    gMapControl1_Load(sender, e);

                    gMapControl1.Overlays.Remove(overlay);

                    // Avion
                    try
                    {
                        // MarcadorGreenDot
                        overlay3 = new GMapOverlay("Marker");
                        marker3 = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), GMarkerGoogleType.green);
                        overlay3.Markers.Add(marker3); // lo agregamos al mapa
                        gMapControl1.Overlays.Add(overlay3); // lo agregamos a nuestro mapa

                        // MarcadorGAircraft
                        //this.BmpAircraftR = new Bitmap(Bmpaircraft, new Size(Bmpaircraft.Width / 10, Bmpaircraft.Height / 10));
                        //overlayAir3 = new GMapOverlay("Marker");
                        //markerAircraft3 = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), BmpAircraftR);
                        //overlayAir3.Markers.Add(markerAircraft3); // lo agregamos al mapa
                        //gMapControl1.Overlays.Add(overlayAir3); // lo agregamos a nuestro mapa

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


            }
            catch (Exception) when (param == "")
            {
                MessageBox.Show("You still have the map reset");
            }

            resLoadMap = true;

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


        private void iconBtnKML_Click(object sender, EventArgs e)
        {
            if (textBoxAircraft.Text == "")
            {
                MessageBox.Show("First select a plane, please");
            }
            else 
            {
                try
                {
                    KML_Load(sender, e);

                    //MessageBox.Show("The KML file has been successfully exported!! (You can find it at Interfaz/bin/...)");

                    KML KML = new KML();
                }
                catch (Exception)
                {
                    //MessageBox.Show("The KML file could not be exported successfully, please try again.");
                }
            }
        }

        private void iconBtnKML_MouseEnter(object sender, EventArgs e)
        {
            labelExportFileKML.Show();
        }

        private void iconBtnKML_MouseLeave(object sender, EventArgs e)
        {
            labelExportFileKML.Hide();
        }

        private void iconPictureBox7_MouseEnter(object sender, EventArgs e)
        {
            labelInfoPinGreenDot.Show();
        }

        private void iconPictureBox7_MouseLeave(object sender, EventArgs e)
        {
            labelInfoPinGreenDot.Hide();
        }

        private void iconPictureBoxPinMap_MouseEnter(object sender, EventArgs e)
        {
            labelAircraftInfo.Show();
        }

        private void iconPictureBoxPinMap_MouseLeave(object sender, EventArgs e)
        {
            labelAircraftInfo.Hide();
        }

        private void KML_Load(object sender, System.EventArgs e)
        {

            // Guardamos la información del avión especificado y le decimos el directorio al que queremos que se guarde
            SaveFileDialog saveFileKML = new SaveFileDialog();
            saveFileKML.InitialDirectory = @"..\..\";

            //Le daremos un nombre al archivo y tambien le expecificamos en que directorio se creara
            string nombrefile = targetID + ".kml";


            //Definimos el archivo XML
            XmlTextWriter writer = new XmlTextWriter(nombrefile, Encoding.UTF8);

            // Empezamos a escribir
            writer.WriteStartDocument();
            writer.WriteStartElement("kml");
            writer.WriteAttributeString("xmlns", "http://earth.google.com/kml/2.0");
            writer.WriteStartElement("Folder");
            writer.WriteStartElement("description");

            //Descripcion del Conjunto de Datos,puede ser texto o HTML
            writer.WriteEndElement();
            writer.WriteElementString("name", "Paises");
            writer.WriteElementString("visibility", "0");
            writer.WriteElementString("open", "1");
            writer.WriteStartElement("Folder");

            /**
            //Obtenemos los datos donde estan las coordenadas
            DataSet ds = dsDatos();
            //Recorremos el DataSet
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //Obtenemos los valores de Latitud y Longitud
                string slong = ds.Tables[0].Rows[i]["Longitud"].ToString();
                string slat = ds.Tables[0].Rows[i]["Latitud"].ToString();
                writer.WriteStartElement("Placemark");
                writer.WriteStartElement("description");
                writer.WriteCData("Aqui puede ir cualquier tipo de texto descriptivo de acuerdo al registro correspondiente");
                writer.WriteEndElement();
                //Asignamos el nombre del registro o coordenada obteniendo el valor del campo Nombre
                writer.WriteElementString("name", ds.Tables[0].Rows[i]["Nombre"].ToString());
                writer.WriteElementString("visibility", "1");
                writer.WriteStartElement("Style");
                writer.WriteStartElement("IconStyle");
                writer.WriteStartElement("Icon");
                //Ruta del icono para ver las coordenadas
                //Debe ser pequeña de 32x32.
                writer.WriteElementString("href", "www.TuDominio.com/directorio/tuicono.ico");
                writer.WriteElementString("w", "32");
                writer.WriteElementString("h", "32");
                writer.WriteElementString("x", "64");
                writer.WriteElementString("y", "96");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteStartElement("LookAt");
                writer.WriteElementString("longitude", slong);
                writer.WriteElementString("latitude", slat);
                writer.WriteElementString("range", "3000");
                writer.WriteElementString("tilt", "60");
                writer.WriteElementString("heading", "0");
                writer.WriteEndElement();
                writer.WriteStartElement("Point");
                writer.WriteElementString("extrude", "1");
                writer.WriteElementString("altitudeMode", "relativeToGround");
                writer.WriteElementString("coordinates", slong + "," + slat + ",50");
                writer.WriteEndElement();
                writer.WriteEndElement();
            }
            */
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

            MessageBox.Show("The KML file has been successfully exported!! (You can find it at Interfaz/bin/...)");
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
                gMapControl1.MapProvider = GMapProviders.GoogleMap;
                gMapControl1.Position = new PointLatLng(LatLEBL, LongLEBL);
                gMapControl1.MinZoom = 3;
                gMapControl1.MaxZoom = 22;
                gMapControl1.Zoom = 14;
                gMapControl1.AutoScroll = true;
            }
            else 
            {
                MessageBox.Show("First load the map --> on the LOAD MAP button");
            }
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {

            //foreach (GMapMarker obj in markersList)
            //{
            //    if (obj.Tag.Equals(item.Tag))
            //    {
            //        Console.WriteLine("good");
            //        MessageBox.Show("good");
            //    }

            //}           
        }
    }
}
