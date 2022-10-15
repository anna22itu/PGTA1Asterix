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

                    int nextents = 1;
                    if (dataitems[n][7] == 1)
                    {
                        nextents++;
                        if(dataitems[n+1][7] == 1)
                        {
                            nextents++;//Cal preguntar si podem tenir més de 3 bit es a dir 2 extents
                        }
                    }
                    TargetReportDescriptor(Functions.subarray(dataitems, n, nextents),nextents);
                    Read.sumbyte(nextents);

                    break;

                case "MeasuredPositionPolarCoordinates":

                    break;

                case "PositionWGS84Coordinates":

                    break;

                case "PositionCartesianCoordinates":

                    break;

                case "Mode3ACodeOctalRepresentation":

                    break;

                case "FlightLevelBinaryRepresentation":

                    break;

                case "MeasuredHeight":

                    break;

                case "AmplitudePrimaryPlot":

                    break;

                case "TimeOfDay":

                    break;

                case "TrackNumber":

                    break;

                case "TrackStatus":

                    break;

                case "CalculatedTrackVelocityPolarCoordinates":

                    break;

                case "CalculatedTrackVelocityCartesianCoordinates":

                    break;

                case "CalculatedAcceleration":

                    break;

                case "TargetAddress":

                    break;

                case "TargetIdentification":

                    break;

                case "ModeSMBData":

                    break;

                case "TargetSizeOrientation":

                    break;

                case "Presence":

                    break;

                case "VehicleFleetIdentification":

                    break;

                case "PreprogrammedMessage":

                    break;

                case "StandardDeviationPosition":

                    break;

                case "SystemStatus":

                    break;

            }
        }
        
        //CAL DECIDIR SI DEIXEM CADA DATA ITEM EN UN METOD INTERN I EL CRIDEM PASSANTLI EL QUE TOCA DES DEL SWITCH O POSEM TOT EL CODI DINS EL SWITCH (OPTO PER OPCIO 1, SERA MES ORDENAT)

        // Data Item I010/000: MessageType
        private static void MessageType(string octeto)
        {
            string message = CAT10Dict.MessageType[Functions.bintonum(octeto)];
            CurrentData.MessageType = message;
        }

        // Data Item I010/010: Data Source Identifier
        private static void DataSourceIdentifier(string octeto1, string octeto2)
        {
            int SAC = Functions.bintonum(octeto1);
            int SIC = Functions.bintonum(octeto2);
            CurrentData.SAC = SAC;
            CurrentData.SIC = SIC;
        }

        // Data Item I010/020: Target Report Descriptor
        public static void TargetReportDescriptor(string[] octeto, int nextents)
        {
            string TYP = octeto[0].Substring(0,3);
            int DCR = octeto[0][3];
            int CHN = octeto[0][4];
            int GBS = octeto[0][5];
            int CRT = octeto[0][6];

            string messageTYP = CAT10Dict.TargetReportDescriptor_TYP[TYP];
            string messageDCR = CAT10Dict.TargetReportDescriptor_DCR[DCR];
            string messageCHN = CAT10Dict.TargetReportDescriptor_CHN[CHN];
            string messageGBS = CAT10Dict.TargetReportDescriptor_GBS[GBS];
            string messageCRT = CAT10Dict.TargetReportDescriptor_CRT[CRT];

            CurrentData.TYP = messageTYP;
            CurrentData.DCR = messageDCR;
            CurrentData.CHN = messageCHN;
            CurrentData.GBS = messageGBS;
            CurrentData.CRT = messageCRT;

            if (nextents > 1)
            {
                //Decodification of 1st extent byte
                int SIM = octeto[1][0];
                int TST = octeto[1][1];
                int RAB = octeto[1][2];
                string LOP = octeto[1].Substring(3, 2);
                string TOT = octeto[1].Substring(5, 2);

                string messageSIM = CAT10Dict.TargetReportDescriptor_SIM[SIM];
                string messageTST = CAT10Dict.TargetReportDescriptor_TST[TST];
                string messageRAB = CAT10Dict.TargetReportDescriptor_RAB[RAB];
                string messageLOP = CAT10Dict.TargetReportDescriptor_LOP[LOP];
                string messageTOT = CAT10Dict.TargetReportDescriptor_TOT[TOT];

                CurrentData.SIM = messageSIM;
                CurrentData.TST = messageTST;
                CurrentData.RAB = messageRAB;
                CurrentData.LOP = messageLOP;
                CurrentData.TOT = messageTOT;

                if (nextents > 2)
                {
                    //Decodification of 2nd extent byte
                    int SPI = octeto[2][0];

                    string messageSPI = CAT10Dict.TargetReportDescriptor_SPI[SPI];

                    CurrentData.SPI = messageSPI;

                }

            }

        }

        // Data Item I010/040: Measured Position in Polar Co-ordinates
        public static void MeasuredPositionPolarCoordinates(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            float rho = Functions.bintonum(octeto1 + octeto2);
            float delta = Functions.bintonum(octeto3 + octeto4);

            CurrentData.rho = rho;
            CurrentData.delta = delta;
        }

        // Data Item I010/041: Position in WGS-84 Co-ordinates
        public static void PositionWGS84Coordinates(string octeto1, string octeto2, string octeto3, string octeto4, string octeto5, string octeto6, string octeto7, string octeto8)
        {
            float latitude = Functions.bintonum(octeto1 + octeto2 + octeto3 + octeto4);         /////////////// FALTA AÑADIR EL COMPLEMENTO A DOS YA QUE SON LONGITUDES Y LATITUDES
            float longitude = Functions.bintonum(octeto5 + octeto5 + octeto7+ octeto8);

            CurrentData.latitude = latitude;
            CurrentData.longitude = longitude;
        }

        // Data Item I010/042: Position in Cartesian Co-ordinates
        public static void PositionCartesianCoordinates(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            float x = Functions.bintonum(octeto1 + octeto2);
            float y = Functions.bintonum(octeto3 + octeto4);

            CurrentData.xpos = x;
            CurrentData.ypos = y;  
        }

        // Data Item I010/060: Mode-3/A Code in Octal Representation
        public static void Mode3ACodeOctalRepresentation(string octeto1, string octeto2)
        {
            int V = octeto1[0];
            int G = octeto1[1];
            int L = octeto1[2];

            string messageV = CAT10Dict.Mode3ACodeOctalRepresentation_V[V];
            string messageG = CAT10Dict.Mode3ACodeOctalRepresentation_G[G];
            string messageL = CAT10Dict.Mode3ACodeOctalRepresentation_L[L];

            CurrentData.ModeV = messageV;
            CurrentData.ModeG = messageG;
            CurrentData.ModeL = messageL;
        }

        // Data Item I010/090: Flight Level in Binary Representation
        public static void FlightLevelBinaryRepresentation(string octeto1, string octeto2)
        {
            int V = octeto1[0];
            int G = octeto1[1];
            int FL = Functions.bintonum(octeto1[3] + octeto1[4] + octeto1[5] + octeto1[6] + octeto1[7] + octeto2);


            string messageV = CAT10Dict.FligthLevel_V[V];
            string messageG = CAT10Dict.FligthLevel_G[G];

            CurrentData.FLV = messageV;
            CurrentData.FlG = messageG;
            CurrentData.FL = FL;
        }

        // Data Item I010/091: Measured Height
        public static void MeasuredHeight(string octeto1, string octeto2)
        {

            int Height = Functions.bintonum(octeto1 + octeto2);

            CurrentData.Height = Height;

        }

        // Data Item I010/131: Amplitude of Primary Plot
        public static void AmplitudePrimaryPlot(string octeto1)
        {
            int PAM = Functions.bintonum(octeto1);

            CurrentData.PAM = PAM;
        }

        // Data Item I010/140: Time of Day
        public static void TimeOfDay(string octeto1, string octeto2, string octeto3)
        {
            int TimeOfDay = Functions.bintonum(octeto1 + octeto2 + octeto3);

            CurrentData.TimeDay = TimeOfDay;
        }

        // Data Item I010/161: Track Number
        public static void TrackNumber(string octeto1, string octeto2)
        {
            int TrackNumber = Functions.bintonum(octeto1[4] + octeto1[5] + octeto1[6] + octeto1[7] + octeto2);

            CurrentData.TrackNumber = TrackNumber;
        }

        // Data Item I010/170: Track Status
        public static void TrackStatus(string[] octeto)
        {
            int CNF = octeto[0][0];
            int TRE = octeto[0][1];
            string CST = octeto[0].Substring(2,2);
            int MAH = octeto[0][4];
            int TCC = octeto[0][5];
            int STH = octeto[0][6];

            string messageCNF = CAT10Dict.TrackStatus_CNF[CNF];
            string messageTRE = CAT10Dict.TrackStatus_TRE[TRE];
            string messageCST = CAT10Dict.TrackStatus_CST[CST];
            string messageMAH = CAT10Dict.TrackStatus_MAH[MAH];
            string messageTCC = CAT10Dict.TrackStatus_TCC[TCC];
            string messageSTH = CAT10Dict.TrackStatus_STH[STH];

            CurrentData.CNF = messageCNF;
            CurrentData.TRE = messageTRE;
            CurrentData.CST = messageCST;
            CurrentData.MAH = messageMAH;
            CurrentData.TCC = messageTCC;
            CurrentData.STH = messageSTH;


            int FX1 = octeto[0][7];

            if (FX1 == 1)
            {
                //Decodification of 1st extent byte
                string TOM = octeto[1].Substring(0,2);
                string DOU = octeto[1].Substring(2,3);
                string MRS = octeto[1].Substring(5,2);

                string messageTOM = CAT10Dict.TrackStatus_TOM[TOM];
                string messageDOU = CAT10Dict.TrackStatus_DOU[DOU];
                string messageMRS = CAT10Dict.TrackStatus_MRS[MRS];

                CurrentData.TOM = messageTOM;
                CurrentData.DOU = messageDOU;
                CurrentData.MRS = messageMRS;

                int FX2 = octeto[1][7];

                if (FX2 ==1)
                {
                    //Decodification of 2nd extent byte
                    int GHO = octeto[2][0];

                    string messageGHO = CAT10Dict.TrackStatus_GHO[GHO];

                    CurrentData.GHO = messageGHO;

                }
            }
        }

        // Data Item I010/200: Calculated Track Velocity in Polar Co-ordinates
        public static void CalculatedTrackVelocityPolarCoordinates(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            float GroundSpeed = Functions.bintonum(octeto1 + octeto2);
            float TrackAngle = Functions.bintonum(octeto3 + octeto4);

            CurrentData.GroundSpeed = GroundSpeed;
            CurrentData.TrackAngle = TrackAngle;

        }

        // Data Item I010/202: Calculated Track Velocity in Cartesian Co-ordinates
        public static void CalculatedTrackVelocityCartesianCoordinates(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            float Vx = Functions.bintonum(octeto1 + octeto2);
            float Vy = Functions.bintonum(octeto3 + octeto4);

            CurrentData.Vx = Vx;
            CurrentData.Vy = Vy;
        }

        // Data Item I010/210: Calculated Acceleration
        public static void CalculatedAcceleration(string octeto1, string octeto2)
        {
            float Ax = Functions.bintonum(octeto1);
            float Ay = Functions.bintonum(octeto2);

            CurrentData.Ax = Ax;
            CurrentData.Ay = Ay;
        }

        // Data Item I010/220: Target Address
        public static void TargetAddress(string octeto1, string octeto2, string octeto3)
        {
            float TA = Functions.bintonum(octeto1 + octeto2 + octeto3);

            string TargetAddress =  BitConverter; //// FALTA AÑADIR QUE LO PASE A HEXAGEMINAL

            CurrentData.TargetAddress = TargetAddress;
        }

        // Data Item I010/245: Target Identification
        public static void TargetIdentification(string octeto1, string octeto2, string octeto3, string octeto4, string octeto5, string octeto6, string octeto7)
        {
            string STI = octeto1.Substring(0,2);

            string messageSTI = CAT10Dict.TargetIdentification_STI[STI];

            CurrentData.STI = messageSTI;


        }

        // Data Item I010/250: Mode S MB Data
        public static void ModeSMBData(string octeto1, string octeto2, string octeto3, string octeto4, string octeto5, string octeto6, string octeto7, string octeto8, string octeto9)
        {
            float REP = Functions.bintonum(octeto1);
            float MB = Functions.bintonum(octeto2 + octeto3 + octeto4 + octeto5 + octeto6 + octeto7 + octeto8);
            float BDS1 = Functions.bintonum(octeto9.Substring(0,4));
            float BDS2 = Functions.bintonum(octeto9.Substring(4,4));

            CurrentData.REP = REP;
            CurrentData.MB = MB;
            CurrentData.BDS1 = BDS1;
            CurrentData.BDS2 = BDS2;

        }

        // Data Item I010/270: Target Size & Orientation
        public static void TargetSizeOrientation(string[] octeto)
        {
            int LengthLSB = Functions.bintonum(octeto[0].Substring(0,7));
            
            CurrentData.LengthLSB = LengthLSB;

            int FX1 = octeto[0][7];

            if (FX1 == 1)
            {
                //Decodification of 1st extent byte
                float OrientationLSB = Functions.bintonum(octeto[1].Substring(0, 7));

                CurrentData.OrientationLSB = OrientationLSB;

                int FX2 = octeto[1][7];

                if (FX2 == 1)
                {
                    //Decodification of 2nd extent byte
                    int WidthLSB = Functions.bintonum(octeto[2].Substring(0, 7));

                    CurrentData.WidthLSB = WidthLSB;

                }
            }
        }

        // Data Item I010/280: Presence
        public static void Presence(string[] octeto)
        {

        }

        // Data Item I010/300: Vehicle Fleet Identification
        public static void VehicleFleetIdentification(string octeto1)
        {
            int VFI = Functions.bintonum(octeto1);

            string messageVFI = CAT10Dict.VehicleFleetIdentification_VFI[VFI];

            CurrentData.VFI = messageVFI;
        }

        // Data Item I010/310: Pre-programmed Message
        public static void PreprogrammedMessage(string octeto1)
        {
            int TRB = octeto1[0];
            int MSG = Functions.bintonum(octeto1.Substring(1,8));

            string messageTRB = CAT10Dict.PreprogrammedMessage_TRB[TRB];
            string messageMSG = CAT10Dict.PreprogrammedMessage_MSG[MSG];

            CurrentData.TRB = messageTRB;
            CurrentData.MSG = messageMSG;

        }

        // Data Item I010/500: Standard Deviation of Position
        public static void StandardDeviationPosition(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            float SDx = Functions.bintonum(octeto1);
            float SDy = Functions.bintonum(octeto2);
            float Covariance = Functions.bintonum(octeto3 + octeto4);   /// FALTA EL COMPLEMENTO A DOSSSSS

            CurrentData.SDx = SDx;
            CurrentData.SDy = SDy;
            CurrentData.Covariance = Covariance;

        }

        // Data Item I010/550: System Status
        public static void SystemStatus(string octeto1)
        {
            string NOGO = octeto1.Substring(0, 2);
            int OVL = octeto1[2];
            int TSV = octeto1[3];
            int DIV = octeto1[4];
            int TTF = octeto1[5];


            string messageNOGO = CAT10Dict.SystemStatus_NOGO[NOGO];
            string messageOVL = CAT10Dict.SystemStatus_OVL[OVL];
            string messageTSV = CAT10Dict.SystemStatus_TSV[TSV];
            string messageDIV = CAT10Dict.SystemStatus_DIV[DIV];
            string messageTTF = CAT10Dict.SystemStatus_TTF[TTF];

            CurrentData.NOGO = messageNOGO;
            CurrentData.OVL = messageOVL;
            CurrentData.TSV = messageTSV;
            CurrentData.DIV = messageDIV;
            CurrentData.TTF = messageTTF;
        }

    }

}

