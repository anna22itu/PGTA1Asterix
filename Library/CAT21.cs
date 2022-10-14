using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CAT21
    {
        public static void DICalling(string Case, string[] dataitems, int n)
        {
            switch (Case)
            {
                case "AircraftOperationalStatus":

                    break;

                case "DataSourceIdentification":

                    break;

                case "ServiceIdentification":

                    break;

                case "ServiceManagement":

                    break;

                case "EmitterCategory":

                    break;

                case "TargetReportDescriptor":

                    break;

                case "Mode3/ACode":

                    break;

                case "TimeofApplicabilityforPosition":

                    break;

                case "TimeofApplicabilityforVelocity":

                    break;

                case "TimeofMessageReceptionforPosition":

                    break;

                case "TimeofMessageReceptionforPositionHighPrecision":

                    break;

                case "TimeofMessageReceptionforVelocity":

                    break;

                case "TimeofMessageReceptionforVelocityHighPrecision":

                    break;

                case "TimeofReportTransmission":

                    break;

                case "TargetAddress":

                    break;

                case "QualityIndicators":

                    break;

                case "TrajectoryIntent":

                    break;

                case "PositioninWGS84coordinates":

                    break;

                case "HighResolutionPositionWGS84Coordinates":

                    break;

                case "MessageAmplitude":

                    break;

                case "GeometricHeight":

                    break;

                case "FlightLevel":

                    break;

                case "SelectedAltitude":

                    break;

                case "FinalStateSelectedAltitude":

                    break;

                case "AirSpeed":

                    break;

                case "TrueAirSpeed":

                    break;

                case "MagneticHeading":

                    break;

                case "BarometricVerticalRate":

                    break;

                case "GeometricVerticalRate":

                    break;

                case "AirborneGroundVector":

                    break;

                case "TrackNumber":

                    break;

                case "TrackAngleRate":

                    break;

                case "TargetIdentification":

                    break;

                case "TargetStatus":

                    break;

                case "MOPSVersion":

                    break;

                case "MetInformation":

                    break;

                case "RollAngle":

                    break;

                case "ModeSMBData":

                    break;

                case "ACASResolutionAdvisoryReport":

                    break;

                case "SurfaceCapabilitiesandCharacteristics":

                    break;

                case "DataAges":

                    break;

                case "ReceiverID":

                    break;

            }
        }

        // Data Item I021/08: Aircraft Operational Status
        private static void AircraftOperationalStatus(string[] octeto)
        {
            string messageRa = octeto[0];
            string messageTc = octeto[1] + octeto[2];
            string messageTs = octeto[3];
            string messageArv = octeto[4];
            string messageCdti = octeto[5];
            string messageNotTcas = octeto[6];
            string messageSa = octeto[7];

            if (messageRa == "0")
            {
                messageRa = "TCAS II or ACAS RA not active";
            }
            else if (messageRa == "1")
            {
                messageRa = "TCAS RA active";
            }

            if (messageTc == "0")
            {
                messageTc = "no capability for Trajectory Change Reports";
            }
            else if (messageTc == "1")
            {
                messageTc = "support for TC + 0 reports only";
            }
            else if (messageTc == "2")
            {
                messageTc = "support for multiple TC reports";
            }
            else if (messageTc == "3")
            {
                messageTc = "reserved";
            }

            if (messageTs == "0")
            {
                messageTs = "no capability to support Target State Reports";
            }
            else if (messageTs == "1")
            {
                messageTs = "capable of supporting target State Reports";
            }

            if (messageArv == "0")
            {
                messageArv = "no capability to generate ARV-reports";
            }
            else if (messageArv == "1")
            {
                messageArv = "capable of generate ARV-reports";
            }

            if (messageCdti == "0")
            {
                messageCdti = "CDTI not operational";
            }
            else if (messageCdti == "1")
            {
                messageCdti = "CDTI operational";
            }

            if (messageNotTcas == "0")
            {
                messageNotTcas = "TCAS operational";
            }
            else if (messageNotTcas == "1")
            {
                messageNotTcas = "TCAS not operational";
            }

            if (messageSa == "0")
            {
                messageSa = "Antenna Diversity";
            }
            else if (messageSa == "1")
            {
                messageSa = "Single Antenna only";
            }

        }

        // Data Item I021/010: Data Source Identification 
        private static void DataSourceIdentification(string[] octeto)
        {
            string SAC = decode(octeto1);
            string SIC = decode(octeto2);

        }

        // Data Item I021/015: Service Identification.
        private static void PositionCartesianCoordinates(string[] octeto)
        {
            string ServiceIdentification = decode(octeto1);

        }

        // Data Item I021/016: Service Management
        private static void ServiceManagement(string[] octeto)
        {
            int RP = deocode(octeto1[0] + octeto1[1] + octeto1[2] + octeto1[3] + octeto1[4] + octeto1[5] + octeto1[6]);
            int LSB = Convert.ToInt32(octeto1[7]);

        }

        // Data Item I021/020: Emitter Category
        private static void EmitterCategory(string[] octeto)
        {
            int decodeECAT = decode(octeto1);
            string messageECAT = "";

            if (decodeECAT == 0)
            {
                messageECAT = "No ADS-B Emitter Category Information";
            }
            else if (decodeECAT == 1)
            {
                messageECAT = " light aircraft <= 15500 lbs";
            }
            else if (decodeECAT == 2)
            {
                messageECAT = "15500 lbs < small aircraft <75000 lbs";
            }
            else if (decodeECAT == 3)
            {
                messageECAT = "75000 lbs < medium a/c < 300000 lbs";
            }
            else if (decodeECAT == 4)
            {
                messageECAT = "High Vortex Large";
            }
            else if (decodeECAT == 5)
            {
                messageECAT = "300000 lbs <= heavy aircraft";
            }

            else if (decodeECAT == 6)
            {
                messageECAT = "highly manoeuvrable (5g acceleration capability) and high speed(> 400 knots cruise)";
            }
            else if (decodeECAT == 7 || decodeECAT == 8 || decodeECAT == 9)
            {
                messageECAT = "reserved";
            }

            else if (decodeECAT == 10)
            {
                messageECAT = "rotocraft";
            }

            else if (decodeECAT == 11)
            {
                messageECAT = "glider / sailplane";
            }
            else if (decodeECAT == 12)
            {
                messageECAT = "lighter-than-air";
            }
            else if (decodeECAT == 13)
            {
                messageECAT = "unmanned aerial vehicle";
            }
            else if (decodeECAT == 14)
            {
                messageECAT = "space / transatmospheric vehicle";
            }
            else if (decodeECAT == 15)
            {
                messageECAT = "ultralight / handglider / paraglider";
            }
            else if (decodeECAT == 16)
            {
                messageECAT = "parachutist / skydiver";
            }

            else if (decodeECAT == 17 || decodeECAT == 18 || decodeECAT == 19)
            {
                messageECAT = "reserved";
            }

            else if (decodeECAT == 20)
            {
                messageECAT = "surface emergency vehicle";
            }
            else if (decodeECAT == 21)
            {
                messageECAT = "surface service vehicle";
            }

            else if (decodeECAT == 22)
            {
                messageECAT = "= fixed ground or tethered obstruction";
            }
            else if (decodeECAT == 23)
            {
                messageECAT = "cluster obstacle";
            }
            else if (decodeECAT == 24)
            {
                messageECAT = "line obstacle";
            }

        }

        // Data Item I021/040: Target Report Descriptor
        private static void TargetReportDescriptor(string[] octeto)
        {
            int decodeATP = decode(octeto1[0] + octeto1[1] + octeto1[2]);
            int decodeARC = decode(octeto1[3] + octeto1[4]);
            int decodeRC = decode(octeto1[5]);
            int decodeRAB = decode(octeto1[6]);
            int decodeFX = decode(octeto1[7]);

            string messageATP = "";
            string messageARC = "";
            string messageRC = "";
            string messageRAB = "";
            string messageFX = "";

            if (decodeATP == 0)
            {
                messageATP = "24-Bit ICAO address";
            }
            else if (decodeATP == 1)
            {
                messageATP = "Duplicate address";
            }

            else if (decodeATP == 2)
            {
                messageATP = "Surface vehicle address";
            }
            else if (decodeATP == 3)
            {
                messageATP = "Anonymous address";
            }
            else if (decodeATP == 4 || decodeATP == 5 || decodeATP == 6 || decodeATP == 7)
            {
                messageATP = "Reserved for future use";
            }


            if (decodeARC == 0)
            {
                messageARC = "25 ft";
            }
            else if (decodeARC == 1)
            {
                messageARC = "100 ft";
            }
            else if (decodeARC == 2)
            {
                messageARC = "Unknown";
            }
            else if (decodeARC == 3)
            {
                messageARC = "Invalid";
            }


            if (decodeRC == 0)
            {
                messageRC = "Default";
            }
            else if (decodeRC == 1)
            {
                messageRC = "Range Check passed, CPR Validation pending";
            }


            if (decodeRAB == 0)
            {
                messageRAB = "Report from target transponder";
            }
            else if (decodeRAB == 1)
            {
                messageRAB = "Report from field monitor (fixed transponder)";
            }


            if (decodeFX == 0)
            {
                messageFX = "End of item";
            }
            else if (decodeFX == 1)
            {
                messageFX = "Extension into first extension";
            }
            
        }

        // Data Item I021/070: Mode 3/A Code in Octal Representation
        private static void Mode3ACodinOctalRepresentation(string[] octeto)
        {

        }

        // Data Item I021/070: Time of Applicability for Position
        private static void TimeofApplicabilityforPosition(string[] octeto)
        {

        }

        // Data Item I021/072: Time of Applicability for Velocity
        private static void TimeofApplicabilityforVelocity(string[] octeto)
        {

        }

        // Data Item I021/073: Time of Message Reception for Position
        private static void TimeofMessageReceptionforPosition(string[] octeto)
        {

        }



        // Data Item I021/074: Time of Message Reception of Position–High Precision .
        private static void TimeofMessageReceptionofPositionHighPrecision(string[] octeto)
        {

        }

        // Data Item I021/075: Time of Message Reception for Velocity
        private static void TimeMessageReceptionVelocity(string[] octeto)
        {

        }

        // Data Item I021/076: Time of Message Reception of Velocity–High Precision
        private static void TimeMessageReceptionVelocityHighPrecision(string[] octeto)
        {

        }

        // Data Item I021/077: Time of ASTERIX Report Transmission
        private static void TimeASTERIXReportTransmission(string[] octeto)
        {

        }

        // Data Item I021/080: Target Address
        private static void TargetAddress(string[] octeto)
        {

        }

        // Data Item I021/090:Quality Indicators
        private static void QualityIndicators(string[] octeto)
        {

        }

        // Data Item I021/110: Trajectory Intent
        private static void TrajectoryIntent(string[] octeto)
        {

        }

        // Data Item I021/130: Position in WGS-84 Co-ordinates
        private static void PositionWGS84Coordinates(string[] octeto)
        {

        }

        // Data Item I021/131: High-Resolution Position in WGS-84 Co-ordinates 
        private static void HighResolutionPositionWGS84Coordinates(string[] octeto)
        {

        }

        // Data Item I021/132:  Message Amplitude
        private static void MessageAmplitude(string[] octeto)
        {

        }

        // Data Item I021/140: Geometric Height
        private static void GeometricHeight(string[] octeto)
        {

        }

        // Data Item I021/145: Flight Level
        private static void FlightLevel(string[] octeto)
        {

        }

        // Data Item I021/146: Selected Altitude
        private static void SelectedAltitude(string[] octeto)
        {

        }

        // Data Item I021/148:Final State Selected Altitude
        private static void FinalStateSelectedAltitude(string[] octeto)
        {

        }

        // Data Item I021/150: Air Speed
        private static void AirSpeed(string[] octeto)
        {

        }

        // Data Item I021/151: True Airspeed 
        private static void TrueAirspeed(string[] octeto)
        {

        }

        // Data Item I021/152:  Magnetic Heading
        private static void MagneticHeading(string[] octeto)
        {

        }

        // Data Item I021/155: Barometric Vertical Rate
        private static void BarometricVerticalRate(string[] octeto)
        {

        }

        // Data Item I021/157: Geometric Vertical Rate
        private static void GeometricVerticalRate(string[] octeto)
        {

        }

        // Data Item I021/160: Airborne Ground Vector
        private static void AirborneGroundVector(string[] octeto)
        {

        }

        // Data Item I021/161: Track Number
        private static void TrackNumber(string[] octeto)
        {

        }

        // Data Item I021/165: Track Angle Rate
        private static void TrackAngleRate(string[] octeto)
        {

        }

        // Data Item I021/170: Target Identification
        private static void TargetIdentification(string[] octeto)
        {

        }

        // Data Item I021/200: Target Status
        private static void TargetStatus(string[] octeto)
        {

        }

        // Data Item I021/210: MOPS Version
        private static void MOPSVersion(string[] octeto)
        {

        }

        // Data Item I021/220:  Met Information
        private static void MetInformation(string[] octeto)
        {

        }

        // Data Item I021/230: Roll Angle
        private static void RollAngle(string[] octeto)
        {

        }

        // Data Item I021/250: BDS Register Data
        private static void BDSRegisterData(string[] octeto)
        {

        }

        // Data Item I021/260: ACAS Resolution Advisory Report
        private static void ACASResolutionAdvisoryReport(string[] octeto)
        {

        }

        // Data Item I021/271:  Surface Capabilities and Characteristics
        private static void SurfaceCapabilitiesCharacteristics(string[] octeto)
        {

        }

        // Data Item I021/295:  Data Ages
        private static void DataAges(string[] octeto)
        {

        }

        // Data Item I021/400: Receiver ID
        private static void ReceiverID(string[] octeto)
        {

        }

    }
}
