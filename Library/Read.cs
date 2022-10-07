using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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

        public static int aux;

        

        public static void sumbyte(int num)
        {
            n = n + num;
        }

        private static void main()
        {
            while (readBytes.Length != 0)
            {
                //identifiquem la categoria
                int currentCategory = Functions.bintonum(readBytes[n]);
                sumbyte(1);

                if (currentCategory == 10)
                {
                    //passem els dos octets del len
                    int length_dataitems = CAT10.Len(readBytes[n], readBytes[n + 1]) - 3;
                    string[] fspec_dataitems = Functions.subarray(readBytes, n, length_dataitems);
                    int[] found_di = CAT10.Fspec(fspec_dataitems); //retornara un vector de 25 posicions (25 di pot haver en cat10) amb 1 si hi es, 0 si no hi es
                    string[] dataitems =Functions.subarray(fspec_dataitems,n-3, length_dataitems+3-n);
                    //Depenent del found_di, utilitzem la funcio xxxx per cridar el metod que toca

                    //Tota la info dels Invoke i tal està a: https://learn.microsoft.com/es-es/dotnet/api/system.reflection.methodbase.invoke?view=net-6.0
                    //NO FUNCIONAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA LO DEL INVOKE, O SE SOLUCIONA O BUSQUEM ALTERNATIVES
                    Type Cat10type = Type.GetType("Library.qualified.CAT10, ");
                    ConstructorInfo Cat10constructor = Cat10type.GetConstructor(Type.EmptyTypes);
                    object Cat10obj = Cat10constructor.Invoke(new object[] { });

                    for (int i=0; i < found_di.Length; i++){
                        //INFO: Als metods sempre passarem tot el dataitems, des d'alla triarem els que toqui utilitzar per a cada data item i sumarem a n el que toqui.
                        //      Podrem accedir des dels metods a n (és public) per a veure en quin byte hem de començar a llegir
                        //      Serà algo del estil dataitems[n]:dataitems[n+2] (2 o quants bytes siguin necessaris)
                        if (found_di[i] == 1)
                        {
                            MethodInfo method = Cat10type.GetMethod(CAT10.methods[i]);
                            object returned = method.Invoke(Cat10obj, new object[] { dataitems });

                        }
                        



                    }




                    //un cop acabat de llegir tot el data block
                    readBytes=Functions.subarray(readBytes,n, readBytes.Length-n); //resetejem el readbytes per començar amb n=0 des del següent byte
                    sumbyte(-n);//per resetejar a 0 la n
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

            
        }

        public static void setReadBytes(string str)
        {
            readBytes = Functions.hextobin(str.Split("-"));
            //un cop tenim llegit l'arxiu, executem el main on s'aniram executant totes les funcions necessaries
            main();
        }

    }
}
