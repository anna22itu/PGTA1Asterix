using System;
using System.Collections.Generic;
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
                f = 42;
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
                        if (i + 8 * n <= 24)
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


        public static string[] methods = { "ComplementoA2" };

        public static Dictionary<char, string> BinaryComplement = new Dictionary<char, string> { { '0', "1" }, { '1', "0" } };
        public static string ComplementoA2 (string bits)
        {
            string[] bitsC2 = new string[bits.Length];

            for (int i=0; i< bits.Length;i++)
            {
                bitsC2[i] = BinaryComplement[bits[i]];
            }

            string result = bitsC2[0];
            for (int i = 0; i < bitsC2.Length; i++)
            {
                result = result + bitsC2[i + 1];
            }

            return result;
        }

        public static Dictionary<int, string> BinaryToHex = new Dictionary<int, string> { { 0, "No differential correction (ADS-B)" }, { 1, "Differential correction (ADS-B)" } };
    }
}
