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

namespace Interfaz
{
    public partial class MENU : Form
    {
        public bool result = true;
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

        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                byte[] fileBytes = File.ReadAllBytes(filename);
                string bitString = BitConverter.ToString(fileBytes);
                Read.setReadBytes(bitString);
                labelCurrentFilenameResponse.Text = filename[(filename.LastIndexOf("\\") + 1)..];
                MessageBox.Show("The file has been loaded successfully.");
                
            }
            else
            {
                MessageBox.Show("ERROR:The file has not been loaded successfully.");
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
            
            MessageBox.Show("The data table is being loaded. This could take a few minutes."); 
            
            f.Show();
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
            pictureBoxMapaDifuminado.Hide();
            gMapControl1.Show();
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

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // para obtener los datos de la lat y long donde el user ha presionado
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            textBoxLAT.Text = lat.ToString();
            textBoxLong.Text = lng.ToString();

            marker.Position= new PointLatLng(lat, lng);
        }

        private void btnClearAicraft_Click(object sender, EventArgs e)
        {
            // Cuando selecionamos se borra toda la informaci�n del avi�n y cuando seleccionemos otro avi�n se volver� a llenar
        }

       
    }
}