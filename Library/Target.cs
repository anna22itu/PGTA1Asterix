using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Apache.Arrow;
using Microsoft.Data.Analysis;

namespace Library
{
    public class Target
    {
        //cada target tindra el seu dataframe amb totes les dades, es comproba si la columna que volem existeix, si no, s'afegeix
        static List<Target> allSMR = new List<Target>();

        //atributs
        //https://learn.microsoft.com/es-es/dotnet/api/system.data.datatable?view=net-7.0

        DataTable dt;
        public static void export()
        {
            allSMR[0].dt.ToCSV("C:\\Users\\alexg\\OneDrive\\UPC\\EETAC\\4A\\PGTA\\Pr1\\SMR\\TR.csv");
            allSMR[1].dt.ToCSV("C:\\Users\\alexg\\OneDrive\\UPC\\EETAC\\4A\\PGTA\\Pr1\\SMR\\SUC.csv");
            allSMR[2].dt.ToCSV("C:\\Users\\alexg\\OneDrive\\UPC\\EETAC\\4A\\PGTA\\Pr1\\SMR\\PSM.csv");
            allSMR[3].dt.ToCSV("C:\\Users\\alexg\\OneDrive\\UPC\\EETAC\\4A\\PGTA\\Pr1\\SMR\\EtSM.csv");
        }
        public Target()
        {
            dt = new DataTable();
        }
        public void add(string what, object thing)
        {
            if (dt.Columns.Contains(what)) //si conté la columna, que no deuria
            {
                dt.Rows[0][what] = thing;
            }
            else
            {
                DataColumn column = new DataColumn();
                column.DataType = Type.GetType("System.Object");
                column.ColumnName = what;
                dt.Columns.Add(column);
                if (dt.Rows.Count == 0)
                {
                    dt.Rows.Add();
                }
                dt.Rows[0][what] = thing;
            }
        }
        public void loaddata()
        {
            int index = CAT10Dict.MessageType.FirstOrDefault(x => x.Value == dt.Rows[0]["MessageType"].ToString()).Key - 1;
            if (dt.Columns.Contains("Target Address")==false) //es SMR
            {
                if (allSMR.Count == 0) //Target Report , Start of Update Cycle , Periodic Status Message , Event-triggered Status Message
                {
                    Target TR = new Target();
                    Target SUC = new Target();
                    Target PSM = new Target();
                    Target EtSM = new Target();
                    allSMR.Add(TR);
                    allSMR.Add(SUC);
                    allSMR.Add(PSM);
                    allSMR.Add(EtSM);
                }
                allSMR[index].dt.Rows.Add();
                foreach (DataColumn column in dt.Columns)
                {
                    if (allSMR[index].dt.Columns.Contains(column.ColumnName) == false)
                    {
                        DataColumn col = new DataColumn();
                        col.DataType = Type.GetType("System.Object");
                        col.ColumnName = column.ColumnName;
                        allSMR[index].dt.Columns.Add(col);
                    }
                    allSMR[index].dt.Rows[allSMR[index].dt.Rows.Count - 1][column.ColumnName] = dt.Rows[0][column.ColumnName];
                }
            }



        }
        public void reset()
        {
            dt.Clear();
            dt.Columns.Clear();
        }

    }
}
