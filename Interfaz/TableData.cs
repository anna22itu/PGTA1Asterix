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
    public partial class TableData : Form
    {
        public TableData()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        

        private void TableData_Load(object sender, EventArgs e)
        {
            Refresh();
            textBoxSearch.Visible = false;
            btnSearch.Visible = false;
            panelFilter.Visible = false;
        }

        public void Refresh()
        {

        }

        private void iconBtnDTClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void iconBtnDTMax_Click(object sender, EventArgs e)
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Visible = true;
            btnSearch.Visible = true;
        }

        private void iconBtnFlecha_MouseEnter(object sender, EventArgs e)
        {
            panelFilter.Visible = true;
        }
    }
}
