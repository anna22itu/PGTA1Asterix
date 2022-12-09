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
using Newtonsoft.Json.Linq;
using System.Data.Entity.Core.Mapping;
using System.Reflection;

namespace Asterix_Decoder
{
    public partial class TableData : Form
    {


        public TableData()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            checkBox2.Checked = true;
            textBoxSearch.Text = "Enter a DataItem";

        }

        List<string> relevantData = new List<string>() { "SIC", "SAC", "Time of Day", "MessageType", "Track Number", "Target Address", "Target Identification", "X Cartesian", "Y Cartesian", "Latitude WGS84", "Longitude WGS84", "Velocity X Cart", "Velocity Y Cart", "Ground Speed", "Track Angle", "FL", "Height", "Geometric Height", "Barometric Vertical Rate", "Selected Altitude", "Mode-3/A Code", "Emitter Category" };
        List<string> columnOrder = new List<string>() { "SIC", "SAC", "Time of Day", "MessageType", "Track Number", "Target Address", "Target Identification", "X Cartesian", "Y Cartesian", "Latitude WGS84", "Latitude WGS84 HP", "Latitude Intention", "Longitude WGS84", "Longitude WGS84 HP", "Longitude Intention", "rho", "theta", "Velocity X Cart", "Velocity Y Cart", "Ground Speed", "Air Speed", "True AirSpeed", "Acceleration X", "Acceleration Y", "Track Angle", "Track Angle Rate", "FL", "Height", "Geometric Height", "Barometric Vertical Rate", "Geometric Vertical Rate", "Selected Altitude", "Altitude Intention", "Altitude Final", "Mode-3/A Code", "Emitter Category", "Vehicle Fleet Identification", "Target Length", "Target Orientation", "Target Width", "Magnetic Heading", "Receiver ID", "Service Identification", "Turbulence", "Temperature", "Wind Direction", "Wind Speed", "Roll Angle", "Amplitude", "Time of Applicability Position", "Time of Applicability Velocity", "Time of Message Reception Position", "Time of Message Reception Position HP", "Time of Message Reception Velocity", "Time of Message Reception Velocity HP", "Point Type", "Presence rho", "Presence theta", "Standard Deviation X", "Standard Deviation Y", "BDS1", "BDS2", "BDS1_BDS", "BDS2_BDS", "BDSDATA", "ATP", "Covariance", "ICF", "MB", "ME", "MSG", "PS", "RA", "RAS", "SIM", "SS", "TCAS", "TD", "TOM", "TOT", "TOV", "TTR" };
        List<string> columnNames = new List<string>() { "SIC", "SAC", "Time of Day", "MessageType", "Track Number", "Target Address", "Target Identification", "X Cartesian [m]", "Y Cartesian [m]", "Latitude WGS84 [º]", "Latitude WGS84 HP [º]", "Latitude Intention [º]", "Longitude WGS84 [º]", "Longitude WGS84 HP [º]", "Longitude Intention [º]", "rho [m]", "theta [º]", "Velocity X Cart [m/s]", "Velocity Y Cart [m/s]", "Ground Speed [kt]", "Air Speed [NM/s]", "True AirSpeed [kt]", "Acceleration X [m/s^2]", "Acceleration Y [m/s^2]", "Track Angle [º]", "Track Angle Rate [º/s]", "FL [FL]", "Height [ft]", "Geometric Height [ft]", "Barometric Vertical Rate [ft/min]", "Geometric Vertical Rate [ft/min]", "Selected Altitude [ft]", "Altitude Intention [ft]", "Altitude Final [ft]", "Mode-3/A Code", "Emitter Category", "Vehicle Fleet Identification", "Target Length [m]", "Target Orientation [º]", "Target Width [m]", "Magnetic Heading [º]", "Receiver ID", "Service Identification", "Turbulence", "Temperature [ºC]", "Wind Direction [º]", "Wind Speed [kt]", "Roll Angle [º]", "Amplitude [dbm]", "Time of Applicability Position", "Time of Applicability Velocity", "Time of Message Reception Position", "Time of Message Reception Position HP", "Time of Message Reception Velocity", "Time of Message Reception Velocity HP", "Point Type", "Presence rho [m]", "Presence theta [º]", "Standard Deviation X [m]", "Standard Deviation Y [m]", "BDS1", "BDS2", "BDS1_BDS", "BDS2_BDS", "BDSDATA", "ATP", "Covariance [m^2]", "ICF", "MB", "ME", "MSG", "PS", "RA", "RAS", "SIM", "SS", "TCAS", "TD", "TOM", "TOT", "TOV", "TTR" };
        List<string> bydict = new List<string>() { "Emitter Category", "Vehicle Fleet Identification", "Point Type", "ATP", "ICF", "ME", "MSG", "PS", "RA", "RAS", "SIM", "SS", "TCAS", "TD", "TOM", "TOT", "TOV", "TTR"};

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

