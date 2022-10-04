using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Read
    {
        static string[] readBytes;

        //n serà el byte que estem llegint en cada moment, és molt important que a cada funció de les classes CAT 10 i 21, quan es decodifiqui un byte es cridi
        //a la funció sumbyte, per saber que hem d'anar a pel següent byte.
        static int n = 0;
        public static void sumbyte(int num)
        {
            n = n + num;
        }

        private static void main()
        {
            //identifiquem la categoria
            int currentCategory = Functions.bintonum(readBytes[n]);
            sumbyte(1);

            if(currentCategory == 10)
            {
                //passem els dos octets del len
                int length_dataitems=CAT10.Len(readBytes[n], readBytes[n+1])-3;
                sumbyte(2);
                string[] fspec_dataitems = Functions.subarray(readBytes,n,length_dataitems);
                int[] found_di = CAT10.Fspec(fspec_dataitems); //retornara un vector de 25 posicions (25 di pot haver en cat10) amb 1 si hi es, 0 si no hi es
                //falta sumar els bytes que toquen, cal treureho de la n que s'utilitza a Fspec, retornarla tb

            }

            else if (currentCategory == 21)
            {
                //fspec de la cat21 etc etc etc
            }

            else
            {
                //dialog de que hi ha un error amb la categoria o ja veiem que fem potser es corrupte o lo que sigui
            }
        }

        public static void setReadBytes(string str)
        {
            readBytes = Functions.hextobin(str.Split("-"));
            //un cop tenim llegit l'arxiu, executem el main on s'aniram executant totes les funcions necessaries
            main();
        }


    }
}
