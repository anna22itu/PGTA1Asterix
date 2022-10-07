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
        public static string[] methods = { "MessageType", "DataSourceIdentifier", "TargetReportDescriptor", "MeasuredPositionPolarCoordinates", "PositionWGS84Coordinates", "PositionCartesianCoordinates", "Mode3ACodeOctalRepresentation", "FlightLevelBinaryRepresentation", "MeasuredHeight", "AmplitudePrimaryPlot", "TimeOfDay", "TrackNumber", "TrackStatus", "CalculatedTrackVelocityPolarCoordinates", "CalculatedTrackVelocityCartesianCoordinates", "CalculatedAcceleration", "TargetAddress", "TargetIdentification", "ModeSMBData", "TargetSizeOrientation", "Presence", "VehicleFleetIdentification", "PreprogrammedMessage", "StandardDeviationPosition", "SystemStatus" }; 
        public static int Len(string octet1, string octet2) //Calcula els dos octets de la llargada de tot el data block
        {
            string length = octet1 + octet2;
            Read.sumbyte(2);
            return Functions.bintonum(length);
        }
        public static int[] Fspec(string[] bytes)
        {
            int[] fspec = new int[25];
            int fx = 1; //indica que continuem mirant fspec
            int n = 0; //studied byte
            int fxcounted = 0; //cal comptar quantes fx hem llegit pq no son bits valids de fspec (no estan relacionats amb data items)
            while (fx == 1)
            {
                for(int i = 0; i < 8; i++)
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
                        fspec[i+8*n-fxcounted] = 1;
                    }
                    else //cal mirar si pot ser q no fos un 0 tambe i que dones error
                    {
                        if(i + 8 * n <= 24)
                        {
                            fspec[i + 8 * n-fxcounted] = 0;
                        }
                        
                    }
                }
                n++;
                
            }
            Read.sumbyte(fxcounted); //this is the number of bytes read
            return fspec;
            
        }
        
        
        
        
        // Data Item I010/000: MessageType
        public static void MessageType(string[] octeto)
        {

        }

        // Data Item I010/010: Data Source Identifier
        public static void DataSourceIdentifier(string octeto1, string octeto2)
        {
            string SAC = octeto1;
            string SIC = octeto2;

        }

        // Data Item I010/020: Target Report Descriptor
        public static void TargetReportDescriptor(string[] octeto)
        {
            string messageTyp = octeto[0] + octeto[1] + octeto[2];
            string messageDcr = octeto[3];
            string messageChn = octeto[4];
            string messageGbs = octeto[5];
            string messageCrt = octeto[6];
            string messageFx = octeto[7];


            if (messageTyp == "000")
            {
                messageTyp = "SSR multilateration";
            }
            else if (messageTyp == "001")
            {
                messageTyp = "Mode S multilateration";
            }
            else if (messageTyp == "010")
            {
                messageTyp = "ADS-B";
            }
            else if (messageTyp == "011")
            {
                messageTyp = "PSR";
            }
            else if (messageTyp == "100")
            {
                messageTyp = "Magnetic Loop System";
            }
            else if (messageTyp == "101")
            {
                messageTyp = "HF multilateration";
            }
            else if (messageTyp == "110")
            {
                messageTyp = "Not defined";
            }
            else if (messageTyp == "111")
            {
                messageTyp = "Other types";
            }

            if (messageDcr == "0")
            {
                messageDcr = "No differential correction (ADS-B)";
            }
            else
            {
                messageDcr = "Differential correction(ADS - B)";
            }


            if (messageChn == "0")
            {
                messageChn = "Chain 1";
            }
            else
            {
                messageChn = "Chain 2";
            }


            if (messageGbs == "0")
            {
                messageGbs = "Transponder Ground bit not set";
            }
            else
            {
                messageGbs = "Transponder Ground bit set";
            }


            if (messageCrt == "0")
            {
                messageCrt = "No Corrupted reply in multilateration";
            }
            else
            {
                messageCrt = "Corrupted replies in multilateration";
            }


            if (messageFx == "0")
            {
                messageFx = "End of Data Item";
            }
            else
            {
                messageFx = "Extension into first extent ";
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

        }

    }
}
