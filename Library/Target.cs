using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.Arrow;
using Microsoft.Data.Analysis;

namespace Library
{
    internal class Target
    {
        //cada target tindra el seu dataframe amb totes les dades, es comproba si la columna que volem existeix, si no, s'afegeix

        List<Target> targets = new List<Target>(); //Cal preguntar com afegim a smr si no hi ha target address

        //atributs
        //https://learn.microsoft.com/es-es/dotnet/api/system.data.datatable?view=net-7.0

        DataTable dt;

        //constructor

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

        }
        public void reset()
        {
            dt.Clear();
            dt.Columns.Clear();
        }

    }
}
