using System.IO;
using Library;


namespace Interfaz
{
    public partial class Form1 : Form
    {
        
        public Form1()
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
    }
}