        int initialLine = 0;
        int endingLine = 5000;
        List<CheckBox> enabledboxes = new List<CheckBox>();
        IProgress<int> loadingDTstarted = new Progress<int>();
        IProgress<int> loadingDTended = new Progress<int>();
        string loading = "Loading...";
        public void LoadData(IProgress<int> loadingStarted, IProgress<int> loadingEnded)
        {
            loadingDTstarted = loadingStarted;
            loadingDTended = loadingEnded;

            loadingStarted.Report(1);
            
            Invoke(setLabel1Text, loading);
            int[] Appear = new int[82];
            dataGridDT.RowHeadersVisible = false;
            dataGridDT.AllowUserToAddRows = false;

            foreach (string column in Data.dataitems)
            {
                if (columnOrder.Contains(column))
                {
                    Appear[columnOrder.IndexOf(column)] = Data.DIAppears[Data.columns[column]];
                }
            }

            dataGridDT.ColumnCount = Appear.Sum();

            int i = 0;
            for (int w=0; w<columnOrder.Count; w++) //afegim totes les columnes que tenen algun valor i que ens interessen
            {
                if (Appear[columnOrder.IndexOf(columnOrder[w])] == 1) //column has any value
                {
                    dataGridDT.Columns[i].Name = columnNames[w];
                    i++;
                }
            }

            for(int s=initialLine; s < endingLine; s++) //1000 -> Data.TotalItems.Count
            {
                object[] item = Data.TotalItems[s]; //El SMR per exemple te 50k files

                passDict(item);

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
            initialLine = endingLine;


            foreach (DataGridViewColumn col in dataGridDT.Columns)
            {
                if (relevantData.Contains(col.Name) == false)
                {
                    col.Visible = false;
                }
            }

            enabledboxes.Clear();
            if(dataGridDT.Columns.Contains("Track Number"))
            {
                enabledboxes.Add(checkBox6);
            }
            if (dataGridDT.Columns.Contains("Target Identification"))
            {
                enabledboxes.Add(checkBox5);
            }
            if (dataGridDT.Columns.Contains("Target Address"))
            {
                enabledboxes.Add(checkBox3);
            }
            if (dataGridDT.Columns.Contains("Mode-3/A Code"))
            {
                enabledboxes.Add(checkBox4);
            }
            enableDisponibles();
            string t = "The amount of rows shown is: " + dataGridDT.Rows.Count.ToString();
            Invoke(setLabel1Text, t );
            loadingEnded.Report(1);

        }

        private void enableDisponibles()
        {
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            foreach (CheckBox checkBox in enabledboxes)
            {
                checkBox.Enabled = true;
            }
        }
        
        private void passDict(object[] item)
        {
            if (item[Data.columns[bydict[0]]] != null) item[Data.columns[bydict[0]]] = CAT21Dict.EmitterCategory_ECAT[Convert.ToInt32(item[Data.columns[bydict[0]]])];
            if (item[Data.columns[bydict[1]]] != null) item[Data.columns[bydict[1]]] = CAT10Dict.VehicleFleetIdentification_VFI[Convert.ToInt32(item[Data.columns[bydict[1]]])];
            if (item[Data.columns[bydict[2]]] != null) item[Data.columns[bydict[2]]] = CAT21Dict.TrajectoryIntent_PointType[Convert.ToInt32(item[Data.columns[bydict[2]]])];
            if (item[Data.columns[bydict[3]]] != null) item[Data.columns[bydict[3]]] = CAT21Dict.TargetReportDescriptor_ATP[Convert.ToInt32(item[Data.columns[bydict[3]]])];
            if (item[Data.columns[bydict[4]]] != null) item[Data.columns[bydict[4]]] = CAT21Dict.TargetStatus_ICF[Convert.ToInt32(item[Data.columns[bydict[4]]])];
            if (item[Data.columns[bydict[5]]] != null) item[Data.columns[bydict[5]]] = CAT21Dict.TargetStatus_ME[Convert.ToInt32(item[Data.columns[bydict[5]]])];
            if (item[Data.columns[bydict[6]]] != null) item[Data.columns[bydict[6]]] = CAT10Dict.PreprogrammedMessage_MSG[Convert.ToInt32(item[Data.columns[bydict[6]]])];
            if (item[Data.columns[bydict[7]]] != null) item[Data.columns[bydict[7]]] = CAT21Dict.TargetStatus_PS[Convert.ToInt32(item[Data.columns[bydict[7]]])];
            if (item[Data.columns[bydict[8]]] != null) item[Data.columns[bydict[8]]] = CAT21Dict.AircraftOperationalStatus_RA[Convert.ToInt32(item[Data.columns[bydict[8]]])];
            if (item[Data.columns[bydict[9]]] != null) item[Data.columns[bydict[9]]] = CAT21Dict.SurfaceCapabilities_RAS[Convert.ToInt32(item[Data.columns[bydict[9]]])];
            if (item[Data.columns[bydict[10]]] != null) item[Data.columns[bydict[10]]] = CAT21Dict.TargetReportDescriptor_SIM[Convert.ToInt32(item[Data.columns[bydict[10]]])];
            if (item[Data.columns[bydict[11]]] != null) item[Data.columns[bydict[11]]] = CAT21Dict.TargetStatus_SS[Convert.ToInt32(item[Data.columns[bydict[11]]])];
            if (item[Data.columns[bydict[12]]] != null) item[Data.columns[bydict[12]]] = CAT21Dict.AircraftOperationalStatus_TCAS[Convert.ToInt32(item[Data.columns[bydict[12]]])];
            if (item[Data.columns[bydict[13]]] != null) item[Data.columns[bydict[13]]] = CAT21Dict.TrajectoryIntent_TD[item[Data.columns[bydict[13]]].ToString()];
            if (item[Data.columns[bydict[14]]] != null) item[Data.columns[bydict[14]]] = CAT10Dict.TrackStatus_TOM[item[Data.columns[bydict[14]]].ToString()];
            if (item[Data.columns[bydict[15]]] != null) item[Data.columns[bydict[15]]] = CAT10Dict.TargetReportDescriptor_TOT[item[Data.columns[bydict[15]]].ToString()];
            if (item[Data.columns[bydict[16]]] != null) item[Data.columns[bydict[16]]] = CAT21Dict.TrajectoryIntent_TOV[Convert.ToInt32(item[Data.columns[bydict[16]]])];
            if (item[Data.columns[bydict[17]]] != null) item[Data.columns[bydict[17]]] = CAT21Dict.TrajectoryIntent_TTR[Convert.ToInt32(item[Data.columns[bydict[17]]])];
        }

        //Checked Boxes
        CheckBox lastChecked1;
        CheckBox lastChecked2;
        List<int> rowsOcultadas = new List<int>();
        private void chk_Click(object sender, EventArgs e) //so that only one checkbox can be used
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked1 && lastChecked1 != null) lastChecked1.Checked = false;
            lastChecked1 = activeCheckBox.Checked ? activeCheckBox : null;


        }
        private void chk_ClickFilter(object sender, EventArgs e) //so that only one checkbox can be used
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked2 && lastChecked2 != null) lastChecked2.Checked = false;
            lastChecked2 = activeCheckBox.Checked ? activeCheckBox : null;

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

        bool found = false;
        
        private void btnSearch_Click(object sender, EventArgs e)
        {

            found = false;
            String value = textBoxSearch.Text;
            String typeValue = "";
                  

            try
            {

                if (isChecked(checkBox5))
                {
                    typeValue = "Target Identification";
                    //value = value + "  ";
                }
                else if (isChecked(checkBox6))
                {
                    typeValue = "Track Number";
                }
                else if (isChecked(checkBox3))
                {
                    typeValue = "Target Address";
                }
                else if (isChecked(checkBox4))
                {
                    typeValue = "Mode-3/A Code";
                }


                if (typeValue == "") 
                {
                    MessageBox.Show("You must check a filter");
                }
                else 
                {
                    for (int i = 0; i < dataGridDT.Rows.Count - 1; i++)
                    {
                        if (dataGridDT.Rows[i].Cells[typeValue].Value.ToString().Equals(value))
                        {
                            dataGridDT.Rows[i].Visible = true;
                            found = true;
                        }
                        else if (typeValue == "Target Identification" && dataGridDT.Rows[i].Cells[typeValue].Value.ToString().Contains(value))
                        {
                            dataGridDT.Rows[i].Visible = true;
                            found = true;
                        }
                        else
                        {
                            dataGridDT.Rows[i].Visible = false;
                        }
                    }

                    if (found == false)
                    {
                        MessageBox.Show("There is no value equal to: " + value + " in the column " + typeValue + ", please make sure that the value entered is an existing value.");
                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("You must check a filter");
            }

        }


        private void textBoxSearch_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < dataGridDT.Rows.Count - 1; i++)
            {
                dataGridDT.Rows[i].Visible = true;
            }

            textBoxSearch.Text = "";
        }


        private void checkBox5_Click(object sender, EventArgs e)
        {
            // TargetID
            chk_ClickFilter(sender, e);
            enableDisponibles();
            checkBox5.Enabled = false;
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            // Track Number
            chk_ClickFilter(sender, e);
            enableDisponibles();
            checkBox6.Enabled = false;
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            // Target Address
            chk_ClickFilter(sender, e);
            enableDisponibles();
            checkBox3.Enabled = false;
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            // Mode 3/A
            chk_ClickFilter(sender, e);
            enableDisponibles();
            checkBox4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            endingLine = endingLine + 5000;

            LoadData(loadingDTstarted, loadingDTended);

        }

        private void guna2PanelDT_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
