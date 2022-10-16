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
            CurrentDataCAT10.MessageType = message;
        }

        // Data Item I010/010: Data Source Identifier
        private static void DataSourceIdentifier(string octeto1, string octeto2)
        {
            int SAC = Functions.bintonum(octeto1);
            int SIC = Functions.bintonum(octeto2);
            CurrentDataCAT10.SAC = SAC;
            CurrentDataCAT10.SIC = SIC;
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

            CurrentDataCAT10.TYP = messageTYP;
            CurrentDataCAT10.DCR = messageDCR;
            CurrentDataCAT10.CHN = messageCHN;
            CurrentDataCAT10.GBS = messageGBS;
            CurrentDataCAT10.CRT = messageCRT;

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

                CurrentDataCAT10.SIM = messageSIM;
                CurrentDataCAT10.TST = messageTST;
                CurrentDataCAT10.RAB = messageRAB;
                CurrentDataCAT10.LOP = messageLOP;
                CurrentDataCAT10.TOT = messageTOT;

                if (nextents > 2)
                {
                    //Decodification of 2nd extent byte
                    int SPI = octeto[2][0];

                    string messageSPI = CAT10Dict.TargetReportDescriptor_SPI[SPI];

                    CurrentDataCAT10.SPI = messageSPI;

                }

            }

        }

        // Data Item I010/040: Measured Position in Polar Co-ordinates
        public static void MeasuredPositionPolarCoordinates(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            float rho = Functions.bintonum(octeto1 + octeto2);
            float delta = Functions.bintonum(octeto3 + octeto4);

            CurrentDataCAT10.rho = rho;
            CurrentDataCAT10.delta = delta;
        }

        // Data Item I010/041: Position in WGS-84 Co-ordinates
        public static void PositionWGS84Coordinates(string octeto1, string octeto2, string octeto3, string octeto4, string octeto5, string octeto6, string octeto7, string octeto8)
        {
            float latitude = Functions.bintonum(octeto1 + octeto2 + octeto3 + octeto4);         /////////////// FALTA AÑADIR EL COMPLEMENTO A DOS YA QUE SON LONGITUDES Y LATITUDES
            float longitude = Functions.bintonum(octeto5 + octeto5 + octeto7+ octeto8);

            CurrentDataCAT10.latitude = latitude;
            CurrentDataCAT10.longitude = longitude;
        }

        // Data Item I010/042: Position in Cartesian Co-ordinates
        public static void PositionCartesianCoordinates(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            float x = Functions.bintonum(octeto1 + octeto2);
            float y = Functions.bintonum(octeto3 + octeto4);

            CurrentDataCAT10.xpos = x;
            CurrentDataCAT10.ypos = y;  
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

            CurrentDataCAT10.ModeV = messageV;
            CurrentDataCAT10.ModeG = messageG;
            CurrentDataCAT10.ModeL = messageL;
        }

        // Data Item I010/090: Flight Level in Binary Representation
        public static void FlightLevelBinaryRepresentation(string octeto1, string octeto2)
        {
            int V = octeto1[0];
            int G = octeto1[1];
            int FL = Functions.bintonum(octeto1[3] + octeto1[4] + octeto1[5] + octeto1[6] + octeto1[7] + octeto2);


            string messageV = CAT10Dict.FligthLevel_V[V];
            string messageG = CAT10Dict.FligthLevel_G[G];

            CurrentDataCAT10.FLV = messageV;
            CurrentDataCAT10.FlG = messageG;
            CurrentDataCAT10.FL = FL;
        }

        // Data Item I010/091: Measured Height
        public static void MeasuredHeight(string octeto1, string octeto2)
        {

            int Height = Functions.bintonum(octeto1 + octeto2);

            CurrentDataCAT10.Height = Height;

        }

        // Data Item I010/131: Amplitude of Primary Plot
        public static void AmplitudePrimaryPlot(string octeto1)
        {
            int PAM = Functions.bintonum(octeto1);

            CurrentDataCAT10.PAM = PAM;
        }

        // Data Item I010/140: Time of Day
        public static void TimeOfDay(string octeto1, string octeto2, string octeto3)
        {
            int TimeOfDay = Functions.bintonum(octeto1 + octeto2 + octeto3);

            CurrentDataCAT10.TimeDay = TimeOfDay;
        }

        // Data Item I010/161: Track Number
        public static void TrackNumber(string octeto1, string octeto2)
        {
            int TrackNumber = Functions.bintonum(octeto1[4] + octeto1[5] + octeto1[6] + octeto1[7] + octeto2);

            CurrentDataCAT10.TrackNumber = TrackNumber;
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

            CurrentDataCAT10.CNF = messageCNF;
            CurrentDataCAT10.TRE = messageTRE;
            CurrentDataCAT10.CST = messageCST;
            CurrentDataCAT10.MAH = messageMAH;
            CurrentDataCAT10.TCC = messageTCC;
            CurrentDataCAT10.STH = messageSTH;


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

                CurrentDataCAT10.TOM = messageTOM;
                CurrentDataCAT10.DOU = messageDOU;
                CurrentDataCAT10.MRS = messageMRS;

                int FX2 = octeto[1][7];

                if (FX2 ==1)
                {
                    //Decodification of 2nd extent byte
                    int GHO = octeto[2][0];

                    string messageGHO = CAT10Dict.TrackStatus_GHO[GHO];

                    CurrentDataCAT10.GHO = messageGHO;

                }
            }
        }

        // Data Item I010/200: Calculated Track Velocity in Polar Co-ordinates
        public static void CalculatedTrackVelocityPolarCoordinates(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            float GroundSpeed = Functions.bintonum(octeto1 + octeto2);
            float TrackAngle = Functions.bintonum(octeto3 + octeto4);

            CurrentDataCAT10.GroundSpeed = GroundSpeed;
            CurrentDataCAT10.TrackAngle = TrackAngle;

        }

        // Data Item I010/202: Calculated Track Velocity in Cartesian Co-ordinates
        public static void CalculatedTrackVelocityCartesianCoordinates(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            float Vx = Functions.bintonum(octeto1 + octeto2);
            float Vy = Functions.bintonum(octeto3 + octeto4);

            CurrentDataCAT10.Vx = Vx;
            CurrentDataCAT10.Vy = Vy;
        }

        // Data Item I010/210: Calculated Acceleration
        public static void CalculatedAcceleration(string octeto1, string octeto2)
        {
            float Ax = Functions.bintonum(octeto1);
            float Ay = Functions.bintonum(octeto2);

            CurrentDataCAT10.Ax = Ax;
            CurrentDataCAT10.Ay = Ay;
        }

        // Data Item I010/220: Target Address
        public static void TargetAddress(string octeto1, string octeto2, string octeto3)
        {
            float TA = Functions.bintonum(octeto1 + octeto2 + octeto3);

            string TargetAddress =  ""; //// FALTA AÑADIR QUE LO PASE A HEXAGEMINAL

            CurrentDataCAT10.TargetAddress = TargetAddress;
        }

        // Data Item I010/245: Target Identification
        public static void TargetIdentification(string octeto1, string octeto2, string octeto3, string octeto4, string octeto5, string octeto6, string octeto7)
        {
            string STI = octeto1.Substring(0,2);

            string messageSTI = CAT10Dict.TargetIdentification_STI[STI];

            CurrentDataCAT10.STI = messageSTI;


        }

        // Data Item I010/250: Mode S MB Data
        public static void ModeSMBData(string octeto1, string octeto2, string octeto3, string octeto4, string octeto5, string octeto6, string octeto7, string octeto8, string octeto9)
        {
            float REP = Functions.bintonum(octeto1);
            float MB = Functions.bintonum(octeto2 + octeto3 + octeto4 + octeto5 + octeto6 + octeto7 + octeto8);
            float BDS1 = Functions.bintonum(octeto9.Substring(0,4));
            float BDS2 = Functions.bintonum(octeto9.Substring(4,4));

            CurrentDataCAT10.REP = REP;
            CurrentDataCAT10.MB = MB;
            CurrentDataCAT10.BDS1 = BDS1;
            CurrentDataCAT10.BDS2 = BDS2;

        }

        // Data Item I010/270: Target Size & Orientation
        public static void TargetSizeOrientation(string[] octeto)
        {
            int LengthLSB = Functions.bintonum(octeto[0].Substring(0,7));
            
            CurrentDataCAT10.LengthLSB = LengthLSB;

            int FX1 = octeto[0][7];

            if (FX1 == 1)
            {
                //Decodification of 1st extent byte
                float OrientationLSB = Functions.bintonum(octeto[1].Substring(0, 7));

                CurrentDataCAT10.OrientationLSB = OrientationLSB;

                int FX2 = octeto[1][7];

                if (FX2 == 1)
                {
                    //Decodification of 2nd extent byte
                    int WidthLSB = Functions.bintonum(octeto[2].Substring(0, 7));

                    CurrentDataCAT10.WidthLSB = WidthLSB;

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

            CurrentDataCAT10.VFI = messageVFI;
        }

        // Data Item I010/310: Pre-programmed Message
        public static void PreprogrammedMessage(string octeto1)
        {
            int TRB = octeto1[0];
            int MSG = Functions.bintonum(octeto1.Substring(1,8));

            string messageTRB = CAT10Dict.PreprogrammedMessage_TRB[TRB];
            string messageMSG = CAT10Dict.PreprogrammedMessage_MSG[MSG];

            CurrentDataCAT10.TRB = messageTRB;
            CurrentDataCAT10.MSG = messageMSG;

        }

        // Data Item I010/500: Standard Deviation of Position
        public static void StandardDeviationPosition(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            float SDx = Functions.bintonum(octeto1);
            float SDy = Functions.bintonum(octeto2);
            float Covariance = Functions.bintonum(octeto3 + octeto4);   /// FALTA EL COMPLEMENTO A DOSSSSS

            CurrentDataCAT10.SDx = SDx;
            CurrentDataCAT10.SDy = SDy;
            CurrentDataCAT10.Covariance = Covariance;

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

            CurrentDataCAT10.NOGO = messageNOGO;
            CurrentDataCAT10.OVL = messageOVL;
            CurrentDataCAT10.TSV = messageTSV;
            CurrentDataCAT10.DIV = messageDIV;
            CurrentDataCAT10.TTF = messageTTF;
        }

    }

}

