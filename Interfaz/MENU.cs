using System.IO;
using Library;


namespace Interfaz
{
    public partial class MENU : Form
    {
        
        public MENU()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                byte[] fileBytes = File.ReadAllBytes(filename);
                string bitString = BitConverter.ToString(fileBytes);
                Read.setReadBytes(bitString);
                MessageBox.Show("EL Fichero se ha cargado correctamente.");
                labelCurrentFilenameResponse.Text = filename;
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
            Application.Exit();
        }

        private void BtnExportFile_Click(object sender, EventArgs e)
        {
            bool result = DataTable.export();

            if (result == true)
            {
                MessageBox.Show("EL Fichero se ha exportado correctamente./n Lo podrás encontrar en Interfaz/bin/Debug/net6.0-windows/ como un fichero excel");
            }
            else
            {
                MessageBox.Show("ERROR: EL Fichero no se ha exportado correctamente.");
            }
        }
    }
}