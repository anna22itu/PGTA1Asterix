using System.IO;
using Library;
using Asterix_Decoder;
using AsterixDecoder;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;



namespace Interfaz
{
    public partial class MENU : Form
    {
        public bool result = true;
        GMarkerGoogle marker;
        GMapOverlay overlay;
        double LatInicial = 41.27575;
        double LongInicial = 1.98721;


        public MENU()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            BtnParar.Hide();
            gMapControl1.Hide();
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
                MessageBox.Show("EL Fichero se ha cargado correctamente.");
                
            }
            else
            {
                MessageBox.Show("ERROR: EL Fichero no se ha cargado correctamente.");
                //caldrà printar en un dialogbox que no s'ha importat bé el fitxer (tb si dona error o lo q sigui)
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
                MessageBox.Show("EL Fichero se ha exportado correctamente./n Lo podrás encontrar en Interfaz/bin/Debug/net6.0-windows/ como un fichero excel");
            }
            else
            {
                MessageBox.Show("ERROR: EL Fichero no se ha exportado correctamente.");
            }
        }

        private void BtnDataView_Click(object sender, EventArgs e)
        {
            Form f = new TableData();
            
            MessageBox.Show("La tabla de datos se està cargando. Esto podria tardar algunos minutos."); 
            
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

            // agregamos un tooltip de texto en los marcad

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
    }
}