using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Functions
    {
        public static string[] hextobin(string[] hex)
        {
            string[] bin = new string[hex.Length];
            int i = 0;
            foreach (string hex2 in hex)
            {
                bin[i]=Convert.ToString(Convert.ToInt32(hex2, 16), 2);
                if (bin[i].Length!=8)
                {
                    string zeros = new string('0', 8 - bin[i].Length);
                    bin[i] = zeros + bin[i];
                }
                i++;
            }
            return bin;
        }
        //HEM DE MIRAR SI EL TIPUS DE BINARI ERA BCD O QUIN
        public static int bintonum(string bin)
        {
            return Convert.ToInt32(bin, 2);
        }
        //crear un subarray de un array
        public static string[] subarray(string[] bytes, int start, int length)
        {
            string[] sub = new string[length];
            Array.Copy(bytes, start, sub, 0, length);
            return sub;
        }
    }
}
