
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

        double LatInicial = 41.27575;
        double LongInicial = 1.98721;
        DataTable dtInf;

        Bitmap Bmpaircraft = (Bitmap)Image.FromFile(@"..\..\aircraft.png");
        Bitmap BmpAircraftR;

        String targetID;


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
        }



        // LOAD & EXPORT FILE
        bool fileimported = false;
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
                Thread thread = new Thread(() =>
                {
                    Read.main(bitString, loadingended);
                    MessageBox.Show("The file has been loaded successfully.");
                    dt.LoadData(loadingDTstarted, loadingDTended);
                    dataLoaded = true;
                });
                thread.Start();
                
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
                if(fileimported == true)
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
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            BtnParar.Show();
            BtnPlay.Hide();
        }

        private void BtnParar_Click(object sender, EventArgs e)
        {
            BtnParar.Hide();
            BtnPlay.Show();
        }

        private void BtnMapView_Click(object sender, EventArgs e)
        {
            gMapControl1_Load(sender, e);

            // Avion
            try
            {
                // MarcadorGreenDot
                overlay = new GMapOverlay("Marker");
                marker = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), GMarkerGoogleType.green);
                overlay.Markers.Add(marker); // lo agregamos al mapa
                gMapControl1.Overlays.Add(overlay); // lo agregamos a nuestro mapa

                // MarcadorGAircraft
                this.BmpAircraftR = new Bitmap(Bmpaircraft, new Size(Bmpaircraft.Width / 10, Bmpaircraft.Height / 10));
                overlay2 = new GMapOverlay("Marker");
                markerAircraft = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), BmpAircraftR);
                overlay2.Markers.Add(markerAircraft); // lo agregamos al mapa
                gMapControl1.Overlays.Add(overlay2); // lo agregamos a nuestro mapa

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("The data has not been loaded correctly");
            }
            catch (Exception)
            {
                MessageBox.Show("The data has not been loaded correctly");
            }

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

            dataGridViewInfoAircraft.Rows[0].Cells[1].Value = dataLoaded;
            dataGridViewInfoAircraft.Rows[1].Cells[1].Value = dataLoaded;
            dataGridViewInfoAircraft.Rows[2].Cells[1].Value = dataLoaded;
            dataGridViewInfoAircraft.Rows[3].Cells[1].Value = dataLoaded;
            dataGridViewInfoAircraft.Rows[4].Cells[1].Value = dataLoaded;
            dataGridViewInfoAircraft.Rows[5].Cells[1].Value = dataLoaded;

            textBoxAircraft.Text = targetID;

            resLoadMap = false;
        }


        private void btnClearAicraft_Click(object sender, EventArgs e)
        {
            for(int i=0; i< dataGridViewInfoAircraft.RowCount; i++)
            {
                dataGridViewInfoAircraft.Rows[i].Cells[1].Value = "";
            }
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            // para obtener los datos de la lat y long donde el user ha presionado
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            textBoxLATGreenDot.Text = lat.ToString();
            textBoxLongGreenDot.Text = lng.ToString();

            marker.Position = new PointLatLng(lat, lng);

            resLoadMap = false;
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.Show();
            pictureBoxMapaDifuminado.Hide();
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LongInicial);
            gMapControl1.MinZoom = 3;
            gMapControl1.MaxZoom = 22;
            gMapControl1.Zoom = 15;
            gMapControl1.AutoScroll = true;
        }

        /**
        private PointLatLng Cartesian2Geocentric(double x, double y, String TargetID) {

        }*/

   
     








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
                if (resLoadMap == true) {
                    param="";
                }
                else
                {
                    gMapControl1_Load(sender, e);

                    gMapControl1.Overlays.Remove(overlay);
                    gMapControl1.Overlays.Remove(overlay2);

                    // Avion
                    try
                    {
                        // MarcadorGreenDot
                        overlay3 = new GMapOverlay("Marker");
                        marker3 = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), GMarkerGoogleType.green);
                        overlay3.Markers.Add(marker3); // lo agregamos al mapa
                        gMapControl1.Overlays.Add(overlay3); // lo agregamos a nuestro mapa

                        // MarcadorGAircraft
                        this.BmpAircraftR = new Bitmap(Bmpaircraft, new Size(Bmpaircraft.Width / 10, Bmpaircraft.Height / 10));
                        overlayAir3 = new GMapOverlay("Marker");
                        markerAircraft3 = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), BmpAircraftR);
                        overlayAir3.Markers.Add(markerAircraft3); // lo agregamos al mapa
                        gMapControl1.Overlays.Add(overlayAir3); // lo agregamos a nuestro mapa

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
            try
            {
                SaveFileDialog saveFileKML = new SaveFileDialog();
                saveFileKML.InitialDirectory = @"..\..\";

                string lat = LatInicial.ToString();
                string lon = LongInicial.ToString();
                string ruta = "Simulator.kml";
                string nombre = "XXX"; // TargetID
                string file = saveFileKML.FileName;

                XmlTextWriter w = new XmlTextWriter(file, Encoding.UTF8);

                w.WriteStartDocument();
                w.WriteStartElement("KML file");

                MessageBox.Show("The KML file has been successfully exported!! (You can find it at Interfaz/bin/...)");
            }
            catch (Exception exp)
            {
                MessageBox.Show("The KML file could not be exported successfully, please try again.");

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

        private void MENU_Load(object sender, EventArgs e)
        {

        }
    }
}