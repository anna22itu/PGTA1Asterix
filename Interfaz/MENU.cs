
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


namespace Interfaz
{
    public partial class MENU : Form
    {
        public bool result = true;
        public bool result2 = false;
        GMarkerGoogle marker;
        GMarkerGoogle markerAircraft;
        GMapOverlay overlay;
        GMapOverlay overlay2;

        double LatInicial = 41.27575;
        double LongInicial = 1.98721;
        DataTable dtInf;

        Bitmap Bmpaircraft = (Bitmap)Image.FromFile(@"..\..\aircraft.png");
        Bitmap BmpAircraftR;


        public MENU()
        {
            InitializeComponent();
            BtnParar.Hide();
            gMapControl1.Hide();
            pictureBoxMapaDifuminado.Show();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

    

        // LOAD & EXPORT FILE
        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileimported = true;
                string filename = openFileDialog1.FileName;
                byte[] fileBytes = File.ReadAllBytes(filename);
                string bitString = BitConverter.ToString(fileBytes);
                var loadingended = new Progress<int>(stoploadingRead);
                var loadingDTended = new Progress<int>(stoploadingDataTable);
                var loadingDTstarted = new Progress<int>(loadingDataTable);

                loadingRead();
                Thread thread = new Thread(() =>
                {
                    Read.main(bitString, loadingended);
                    MessageBox.Show("The file has been loaded successfully.");
                    createDataTable(0, dataLoaded, loadingDTstarted, loadingDTended);
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
        private void createDataTable(int cas, bool dataLoaded, IProgress<int> loadingDTstarted, IProgress<int> loadingDTended) //case 0 create dataframe case 1 show it
        {
            Form dt = new Form();

            switch (cas)
            {
                case 0:

                    dt = new TableData(dataLoaded, loadingDTstarted, loadingDTended); //if (dataLoaded == true) ja hi havien coses, cal borrar

                    break;

                case 1:

                    dt.Show(); //ESTO NO VA

                    break;
            }
            
            
        }
        bool fileimported = false;


        public static bool dataLoaded = false;
        
        private void loadingDataTable(int i)
        {
            //iconPictureBox6.Hide();
            //pictureBox3.Show();
        }
        private void stoploadingDataTable(int i)
        {
            //pictureBox3.Hide();
            //iconPictureBox6.Show();
        }
        public static Form globalForm = new Form();
        private void BtnDataView_Click(object sender, EventArgs e)
        {
            //bool r = MENU.BtnLoadFile_Click();
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
                var loadingDTended = new Progress<int>(stoploadingDataTable);
                var loadingDTstarted = new Progress<int>(loadingDataTable);
                createDataTable(1, dataLoaded, loadingDTstarted, loadingDTended);
            }

            /**
            if (r == true)
            {
                MessageBox.Show("The data table is being loaded. This could take a few minutes.");

                f.Show();
            }
            else {
                MessageBox.Show("The data table is not available, load the file first please");
            }*/
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
                this.BmpAircraftR = new Bitmap(Bmpaircraft, new Size(Bmpaircraft.Width /10, Bmpaircraft.Height /10));
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

            //dataGridViewInfoAircraft.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            

            dtInf.Columns.Add("Field");
            dtInf.Columns.Add("Value");

            dtInf.Rows.Add("Callsing");
            dtInf.Rows.Add("ICAO");
            dtInf.Rows.Add("FL");
            dtInf.Rows.Add("Track Nº");
            dtInf.Rows.Add("Ground Speed");
            dtInf.Rows.Add("Packets");

            dataGridViewInfoAircraft.DataSource = dtInf;

        }

   
        private void btnClearAicraft_Click(object sender, EventArgs e)
        {
            // Cuando selecionamos se borra toda la información del avión y cuando seleccionemos otro avión se volverá a llenar
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            // para obtener los datos de la lat y long donde el user ha presionado
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            textBoxLATGreenDot.Text = lat.ToString();
            textBoxLongGreenDot.Text = lng.ToString();

            marker.Position = new PointLatLng(lat, lng);
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            // Caracteristicas del mapa
            gMapControl1.Show();
            pictureBoxMapaDifuminado.Hide();
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LongInicial);
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 30;
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

      
    }
}