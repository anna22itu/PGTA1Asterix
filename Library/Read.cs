using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Library
{
    public class Read
    {
        static string[] readBytes = new string[] {};

        //n serà el byte que estem llegint en cada moment, és molt important que a cada funció de les classes CAT 10 i 21, quan es decodifiqui un byte es cridi
        //a la funció sumbyte, per saber que hem d'anar a pel següent byte.
        static int n = 0;

        public static int getn()
        {
            return n;
        }
        public static void sumbyte(int num)
        {
            n = n + num;
        }

        public static void main(string str, IProgress<int> loadingEnded)
        {
            readBytes = Functions.hextobin(str.Split("-"));

            int alreadyread = 0;
            Data.resetData();
            while (alreadyread != readBytes.Length) //readBytes.Length != 0
            {
                //identifiquem la categoria
                int currentCategory = Functions.bintonum(readBytes[n + alreadyread]);
                sumbyte(1);

                if (currentCategory == 10 | currentCategory == 21)
                {
                    //passem els dos octets del len
                    int length_dataitems = Functions.Len(readBytes[n + alreadyread], readBytes[n + 1 + alreadyread]) - 3;

                    string[] fspec_dataitems = readBytes[(n + alreadyread)..((n + alreadyread) + length_dataitems)]; //Functions.subarray(readBytes, n, length_dataitems);

                    int[] found_di = Functions.Fspec(fspec_dataitems, currentCategory); //retornara un vector de 25 o 42 posicions (25 di pot haver en cat10) amb 1 si hi es, 0 si no hi es

                    string[] dataitems = fspec_dataitems[(n - 3)..length_dataitems]; //Functions.subarray(fspec_dataitems,n-3, length_dataitems+3-n); //array dels data items sense el fspec

                    sumbyte(-n); //Resetejem la n a 0 per quan cridem DICalling a dataitems

                    //Si, a la cat10, al missatge no tenim el primer data item (message type) és un error
                    if (currentCategory == 10 && found_di[0] == 0)
                    {
                        int m = length_dataitems + 3;
                        alreadyread = alreadyread + m;
                        sumbyte(-n);//per resetejar a 0 la n
                        break;
                    }
                    

                    //Depenent del found_di, utilitzem la funcio DICalling per cridar el metod que toca
                    for (int i=0; i < found_di.Length; i++){
                        
                        //INFO: Als metods sempre passarem tot el dataitems i el n on comencem, des d'alla triarem els que toqui utilitzar per a cada data item i sumarem a n el que toqui.
                        //      Serà algo del estil dataitems[n]:dataitems[n+2] (2 o quants bytes siguin necessaris)
                        if (found_di[i] == 1)
                        {
                            if (currentCategory == 10)
                            {
                                CAT10.DICalling(CAT10Dict.methods[i], dataitems, n);
                            }
                            else
                            {
                                CAT21.DICalling(CAT21Dict.methods[i], dataitems, n);
                            }
                            
                        }
                        
                    }

                    Data.nextblock();
                    int l = length_dataitems + 3;
                    alreadyread = alreadyread + l;
                    sumbyte(-n);//per resetejar a 0 la n
                }

                else
                {
                    int length_catout = Functions.Len(readBytes[n + alreadyread], readBytes[n + 1 + alreadyread]);
                    alreadyread = alreadyread + length_catout;
                    sumbyte(-n);//per resetejar a 0 la n
                }
            }
            loadingEnded.Report(1);
        }
    }
}
