using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Text;

namespace AsterixDecoder
{
    public partial class KML : Form
    {
        public KML()
        {
            InitializeComponent();
            labelIngoGoogleEarth.Hide();
        }

        private void buttonKMLYes_MouseEnter(object sender, EventArgs e)
        {
            labelIngoGoogleEarth.Show();
        }

        private void buttonKMLYes_MouseLeave(object sender, EventArgs e)
        {
            labelIngoGoogleEarth.Hide();
        }

        private void buttonKMLNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonKMLYes_Click(object sender, EventArgs e)
        {
            KML_Load_GoogleEarth(sender, e);
        }

        private void KML_Load_GoogleEarth(object sender, System.EventArgs e)
        {
            // Tendremos que hacer que se habra con google earth

        }
    }
}
