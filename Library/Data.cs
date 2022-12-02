using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Apache.Arrow;
using Microsoft.Data.Analysis;
using static Microsoft.ML.DataViewSchema;

namespace Library
{
    public class Data
    {

        public static List<string> dataitems = new List<string>() { "Mode-3/A Code", "Acceleration X", "Acceleration Y", "AH", "Air Speed", "Altitude Intention", "Altitude Final", "AM", "Amplitude", "AOS Value", "ARA", "ARA Value", "ARC", "ARV", "AS Value", "ATP", "B2", "Barometric Vertical Rate", "BDS1", "BDS1_BDS", "BDS2", "BDS2_BDS", "BDSDATA", "BVR Value", "CDTI", "CDTIA", "CHN", "CL", "CNF", "Covariance", "CPR", "CRT", "CST", "DCR", "DIV", "DOU", "Emitter Category", "FL", "FL Value", "FL G", "FL V", "FSA Value", "FSI Position", "FSI Velocity", "GBS", "Geometric Height", "Geometric Vertical Rate", "GH Value", "GHO", "Ground Speed", "GV Value", "GVR Value", "Height", "ICF", "IDENT", "IM", "IPC", "Latitude Intention", "Latitude WGS84", "Latitude WGS84 HP", "LDPJ", "LLC", "LNAV", "Longitude Intention", "Longitude WGS84", "Longitude WGS84 HP", "LOP", "LTT", "M3A Value", "Magnetic Heading", "MAH", "MAM Value", "MB", "MBC element", "MBC value", "ME", "MessageType", "MET Value", "MH Value", "Mode3/A G", "Mode3/A L", "Mode3/A V", "MRS", "MSG", "MTE", "MV", "NAV", "NC", "NOGO", "NVB", "OVL", "POA", "Point Type", "Presence N", "Presence rho", "Presence theta", "PS", "QI Value", "RA", "RAB", "RAC", "RAS", "RAT", "RC", "RCF", "RE", "RE_A", "RE_G", "RE_VR", "Receiver ID", "REP", "REP_BDS", "rho", "ROA Value", "Roll Angle", "RP", "SA", "SAA", "SAC", "SAL Value", "SAS", "SCC Value", "Selected Altitude", "Service Identification", "SIC", "SIM", "SPI", "SS", "Standard Deviation X", "Standard Deviation Y", "STH", "STI", "STYP", "TAR Value", "Target Address", "Target Identification", "Target Length", "Target Orientation", "Target Width", "TAS Value", "TBC element", "TBC value", "TC", "TCA", "TCAS", "TCC", "TCP", "TD", "Temperature", "theta", "TI Value", "TID", "TID_ACAS", "Tidentification Value", "Time of Applicability Position", "Time of Applicability Velocity", "Time of Asterix Transmission", "Time of Day", "Time of Message Reception Position", "Time of Message Reception Position HP", "Time of Message Reception Velocity", "Time of Message Reception Velocity HP", "TIS", "TOA", "TOM", "TOT", "TOV", "TRA", "Track Angle", "Track Angle Rate", "Track Number", "TRB", "TRD Value", "TRE", "True Airspeed", "TS", "TS Value", "TST", "TSV", "TTF", "TTI", "TTR", "Turbulence", "TYP", "Vehicle Fleet Identification", "Velocity X Cart", "Velocity Y Cart", "VN", "VNS", "Wind Direction", "Wind Speed", "X Cartesian", "Y Cartesian" };
        public static int[] DIAppears= new int[193]; //afegim un 1 quan tenim algun valor en aquesta columna, per poder eliminar les columnes on no hi ha res al datagrid
        public static IDictionary<string, int> columns = new Dictionary<string, int>() { { "Mode-3/A Code", 0 }, { "Acceleration X", 1 }, { "Acceleration Y", 2 }, { "AH", 3 }, { "Air Speed", 4 }, { "Altitude Intention", 5 }, { "Altitude Final", 6 }, { "AM", 7 }, { "Amplitude", 8 }, { "AOS Value", 9 }, { "ARA", 10 }, { "ARA Value", 11 }, { "ARC", 12 }, { "ARV", 13 }, { "AS Value", 14 }, { "ATP", 15 }, { "B2", 16 }, { "Barometric Vertical Rate", 17 }, { "BDS1", 18 }, { "BDS1_BDS", 19 }, { "BDS2", 20 }, { "BDS2_BDS", 21 }, { "BDSDATA", 22 }, { "BVR Value", 23 }, { "CDTI", 24 }, { "CDTIA", 25 }, { "CHN", 26 }, { "CL", 27 }, { "CNF", 28 }, { "Covariance", 29 }, { "CPR", 30 }, { "CRT", 31 }, { "CST", 32 }, { "DCR", 33 }, { "DIV", 34 }, { "DOU", 35 }, { "Emitter Category", 36 }, { "FL", 37 }, { "FL Value", 38 }, { "FL G", 39 }, { "FL V", 40 }, { "FSA Value", 41 }, { "FSI Position", 42 }, { "FSI Velocity", 43 }, { "GBS", 44 }, { "Geometric Height", 45 }, { "Geometric Vertical Rate", 46 }, { "GH Value", 47 }, { "GHO", 48 }, { "Ground Speed", 49 }, { "GV Value", 50 }, { "GVR Value", 51 }, { "Height", 52 }, { "ICF", 53 }, { "IDENT", 54 }, { "IM", 55 }, { "IPC", 56 }, { "Latitude Intention", 57 }, { "Latitude WGS84", 58 }, { "Latitude WGS84 HP", 59 }, { "LDPJ", 60 }, { "LLC", 61 }, { "LNAV", 62 }, { "Longitude Intention", 63 }, { "Longitude WGS84", 64 }, { "Longitude WGS84 HP", 65 }, { "LOP", 66 }, { "LTT", 67 }, { "M3A Value", 68 }, { "Magnetic Heading", 69 }, { "MAH", 70 }, { "MAM Value", 71 }, { "MB", 72 }, { "MBC element", 73 }, { "MBC value", 74 }, { "ME", 75 }, { "MessageType", 76 }, { "MET Value", 77 }, { "MH Value", 78 }, { "Mode3/A G", 79 }, { "Mode3/A L", 80 }, { "Mode3/A V", 81 }, { "MRS", 82 }, { "MSG", 83 }, { "MTE", 84 }, { "MV", 85 }, { "NAV", 86 }, { "NC", 87 }, { "NOGO", 88 }, { "NVB", 89 }, { "OVL", 90 }, { "POA", 91 }, { "Point Type", 92 }, { "Presence N", 93 }, { "Presence rho", 94 }, { "Presence theta", 95 }, { "PS", 96 }, { "QI Value", 97 }, { "RA", 98 }, { "RAB", 99 }, { "RAC", 100 }, { "RAS", 101 }, { "RAT", 102 }, { "RC", 103 }, { "RCF", 104 }, { "RE", 105 }, { "RE_A", 106 }, { "RE_G", 107 }, { "RE_VR", 108 }, { "Receiver ID", 109 }, { "REP", 110 }, { "REP_BDS", 111 }, { "rho", 112 }, { "ROA Value", 113 }, { "Roll Angle", 114 }, { "RP", 115 }, { "SA", 116 }, { "SAA", 117 }, { "SAC", 118 }, { "SAL Value", 119 }, { "SAS", 120 }, { "SCC Value", 121 }, { "Selected Altitude", 122 }, { "Service Identification", 123 }, { "SIC", 124 }, { "SIM", 125 }, { "SPI", 126 }, { "SS", 127 }, { "Standard Deviation X", 128 }, { "Standard Deviation Y", 129 }, { "STH", 130 }, { "STI", 131 }, { "STYP", 132 }, { "TAR Value", 133 }, { "Target Address", 134 }, { "Target Identification", 135 }, { "Target Length", 136 }, { "Target Orientation", 137 }, { "Target Width", 138 }, { "TAS Value", 139 }, { "TBC element", 140 }, { "TBC value", 141 }, { "TC", 142 }, { "TCA", 143 }, { "TCAS", 144 }, { "TCC", 145 }, { "TCP", 146 }, { "TD", 147 }, { "Temperature", 148 }, { "theta", 149 }, { "TI Value", 150 }, { "TID", 151 }, { "TID_ACAS", 152 }, { "Tidentification Value", 153 }, { "Time of Applicability Position", 154 }, { "Time of Applicability Velocity", 155 }, { "Time of Asterix Transmission", 156 }, { "Time of Day", 157 }, { "Time of Message Reception Position", 158 }, { "Time of Message Reception Position HP", 159 }, { "Time of Message Reception Velocity", 160 }, { "Time of Message Reception Velocity HP", 161 }, { "TIS", 162 }, { "TOA", 163 }, { "TOM", 164 }, { "TOT", 165 }, { "TOV", 166 }, { "TRA", 167 }, { "Track Angle", 168 }, { "Track Angle Rate", 169 }, { "Track Number", 170 }, { "TRB", 171 }, { "TRD Value", 172 }, { "TRE", 173 }, { "True Airspeed", 174 }, { "TS", 175 }, { "TS Value", 176 }, { "TST", 177 }, { "TSV", 178 }, { "TTF", 179 }, { "TTI", 180 }, { "TTR", 181 }, { "Turbulence", 182 }, { "TYP", 183 }, { "Vehicle Fleet Identification", 184 }, { "Velocity X Cart", 185 }, { "Velocity Y Cart", 186 }, { "VN", 187 }, { "VNS", 188 }, { "Wind Direction", 189 }, { "Wind Speed", 190 }, { "X Cartesian", 191 }, { "Y Cartesian", 192 } };
        static object[] datait = new object[193];
        public static List<object[]> TotalItems = new List<object[]>();

