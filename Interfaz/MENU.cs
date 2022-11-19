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

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                byte[] fileBytes = File.ReadAllBytes(filename);
                string bitString = BitConverter.ToString(fileBytes);
                Read.setReadBytes(bitString);
            }
            else
            {
                //caldrà printar en un dialogbox que no s'ha importat bé el fitxer (tb si dona error o lo q sigui)
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable.export();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}