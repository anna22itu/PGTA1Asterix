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
        private static void AircraftOperationalStatus(string octeto1)
        {
            int RA = octeto1[0];
            int TC = Functions.bintonum(octeto1.Substring(1, 2));
            int TS = octeto1[3];
            int ARV = octeto1[4];
            int CDTIA = octeto1[5];
            int TCAS = octeto1[6];
            int SA = octeto1[7];

            string messageRA = CAT21Dict.AircraftOperationalStatus_RA[RA];
            string messageTC = CAT21Dict.AircraftOperationalStatus_TC[TC];
            string messageTS = CAT21Dict.AircraftOperationalStatus_TS[TS];
            string messageARV = CAT21Dict.AircraftOperationalStatus_ARV[ARV];
            string messageCDTIA = CAT21Dict.AircraftOperationalStatus_CDTIA[CDTIA];
            string messageTCAS = CAT21Dict.AircraftOperationalStatus_TCAS[TCAS];
            string messageSA = CAT21Dict.AircraftOperationalStatus_SA[SA];

            CurrentDataCAT21.RA = messageRA;
            CurrentDataCAT21.TC = messageTC;
            CurrentDataCAT21.TS = messageTS;
            CurrentDataCAT21.ARV = messageARV;
            CurrentDataCAT21.CDTIA = messageCDTIA;
            CurrentDataCAT21.TCAS = messageTCAS;
            CurrentDataCAT21.SA = messageSA;

        }

        // Data Item I021/010: Data Source Identification 
        private static void DataSourceIdentification(string octeto1, string octeto2)
        {
            int SAC = Functions.bintonum(octeto1);
            int SIC = Functions.bintonum(octeto2);

            CurrentDataCAT21.SAC = SAC;  ///////////////// Tenemos SAC & SIC en ambas categoriassssss
            CurrentDataCAT21.SIC = SIC;
        }

        // Data Item I021/015: Service Identification.
        private static void PositionCartesianCoordinates(string octeto1)
        {
            int ServiceIdentification = Functions.bintonum(octeto1);

            CurrentDataCAT21.ServiceIdentification = ServiceIdentification;

        }

        // Data Item I021/016: Service Management
        private static void ServiceManagement(string octeto1)
        {
            float RP = Functions.bintonum(octeto1);

            CurrentDataCAT21.RP = RP;
          
        }

        // Data Item I021/020: Emitter Category
        private static void EmitterCategory(string octeto1)
        {
            int ECAT = Functions.bintonum(octeto1);

            string messageECAT = CAT21Dict.EmitterCategory_ECAT[ECAT];

            CurrentDataCAT21.ECAT = messageECAT;

        }

        // Data Item I021/040: Target Report Descriptor
        private static void TargetReportDescriptor(string[] octeto)
        {
            int ATP = Functions.bintonum(octeto[0].Substring(0,3));
            int ARC = Functions.bintonum(octeto[0].Substring(3, 2));
            int RC = octeto[0][5];
            int RAB21 = octeto[0][6];

            string messageATP = CAT21Dict.TargetReportDescriptor_ATP[ATP];
            string messageARC = CAT21Dict.TargetReportDescriptor_ARC[ARC];
            string messageRC = CAT21Dict.TargetReportDescriptor_RC[RC];
            string messageRAB21 = CAT21Dict.TargetReportDescriptor_RAB[RAB21];

            CurrentDataCAT21.ATP = messageATP;
            CurrentDataCAT21.ARC = messageARC;
            CurrentDataCAT21.RC = messageRC;
            CurrentDataCAT21.RAB = messageRAB21;


            int FX1 = octeto[0][7];

            if (FX1 == 1)
            {
                //Decodification of 1st extent byte
                int DCR = octeto[1][0];
                int GBS = octeto[1][1];
                int SIM = octeto[1][2];
                int TST = octeto[1][3];
                int SAA = octeto[1][4];
                int CL = Functions.bintonum(octeto[1].Substring(5, 2));

                string messageDCR = CAT21Dict.TargetReportDescriptor_DCR[DCR];
                string messageGBS = CAT21Dict.TargetReportDescriptor_GBS[GBS];
                string messageSIM = CAT21Dict.TargetReportDescriptor_SIM[SIM];
                string messageTST = CAT21Dict.TargetReportDescriptor_TST[TST];
                string messageSAA = CAT21Dict.TargetReportDescriptor_SAA[SAA];
                string messageCL = CAT21Dict.TargetReportDescriptor_CL[CL];

                CurrentDataCAT21.DCR = messageDCR;
                CurrentDataCAT21.GBS = messageGBS;
                CurrentDataCAT21.SIM = messageSIM;
                CurrentDataCAT21.TST = messageTST;
                CurrentDataCAT21.SAA = messageSAA;
                CurrentDataCAT21.CL = messageCL;

                int FX2 = octeto[1][7];

                if (FX2 == 1)
                {
                    //Decodification of 2nd extent byte
                    int LLC = octeto[2][1];
                    int IPC = octeto[2][2];
                    int NOGO = octeto[2][3];
                    int CPR = octeto[2][4];
                    int LDPJ = octeto[2][5];
                    int RCF = octeto[2][6];

                    string messageLLC = CAT21Dict.TargetReportDescriptor_LLC[LLC];
                    string messageIPC = CAT21Dict.TargetReportDescriptor_IPC[IPC];
                    string messageNOGO = CAT21Dict.TargetReportDescriptor_NOGO[NOGO];
                    string messageCPR = CAT21Dict.TargetReportDescriptor_CPR[CPR];
                    string messageLDPJ = CAT21Dict.TargetReportDescriptor_LDPJ[LDPJ];
                    string messageRCF = CAT21Dict.TargetReportDescriptor_RCF[RCF];

                    CurrentDataCAT21.LLC = messageLLC;
                    CurrentDataCAT21.IPC = messageIPC;
                    CurrentDataCAT21.NOGO = messageNOGO;
                    CurrentDataCAT21.CPR = messageCPR;
                    CurrentDataCAT21.LDPJ = messageLDPJ;
                    CurrentDataCAT21.RCF = messageRCF;

                    int FX3 = octeto[2][7];

                    if (FX3== 1)
                    {
                        //Decodification of 2nd extent byte
                        int TBC_element = octeto[3][0];
                        int TBC_value = Functions.bintonum(octeto[3].Substring(1,6));

                        string messageTBC_element = CAT21Dict.TargetReportDescriptor_TBC_element[TBC_element];

                        CurrentDataCAT21.TBC_element = messageTBC_element;
                        CurrentDataCAT21.TBC_value = TBC_value;

                        int FX4 = octeto[3][7];

                        if (FX4 == 1)
                        {
                            //Decodification of 2nd extent byte
                            int MBC_element = octeto[3][0];
                            int MBC_value = Functions.bintonum(octeto[3].Substring(1, 6));

                            string messageMBC_element = CAT21Dict.TargetReportDescriptor_MBC_element[MBC_element];

                            CurrentDataCAT21.MBC_element = messageMBC_element;
                            CurrentDataCAT21.MBC_value = MBC_value;

                        }
                    }
                }
            }
        }

        // Data Item I021/070: Mode 3/A Code in Octal Representation
        private static void Mode3ACodinOctalRepresentation(string[] octeto)
        {

        }

        // Data Item I021/070: Time of Applicability for Position
        private static void TimeofApplicabilityforPosition(string octeto1, string octeto2, string octeto3)
        {
            float TimeApplicabilityPosition = Functions.bintonum(octeto1 + octeto2 + octeto3);

            CurrentDataCAT21.TimeApplicabilityPosition = TimeApplicabilityPosition;
        }

        // Data Item I021/072: Time of Applicability for Velocity
        private static void TimeofApplicabilityforVelocity(string octeto1, string octeto2, string octeto3)
        {
            float TimeApplicabilityVelocity = Functions.bintonum(octeto1 + octeto2 + octeto3);

            CurrentDataCAT21.TimeApplicabilityVelocity = TimeApplicabilityVelocity;
        }

        // Data Item I021/073: Time of Message Reception for Position
        private static void TimeofMessageReceptionforPosition(string octeto1, string octeto2, string octeto3)
        {
            float TimeMessagePosition = Functions.bintonum(octeto1 + octeto2 + octeto3);

            CurrentDataCAT21.TimeMessagePosition = TimeMessagePosition;
        }


        // Data Item I021/074: Time of Message Reception of Position–High Precision .
        private static void TimeofMessageReceptionofPositionHighPrecision(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            string FSI_Pos = octeto1.Substring(0, 2);
            float TimeMessagePositionHP = Functions.bintonum(octeto1.Substring(2, 6) + octeto2 + octeto3 + octeto4);

            string messageFSI = CAT21Dict.TimeMessageReceptionPosition_HP_FSI[FSI_Pos];

            CurrentDataCAT21.FSI_Pos = messageFSI;
            CurrentDataCAT21.TimeMessagePosition_HP = TimeMessagePositionHP;
        }


        // Data Item I021/075: Time of Message Reception for Velocity
        private static void TimeMessageReceptionVelocity(string octeto1, string octeto2, string octeto3)
        {
            float TimeMessageVelocity = Functions.bintonum(octeto1 + octeto2 + octeto3);

            CurrentDataCAT21.TimeMessageVelocity = TimeMessageVelocity;
        }

        // Data Item I021/076: Time of Message Reception of Velocity–High Precision
        private static void TimeMessageReceptionVelocityHighPrecision(string octeto1, string octeto2, string octeto3, string octeto4)
        {

            string FSI_Vel = octeto1.Substring(0, 2);
            float TimeMessageVelocityHP = Functions.bintonum(octeto1.Substring(2, 6) + octeto2 + octeto3 + octeto4);

            string messageFSI = CAT21Dict.TimeMessageReceptionVelocity_HP_FSI[FSI_Vel];

            CurrentDataCAT21.FSI_Vel = messageFSI;
            CurrentDataCAT21.TimeMessageVelocity_HP = TimeMessageVelocityHP;
        }

        // Data Item I021/077: Time of ASTERIX Report Transmission
        private static void TimeASTERIXReportTransmission(string octeto1, string octeto2, string octeto3)
        {
            float TimeAsterixTransmission = Functions.bintonum(octeto1 + octeto2 + octeto3);

            CurrentDataCAT21.TimeAsterixTransmission = TimeAsterixTransmission;
        }

        // Data Item I021/080: Target Address
        private static void TargetAddress(string octeto1, string octeto2, string octeto3)
        {
            float TargerAddress = Functions.bintonum(octeto1 + octeto2 + octeto3);

            CurrentDataCAT21.TargerAddress = TargerAddress;  /// FALTA CAMBIAR A HEXAGESIMAL
        }

        // Data Item I021/090:Quality Indicators
        private static void QualityIndicators(string[] octeto)
        {

        }
        // Data Item I021/110: Trajectory Intent
        private static void TrajectoryIntent(string[] octeto)
        {            
            int TIS = octeto[0][0];
            int TID = octeto[0][1];

            string messageTIS = CAT21Dict.TrajectoryIntent_TIS[TIS];
            string messageARC = CAT21Dict.TrajectoryIntent_TID[TID];

            CurrentDataCAT21.TIS = messageTIS;
            CurrentDataCAT21.TID = messageARC;


            int FX1 = octeto[0][7];

            if (FX1 == 1)
            {
                //Decodification of 1st extent byte
                int NAV = octeto[1][0];
                int NVB = octeto[1][1];

                string messageNAV = CAT21Dict.TrajectoryIntent_NAV[NAV];
                string messageNVB = CAT21Dict.TrajectoryIntent_NVB[NVB];

                CurrentDataCAT21.NAV = messageNAV;
                CurrentDataCAT21.NVB = messageNVB;

                int FX2 = octeto[1][7];

                if (FX2 == 1)
                {
                    //Decodification of 2nd extent byte
                    float REP = Functions.bintonum(octeto[2]);
                    int TCA = octeto[3][0];
                    int NC = octeto[3][1];
                    float TCP = Functions.bintonum(octeto[3].Substring(2,6));
                    float Altitude = Functions.bintonum(octeto[4] + octeto[5]);
                    float Latitude = Functions.bintonum(octeto[6] + octeto[7] + octeto[8]);
                    float Longitude = Functions.bintonum(octeto[9] + octeto[10] + octeto[11]);
                    int PointType = Functions.bintonum(octeto[12].Substring(0,4));
                    string TD = octeto[12].Substring(4, 2);
                    int TRA = octeto[12][6];
                    int TOA = octeto[12][7];
                    float TOV = Functions.bintonum(octeto[13] + octeto[14] + octeto[15]);
                    float TTR = Functions.bintonum(octeto[16] + octeto[17]);

                    string messageTCA = CAT21Dict.TrajectoryIntent_TCA[TCA];
                    string messageNC = CAT21Dict.TrajectoryIntent_NC[NC];
                    string messagePointType = CAT21Dict.TrajectoryIntent_PointType[PointType];
                    string messageTD = CAT21Dict.TrajectoryIntent_TD[TD];
                    string messageTRA = CAT21Dict.TrajectoryIntent_TRA[TRA];
                    string messageTOA = CAT21Dict.TrajectoryIntent_TOA[TOA];

                    CurrentDataCAT21.REP = REP;
                    CurrentDataCAT21.TCA = messageTCA;
                    CurrentDataCAT21.NC = messageNC;
                    CurrentDataCAT21.TCP = TCP;
                    CurrentDataCAT21.Altitude = Altitude;
                    CurrentDataCAT21.Latitude = Latitude;
                    CurrentDataCAT21.Longitude = Longitude;
                    CurrentDataCAT21.PointType = messagePointType;
                    CurrentDataCAT21.TD = messageTD;
                    CurrentDataCAT21.TRA = messageTRA;
                    CurrentDataCAT21.TOA = messageTOA;
                    CurrentDataCAT21.TOV = TOV;
                    CurrentDataCAT21.TTR = TTR;
                                       
                }
            }
        }
        // Data Item I021/130: Position in WGS-84 Co-ordinates
        private static void PositionWGS84Coordinates(string octeto1, string octeto2, string octeto3, string octeto4, string octeto5, string octeto6)
        {
            float Latitude_WGS = Functions.bintonum(octeto1 + octeto2 + octeto3);   /////// FALTA COMPLEMENTO A DOSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
            float Longitude_WGS = Functions.bintonum(octeto4 + octeto5 + octeto6);   ///// TENEMOS QUE INDICAR EL ESTE Y EL OESTE

            CurrentDataCAT21.Latitude_WGS = Latitude_WGS;
            CurrentDataCAT21.Longitude_WGS = Longitude_WGS;

            if (Latitude_WGS > 0)
            {
                //NORTE
            }
            else
            {
                //SUR
            }

            if (Longitude_WGS > 0)
            {
                //ESTE
            }
            else
            { 
                //OESTE
            }
        }

        // Data Item I021/131: High-Resolution Position in WGS-84 Co-ordinates 
        private static void HighResolutionPositionWGS84Coordinates(string octeto1, string octeto2, string octeto3, string octeto4, string octeto5, string octeto6, string octeto7, string octeto8)
        {
            float Latitude_WGS_HP = Functions.bintonum(octeto1 + octeto2 + octeto3 + octeto4);   /////// FALTA COMPLEMENTO A DOSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
            float Longitude_WGS_HP = Functions.bintonum(octeto5 + octeto6 + octeto7 +  octeto8);   ///// TENEMOS QUE INDICAR EL ESTE Y EL OESTE

            CurrentDataCAT21.Latitude_WGS_HP = Latitude_WGS_HP;
            CurrentDataCAT21.Longitude_WGS_HP = Longitude_WGS_HP;

            if (Latitude_WGS_HP > 0)
            {
                //NORTE
            }
            else
            {
                //SUR
            }

            if (Longitude_WGS_HP > 0)
            {
                //ESTE
            }
            else
            {
                //OESTE
            }
        }

        // Data Item I021/132:  Message Amplitude
        private static void MessageAmplitude(string octeto1)
        {
            float MAM = Functions.bintonum(octeto1);   

            CurrentDataCAT21.MAM = MAM;
        }

        // Data Item I021/140: Geometric Height
        private static void GeometricHeight(string octeto1, string octeto2)
        {
            float GH = Functions.bintonum(octeto1 + octeto2);

            CurrentDataCAT21.GH = GH;

            if(octeto1 + octeto2 == "0111111111111111")
            {
                GH = 0;   /// TENEMOS QUE AÑADIR QUE PASA EN ESTE CASO
            }
        }

        // Data Item I021/145: Flight Level
        private static void FlightLevel(string octeto1, string octeto2)
        {
            float FL = Functions.bintonum(octeto1 + octeto2);

            CurrentDataCAT21.FL = FL;
        }

        // Data Item I021/146: Selected Altitude
        private static void SelectedAltitude(string octeto1, string octeto2)
        {
            int SAS = octeto1[0];
            string Source = octeto1.Substring(1,2);
            float SelectedAltitude = Functions.bintonum(octeto1.Substring(3, 5));   /// FALTA EL COMPLEMENTO A DOS

            string messageSAS = CAT21Dict.SelectedAltitude_SAS[SAS];
            string messageARC = CAT21Dict.SelectedAltitude_Source[Source];

            CurrentDataCAT21.SAS = messageSAS;
            CurrentDataCAT21.TID = messageARC;
            CurrentDataCAT21.SelectedAltitude = SelectedAltitude;
        }

        // Data Item I021/148:Final State Selected Altitude
        private static void FinalStateSelectedAltitude(string octeto1, string octeto2)
        {
            int MV = octeto1[0];
            int AH = octeto1[1];
            int AM = octeto1[2];
            float AltitudeFinal = Functions.bintonum(octeto1.Substring(3, 5) + octeto2);   /// FALTA EL COMPLEMENTO A DOS

            string messageMV = CAT21Dict.AltitudeFinal_MV[MV];
            string messageAH = CAT21Dict.AltitudeFinal_AH[AH];
            string messageAM = CAT21Dict.AltitudeFinal_AM[AM];

            CurrentDataCAT21.MV = messageMV;
            CurrentDataCAT21.AH = messageAH;
            CurrentDataCAT21.AM = messageAM;
            CurrentDataCAT21.AltitudeFinal = AltitudeFinal;
        }

        // Data Item I021/150: Air Speed
        private static void AirSpeed(string octeto1, string octeto2)
        {
            int IM = octeto1[0];
            float AirSpeed = Functions.bintonum(octeto1.Substring(2, 7) + octeto2);  

            string messageIM = CAT21Dict.AirSpeed_IM[IM];

            CurrentDataCAT21.IM = messageIM;
            CurrentDataCAT21.AirSpeed = AirSpeed;
        }

        // Data Item I021/151: True Airspeed 
        private static void TrueAirspeed(string octeto1, string octeto2)
        {
            int RE = octeto1[0];
            float TrueAirSpeed = Functions.bintonum(octeto1.Substring(2, 7) + octeto2);   

            string messageRE = CAT21Dict.TrueAirSpeed_RE[RE];

            CurrentDataCAT21.RE = messageRE;
            CurrentDataCAT21.TrueAirSpeed = TrueAirSpeed;
        }

        // Data Item I021/152:  Magnetic Heading
        private static void MagneticHeading(string octeto1, string octeto2)
        {
            float MagneticHeading = Functions.bintonum(octeto1 + octeto2); 
            CurrentDataCAT21.MagneticHeading = MagneticHeading;
        }

        // Data Item I021/155: Barometric Vertical Rate
        private static void BarometricVerticalRate(string octeto1, string octeto2)
        {
            int RE_VR = octeto1[0];
            float BarometricVerticalRate = Functions.bintonum(octeto1.Substring(2, 7) + octeto2);

            string messageRE_VR = CAT21Dict.BarometricVerticalRate_RE[RE_VR];

            CurrentDataCAT21.RE_VR = messageRE_VR;
            CurrentDataCAT21.BarometricVerticalRate = BarometricVerticalRate;
        }

        // Data Item I021/157: Geometric Vertical Rate
        private static void GeometricVerticalRate(string octeto1, string octeto2)
        {
            int RE_G = octeto1[0];
            float GeometricVerticalRate = Functions.bintonum(octeto1.Substring(2, 7) + octeto2);

            string messageRE_G = CAT21Dict.GeometricVerticalRate_RE[RE_G];

            CurrentDataCAT21.RE_G = messageRE_G;
            CurrentDataCAT21.GeometricVerticalRate = GeometricVerticalRate;
        }

        // Data Item I021/160: Airborne Ground Vector
        private static void AirborneGroundVector(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            int RE_A = octeto1[0];
            float GroundSpeed = Functions.bintonum(octeto1.Substring(2, 7) + octeto2);
            float TrackAngle = Functions.bintonum(octeto3 + octeto4);


            string messageRE_A = CAT21Dict.AirborneGroundVector_RE[RE_A];

            CurrentDataCAT21.RE_A = messageRE_A;
            CurrentDataCAT21.GroundSpeed = GroundSpeed;
            CurrentDataCAT21.TrackAngle = TrackAngle;
        }

        // Data Item I021/161: Track Number
        private static void TrackNumber(string octeto1, string octeto2)
        {
            int TrackNumber = Functions.bintonum(octeto1.Substring(3, 4) + octeto2);

            CurrentDataCAT21.TrackNumber = TrackNumber;
        }

        // Data Item I021/165: Track Angle Rate
        private static void TrackAngleRate(string octeto1, string octeto2)
        {
            float TrackAngleRate = Functions.bintonum(octeto1.Substring(5, 2) + octeto2);

            CurrentDataCAT21.TrackAngleRate = TrackAngleRate;
        }

        // Data Item I021/170: Target Identification
        private static void TargetIdentification(string octeto1, string octeto2, string octeto3, string octeto4, string octeto5, string octeto6)
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
