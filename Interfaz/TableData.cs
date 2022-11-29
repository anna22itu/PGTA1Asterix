using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsterixDecoder;
using Library;
using Interfaz;

namespace Asterix_Decoder
{
    public partial class TableData : Form
    {
        String search;

        public TableData()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            checkBox2.Checked = true;
            textBoxSearch.Text = "Enter a DataItem";
        }

        List<string> relevantData = new List<string>() { "SIC", "SAC", "Time of Day", "MessageType", "Track Number", "Target Address", "Target Identification", "X Cartesian", "Y Cartesian", "Latitude WGS84", "Longitude WGS84", "Velocity X Cart", "Velocity Y Cart", "Ground Speed", "Track Angle", "FL", "Height", "Geometric Height", "Barometric Vertical Rate", "Selected Altitude", "Mode-3/A Code", "Emitter Category" };
        List<string> columnOrder = new List<string>() { "SIC", "SAC", "Time of Day", "MessageType", "Track Number", "Target Address", "Target Identification", "X Cartesian", "Y Cartesian", "Latitude WGS84", "Latitude WGS84 HP", "Latitude Intention", "Longitude WGS84", "Longitude WGS84 HP", "Longitude Intention", "rho", "theta", "Velocity X Cart", "Velocity Y Cart", "Ground Speed", "Air Speed", "True AirSpeed", "Acceleration X", "Acceleration Y", "Track Angle", "Track Angle Rate", "FL", "Height", "Geometric Height", "Barometric Vertical Rate", "Geometric Vertical Rate", "Selected Altitude", "Altitude Intention", "Altitude Final", "Mode-3/A Code", "Emitter Category", "Vehicle Fleet Identification", "Target Length", "Target Orientation", "Target Width", "Magnetic Heading", "Receiver ID", "Service Identification", "Turbulence", "Temperature", "Wind Direction", "Wind Speed", "Roll Angle", "Amplitude", "Time of Applicability Position", "Time of Applicability Velocity", "Time of Message Reception Position", "Time of Message Reception Position HP", "Time of Message Reception Velocity", "Time of Message Reception Velocity HP", "Point Type", "Presence rho", "Presence theta", "Standard Deviation X", "Standard Deviation Y", "BDS1", "BDS2", "BDS1_BDS", "BDS2_BDS", "BDSDATA", "ATP", "Covariance", "ICF", "MB", "ME", "MSG", "PS", "RA", "RAS", "SIM", "SS", "TCAS", "TD", "TOM", "TOT", "TOV", "TTR" };
        IDictionary<int, int> relation = new Dictionary<int, int>() { {0,124},{1,118},{2,157},{3,76},{4,170},{5,134},{6,135},{7,191},{8,192},{9,58},{10,59},{11,57},{12,64},{13,65},{14,63},{15,112},{16,149},{17,185},{18,186},{19,49},{20,4},{21,174},{22,1},{23,2},{24,168},{25,169},{26,37},{27,52},{28,45},{29,17},{30,46},{31,122},{32,5},{33,6},{34,0},{35,36},{36,184},{37,136},{38,137},{39,138},{40,69},{41,109},{42,123},{43,182},{44,148},{45,189},{46,190},{47,114},{48,8},{49,154},{50,155},{51,158},{52,159},{53,160},{54,161},{55,92},{56,94},{57,95},{58,128},{59,129},{60,18},{61,20},{62,19},{63,21},{64,22},{65,15},{66,29},{67,53},{68,72},{69,75},{70,83},{71,96},{72,98},{73,101},{74,125},{75,127},{76,144},{77,147},{78,164},{79,165},{80,166},{81,181} };
        public void clearTable()
        {
            dataGridDT.Columns.Clear();
            dataGridDT.Rows.Clear();
        }
        public void TableData_Load(object sender, EventArgs e)
        {

            textBoxSearch.Visible = false;
            btnSearch.Visible = false;
        }


