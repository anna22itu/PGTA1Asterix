using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Functions
    {
        public static int strtoint(char str) //Es necesita per solucionar una incompatibilitat
        {
            return Convert.ToInt16(str.ToString());
        }
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
        public static int Len(string octet1, string octet2) //Calcula els dos octets de la llargada de tot el data block
        {
            string length = octet1 + octet2;
            Read.sumbyte(2);
            return bintonum(length);
        }
        public static int[] Fspec(string[] bytes, int cat)
        {
            int f;
            if (cat == 10)
            {
                f = 25;
            }
            else
            {
                f = 49;
            }
          
            int[] fspec = new int[f];
            int fx = 1; //indica que continuem mirant fspec
            int n = 0; //studied byte
            int fxcounted = 0; //cal comptar quantes fx hem llegit pq no son bits valids de fspec (no estan relacionats amb data items)
            while (fx == 1)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i == 7) //si estem mirant el fx
                    {
                        fxcounted++;
                        if (bytes[n][i] == '0')
                        {
                            fx = 0;
                        }
                    }
                    else if (bytes[n][i] == '1')
                    {
                        fspec[i + 8 * n - fxcounted] = 1;
                    }
                    else //cal mirar si pot ser q no fos un 0 tambe i que dones error
                    {
                        if (i + 8 * n <= f)
                        {
                            fspec[i + 8 * n - fxcounted] = 0;
                        }

                    }
                }
                n++;

            }
            Read.sumbyte(fxcounted); //this is the number of bytes read
            return fspec;
        }

        public static string numtobin(int i)
        {            
            int number = i;
            int remainder;
            string binary = string.Empty;

            while (number > 0)
            {
                remainder = number % 2;
                number /= 2;
                binary = remainder.ToString() + binary;
            }
            return binary;
        }

        public static Dictionary<char, string> BinaryComplement = new Dictionary<char, string> { { '0', "1" }, { '1', "0" } };
        static bool isnegative = false;
        public static string ComplementoA2 (string bits)
        {
            
            string result;

            if (strtoint(bits[0]) == 1) //el resultat és negatiu, cal fer proces
            {
                isnegative = true;
                string bc2="";
                for (int i = 1; i < bits.Length; i++)
                {
                    bc2 = bc2+BinaryComplement[bits[i]];
                }
                bc2 = Convert.ToString(Convert.ToInt32(bc2, 2) + 1, 2);
                result = bc2;
            }

            else
            {
                result = bits;
            }

            return result;
        }

        public static double BCD(string bits, double LSB) 
        {
            if (isnegative == true)
            {
                LSB = -LSB;
            }

            double value = bintonum(bits) * LSB;
            isnegative = false;

            return value;
        }

        public static string bintohex(string bin)
        {
            string hex = Convert.ToInt32(bin, 2).ToString("X");
            return hex;
        }



    }
}
