using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CAT10
    {
        //La funció no ha de retornar res, des del metod ja anem ficant les dades on toquin (objecte avió o lo que sigui)
        static Target dataload = new Target();
        public static void resetdataload()
        {
            dataload.reset();
        }
        public static void loaddata()
        {
            dataload.loaddata();
        }
        public static void DICalling(string Case, string[] dataitems, int n)
        {
            switch (Case)
            {
                case "MessageType":

                    MessageType(dataitems[n]);
                    Read.sumbyte(1);

                    break;

                case "DataSourceIdentifier":

                    DataSourceIdentifier(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "TargetReportDescriptor":

                    int nextentstrd = 1;
                    if (Functions.strtoint(dataitems[n][7]) == 1)
                    {
                        nextentstrd++;
                        if(Functions.strtoint(dataitems[n+1][7]) == 1)
                        {
                            nextentstrd++;//Cal preguntar si podem tenir més de 3 bit es a dir 2 extents
                        }
                    }
                    TargetReportDescriptor(Functions.subarray(dataitems, n, nextentstrd),nextentstrd);
                    Read.sumbyte(nextentstrd);

                    break;

                case "MeasuredPositionPolarCoordinates":

                    MeasuredPositionPolarCoordinates(Functions.subarray(dataitems,n,4));
                    Read.sumbyte(4);

                    break;

                case "PositionWGS84Coordinates":

                    PositionWGS84Coordinates(Functions.subarray(dataitems, n, 8));
                    Read.sumbyte(8);

                    break;

                case "PositionCartesianCoordinates":

                    PositionCartesianCoordinates(Functions.subarray(dataitems,n,4));
                    Read.sumbyte(4);

                    break;

                case "Mode3ACodeOctalRepresentation":

                    Mode3ACodeOctalRepresentation(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "FlightLevelBinaryRepresentation":

                    FlightLevelBinaryRepresentation(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "MeasuredHeight":

                    MeasuredHeight(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "AmplitudePrimaryPlot":

                    AmplitudePrimaryPlot(dataitems[n]);
                    Read.sumbyte(1);

                    break;

                case "TimeOfDay":

                    TimeOfDay(dataitems[n], dataitems[n + 1], dataitems[n + 2]);
                    Read.sumbyte(3);

                    break;

                case "TrackNumber":

                    TrackNumber(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "TrackStatus":

                    int nextentsts = 1;
                    if (Functions.strtoint(dataitems[n][7]) == 1)
                    {
                        nextentsts++;
                        if (Functions.strtoint(dataitems[n + 1][7]) == 1)
                        {
                            nextentsts++;//Cal preguntar si podem tenir més de 3 bit es a dir 2 extents
                        }
                    }
                    TrackStatus(Functions.subarray(dataitems, n, nextentsts), nextentsts);
                    Read.sumbyte(nextentsts);

                    break;

                case "CalculatedTrackVelocityPolarCoordinates":

                    CalculatedTrackVelocityPolarCoordinates(Functions.subarray(dataitems, n, 4));
                    Read.sumbyte(4);

                    break;

                case "CalculatedTrackVelocityCartesianCoordinates":

                    CalculatedTrackVelocityCartesianCoordinates(Functions.subarray(dataitems, n, 4));
                    Read.sumbyte(4);

                    break;

                case "CalculatedAcceleration":

                    CalculatedAcceleration(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "TargetAddress":

                    TargetAddress(dataitems[n], dataitems[n+1], dataitems[n + 2]);
                    Read.sumbyte(3);

                    break;

                case "TargetIdentification":

                    TargetIdentification(Functions.subarray(dataitems, n, 7));
                    Read.sumbyte(7);

                    break;

                case "ModeSMBData":

                    ModeSMBData(Functions.subarray(dataitems, n, 9));
                    Read.sumbyte(9);

                    break;

                case "TargetSizeOrientation":

                    int nextentstso = 1;
                    if (Functions.strtoint(dataitems[n][7]) == 1)
                    {
                        nextentstso++;
                        if (Functions.strtoint(dataitems[n + 1][7]) == 1)
                        {
                            nextentstso++;//Cal preguntar si podem tenir més de 3 bit es a dir 2 extents
                        }
                    }
                    TargetSizeOrientation(Functions.subarray(dataitems, n, nextentstso), nextentstso);
                    Read.sumbyte(nextentstso);

                    break;

                case "Presence":

                    Presence(dataitems[n], dataitems[n + 1], dataitems[n + 2]);
                    Read.sumbyte(3);

                    break;

                case "VehicleFleetIdentification":

                    VehicleFleetIdentification(dataitems[n]);
                    Read.sumbyte(1);

                    break;

                case "PreprogrammedMessage":

                    PreprogrammedMessage(dataitems[n]);
                    Read.sumbyte(1);

                    break;

                case "StandardDeviationPosition":

                    StandardDeviationPosition(Functions.subarray(dataitems, n, 4));
                    Read.sumbyte(4);

                    break;

                case "SystemStatus":

                    SystemStatus(dataitems[n]);
                    Read.sumbyte(1);

                    break;

            }
        }
        
        // Data Item I010/000: MessageType
        private static void MessageType(string octeto)
        {
            string message = CAT10Dict.MessageType[Functions.bintonum(octeto)];
            dataload.add("MessageType", message);

        }

        // Data Item I010/010: Data Source Identifier
        private static void DataSourceIdentifier(string octeto1, string octeto2)
        {
            int SAC = Functions.bintonum(octeto1);
            int SIC = Functions.bintonum(octeto2);
            dataload.add("SAC", SAC);
            dataload.add("SIC", SIC);
        }

        // Data Item I010/020: Target Report Descriptor
        public static void TargetReportDescriptor(string[] octeto, int nextents)
        {
            string TYP = octeto[0].Substring(0,3);
            int DCR = Functions.strtoint(octeto[0][3]);
            int CHN = Functions.strtoint(octeto[0][4]);
            int GBS = Functions.strtoint(octeto[0][5]);
            int CRT = Functions.strtoint(octeto[0][6]);

            dataload.add("TYP", TYP);
            dataload.add("DCR", DCR);
            dataload.add("CHN", CHN);
            dataload.add("GBS", GBS);
            dataload.add("CRT", CRT);

            if (nextents > 1)
            {
                //Decodification of 1st extent byte
                int SIM = Functions.strtoint(octeto[1][0]);
                int TST = Functions.strtoint(octeto[1][1]);
                int RAB = Functions.strtoint(octeto[1][2]);
                string LOP = octeto[1].Substring(3, 2);
                string TOT = octeto[1].Substring(5, 2);

                dataload.add("SIM", SIM);
                dataload.add("TST", TST);
                dataload.add("RAB", RAB);
                dataload.add("LOP", LOP);
                dataload.add("TOT", TOT);

                if (nextents > 2)
                {
                    //Decodification of 2nd extent byte
                    int SPI = Functions.strtoint(octeto[2][0]);

                    dataload.add("SPI", SPI);

                }

            }

        }

        // Data Item I010/040: Measured Position in Polar Co-ordinates
        public static void MeasuredPositionPolarCoordinates(string[] octetos) //BCD
        {
            double LSBrho = 1; //meter
            double LSBtheta = (double)360/Math.Pow(2,16); //deg
            double rho = Functions.BCD(octetos[0] + octetos[1], LSBrho);
            double theta = Functions.BCD(octetos[2] + octetos[3], LSBtheta);

            dataload.add("rho", rho);
            dataload.add("theta", Math.Round(theta,3));
        }

        // Data Item I010/041: Position in WGS-84 Co-ordinates
        public static void PositionWGS84Coordinates(string[] octetos) //COMPLEMENTO A DOS
        {
            double LSB = (double)180 / Math.Pow(2, 31); //deg
            double latitude = Functions.BCD(Functions.ComplementoA2(octetos[0] + octetos[1] + octetos[2] + octetos[3]),LSB);
            double longitude = Functions.BCD(Functions.ComplementoA2(octetos[4] + octetos[5] + octetos[6] + octetos[7]),LSB);

            dataload.add("Latitude WGS84", latitude);
            dataload.add("Longitude WGS84", longitude);
        }

        // Data Item I010/042: Position in Cartesian Co-ordinates
        public static void PositionCartesianCoordinates(string[] octetos) //SI HAY MAS DE UNA COGEMOS ESTAS //BCD
        {
            double LSB = 1; //m
            double x = Functions.BCD(Functions.ComplementoA2(octetos[0] + octetos[1]),LSB);
            double y = Functions.BCD(Functions.ComplementoA2(octetos[2] + octetos[3]),LSB);

            dataload.add("X Cartesian", x);
            dataload.add("Y Cartesian", y);
        }

        // Data Item I010/060: Mode-3/A Code in Octal Representation
        public static void Mode3ACodeOctalRepresentation(string octeto1, string octeto2)
        {
            int V = Functions.strtoint(octeto1[0]);
            int G = Functions.strtoint(octeto1[1]);
            int L = Functions.strtoint(octeto1[2]);

            string A = Functions.bintonum(octeto1.Substring(4, 3)).ToString();
            string B = Functions.bintonum(octeto1[7]+octeto2.Substring(0,2)).ToString();
            string C = Functions.bintonum(octeto2.Substring(2, 3)).ToString();
            string D = Functions.bintonum(octeto2.Substring(5, 3)).ToString();

            int ABCD = Convert.ToInt32(A+B+C+D);

            dataload.add("Mode3/A V", V);
            dataload.add("Mode3/A G", G);
            dataload.add("Mode3/A L", L);
            dataload.add("Mode3/A ABCD", ABCD);
        }

        // Data Item I010/090: Flight Level in Binary Representation
        public static void FlightLevelBinaryRepresentation(string octeto1, string octeto2) 
        {
            int V = Functions.strtoint(octeto1[0]);
            int G = Functions.strtoint(octeto1[1]);

            double LSB = 0.25; //FL
            double FL = Functions.BCD(Functions.ComplementoA2(octeto1.Substring(3) + octeto2),LSB);

            dataload.add("FL V", V);
            dataload.add("FL G", G);
            dataload.add("FL", FL);
        }

        // Data Item I010/091: Measured Height
        public static void MeasuredHeight(string octeto1, string octeto2)//BCD
        {
            double LSB = 6.25; //ft
            double Height = Functions.BCD(Functions.ComplementoA2(octeto1 + octeto2), LSB);

            dataload.add("Height", Height);
        }

        // Data Item I010/131: Amplitude of Primary Plot
        public static void AmplitudePrimaryPlot(string octeto1)
        {
            int PAM = Functions.bintonum(octeto1);

            dataload.add("Amplitude", PAM);
        }

        // Data Item I010/140: Time of Day
        public static void TimeOfDay(string octeto1, string octeto2, string octeto3) //BCD
        {
            double LSB = (double)1 / 128; //s
            double TimeOfDay = Functions.BCD(octeto1 + octeto2 + octeto3, LSB);
            TimeSpan time = TimeSpan.FromSeconds(TimeOfDay);
            string str = time.ToString(@"hh\:mm\:ss");

            dataload.add("Time of Day", str);
        }

        // Data Item I010/161: Track Number
        public static void TrackNumber(string octeto1, string octeto2)
        {
            int TrackNumber = Functions.bintonum(octeto1[4].ToString() + octeto1[5].ToString() + octeto1[6].ToString() + octeto1[7].ToString() + octeto2);

            dataload.add("Track Number", TrackNumber);
        }

        // Data Item I010/170: Track Status
        public static void TrackStatus(string[] octeto, int nextents)
        {
            int CNF = Functions.strtoint(octeto[0][0]);
            int TRE = Functions.strtoint(octeto[0][1]);
            string CST = octeto[0].Substring(2,2);
            int MAH = Functions.strtoint(octeto[0][4]);
            int TCC = Functions.strtoint(octeto[0][5]);
            int STH = Functions.strtoint(octeto[0][6]);

            dataload.add("CNF", CNF);
            dataload.add("TRE", TRE);
            dataload.add("CST", CST);
            dataload.add("MAH", MAH);
            dataload.add("TCC", TCC);
            dataload.add("STH", STH);

            if (nextents > 1)
            {
                //Decodification of 1st extent byte
                string TOM = octeto[1].Substring(0,2);
                string DOU = octeto[1].Substring(2,3);
                string MRS = octeto[1].Substring(5,2);

                dataload.add("TOM", TOM);
                dataload.add("DOU", DOU);
                dataload.add("MRS", MRS);

                if (nextents > 2)
                {
                    //Decodification of 2nd extent byte
                    int GHO = Functions.strtoint(octeto[2][0]);

                    dataload.add("GHO", GHO);
                }
            }
        }

        // Data Item I010/200: Calculated Track Velocity in Polar Co-ordinates
        public static void CalculatedTrackVelocityPolarCoordinates(string[] octetos) //BCD 
        {
            double LSBgs = 0.22; //kt
            double LSBta =(double)360 / Math.Pow(2,16); //deg

            double GroundSpeed = Functions.BCD(octetos[0] + octetos[1], LSBgs);
            double TrackAngle = Functions.BCD(octetos[2] + octetos[3], LSBta);

            dataload.add("Ground Speed", Math.Round(GroundSpeed,3));
            dataload.add("Track Angle", Math.Round(TrackAngle,3));
        }

        // Data Item I010/202: Calculated Track Velocity in Cartesian Co-ordinates
        public static void CalculatedTrackVelocityCartesianCoordinates(string[] octetos)
        {
            double LSB = 0.25; //m/s
            
            double Vx = Functions.BCD(Functions.ComplementoA2(octetos[0]+ octetos[1]),LSB);
            double Vy = Functions.BCD(Functions.ComplementoA2(octetos[2]+octetos[3]),LSB);

            dataload.add("Velocity X Cart", Vx);
            dataload.add("Velocity Y Cart", Vy);
        }

        // Data Item I010/210: Calculated Acceleration
        public static void CalculatedAcceleration(string octeto1, string octeto2) 
        {
            double LSB = 0.25; //m/s^2
            
            double Ax = Functions.BCD(Functions.ComplementoA2(octeto1),LSB);
            double Ay = Functions.BCD(Functions.ComplementoA2(octeto2),LSB);

            dataload.add("Acceleration X", Ax);
            dataload.add("Acceleration Y", Ay);
        }

        // Data Item I010/220: Target Address
        public static void TargetAddress(string octeto1, string octeto2, string octeto3)
        {
            string TA = Functions.bintohex(octeto1 + octeto2 + octeto3);
            dataload.add("Target Address", TA);
        }

        // Data Item I010/245: Target Identification
        public static void TargetIdentification(string[] octetos)
        {
            string STI = octetos[0].Substring(0,2);

            string C1 = octetos[1].Substring(0,6);
            string C1message = CAT10Dict.TargetIdentification_octetos[C1];

            string C2 = octetos[1].Substring(6, 2) + octetos[2].Substring(0, 4);
            string C2message = CAT10Dict.TargetIdentification_octetos[C2];

            string C3 =octetos[2].Substring(4, 4) + octetos[3].Substring(0, 2);
            string C3message = CAT10Dict.TargetIdentification_octetos[C3];

            string C4 = octetos[3].Substring(2, 6);
            string C4message = CAT10Dict.TargetIdentification_octetos[C4];

            string C5 = octetos[4].Substring(0, 6);
            string C5message = CAT10Dict.TargetIdentification_octetos[C5];

            string C6 = octetos[4].Substring(6, 2) + octetos[5].Substring(0, 4);
            string C6message = CAT10Dict.TargetIdentification_octetos[C6];

            string C7 = octetos[5].Substring(4, 4) + octetos[6].Substring(0, 2);
            string C7message = CAT10Dict.TargetIdentification_octetos[C7];

            string C8 = octetos[6].Substring(2, 6);
            string C8message = CAT10Dict.TargetIdentification_octetos[C8];


            string C = C1message + C2message + C3message + C4message + C5message + C6message + C7message + C8message;

            dataload.add("STI", STI);
            dataload.add("Target Identification", C);
        }

        // Data Item I010/250: Mode S MB Data
        public static void ModeSMBData(string[] octetos)
        {
            float REP = Functions.bintonum(octetos[0]);
            float MB = Functions.bintonum(octetos[1] + octetos[2] + octetos[3] + octetos[4] + octetos[5] + octetos[6] + octetos[7]);
            float BDS1 = Functions.bintonum(octetos[8].Substring(0,4));
            float BDS2 = Functions.bintonum(octetos[8].Substring(4,4));

            dataload.add("REP", REP);
            dataload.add("MB", MB);
            dataload.add("BDS1", BDS1);
            dataload.add("BDS2", BDS2);
        }

        // Data Item I010/270: Target Size & Orientation
        public static void TargetSizeOrientation(string[] octeto, int nextents)
        {
            double LSBlen = 1; //m
            double Length = Functions.BCD(octeto[0].Substring(0,7),LSBlen);

            dataload.add("Target Length", Length);

            if (nextents > 1)
            {
                //Decodification of 1st extent byte //BCD
                double LSBori = (double)360 / 128; //deg
                double Orientation = Functions.BCD(octeto[1].Substring(0, 7), LSBori);

                dataload.add("Target Orientation", Math.Round(Orientation,3));

                if (nextents > 2)
                {
                    //Decodification of 2nd extent byte
                    double LSBwid = 1; //m
                    double Width = Functions.BCD(octeto[2].Substring(0, 7), LSBwid);

                    dataload.add("Target Width", Width);
                }
            }
        }

        // Data Item I010/280: Presence
        public static void Presence(string octeto1, string octeto2, string octeto3) //BCD 
        {
            int N = Functions.bintonum(octeto1);
            double LSBdrho = 1; //m
            double DRHO = Functions.BCD(octeto2,LSBdrho);
            double LSBdtheta = 0.15; //deg
            double DTHETA = Functions.BCD(octeto3,LSBdtheta);

            dataload.add("Presence N", N);
            dataload.add("Presence rho", DRHO);
            dataload.add("Presence theta", DTHETA);
        }

        // Data Item I010/300: Vehicle Fleet Identification
        public static void VehicleFleetIdentification(string octeto1)
        {
            int VFI = Functions.bintonum(octeto1);

            dataload.add("Vehicle Fleet Identification", VFI);
        }

        // Data Item I010/310: Pre-programmed Message
        public static void PreprogrammedMessage(string octeto1)
        {
            int TRB = Functions.strtoint(octeto1[0]);
            int MSG = Functions.bintonum(octeto1.Substring(1,7));

            dataload.add("TRB", TRB);
            dataload.add("MSG", MSG);
        }

        // Data Item I010/500: Standard Deviation of Position
        public static void StandardDeviationPosition(string[] octetos)
        {
            double LSB = 0.25; //m  m   m^2
            double SDx = Functions.BCD(octetos[0], LSB);
            double SDy = Functions.BCD(octetos[1], LSB);
            double Covariance = Functions.BCD(Functions.ComplementoA2(octetos[2] + octetos[3]),LSB);

            dataload.add("Standard Deviation X", SDx);
            dataload.add("Standard Deviation y", SDy);
            dataload.add("Covariance", Covariance);
        }

        // Data Item I010/550: System Status
        public static void SystemStatus(string octeto1)
        {
            string NOGO = octeto1.Substring(0, 2);
            int OVL = Functions.strtoint(octeto1[2]);
            int TSV = Functions.strtoint(octeto1[3]);
            int DIV = Functions.strtoint(octeto1[4]);
            int TTF = Functions.strtoint(octeto1[5]);

            dataload.add("NOGO", NOGO);
            dataload.add("OVL", OVL);
            dataload.add("TSV", TSV);
            dataload.add("DIV", DIV);
            dataload.add("TTF", TTF);
        }

    }

}