        public static void add(string what, object thing)
        {
            datait[columns[what]] = thing;
            if (DIAppears[columns[what]]==0)
            {
                DIAppears[columns[what]] = 1;
            }
        }
        public static void resetData() //if we upload another document we net to set everything to default
        {
            TotalItems.Clear();
            datait = new object[193];
            DIAppears = new int[193];
        }
        public static void nextblock()
        {
            TotalItems.Add(datait);
            datait = new object[193];
        }

        public static bool export(string path, IProgress<int> loadingStarted, IProgress<int> loadingEnded)
        {
            loadingStarted.Report(1);
            //string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName; // return the application.exe current folder
            string name = DateTime.Now.ToString(@"ddMMyyyyhhmmtt");
            string fileName = Path.Combine(path, name+".csv");
            StreamWriter sw = new StreamWriter(fileName, false);

            //headers
            try
            {
                string headers = "";
                foreach (string item in dataitems)
                {
                    headers = headers + item + ";";
                }
                sw.WriteLine(headers);

                foreach (object[] datablock in TotalItems)
                {
                    string data = "";
                    foreach (object item in datablock)
                    {
                        if (item != null)
                        {
                            data = data + item.ToString() + ";";
                        }
                        else
                        {
                            data = data + ";";
                        }
                    }
                    sw.WriteLine(data);
                }
                sw.Close();
                loadingEnded.Report(1);
                return true;
            }
            catch
            {
                return false;
            }

            
        }
    }
}
