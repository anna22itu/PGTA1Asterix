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


            //PODRIEM FER UN DICCIONARI AMB CADA CODI I EL SEU MISSATGE I ENS ESTALVIEM ELS 8MIL IFS
            string messageTYP = CAT10Dict.TargetReportDescriptor_TYP[TYP];
            
            CurrentData.TYP = messageTYP;
            CurrentData.DCR = DCR;
            CurrentData.CHN = CHN;
            CurrentData.GBS = GBS;
            CurrentData.CRT = CRT;

            if (nextents > 1)
            {
                //Decodification of 1st extent byte
                int SIM = octeto[1][0];
                int TST = octeto[1][1];
                int RAB = octeto[1][2];
                string LOP = octeto[1].Substring(3, 2);
                string TOT = octeto[1].Substring(5, 2);

                CurrentData.SIM = SIM;
                CurrentData.TST = TST;
                CurrentData.RAB = RAB;

                string messageLOP = CAT10Dict.TargetReportDescriptor_LOP[LOP];
                string messageTOT = CAT10Dict.TargetReportDescriptor_TOT[TOT];

                CurrentData.LOP = messageLOP;
                CurrentData.TOT = messageTOT;

                if (nextents > 2)
                {
                    //Decodification of 2nd extent byte
                    int SPI = octeto[2][0];

                    CurrentData.SPI = SPI;

                }

            }

        }

        // Data Item I010/040: Measured Position in Polar Co-ordinates
        public static void MeasuredPositionPolarCoordinates(string[] octeto)
        {

        }

        // Data Item I010/041: Position in WGS-84 Co-ordinates
        public static void PositionWGS84Coordinates(string[] octeto)
        {

        }

        // Data Item I010/042: Position in Cartesian Co-ordinates
        public static void PositionCartesianCoordinates(string[] octeto)
        {

        }

        // Data Item I010/060: Mode-3/A Code in Octal Representation
        public static void Mode3ACodeOctalRepresentation(string[] octeto)
        {

        }

        // Data Item I010/090: Flight Level in Binary Representation
        public static void FlightLevelBinaryRepresentation(string[] octeto)
        {

        }

        // Data Item I010/091: Measured Height
        public static void MeasuredHeight(string[] octeto)
        {

        }

        // Data Item I010/131: Amplitude of Primary Plot
        public static void AmplitudePrimaryPlot(string octeto)
        {
            string PAM = octeto;
        }

        // Data Item I010/140: Time of Day
        public static void TimeOfDay(string[] octeto1, string[] octeto2, string[] octeto3)
        {
            int decodeTimeDay = 0; // llamamos a una funcion que me decodifique el octeto
        }

        // Data Item I010/161: Track Number
        public static void TrackNumber(string[] octeto1, string[] octeto2)
        {

        }

        // Data Item I010/170: Track Status
        public static void TrackStatus(string[] octeto)
        {
            string messageCnf = octeto[0];
            string messageTre = octeto[1];
            string messageCst = octeto[2] + octeto[3];
            string messageMah = octeto[4];
            string messageTcc = octeto[5];
            string messageSth = octeto[6];
            string messageFx = octeto[7];


            if (messageCnf == "0")
            {
                messageCnf = "Confirmed track";
            }
            else
            {
                messageCnf = "Track in initialisation phase";
            }

            if (messageTre == "010")
            {
                messageTre = "Default";
            }
            else
            {
                messageTre = "Last report for a track";
            }

            if (messageCst == "00")
            {
                messageCst = "No extrapolation";
            }
            else if (messageCst == "01")
            {
                messageCst = "Predictable extrapolation due to sensor refresh period(see NOTE)";
            }
            else if (messageCst == "10")
            {
                messageCst = "Predictable extrapolation in masked area";
            }
            else if (messageCst == "11")
            {
                messageCst = "Extrapolation due to unpredictable absence of detection";
            }

            if (messageMah == "0")
            {
                messageMah = "Default";
            }
            else
            {
                messageMah = "Horizontal manoeuvre";
            }

            if (messageTcc == "0")
            {
                messageTcc = "Tracking performed in 'Sensor Plane'";
            }
            else
            {
                messageTcc = "Slant range correction and a suitable projection technique are used to track in a 2D";
            }

            if (messageSth == "0")
            {
                messageSth = "Measured position";
            }
            else
            {
                messageSth = "Smoothed position";
            }

            if (messageFx == "0")
            {
                messageFx = "End of Data Item";
            }
            else
            {
                messageFx = "Extension into first extent";
            }
        }

        // Data Item I010/200: Calculated Track Velocity in Polar Co-ordinates
        public static void CalculatedTrackVelocityPolarCoordinates(string[] octeto)
        {

        }

        // Data Item I010/202: Calculated Track Velocity in Cartesian Co-ordinates
        public static void CalculatedTrackVelocityCartesianCoordinates(string[] octeto)
        {

        }

        // Data Item I010/210: Calculated Acceleration
        public static void CalculatedAcceleration(string[] octeto)
        {

        }

        // Data Item I010/220: Target Address
        public static void TargetAddress(string[] octeto)
        {

        }

        // Data Item I010/245: Target Identification
        public static void TargetIdentification(string[] octeto)
        {

        }

        // Data Item I010/250: Mode S MB Data
        public static void ModeSMBData(string[] octeto)
        {

        }

        // Data Item I010/270: Target Size & Orientation
        public static void TargetSizeOrientation(string[] octeto)
        {

        }

        // Data Item I010/280: Presence
        public static void Presence(string[] octeto)
        {

        }

        // Data Item I010/300: Vehicle Fleet Identification
        public static void VehicleFleetIdentification(string[] octeto)
        {
            int decodeVFI = 0; //habra que ver pq con NULL daba error
            string messageVfi = "";

            if (decodeVFI == 0)
            {
                messageVfi = "Unknown";
            }
            else if (decodeVFI == 1)
            {
                messageVfi = "ATC equipment maintenance";
            }
            else if (decodeVFI == 2)
            {
                messageVfi = "Airport maintenance";
            }
            else if (decodeVFI == 3)
            {
                messageVfi = "Fire";
            }
            else if (decodeVFI == 4)
            {
                messageVfi = "Bird scarer";
            }
            else if (decodeVFI == 5)
            {
                messageVfi = "Snow plough";
            }

            else if (decodeVFI == 6)
            {
                messageVfi = "Runway sweeper";
            }
            else if (decodeVFI == 7)
            {
                messageVfi = "Emergency";
            }
            else if (decodeVFI == 8)
            {
                messageVfi = "Police";
            }
            else if (decodeVFI == 9)
            {
                messageVfi = "Bus";
            }
            else if (decodeVFI == 10)
            {
                messageVfi = "Tug (push/tow)";
            }

            else if (decodeVFI == 11)
            {
                messageVfi = "Grass cutter";
            }
            else if (decodeVFI == 12)
            {
                messageVfi = "Fuel";
            }
            else if (decodeVFI == 13)
            {
                messageVfi = "Baggage";
            }
            else if (decodeVFI == 14)
            {
                messageVfi = "Catering";
            }
            else if (decodeVFI == 15)
            {
                messageVfi = "Aircraft maintenance";
            }
            else if (decodeVFI == 16)
            {
                messageVfi = "Flyco(follow me)";
            }
        }

        // Data Item I010/310: Pre-programmed Message
        public static void PreprogrammedMessage(string[] octeto)
        {
            string messageTrb = octeto[0];
            String messageMsg = "";
            int decoMsg = 0;

            if (messageTrb == "0")
            {
                messageTrb = "Default";
            }
            else
            {
                messageTrb = "In Trouble";
            }


            if (decoMsg == 1)
            {
                messageMsg = "Towing aircraft";
            }
            else if (decoMsg == 2)
            {
                messageMsg = "'Follow me' operation";
            }
            else if (decoMsg == 3)
            {
                messageMsg = "Runway check";
            }
            else if (decoMsg == 4)
            {
                messageMsg = "Emergency operation (fire, medical…)";
            }
            else if (decoMsg == 5)
            {
                messageMsg = "Work in progress (maintenance, birds scarer,sweepers…)";
            }


        }

        // Data Item I010/500: Standard Deviation of Position
        public static void StandardDeviationPosition(string[] octeto1, string[] octeto2, string[] octeto3)
        {
            string[] standDeviX = octeto1;
            string[] standDeviY = octeto2;
            string[] standDeviXY = octeto3;
        }

        // Data Item I010/550: System Status
        public static void SystemStatus(string[] octeto)
        {
            string messageNogo = octeto1[0] + octeto1[1];
            string messageOvl = octeto1[2];
            string messageTsv = octeto1[3];
            string messageDiv = octeto1[4];
            string messageTtf = octeto1[5];
            string messageZero = octeto1[6];
            string messageZero0 = octeto1[7];

            if (messageNogo == "00")
            {
                messageNogo = "Operational";
            }
            else if (messageNogo == "01")
            {
                messageNogo = "Degraded";
            }
            else if (messageNogo == "10")
            {
                messageNogo = "NOGO";
            }

            if (messageOvl == "0")
            {
                messageOvl = "NO overload";
            }
            else if (messageOvl == "1")
            {
                messageOvl = "Overload";
            }

            if (messageTsv == "0")
            {
                messageTsv = "valid";
            }
            else if (messageTsv == "1")
            {
                messageTsv = "invalid";
            }

            if (messageDiv == "0")
            {
                messageDiv = "Normal Operations";
            }
            else if (messageDiv == "1")
            {
                messageDiv = "Diversity degraded";
            }

            if (messageTtf == "0")
            {
                messageTtf = "Test Target Operative";
            }
            else if (messageTtf == "1")
            {
                messageTtf = "Test Target Failure";
            }

            messageZero = "0";
            messageZero0 = "0";

        }

    }

}
}
