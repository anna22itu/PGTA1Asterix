using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asterix_Decoder
{
    public partial class SeguridadClose : Form
    {
        public SeguridadClose()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
