using System;
using System.Collections.Generic;
using System.Data;
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
    public class Target
    {
        //cada target tindra el seu dataframe amb totes les dades, es comproba si la columna que volem existeix, si no, s'afegeix
        static List<Target> byKind = new List<Target>();
        static List<Target> byTarget = new List<Target>();
        public static IDictionary<object, int> targets = new Dictionary<object, int>() { };

        //atributs
        //https://learn.microsoft.com/es-es/dotnet/api/system.data.datatable?view=net-7.0

        DataTable dt;
        public static void export()
        {
            if (byKind.Count>0)
            {
                byKind[0].dt.ToCSV("C:\\Users\\alexg\\OneDrive\\UPC\\EETAC\\4A\\PGTA\\Pr1\\Data\\TR.csv");
                byKind[1].dt.ToCSV("C:\\Users\\alexg\\OneDrive\\UPC\\EETAC\\4A\\PGTA\\Pr1\\Data\\SUC.csv");
                byKind[2].dt.ToCSV("C:\\Users\\alexg\\OneDrive\\UPC\\EETAC\\4A\\PGTA\\Pr1\\Data\\PSM.csv");
                byKind[3].dt.ToCSV("C:\\Users\\alexg\\OneDrive\\UPC\\EETAC\\4A\\PGTA\\Pr1\\Data\\EtSM.csv");
            }

            if (byTarget.Count>0)
            {
                int i = 0;
                foreach (Target target in byTarget)
                {
                    
                    var myKey = targets.FirstOrDefault(x => x.Value == i).Key.ToString();
                    string name = myKey.ToString()+".csv";
                    target.dt.ToCSV("C:\\Users\\alexg\\OneDrive\\UPC\\EETAC\\4A\\PGTA\\Pr1\\Data\\" + name);
                    i++;
                }
            }
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
            //És SMR o MLAT i podem separar per tipus
            if (dt.Columns.Contains("MessageType"))
            {
                int index = CAT10Dict.MessageType.FirstOrDefault(x => x.Value == dt.Rows[0]["MessageType"].ToString()).Key - 1;
                if (byKind.Count == 0) //Target Report , Start of Update Cycle , Periodic Status Message , Event-triggered Status Message
                {
                    Target TR = new Target();
                    Target SUC = new Target();
                    Target PSM = new Target();
                    Target EtSM = new Target();
                    byKind.Add(TR);
                    byKind.Add(SUC);
                    byKind.Add(PSM);
                    byKind.Add(EtSM);
                }
                byKind[index].dt.Rows.Add();

                foreach (DataColumn column1 in dt.Columns)
                {
                    if (byKind[index].dt.Columns.Contains(column1.ColumnName) == false)
                    {
                        DataColumn col1 = new DataColumn();
                        col1.DataType = Type.GetType("System.Object");
                        col1.ColumnName = column1.ColumnName;
                        byKind[index].dt.Columns.Add(col1);
                    }
                    byKind[index].dt.Rows[byKind[index].dt.Rows.Count - 1][column1.ColumnName] = dt.Rows[0][column1.ColumnName];
                }

                if (dt.Rows[0]["MessageType"].ToString()=="Target Report")
                {
                    if (dt.Columns.Contains("Target Address")==true)
                    {
                        if (targets.ContainsKey(dt.Rows[0]["Target Address"]) == false)
                        {
                            targets[dt.Rows[0]["Target Address"]] = byTarget.Count;
                            Target target = new Target();
                            byTarget.Add(target);
                        }
                        
                    }
                    else if (targets.ContainsKey(Convert.ToInt32(dt.Rows[0]["Track Number"])) == false)
                    {
                        targets[Convert.ToInt32(dt.Rows[0]["Track Number"])] = byTarget.Count;
                        Target target = new Target();
                        byTarget.Add(target);
                        
                    }
                    if (dt.Columns.Contains("Target Address") == true)
                    {
                        index = targets[dt.Rows[0]["Target Address"]];
                    }
                    else
                    {
                        index = targets[Convert.ToInt32(dt.Rows[0]["Track Number"])];
                    }

                    byTarget[index].dt.Rows.Add();
                    foreach (DataColumn column2 in dt.Columns)
                    {
                        if (byTarget[index].dt.Columns.Contains(column2.ColumnName) == false)
                        {
                            DataColumn col2 = new DataColumn();
                            col2.DataType = Type.GetType("System.Object");
                            col2.ColumnName = column2.ColumnName;
                            byTarget[index].dt.Columns.Add(col2);
                        }
                        byTarget[index].dt.Rows[byTarget[index].dt.Rows.Count - 1][column2.ColumnName] = dt.Rows[0][column2.ColumnName];
                    }
                }
            }

            else //Es ASD-B
            {
                if (dt.Columns.Contains("Target Address"))
                {
                    if (targets.ContainsKey(dt.Rows[0]["Target Address"]) == false)
                    {
                        targets[dt.Rows[0]["Target Address"]] = byTarget.Count;
                        Target target = new Target();
                        byTarget.Add(target);
                    }

                    int index = targets[dt.Rows[0]["Target Address"]];
                    byTarget[index].dt.Rows.Add();
                    foreach (DataColumn column3 in dt.Columns)
                    {
                        if (byTarget[index].dt.Columns.Contains(column3.ColumnName) == false)
                        {
                            DataColumn col3 = new DataColumn();
                            col3.DataType = Type.GetType("System.Object");
                            col3.ColumnName = column3.ColumnName;
                            byTarget[index].dt.Columns.Add(col3);
                        }
                        byTarget[index].dt.Rows[byTarget[index].dt.Rows.Count - 1][column3.ColumnName] = dt.Rows[0][column3.ColumnName];
                    }
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