        public void LoadData(IProgress<int> loadingStarted, IProgress<int> loadingEnded)
        {

            loadingStarted.Report(1);
            int[] Appear = new int[82];

            foreach (string column in Data.dataitems)
            {
                if (columnOrder.Contains(column))
                {
                    Appear[columnOrder.IndexOf(column)] = Data.DIAppears[Data.columns[column]];
                }
            }

            dataGridDT.ColumnCount = Appear.Sum();

            int i = 0;
            foreach (string column in columnOrder) //afegim totes les columnes que tenen algun valor i que ens interessen
            {
                if (Appear[columnOrder.IndexOf(column)]==1) //column has any value
                {
                    dataGridDT.Columns[i].Name=column;
                    i++;
                }
            }
            for(int s=0; s < 1000; s++)
            {
                object[] item = Data.TotalItems[s]; //El SMR per exemple te 50k files

                object[] toadd = new object[dataGridDT.ColumnCount];
                int w = 0;
                for (int u = 0; u < Appear.Length; u++)
                {
                    if (Appear[u] == 1) //this value appears at least once
                    {
                        if (item[relation[u]] != null) //we add a value 
                        {
                            toadd[w] = item[relation[u]];
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


            foreach (DataGridViewColumn col in dataGridDT.Columns)
            {
                if (relevantData.Contains(col.Name) == false)
                {
                    col.Visible = false;
                }
            }

            if (dataGridDT.Columns.Contains("MessageType")==false) //bloquejem els filtres de messagetype
            {
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }

            loadingEnded.Report(1);



        }

        //Checked Boxes
        CheckBox lastChecked;
        List<int> rowsOcultadas = new List<int>();
        private void chk_Click(object sender, EventArgs e) //so that only one checkbox can be used
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;


        }
        public bool isChecked(CheckBox checkbox)
        {
            if (checkbox.CheckState == CheckState.Checked) return true;
            else return false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //Show Relevant Data
        {
            chk_Click(sender, e);
            if (isChecked(checkBox2))
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = false;

                foreach (DataGridViewColumn col in dataGridDT.Columns)
                {
                    if (relevantData.Contains(col.Name) == false)
                    {
                        col.Visible = false;
                    }
                }
            }
            
        }
        
        private void checkBox3_CheckedChanged(object sender, EventArgs e) //Only Target Reports
        {

            if (isChecked(checkBox3))
            {
                checkBox4.Enabled = false;
                if (dataGridDT.Columns.Contains("MessageType"))
                {
                    for (int i = 0; i < dataGridDT.Rows.Count-1; i++)
                    {
                        if (dataGridDT.Rows[i].Cells[columnOrder.IndexOf("MessageType")].Value.ToString() != "Target Report" && dataGridDT.Rows[i].Cells[columnOrder.IndexOf("MessageType")].Value.ToString() != "")
                        {
                            dataGridDT.Rows[i].Visible = false;
                            rowsOcultadas.Add(i);
                        }
                    }
                }
                
            }
            else
            {
                checkBox4.Enabled = true;
                while (rowsOcultadas.Count != 0)
                {
                    dataGridDT.Rows[rowsOcultadas[0]].Visible = true;
                    rowsOcultadas.Remove(rowsOcultadas[0]);
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) //Show Extra Reports
        {
            
            if (isChecked(checkBox4))
            {
                checkBox3.Enabled = false;
                if (dataGridDT.Columns.Contains("MessageType"))
                {
                    for (int i = 0; i < dataGridDT.Rows.Count - 1; i++)
                    {
                        if (dataGridDT.Rows[i].Cells[columnOrder.IndexOf("MessageType")].Value.ToString() == "Target Report" || dataGridDT.Rows[i].Cells[columnOrder.IndexOf("MessageType")].Value.ToString() == "")
                        {
                            dataGridDT.Rows[i].Visible = false;
                            rowsOcultadas.Add(i);
                        }
                    }
                }


            }
            else
            {
                checkBox3.Enabled = true;
                while (rowsOcultadas.Count != 0)
                {
                    dataGridDT.Rows[rowsOcultadas[0]].Visible = true;
                    rowsOcultadas.Remove(rowsOcultadas[0]);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //Show All Data
        {
            chk_Click(sender, e);
            if (isChecked(checkBox1))
            {

                checkBox1.Enabled = false; 
                checkBox2.Enabled = true;

                foreach (DataGridViewColumn col in dataGridDT.Columns)
                {
                    col.Visible = true;
                }
            }

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


        private void guna2PanelDT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            search = textBoxSearch.Text;
            try
            {
                if (this.search == "")
                {
                    MessageBox.Show("You must enter a name of a header column");
                }
                else 
                {
                    foreach (DataGridViewColumn column in dataGridDT.Columns)
                    {
                        if (column.HeaderText.Equals(this.search))
                        {
                            for (int i = 0; i < dataGridDT.Columns.Count; i++)
                            {
                                dataGridDT.Columns[i].Visible = false;
                            }
                            found = true;
                            dataGridDT.Columns[this.search].Visible = true;
                        }
                    }

                    if (found == false)
                    {
                        MessageBox.Show("There is no column with that name, please make sure that the name entered is the same as the one in the table header.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is no column with that name, please make sure that the name entered is the same as the one in the table header.");
            }
        }


        private void textBoxSearch_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSearch.Text = "";
        }
    }
}
