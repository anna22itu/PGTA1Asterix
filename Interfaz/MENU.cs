
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

namespace Interfaz
{
    public partial class MENU : Form
    {
        public bool result = true;
        public bool result2 = false;
        GMarkerGoogle marker;
        GMapOverlay overlay;
        double LatInicial = 41.27575;
        double LongInicial = 1.98721;
        DataTable dtInf;


        public MENU()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            BtnParar.Hide();
            gMapControl1.Hide();
            pictureBoxMapaDifuminado.Show();
        }
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
        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                byte[] fileBytes = File.ReadAllBytes(filename);
                string bitString = BitConverter.ToString(fileBytes);
                var loadingended = new Progress<int>(stoploadingRead);

                loadingRead();
                Thread thread = new Thread(() => 
                {
                    Read.main(bitString, loadingended);
                    MessageBox.Show("The file has been loaded successfully."); 
                });
                thread.Start();
                labelCurrentFilenameResponse.Text = filename[(filename.LastIndexOf("\\") + 1)..];

            }
            else
            {
                MessageBox.Show("ERROR: The file has not been loaded successfully.");
                //caldr� printar en un dialogbox que no s'ha importat b� el fitxer (tb si dona error o lo q sigui)
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

        private void BtnDataView_Click(object sender, EventArgs e)
        {
            Form f = new TableData();
            //bool r = MENU.BtnLoadFile_Click();

            MessageBox.Show("The data table is being loaded. This could take a few minutes.");

            f.Show();

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

        private void iconBtnMenuBars_Click(object sender, EventArgs e)
        {

            if (result== true)
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

        private void BtnAboutUs_Click(object sender, EventArgs e)
        {
            Form f = new AboutUs();
            f.Show();
        }

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

            // Marcador
            overlay = new GMapOverlay("Marker");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), GMarkerGoogleType.green);
            overlay.Markers.Add(marker); // lo agregamos al mapa
            gMapControl1.Overlays.Add(overlay); // lo agregamos a nuestro mapa

            // Avion
            try
            {
                PictureBox p1 = new PictureBox();

                p1.Width = 20;
                p1.Height = 20;
                p1.ClientSize = new Size(20, 20);
                p1.Location = new Point(Convert.ToInt32(LatInicial), Convert.ToInt32(LongInicial));
                p1.SizeMode = PictureBoxSizeMode.StretchImage;

                Bitmap image1 = new Bitmap("aircraft.png");
                p1.Image = (Image)image1;
                gMapControl1.Controls.Add(p1);
                
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("The data has not been loaded correctly");
            }
            catch (Exception)
            {
                MessageBox.Show("The data has not been loaded correctly");
            }


            // Data de informaci�n
            dtInf = new DataTable();
            dataGridViewInfoAircraft.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewInfoAircraft.Font, FontStyle.Bold);
            dtInf.Columns.Add("    Field");
            dtInf.Columns.Add("    Value");

            dtInf.Rows.Add("       Callsing");
            dtInf.Rows.Add("        ICAO");
            dtInf.Rows.Add("           FL");
            dtInf.Rows.Add("       Track N�");
            dtInf.Rows.Add("  Ground Speed");
            dtInf.Rows.Add("       Packets");

            dataGridViewInfoAircraft.DataSource = dtInf;

        }

   
        private void btnClearAicraft_Click(object sender, EventArgs e)
        {
            // Cuando selecionamos se borra toda la informaci�n del avi�n y cuando seleccionemos otro avi�n se volver� a llenar
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            // para obtener los datos de la lat y long donde el user ha presionado
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            textBoxLAT.Text = lat.ToString();
            textBoxLong.Text = lng.ToString();

            marker.Position = new PointLatLng(lat, lng);
        }
    }
}