using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace Asterix_Decoder
{
    public partial class TableData : Form
    {
        public TableData(bool dataLoaded, IProgress<int> loadingStarted, IProgress<int> loadingEnded) //
        {
            if (dataLoaded)
            {
                dataGridDT.Columns.Clear();
            }
            loadingStarted.Report(1);
            InitializeComponent(loadingEnded);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }

        
        public void clearTable()
        {
            dataGridDT.Columns.Clear();
         
        }
        public void TableData_Load(object sender, EventArgs e)
        {

            textBoxSearch.Visible = false;
            btnSearch.Visible = false;
            panelFilter.Visible = false;
        }

        private void ShowData(IProgress<int> loadingEnded)
        {
            int i = 0;
            foreach (string column in Data.dataitems) //afegim totes les columnes que tenen algun valor
            {
                dataGridDT.ColumnCount = Data.DIAppears.Sum();
                if (Data.DIAppears[Data.columns[column]]==1) //column has any value
                {
                    dataGridDT.Columns[i].Name=column;
                    i++;
                }
            }
            
            foreach (object[] item in Data.TotalItems)
            {
                object[] toadd = new object[dataGridDT.ColumnCount];
                int w = 0;
                for (int u=0; u<Data.DIAppears.Length; u++)
                {
                    if (Data.DIAppears[u]==1) //this value appears at least once
                    {
                        if (item[u]!=null) //we add a value
                        {
                            toadd[w] = item[u];
                        }
                        else
                        {
                            toadd[w] = "";
                        }
                        w++;
                    }

                }
                dataGridDT.Rows.Add(toadd);
            }
            loadingEnded.Report(1);

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
            textBoxSearch.Text = "Enter a DataItem";
        }

        private void iconBtnFlecha_MouseEnter(object sender, EventArgs e)
        {
            panelFilter.Visible = true;
        }

        private void iconBtnFlecha_MouseLeave(object sender, EventArgs e)
        {
            panelFilter.Visible = false;
        }

        private void textBoxSearch_MouseEnter(object sender, EventArgs e)
        {
            textBoxSearch.Text = string.Empty;
        }

        private void textBoxSearch_MouseLeave(object sender, EventArgs e)
        {
            textBoxSearch.Text = "Enter a DataItem";
        }
    }
}
