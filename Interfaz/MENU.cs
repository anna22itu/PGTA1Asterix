using System.IO;
using Library;


namespace Interfaz
{
    public partial class MENU : Form
    {
        
        public MENU()
        {
            InitializeComponent();
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
    }
}