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

            CurrentData.RA = messageRA;
            CurrentData.TC = messageTC;
            CurrentData.TS = messageTS;
            CurrentData.ARV = messageARV;
            CurrentData.CDTIA = messageCDTIA;
            CurrentData.TCAS = messageTCAS;
            CurrentData.SA = messageSA;

        }

        // Data Item I021/010: Data Source Identification 
        private static void DataSourceIdentification(string octeto1, string octeto2)
        {
            int SAC = Functions.bintonum(octeto1);
            int SIC = Functions.bintonum(octeto2);

            CurrentData.SAC = SAC;
            CurrentData.SIC = SIC;
        }

        // Data Item I021/015: Service Identification.
        private static void ServiceIdentification(string octeto1)
        {
            int ServiceIdentification = Functions.bintonum(octeto1);

            CurrentData.ServiceIdentification = ServiceIdentification;

        }

        // Data Item I021/016: Service Management
        private static void ServiceManagement(string octeto1) //BCD
        {
            float RP = Functions.bintonum(octeto1);

            CurrentData.RP = RP;
          
        }

        // Data Item I021/020: Emitter Category
        private static void EmitterCategory(string octeto1)
        {
            int ECAT = Functions.bintonum(octeto1);

            string messageECAT = CAT21Dict.EmitterCategory_ECAT[ECAT];

            CurrentData.ECAT = messageECAT;

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

            CurrentData.ATP = messageATP;
            CurrentData.ARC = messageARC;
            CurrentData.RC = messageRC;
            CurrentData.RAB_21 = messageRAB21;


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

                CurrentData.DCR_21 = messageDCR;
                CurrentData.GBS_21 = messageGBS;
                CurrentData.SIM_21 = messageSIM;
                CurrentData.TST_21 = messageTST;
                CurrentData.SAA = messageSAA;
                CurrentData.CL = messageCL;
                
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

                    CurrentData.LLC = messageLLC;
                    CurrentData.IPC = messageIPC;
                    CurrentData.NOGO_21 = messageNOGO;
                    CurrentData.CPR = messageCPR;
                    CurrentData.LDPJ = messageLDPJ;
                    CurrentData.RCF = messageRCF;

                    int FX3 = octeto[2][7];

                    if (FX3== 1)
                    {
                        //Decodification of 2nd extent byte
                        int TBC_element = octeto[3][0];
                        int TBC_value = Functions.bintonum(octeto[3].Substring(1,6));

                        string messageTBC_element = CAT21Dict.TargetReportDescriptor_TBC_element[TBC_element];

                        CurrentData.TBC_element = messageTBC_element;
                        CurrentData.TBC_value = TBC_value;

                        int FX4 = octeto[3][7];

                        if (FX4 == 1)
                        {
                            //Decodification of 2nd extent byte
                            int MBC_element = octeto[3][0];
                            int MBC_value = Functions.bintonum(octeto[3].Substring(1, 6));

                            string messageMBC_element = CAT21Dict.TargetReportDescriptor_MBC_element[MBC_element];

                            CurrentData.MBC_element = messageMBC_element;
                            CurrentData.MBC_value = MBC_value;

                        }
                    }
                }
            }
        }

        // Data Item I021/070: Mode 3/A Code in Octal Representation
        private static void Mode3ACodinOctalRepresentation(string octeto1, string octeto2)
        {

            string A = Functions.bintonum(octeto1.Substring(4, 3)).ToString();
            string B = Functions.bintonum(octeto1[7] + octeto2.Substring(0, 2)).ToString();
            string C = Functions.bintonum(octeto2.Substring(2, 3)).ToString();
            string D = Functions.bintonum(octeto2.Substring(5, 3)).ToString();

            int ABCD = Convert.ToInt32(A + B + C + D);

            CurrentData.ABCD = ABCD;
        }

        // Data Item I021/070: Time of Applicability for Position
        private static void TimeofApplicabilityforPosition(string octeto1, string octeto2, string octeto3) //BCD
        {
            float TimeApplicabilityPosition = Functions.bintonum(octeto1 + octeto2 + octeto3);

            CurrentData.TimeApplicabilityPosition = TimeApplicabilityPosition;
        }

        // Data Item I021/072: Time of Applicability for Velocity
        private static void TimeofApplicabilityforVelocity(string octeto1, string octeto2, string octeto3) //BCD
        {
            float TimeApplicabilityVelocity = Functions.bintonum(octeto1 + octeto2 + octeto3);

            CurrentData.TimeApplicabilityVelocity = TimeApplicabilityVelocity;
        }

        // Data Item I021/073: Time of Message Reception for Position
        private static void TimeofMessageReceptionforPosition(string octeto1, string octeto2, string octeto3) //BCD
        {
            float TimeMessagePosition = Functions.bintonum(octeto1 + octeto2 + octeto3);

            CurrentData.TimeMessagePosition = TimeMessagePosition;
        }


        // Data Item I021/074: Time of Message Reception of Position–High Precision .
        private static void TimeofMessageReceptionofPositionHighPrecision(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            string FSI_Pos = octeto1.Substring(0, 2);
            float TimeMessagePositionHP = Functions.bintonum(octeto1.Substring(2, 6) + octeto2 + octeto3 + octeto4); //BCD

            string messageFSI = CAT21Dict.TimeMessageReceptionPosition_HP_FSI[FSI_Pos];

            CurrentData.FSI_Pos = messageFSI;
            CurrentData.TimeMessagePosition_HP = TimeMessagePositionHP;
        }


        // Data Item I021/075: Time of Message Reception for Velocity
        private static void TimeMessageReceptionVelocity(string octeto1, string octeto2, string octeto3) //BCD
        {
            float TimeMessageVelocity = Functions.bintonum(octeto1 + octeto2 + octeto3);

            CurrentData.TimeMessageVelocity = TimeMessageVelocity;
        }

        // Data Item I021/076: Time of Message Reception of Velocity–High Precision
        private static void TimeMessageReceptionVelocityHighPrecision(string octeto1, string octeto2, string octeto3, string octeto4)
        {

            string FSI_Vel = octeto1.Substring(0, 2);
            float TimeMessageVelocityHP = Functions.bintonum(octeto1.Substring(2, 6) + octeto2 + octeto3 + octeto4); //BCD

            string messageFSI = CAT21Dict.TimeMessageReceptionVelocity_HP_FSI[FSI_Vel];

            CurrentData.FSI_Vel = messageFSI;
            CurrentData.TimeMessageVelocity_HP = TimeMessageVelocityHP;
        }

        // Data Item I021/077: Time of ASTERIX Report Transmission
        private static void TimeASTERIXReportTransmission(string octeto1, string octeto2, string octeto3)
        {
            float TimeAsterixTransmission = Functions.bintonum(octeto1 + octeto2 + octeto3); //BCD

            CurrentData.TimeAsterixTransmission = TimeAsterixTransmission;
        }

        // Data Item I021/080: Target Address
        private static void TargetAddress(string octeto1, string octeto2, string octeto3)
        {
            int TargetAddress = Functions.bintonum(octeto1 + octeto2 + octeto3);
            string tahex="";

            CurrentData.TargetAddress = tahex;  /// FALTA CAMBIAR A HEXAGESIMAL
        }

        // Data Item I021/090:Quality Indicators
        private static void QualityIndicators(string[] octeto) //NIIDEA NI DE COMO MIRARLO
        {


        }
        // Data Item I021/110: Trajectory Intent
        private static void TrajectoryIntent(string[] octeto) //FALTA MIRAR TODOS LOS QUE SON BCD
        {            
            int TIS = octeto[0][0];
            int TID = octeto[0][1];

            string messageTIS = CAT21Dict.TrajectoryIntent_TIS[TIS];
            string messageARC = CAT21Dict.TrajectoryIntent_TID[TID];

            CurrentData.TIS = messageTIS;
            CurrentData.TID = messageARC;


            int FX1 = octeto[0][7];

            if (FX1 == 1)
            {
                //Decodification of 1st extent byte
                int NAV = octeto[1][0];
                int NVB = octeto[1][1];

                string messageNAV = CAT21Dict.TrajectoryIntent_NAV[NAV];
                string messageNVB = CAT21Dict.TrajectoryIntent_NVB[NVB];

                CurrentData.NAV = messageNAV;
                CurrentData.NVB = messageNVB;

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

                    CurrentData.REP_21 = REP;
                    CurrentData.TCA = messageTCA;
                    CurrentData.NC = messageNC;
                    CurrentData.TCP = TCP;
                    CurrentData.Altitude = Altitude;
                    CurrentData.Latitude = Latitude;
                    CurrentData.Longitude = Longitude;
                    CurrentData.PointType = messagePointType;
                    CurrentData.TD = messageTD;
                    CurrentData.TRA = messageTRA;
                    CurrentData.TOA = messageTOA;
                    CurrentData.TOV = TOV;
                    CurrentData.TTR = TTR;
                                       
                }
            }
        }
        // Data Item I021/130: Position in WGS-84 Co-ordinates
        private static void PositionWGS84Coordinates(string octeto1, string octeto2, string octeto3, string octeto4, string octeto5, string octeto6)
        {
            float Latitude_WGS = Functions.bintonum(octeto1 + octeto2 + octeto3);   /////// FALTA COMPLEMENTO A DOSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
            float Longitude_WGS = Functions.bintonum(octeto4 + octeto5 + octeto6);   ///// TENEMOS QUE INDICAR EL ESTE Y EL OESTE

            CurrentData.Latitude_WGS = Latitude_WGS;
            CurrentData.Longitude_WGS = Longitude_WGS;

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

            CurrentData.Latitude_WGS_HP = Latitude_WGS_HP;
            CurrentData.Longitude_WGS_HP = Longitude_WGS_HP;

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
            float MAM = Functions.bintonum(octeto1); //TWO COMPLEMENT BCD

            CurrentData.MAM = MAM;
        }

        // Data Item I021/140: Geometric Height
        private static void GeometricHeight(string octeto1, string octeto2)
        {
            float GH = Functions.bintonum(octeto1 + octeto2); //BCD TWO COMPLEMENT

            CurrentData.GH = GH;

            if(octeto1 + octeto2 == "0111111111111111")
            {
                GH = 0;   /// TENEMOS QUE AÑADIR QUE PASA EN ESTE CASO
            }
        }

        // Data Item I021/145: Flight Level
        private static void FlightLevel(string octeto1, string octeto2) //TWO COMPLEMENT
        {
            float FL = Functions.bintonum(octeto1 + octeto2);

            CurrentData.FL_21 = FL;
        }

        // Data Item I021/146: Selected Altitude
        private static void SelectedAltitude(string octeto1, string octeto2)
        {
            int SAS = octeto1[0];
            string Source = octeto1.Substring(1,2);
            float SelectedAltitude = Functions.bintonum(octeto1.Substring(3, 5)+octeto2);   /// FALTA EL COMPLEMENTO A DOS

            string messageSAS = CAT21Dict.SelectedAltitude_SAS[SAS];
            string messageARC = CAT21Dict.SelectedAltitude_Source[Source];

            CurrentData.SAS = messageSAS;
            CurrentData.TID = messageARC;
            CurrentData.SelectedAltitude = SelectedAltitude;
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

            CurrentData.MV = messageMV;
            CurrentData.AH = messageAH;
            CurrentData.AM = messageAM;
            CurrentData.AltitudeFinal = AltitudeFinal;
        }

        // Data Item I021/150: Air Speed
        private static void AirSpeed(string octeto1, string octeto2)
        {
            int IM = octeto1[0];
            float AirSpeed = Functions.bintonum(octeto1.Substring(2, 7) + octeto2); //BCD 

            string messageIM = CAT21Dict.AirSpeed_IM[IM];

            CurrentData.IM = messageIM;
            CurrentData.AirSpeed = AirSpeed;
        }

        // Data Item I021/151: True Airspeed 
        private static void TrueAirspeed(string octeto1, string octeto2)
        {
            int RE = octeto1[0];
            float TrueAirSpeed = Functions.bintonum(octeto1.Substring(2, 7) + octeto2);   //BCD

            string messageRE = CAT21Dict.TrueAirSpeed_RE[RE];

            CurrentData.RE = messageRE;
            CurrentData.TrueAirSpeed = TrueAirSpeed;
        }

        // Data Item I021/152:  Magnetic Heading
        private static void MagneticHeading(string octeto1, string octeto2)
        {
            float MagneticHeading = Functions.bintonum(octeto1 + octeto2); //BCD
            CurrentData.MagneticHeading = MagneticHeading;
        }

        // Data Item I021/155: Barometric Vertical Rate
        private static void BarometricVerticalRate(string octeto1, string octeto2) 
        {
            int RE_VR = octeto1[0];
            float BarometricVerticalRate = Functions.bintonum(octeto1.Substring(2, 7) + octeto2); //BCD TWO COMPLEMENT 

            string messageRE_VR = CAT21Dict.BarometricVerticalRate_RE[RE_VR];

            CurrentData.RE_VR = messageRE_VR;
            CurrentData.BarometricVerticalRate = BarometricVerticalRate;
        }

        // Data Item I021/157: Geometric Vertical Rate
        private static void GeometricVerticalRate(string octeto1, string octeto2)
        {
            int RE_G = octeto1[0];
            float GeometricVerticalRate = Functions.bintonum(octeto1.Substring(2, 7) + octeto2); //BCD TWO COMPLEMENT

            string messageRE_G = CAT21Dict.GeometricVerticalRate_RE[RE_G];

            CurrentData.RE_G = messageRE_G;
            CurrentData.GeometricVerticalRate = GeometricVerticalRate;
        }

        // Data Item I021/160: Airborne Ground Vector
        private static void AirborneGroundVector(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            int RE_A = octeto1[0];
            float GroundSpeed = Functions.bintonum(octeto1.Substring(2, 7) + octeto2); //BCD
            float TrackAngle = Functions.bintonum(octeto3 + octeto4); //BCD


            string messageRE_A = CAT21Dict.AirborneGroundVector_RE[RE_A];

            CurrentData.RE_A = messageRE_A;
            CurrentData.GroundSpeed_21 = GroundSpeed;
            CurrentData.TrackAngle_21 = TrackAngle;
        }

        // Data Item I021/161: Track Number
        private static void TrackNumber(string octeto1, string octeto2)
        {
            int TrackNumber = Functions.bintonum(octeto1.Substring(3, 4) + octeto2);

            CurrentData.TrackNumber_21 = TrackNumber;
        }

        // Data Item I021/165: Track Angle Rate
        private static void TrackAngleRate(string octeto1, string octeto2)
        {
            float TrackAngleRate = Functions.bintonum(octeto1.Substring(5, 2) + octeto2); //BCD TWO COMPLEMENT

            CurrentData.TrackAngleRate = TrackAngleRate;
        }

        // Data Item I021/170: Target Identification
        private static void TargetIdentification(string octeto1, string octeto2, string octeto3, string octeto4, string octeto5, string octeto6)
        {
            string C1 = octeto1.Substring(0, 6);
            string C2 = octeto1.Substring(6, 2) + octeto2.Substring(0, 4);
            string C3 = octeto2.Substring(4, 4) + octeto3.Substring(0, 2);
            string C4 = octeto3.Substring(2, 6);
            string C5 = octeto4.Substring(0, 6);
            string C6 = octeto4.Substring(6, 2) + octeto5.Substring(0, 4);
            string C7 = octeto5.Substring(4, 4) + octeto6.Substring(0, 2);
            string C8 = octeto6.Substring(2, 6);

            int C = Convert.ToInt32(C1 + C2 + C3 + C4 + C5 + C6 + C7 + C8);

            CurrentData.TargetIdentification = C;
        }

        // Data Item I021/200: Target Status
        private static void TargetStatus(string octeto1)
        {
            int ICF = octeto1[0];
            int LNAV = octeto1[1];
            int ME = octeto1[2];
            int PS = Functions.bintonum(octeto1.Substring(3, 3));
            int SS = Functions.bintonum(octeto1.Substring(6, 2));

            string messageICF = CAT21Dict.TargetStatus_ICF[ICF];
            string messageLNAV = CAT21Dict.TargetStatus_LNAV[LNAV];
            string messageME = CAT21Dict.TargetStatus_ME[ME];
            string messagePS = CAT21Dict.TargetStatus_PS[PS];
            string messageSS = CAT21Dict.TargetStatus_SS[SS];

            CurrentData.ICF = messageICF;
            CurrentData.LNAV = messageLNAV;
            CurrentData.ME = messageME;
            CurrentData.PS = messagePS;
            CurrentData.SS = messageSS;

        }

        // Data Item I021/210: MOPS Version
        private static void MOPSVersion(string octeto1)
        {
            int VNS = octeto1[1];
            int LTT = Functions.bintonum(octeto1.Substring(5, 3));

            string messageVNS = CAT21Dict.MOPSVersion_VNS[VNS];
            string messageLTT = CAT21Dict.MOPSVersion_LTT[LTT];

            CurrentData.VNS = messageVNS;
            CurrentData.LTT = messageLTT;

            if (LTT == 2)
            {
                int VN = Functions.bintonum(octeto1.Substring(2, 3));
                string messageVN = CAT21Dict.MOPSVersion_VN[VN];
                CurrentData.VN = messageVN;

            }
            else
            {
                CurrentData.VN = "null";
            }
        }

        // Data Item I021/220:  Met Information
        private static void MetInformation(string[] octeto)
        {
            int WS = octeto[0][0];
            int WD = octeto[0][1];
            int TMP = octeto[0][2];
            int TRB = octeto[0][3];

            string messageWS = CAT21Dict.MetInformation_WS[WS];
            string messageWD = CAT21Dict.MetInformation_WD[WD];
            string messageTMP = CAT21Dict.MetInformation_TMP[TMP];
            string messageTRB = CAT21Dict.MetInformation_TRB[TRB];

            CurrentData.ATP = messageWS;
            CurrentData.WD = messageWD;
            CurrentData.TMP = messageTMP;
            CurrentData.TRB = messageTRB;


            int FX1 = octeto[0][7];

            if (FX1 == 1)
            {
                //Decodification of 1st extent byte
                float WindSpeed = Functions.bintonum(octeto[1] + octeto[2]);          //TODOS BCD
                float WindDirection = Functions.bintonum(octeto[1] + octeto[2]);
                float Temperature = Functions.bintonum(octeto[1] + octeto[2]);
                float Turbulence = Functions.bintonum(octeto[1] + octeto[2]);

                CurrentData.WindSpeed = WindSpeed;
                CurrentData.WindDirection = WindDirection;
                CurrentData.Temperature = Temperature;
                CurrentData.Turbulence = Turbulence;
            }
        }

        // Data Item I021/230: Roll Angle
        private static void RollAngle(string octeto1, string octeto2)
        {
            float RollAngle = Functions.bintonum(octeto1 + octeto2); //TWO COMPLEMENT BCD

            CurrentData.RollAngle = RollAngle;
        }

        // Data Item I021/250: BDS Register Data
        private static void BDSRegisterData(string octeto1, string octeto2, string octeto3, string octeto4, string octeto5, string octeto6, string octeto7, string octeto8, string octeto9)
        {
            float REP_BDS = Functions.bintonum(octeto1);
            float BDSDATA = Functions.bintonum(octeto2 + octeto3 + octeto4 + octeto5 + octeto6 + octeto7 + octeto8);
            float BDS1_BDS = Functions.bintonum(octeto9.Substring(0,4));
            float BDS2_BDS = Functions.bintonum(octeto9.Substring(4,4));


            CurrentData.REP_BDS = REP_BDS;
            CurrentData.BDSDATA = BDSDATA;
            CurrentData.BDS1_BDS = BDS1_BDS;
            CurrentData.BDS2_BDS = BDS2_BDS;

        }

        // Data Item I021/260: ACAS Resolution Advisory Report
        private static void ACASResolutionAdvisoryReport(string octeto1, string octeto2, string octeto3, string octeto4, string octeto5, string octeto6, string octeto7)
        {
            float TYT = Functions.bintonum(octeto1.Substring(0,5));                             //TODO BCD
            float STYP = Functions.bintonum(octeto1.Substring(5,3));
            float ARA = Functions.bintonum(octeto2 + octeto3.Substring(0, 6));
            float RAC = Functions.bintonum(octeto3.Substring(6, 2) + octeto4.Substring(0,2));
            float RAT = octeto4[2];
            float MTE = octeto4[3];
            float TTI = Functions.bintonum(octeto4.Substring(4, 2));
            float TID_ACAS = Functions.bintonum(octeto4.Substring(6,2) + octeto5 + octeto6 + octeto7);


            CurrentData.TYT = TYT;
            CurrentData.STYP = STYP;
            CurrentData.ARA = ARA;
            CurrentData.RAC = RAC;
            CurrentData.RAT = RAT;
            CurrentData.MTE = MTE;
            CurrentData.TTI = TTI;
            CurrentData.TID_ACAS = TID_ACAS;
        }

        // Data Item I021/271:  Surface Capabilities and Characteristics
        private static void SurfaceCapabilitiesCharacteristics(string octeto1)
        {
            int POA = octeto1[2];
            int CDTI = octeto1[3];
            int B2 = octeto1[4];
            int RAS = octeto1[5];
            int IDENT = octeto1[6];


            string messagePOA = CAT21Dict.SurfaceCapabilities_POA[POA];
            string messageCDTI = CAT21Dict.SurfaceCapabilities_CDTI[CDTI];
            string messageB2 = CAT21Dict.SurfaceCapabilities_B2[B2];
            string messageRAS = CAT21Dict.SurfaceCapabilities_RAS[RAS];
            string messageIDENT = CAT21Dict.SurfaceCapabilities_IDENT[IDENT];

            CurrentData.POA = messagePOA;
            CurrentData.CDTI = messageCDTI;
            CurrentData.B2 = messageB2;
            CurrentData.RAS = messageRAS;
            CurrentData.IDENT = messageIDENT;


            int FX1 = octeto1[7];

            if (FX1 == 1)
            {
                //MIRAR LA TABLA
            }
        }

        // Data Item I021/295:  Data Ages
        private static void DataAges(string[] octeto)
        {
            int AOS = octeto[0][0];
            int TRD = octeto[0][1];
            int M3A = octeto[0][2];
            int QI = octeto[0][3];
            int TI = octeto[0][4];
            int MAM = octeto[0][5];
            int GH = octeto[0][6];

            int FL = octeto[1][0];
            int SAL = octeto[1][1];
            int FSA = octeto[1][2];
            int AS = octeto[1][3];
            int TAS = octeto[1][4];
            int MH = octeto[1][5];
            int BVR = octeto[1][6];

            int GVR = octeto[2][0];
            int GV = octeto[2][1];
            int TAR = octeto[2][2];
            int TIdentification = octeto[2][3];
            int TS = octeto[2][4];
            int MET = octeto[2][5];
            int ROA = octeto[2][6];

            int ARA = octeto[3][4];
            int SCC = octeto[3][5];


            string messageAOS = CAT21Dict.DataAges_AOS[AOS];
            string messageTRD = CAT21Dict.DataAges_TRD[TRD];
            string messageM3A = CAT21Dict.DataAges_M3A[M3A];
            string messageQI = CAT21Dict.DataAges_QI[QI];
            string messageTI = CAT21Dict.DataAges_TI[TI];
            string messageMAM = CAT21Dict.DataAges_MAM[MAM];
            string messageGH = CAT21Dict.DataAges_GH[GH];

            string messageFL = CAT21Dict.DataAges_FL[FL];
            string messageSAL = CAT21Dict.DataAges_SAL[SAL];
            string messageFSA = CAT21Dict.DataAges_FSA[FSA];
            string messageAS = CAT21Dict.DataAges_AS[AS];
            string messageTAS = CAT21Dict.DataAges_TAS[TAS];
            string messageMH = CAT21Dict.DataAges_MH[MH];
            string messageBVR = CAT21Dict.DataAges_BVR[BVR];

            string messageGVR = CAT21Dict.DataAges_GVR[GVR];
            string messageGV = CAT21Dict.DataAges_GV[GV]; 
            string messageTAR = CAT21Dict.DataAges_TAR[TAR];
            string messageTIdentification = CAT21Dict.DataAges_TIdentification[TIdentification];
            string messageTS = CAT21Dict.DataAges_TS[TS];
            string messageMET = CAT21Dict.DataAges_MET[MET];
            string messageROA = CAT21Dict.DataAges_ROA[ROA];

            string messageARA = CAT21Dict.DataAges_ARA[ARA];
            string messageSCC = CAT21Dict.DataAges_SCC[SCC];


            CurrentData.AOS = messageAOS;
            CurrentData.TRD = messageTRD;
            CurrentData.M3A = messageM3A;
            CurrentData.QI = messageQI;
            CurrentData.TI = messageTI;
            CurrentData.MessageAmplitude = messageMAM;
            CurrentData.GHeight = messageGH;

            CurrentData.FLevelAge = messageFL;
            CurrentData.SAL = messageSAL;
            CurrentData.FSA = messageFSA;
            CurrentData.AS = messageAS;
            CurrentData.TAS = messageTAS;
            CurrentData.MH = messageMH;
            CurrentData.BVR = messageBVR;

            CurrentData.GVR = messageGVR;
            CurrentData.GV = messageGV;
            CurrentData.TAR = messageTAR;
            CurrentData.TIdentification = messageTIdentification;
            CurrentData.TS = messageTS;
            CurrentData.MET = messageMET;
            CurrentData.ROA = messageROA;

            CurrentData.AResolution = messageARA;
            CurrentData.SCC = messageSCC;


            int FX1 = octeto[0][7];

            if(FX1 == 1)
            {
                float AOS_value = Functions.bintonum(octeto[4]);        //TODO BCD
                float TRD_value = Functions.bintonum(octeto[5]);
                float M3A_value = Functions.bintonum(octeto[6]);
                float QI_value = Functions.bintonum(octeto[7]);
                float TI_value = Functions.bintonum(octeto[8]);
                float MAM_value = Functions.bintonum(octeto[9]);
                float GH_value = Functions.bintonum(octeto[10]);

                CurrentData.AOS_value = AOS_value;
                CurrentData.TRD_value = TRD_value;
                CurrentData.M3A_value = M3A_value;
                CurrentData.QI_value = QI_value;
                CurrentData.TI_value = TI_value;
                CurrentData.MAM_value = MAM_value;
                CurrentData.GH_value = GH_value;
            }

            int FX2 = octeto[1][7];

            if (FX2 == 1)
            {

                float FL_value = Functions.bintonum(octeto[11]);    //TODO BCD
                float SAL_value = Functions.bintonum(octeto[12]);
                float FSA_value = Functions.bintonum(octeto[13]);
                float AS_value = Functions.bintonum(octeto[14]);
                float TAS_value = Functions.bintonum(octeto[15]);
                float MH_value = Functions.bintonum(octeto[16]);
                float BVR_value = Functions.bintonum(octeto[17]);

                CurrentData.FL_value = FL_value;
                CurrentData.SAL_value = SAL_value;
                CurrentData.FSA_value = FSA_value;
                CurrentData.AS_value = AS_value;
                CurrentData.TAS_value = TAS_value;
                CurrentData.MH_value = MH_value;
                CurrentData.BVR_value = BVR_value;
            }

            int FX3 = octeto[2][7];

            if (FX3 == 1)
            {
                float GVR_value = Functions.bintonum(octeto[18]);
                float GV_value = Functions.bintonum(octeto[19]);
                float TAR_value = Functions.bintonum(octeto[20]);
                float TIdentification_value = Functions.bintonum(octeto[21]);
                float TS_value = Functions.bintonum(octeto[22]);
                float MET_value = Functions.bintonum(octeto[23]);
                float ROA_value = Functions.bintonum(octeto[24]);

                CurrentData.GVR_value = GVR_value;
                CurrentData.GV_value = GV_value;
                CurrentData.TAR_value = TAR_value;
                CurrentData.TIdentification_value = TIdentification_value;
                CurrentData.TS_value = TS_value;
                CurrentData.MET_value = MET_value;
                CurrentData.ROA_value = ROA_value;
            }

            int FX4 = octeto[3][7];

            if (FX4 == 1)
            {
                float ARA_value = Functions.bintonum(octeto[25]);
                float SCC_value = Functions.bintonum(octeto[26]);

                CurrentData.ARA_value = ARA_value;
                CurrentData.SCC_value = SCC_value;
            }
        }

        // Data Item I021/400: Receiver ID
        private static void ReceiverID(string octeto1)
        {
            float ID = Functions.bintonum(octeto1);

            CurrentData.ID = ID;
        }
    }   
        
}
