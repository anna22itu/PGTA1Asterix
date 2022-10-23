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

                    AircraftOperationalStatus(dataitems[n]);
                    Read.sumbyte(1);

                    break;

                case "DataSourceIdentification":

                    DataSourceIdentification(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "ServiceIdentification":

                    ServiceIdentification(dataitems[n]);
                    Read.sumbyte(1);

                    break;

                case "ServiceManagement":

                    ServiceManagement(dataitems[n]);
                    Read.sumbyte(1);

                    break;

                case "EmitterCategory":

                    EmitterCategory(dataitems[n]);
                    Read.sumbyte(1);

                    break;

                case "TargetReportDescriptor":

                    int nextentstrd = 1;
                    if (dataitems[n][7] == 1)
                    {
                        nextentstrd++;
                        if (dataitems[n + 1][7] == 1)
                        {
                            nextentstrd++;
                            if (dataitems[n + 2][7] == 1)
                            {
                                nextentstrd++;
                                if (dataitems[n + 3][7] == 1)
                                {
                                    nextentstrd++;
                                }
                            }

                        }
                    }
                    TargetReportDescriptor(Functions.subarray(dataitems, n, nextentstrd), nextentstrd);
                    Read.sumbyte(nextentstrd);

                    break;

                case "Mode3/ACode":

                    Mode3ACodinOctalRepresentation(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "TimeofApplicabilityforPosition":

                    TimeofApplicabilityforPosition(dataitems[n], dataitems[n + 1], dataitems[n + 2]);
                    Read.sumbyte(3);

                    break;

                case "TimeofApplicabilityforVelocity":

                    TimeofApplicabilityforVelocity(dataitems[n], dataitems[n + 1], dataitems[n + 2]);
                    Read.sumbyte(3);

                    break;

                case "TimeofMessageReceptionforPosition":

                    TimeofMessageReceptionforPosition(dataitems[n], dataitems[n + 1], dataitems[n + 2]);
                    Read.sumbyte(3);

                    break;

                case "TimeofMessageReceptionforPositionHighPrecision":

                    TimeofMessageReceptionofPositionHighPrecision(dataitems[n], dataitems[n + 1], dataitems[n + 2], dataitems[n+3]);
                    Read.sumbyte(4);

                    break;

                case "TimeofMessageReceptionforVelocity":

                    TimeMessageReceptionVelocity(dataitems[n], dataitems[n + 1], dataitems[n + 2]);
                    Read.sumbyte(3);

                    break;

                case "TimeofMessageReceptionforVelocityHighPrecision":

                    TimeMessageReceptionVelocityHighPrecision(dataitems[n], dataitems[n + 1], dataitems[n + 2], dataitems[n+3]);
                    Read.sumbyte(4);

                    break;

                case "TimeofReportTransmission":

                    TimeASTERIXReportTransmission(dataitems[n], dataitems[n + 1], dataitems[n + 2]);
                    Read.sumbyte(3);

                    break;

                case "TargetAddress":

                    TargetAddress(dataitems[n], dataitems[n + 1], dataitems[n + 2]);
                    Read.sumbyte(3);

                    break;

                case "QualityIndicators":



                    break;

                case "TrajectoryIntent":

                    int nextentsti = 1;
                    if (dataitems[n][7] == 1)
                    {
                        nextentsti++;
                        if (dataitems[n + 1][7] == 1)
                        {
                            nextentsti = nextentsti + 16;
                        }
                    }

                    TrajectoryIntent(Functions.subarray(dataitems, n, nextentsti), nextentsti);
                    Read.sumbyte(nextentsti);

                    break;

                case "PositioninWGS84coordinates":

                    PositionWGS84Coordinates(dataitems[n], dataitems[n + 1], dataitems[n + 2], dataitems[n + 3], dataitems[n + 4], dataitems[n + 5]);
                    Read.sumbyte(6);
                    
                    break;

                case "HighResolutionPositionWGS84Coordinates":

                    HighResolutionPositionWGS84Coordinates(dataitems[n], dataitems[n + 1], dataitems[n + 2], dataitems[n + 3], dataitems[n + 4], dataitems[n + 5], dataitems[n + 6], dataitems[n + 7]);
                    Read.sumbyte(8);

                    break;

                case "MessageAmplitude":

                    MessageAmplitude(dataitems[n]);
                    Read.sumbyte(1);

                    break;

                case "GeometricHeight":

                    GeometricHeight(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "FlightLevel":

                    FlightLevel(dataitems[n],dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "SelectedAltitude":

                    SelectedAltitude(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "FinalStateSelectedAltitude":

                    FinalStateSelectedAltitude(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "AirSpeed":

                    AirSpeed(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "TrueAirSpeed":

                    TrueAirspeed(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "MagneticHeading":

                    MagneticHeading(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "BarometricVerticalRate":

                    BarometricVerticalRate(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "GeometricVerticalRate":

                    GeometricVerticalRate(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "AirborneGroundVector":

                    AirborneGroundVector(dataitems[n], dataitems[n + 1], dataitems[n + 2], dataitems[n + 3]);
                    Read.sumbyte(4);

                    break;

                case "TrackNumber":

                    TrackNumber(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "TrackAngleRate":

                    TrackAngleRate(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "TargetIdentification":

                    TargetIdentification(dataitems[n], dataitems[n + 1], dataitems[n + 2], dataitems[n + 3], dataitems[n + 4], dataitems[n + 5]);
                    Read.sumbyte(6);

                    break;

                case "TargetStatus":

                    TargetStatus(dataitems[n]);
                    Read.sumbyte(1);

                    break;

                case "MOPSVersion":

                    MOPSVersion(dataitems[n]);
                    Read.sumbyte(1);

                    break;

                case "MetInformation":

                    MetInformation(dataitems);
                    //El sumbyte el fem des de la funció

                    break;

                case "RollAngle":

                    RollAngle(dataitems[n], dataitems[n + 1]);
                    Read.sumbyte(2);

                    break;

                case "ModeSMBData":

                    BDSRegisterData(Functions.subarray(dataitems, n, 9));
                    Read.sumbyte(9);

                    break;

                case "ACASResolutionAdvisoryReport":

                    ACASResolutionAdvisoryReport(Functions.subarray(dataitems, n, 7));
                    Read.sumbyte(7);

                    break;

                case "SurfaceCapabilitiesandCharacteristics":

                    SurfaceCapabilitiesCharacteristics(dataitems[n]);
                    Read.sumbyte(1);

                    break;

                case "DataAges":

                    DataAges(dataitems);
                    //el sumbyte el fem a la funció

                    break;

                case "ReceiverID":

                    ReceiverID(dataitems[n]);
                    Read.sumbyte(1);

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
            float RP = Functions.BCD(octeto1);

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
        private static void TargetReportDescriptor(string[] octeto, int nextents)
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


            if (nextents > 1)
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

                if (nextents > 2)
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

                    if (nextents > 3)
                    {
                        //Decodification of 3rd extent byte
                        int TBC_element = octeto[3][0];
                        int TBC_value = Functions.bintonum(octeto[3].Substring(1,6));

                        string messageTBC_element = CAT21Dict.TargetReportDescriptor_TBC_element[TBC_element];

                        CurrentData.TBC_element = messageTBC_element;
                        CurrentData.TBC_value = TBC_value;

                        if (nextents > 4)
                        {
                            //Decodification of 4th extent byte
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

        // Data Item I021/071: Time of Applicability for Position
        private static void TimeofApplicabilityforPosition(string octeto1, string octeto2, string octeto3) //BCD
        {
            float TimeApplicabilityPosition = Functions.BCD(octeto1 + octeto2 + octeto3);

            CurrentData.TimeApplicabilityPosition = TimeApplicabilityPosition;
        }

        // Data Item I021/072: Time of Applicability for Velocity
        private static void TimeofApplicabilityforVelocity(string octeto1, string octeto2, string octeto3) //BCD
        {
            float TimeApplicabilityVelocity = Functions.BCD(octeto1 + octeto2 + octeto3);

            CurrentData.TimeApplicabilityVelocity = TimeApplicabilityVelocity;
        }

        // Data Item I021/073: Time of Message Reception for Position
        private static void TimeofMessageReceptionforPosition(string octeto1, string octeto2, string octeto3) //BCD
        {
            float TimeMessagePosition = Functions.BCD(octeto1 + octeto2 + octeto3);

            CurrentData.TimeMessagePosition = TimeMessagePosition;
        }


        // Data Item I021/074: Time of Message Reception of Position–High Precision .
        private static void TimeofMessageReceptionofPositionHighPrecision(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            string FSI_Pos = octeto1.Substring(0, 2);
            float TimeMessagePositionHP = Functions.BCD(octeto1.Substring(2, 6) + octeto2 + octeto3 + octeto4); //BCD

            string messageFSI = CAT21Dict.TimeMessageReceptionPosition_HP_FSI[FSI_Pos];

            CurrentData.FSI_Pos = messageFSI;
            CurrentData.TimeMessagePosition_HP = TimeMessagePositionHP;
        }


        // Data Item I021/075: Time of Message Reception for Velocity
        private static void TimeMessageReceptionVelocity(string octeto1, string octeto2, string octeto3) //BCD
        {
            float TimeMessageVelocity = Functions.BCD(octeto1 + octeto2 + octeto3);

            CurrentData.TimeMessageVelocity = TimeMessageVelocity;
        }

        // Data Item I021/076: Time of Message Reception of Velocity–High Precision
        private static void TimeMessageReceptionVelocityHighPrecision(string octeto1, string octeto2, string octeto3, string octeto4)
        {

            string FSI_Vel = octeto1.Substring(0, 2);
            float TimeMessageVelocityHP = Functions.BCD(octeto1.Substring(2, 6) + octeto2 + octeto3 + octeto4); //BCD

            string messageFSI = CAT21Dict.TimeMessageReceptionVelocity_HP_FSI[FSI_Vel];

            CurrentData.FSI_Vel = messageFSI;
            CurrentData.TimeMessageVelocity_HP = TimeMessageVelocityHP;
        }

        // Data Item I021/077: Time of ASTERIX Report Transmission
        private static void TimeASTERIXReportTransmission(string octeto1, string octeto2, string octeto3)
        {
            float TimeAsterixTransmission = Functions.BCD(octeto1 + octeto2 + octeto3); //BCD

            CurrentData.TimeAsterixTransmission = TimeAsterixTransmission;
        }

        // Data Item I021/080: Target Address
        private static void TargetAddress(string octeto1, string octeto2, string octeto3)
        {
            int TargetAddress = Functions.bintonum(octeto1 + octeto2 + octeto3);
            string tahex="";

            CurrentData.TargetAddress = tahex;  // FALTA CAMBIAR A HEXAGESIMAL
        }

        // Data Item I021/090:Quality Indicators
        private static void QualityIndicators(string[] octeto) //NIIDEA NI DE COMO MIRARLO
        {


        }
        // Data Item I021/110: Trajectory Intent
        private static void TrajectoryIntent(string[] octeto, int nextents) //FALTA MIRAR TODOS LOS QUE SON BCD
        {            
            int TIS = octeto[0][0];
            int TID = octeto[0][1];

            string messageTIS = CAT21Dict.TrajectoryIntent_TIS[TIS];
            string messageARC = CAT21Dict.TrajectoryIntent_TID[TID];

            CurrentData.TIS = messageTIS;
            CurrentData.TID = messageARC;


            if (nextents > 1)
            {
                //Decodification of 1st extent byte
                int NAV = octeto[1][0];
                int NVB = octeto[1][1];

                string messageNAV = CAT21Dict.TrajectoryIntent_NAV[NAV];
                string messageNVB = CAT21Dict.TrajectoryIntent_NVB[NVB];

                CurrentData.NAV = messageNAV;
                CurrentData.NVB = messageNVB;

                if (nextents > 2)
                {
                    //Decodification of 2nd extent byte
                    float REP = Functions.bintonum(octeto[2]);
                    int TCA = octeto[3][0];
                    int NC = octeto[3][1];
                    float TCP = Functions.bintonum(octeto[3].Substring(2,6));
                    float Altitude = Functions.BCD(octeto[4] + octeto[5]);
                    float Latitude = Functions.BCD(octeto[6] + octeto[7] + octeto[8]);
                    float Longitude = Functions.BCD(octeto[9] + octeto[10] + octeto[11]);
                    int PointType = Functions.bintonum(octeto[12].Substring(0,4));
                    string TD = octeto[12].Substring(4, 2);
                    int TRA = octeto[12][6];
                    int TOA = octeto[12][7];
                    float TOV = Functions.BCD(octeto[13] + octeto[14] + octeto[15]);
                    float TTR = Functions.BCD(octeto[16] + octeto[17]);

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
            float Latitude_WGS = Functions.bintonum(Functions.ComplementoA2(octeto1 + octeto2 + octeto3));   /////// FALTA COMPLEMENTO A DOSSSSSSSSSSSSSSSSSSSS
            float Longitude_WGS = Functions.bintonum(Functions.ComplementoA2(octeto4 + octeto5 + octeto6));   ///// TENEMOS QUE INDICAR EL ESTE Y EL OESTE

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
            float Latitude_WGS_HP = Functions.bintonum(Functions.ComplementoA2(octeto1 + octeto2 + octeto3 + octeto4));   /////// FALTA COMPLEMENTO A DOSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
            float Longitude_WGS_HP = Functions.bintonum(Functions.ComplementoA2(octeto5 + octeto6 + octeto7 +  octeto8));   ///// TENEMOS QUE INDICAR EL ESTE Y EL OESTE

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
            float MAM = Functions.BCD(Functions.ComplementoA2(octeto1)); //TWO COMPLEMENT BCD

            CurrentData.MAM = MAM;
        }

        // Data Item I021/140: Geometric Height
        private static void GeometricHeight(string octeto1, string octeto2)
        {
            float GH = Functions.BCD(Functions.ComplementoA2(octeto1 + octeto2)); //BCD TWO COMPLEMENT

            CurrentData.GH = GH;

            if(octeto1 + octeto2 == "0111111111111111")
            {
                GH = 0;   /// TENEMOS QUE AÑADIR QUE PASA EN ESTE CASO
            }
        }

        // Data Item I021/145: Flight Level
        private static void FlightLevel(string octeto1, string octeto2) //TWO COMPLEMENT
        {
            float FL = Functions.bintonum(Functions.ComplementoA2(octeto1 + octeto2));

            CurrentData.FL_21 = FL;
        }

        // Data Item I021/146: Selected Altitude
        private static void SelectedAltitude(string octeto1, string octeto2)
        {
            int SAS = octeto1[0];
            string Source = octeto1.Substring(1,2);
            float SelectedAltitude = Functions.bintonum(Functions.ComplementoA2(octeto1.Substring(3, 5)+octeto2));   /// FALTA EL COMPLEMENTO A DOS

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
            float AltitudeFinal = Functions.bintonum(Functions.ComplementoA2(octeto1.Substring(3, 5) + octeto2));   /// FALTA EL COMPLEMENTO A DOS

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
            float AirSpeed = Functions.BCD(octeto1.Substring(2, 7) + octeto2); //BCD 

            string messageIM = CAT21Dict.AirSpeed_IM[IM];

            CurrentData.IM = messageIM;
            CurrentData.AirSpeed = AirSpeed;
        }

        // Data Item I021/151: True Airspeed 
        private static void TrueAirspeed(string octeto1, string octeto2)
        {
            int RE = octeto1[0];
            float TrueAirSpeed = Functions.BCD(octeto1.Substring(2, 7) + octeto2);   //BCD

            string messageRE = CAT21Dict.TrueAirSpeed_RE[RE];

            CurrentData.RE = messageRE;
            CurrentData.TrueAirSpeed = TrueAirSpeed;
        }

        // Data Item I021/152:  Magnetic Heading
        private static void MagneticHeading(string octeto1, string octeto2)
        {
            float MagneticHeading = Functions.BCD(octeto1 + octeto2); //BCD
            CurrentData.MagneticHeading = MagneticHeading;
        }

        // Data Item I021/155: Barometric Vertical Rate
        private static void BarometricVerticalRate(string octeto1, string octeto2) 
        {
            int RE_VR = octeto1[0];
            float BarometricVerticalRate = Functions.BCD(Functions.ComplementoA2(octeto1.Substring(2, 7) + octeto2)); //BCD TWO COMPLEMENT 

            string messageRE_VR = CAT21Dict.BarometricVerticalRate_RE[RE_VR];

            CurrentData.RE_VR = messageRE_VR;
            CurrentData.BarometricVerticalRate = BarometricVerticalRate;
        }

        // Data Item I021/157: Geometric Vertical Rate
        private static void GeometricVerticalRate(string octeto1, string octeto2)
        {
            int RE_G = octeto1[0];
            float GeometricVerticalRate = Functions.BCD(Functions.ComplementoA2(octeto1.Substring(2, 7) + octeto2)); //BCD TWO COMPLEMENT

            string messageRE_G = CAT21Dict.GeometricVerticalRate_RE[RE_G];

            CurrentData.RE_G = messageRE_G;
            CurrentData.GeometricVerticalRate = GeometricVerticalRate;
        }

        // Data Item I021/160: Airborne Ground Vector
        private static void AirborneGroundVector(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            int RE_A = octeto1[0];
            float GroundSpeed = Functions.BCD(octeto1.Substring(2, 7) + octeto2); //BCD
            float TrackAngle = Functions.BCD(octeto3 + octeto4); //BCD


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
            float TrackAngleRate = Functions.BCD(Functions.ComplementoA2(octeto1.Substring(5, 2) + octeto2)); //BCD TWO COMPLEMENT

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
            int nextents = 1;
            int WS = octeto[0][0];
            int WD = octeto[0][1];
            int TMP = octeto[0][2];
            int TRB = octeto[0][3];

            if (WS==1)
            {
                float WindSpeed = Functions.BCD(octeto[1] + octeto[2]);
                nextents = nextents + 2;

                CurrentData.WindSpeed = WindSpeed;
            }
            if (WD==1)
            {
                float WindDirection = Functions.BCD(octeto[nextents] + octeto[nextents+1]);
                nextents = nextents + 2;

                CurrentData.WindDirection = WindDirection;
            }
            if (TMP == 1)
            {
                float Temperature = Functions.BCD(octeto[nextents] + octeto[nextents + 1]);
                nextents = nextents + 2;

                CurrentData.Temperature = Temperature;
            }
            if (TRB == 1)
            {
                float Turbulence = Functions.BCD(octeto[nextents] + octeto[nextents + 1]);
                nextents = nextents + 2;

                CurrentData.Turbulence = Turbulence;
            }

            Read.sumbyte(nextents);
        }

        // Data Item I021/230: Roll Angle
        private static void RollAngle(string octeto1, string octeto2)
        {
            float RollAngle = Functions.BCD(Functions.ComplementoA2(octeto1 + octeto2)); //TWO COMPLEMENT BCD

            CurrentData.RollAngle = RollAngle;
        }

        // Data Item I021/250: BDS Register Data
        private static void BDSRegisterData(string[] octetos)
        {
            float REP_BDS = Functions.bintonum(octetos[0]);
            float BDSDATA = Functions.bintonum(octetos[1] + octetos[2] + octetos[3] + octetos[4] + octetos[5] + octetos[6] + octetos[7]);
            float BDS1_BDS = Functions.bintonum(octetos[8].Substring(0,4));
            float BDS2_BDS = Functions.bintonum(octetos[8].Substring(4,4));


            CurrentData.REP_BDS = REP_BDS;
            CurrentData.BDSDATA = BDSDATA;
            CurrentData.BDS1_BDS = BDS1_BDS;
            CurrentData.BDS2_BDS = BDS2_BDS;

        }

        // Data Item I021/260: ACAS Resolution Advisory Report
        private static void ACASResolutionAdvisoryReport(string[] octetos)
        {
            float TYT = Functions.BCD(octetos[0].Substring(0,5));                             //TODO BCD
            float STYP = Functions.BCD(octetos[0].Substring(5,3));
            float ARA = Functions.BCD(octetos[1] + octetos[2].Substring(0, 6));
            float RAC = Functions.BCD(octetos[2].Substring(6, 2) + octetos[3].Substring(0,2));
            float RAT = octetos[3][2];
            float MTE = octetos[3][3];
            float TTI = Functions.BCD(octetos[3].Substring(4, 2));
            float TID_ACAS = Functions.BCD(octetos[3].Substring(6,2) + octetos[4] + octetos[5] + octetos[6]);


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
            int nextents = 1;
            int n = 1;
            if (octeto[0][7] == 1)
            {
                nextents++;
                n++;
                if (octeto[1][7] == 1)
                {
                    nextents++;
                    n++;
                    if (octeto[2][7] == 1)
                    {
                        nextents++;
                        n++;
                    }
                }
            }

            if (octeto[0][0] == 1)
            {
                float AOS_value = Functions.BCD(octeto[n]);
                n++;

                CurrentData.AOS_value = AOS_value;
            }
            if (octeto[0][1] == 1)
            {
                float TRD_value = Functions.BCD(octeto[n]);
                n++;

                CurrentData.TRD_value = TRD_value;
            }
            if (octeto[0][2] == 1)
            {
                float M3A_value = Functions.BCD(octeto[n]);
                n++;

                CurrentData.M3A_value = M3A_value;
            }
            if (octeto[0][3] == 1)
            {
                float QI_value = Functions.BCD(octeto[n]);
                n++;

                CurrentData.QI_value = QI_value;
            }
            if (octeto[0][4] == 1)
            {
                float TI_value = Functions.BCD(octeto[n]);
                n++;

                CurrentData.TI_value = TI_value;
            }
            if (octeto[0][5] == 1)
            {
                float MAM_value = Functions.BCD(octeto[n]);
                n++;

                CurrentData.MAM_value = MAM_value;
            }
            if (octeto[0][6] == 1)
            {
                float GH_value = Functions.BCD(octeto[n]);
                n++;

                CurrentData.GH_value = GH_value;
            }

            if (nextents > 1)
            {
                if (octeto[1][0] == 1)
                {
                    float FL_value = Functions.BCD(octeto[n]);
                    n++;

                    CurrentData.FL_value = FL_value;
                }
                if (octeto[1][1] == 1)
                {
                    float SAL_value = Functions.BCD(octeto[n]);
                    n++;

                    CurrentData.SAL_value = SAL_value;
                }
                if (octeto[1][2] == 1)
                {
                    float FSA_value = Functions.BCD(octeto[n]);
                    n++;

                    CurrentData.FSA_value = FSA_value;
                }
                if (octeto[1][3] == 1)
                {
                    float AS_value = Functions.BCD(octeto[n]);
                    n++;

                    CurrentData.AS_value = AS_value;
                }
                if (octeto[1][4] == 1)
                {
                    float TAS_value = Functions.BCD(octeto[n]);
                    n++;

                    CurrentData.TAS_value = TAS_value;
                }
                if (octeto[1][5] == 1)
                {
                    float MH_value = Functions.BCD(octeto[n]);
                    n++;

                    CurrentData.MH_value = MH_value;
                }
                if (octeto[1][6] == 1)
                {
                    float BVR_value = Functions.BCD(octeto[n]);
                    n++;

                    CurrentData.BVR_value = BVR_value;
                }

                if (nextents > 2)
                {
                    if (octeto[2][0] == 1)
                    {
                        float GVR_value = Functions.BCD(octeto[n]);
                        n++;

                        CurrentData.GVR_value = GVR_value;
                    }
                    if (octeto[2][1] == 1)
                    {
                        float GV_value = Functions.BCD(octeto[n]);
                        n++;

                        CurrentData.GV_value = GV_value;
                    }
                    if (octeto[2][2] == 1)
                    {
                        float TAR_value = Functions.BCD(octeto[n]);
                        n++;

                        CurrentData.TAR_value = TAR_value;
                    }
                    if (octeto[2][3] == 1)
                    {
                        float TIdentification_value = Functions.BCD(octeto[n]);
                        n++;

                        CurrentData.TIdentification_value = TIdentification_value;
                    }
                    if (octeto[2][4] == 1)
                    {
                        float TS_value = Functions.BCD(octeto[n]);
                        n++;

                        CurrentData.TS_value = TS_value;
                    }
                    if (octeto[2][5] == 1)
                    {
                        float MET_value = Functions.BCD(octeto[n]);
                        n++;

                        CurrentData.MET_value = MET_value;
                    }
                    if (octeto[2][6] == 1)
                    {
                        float ROA_value = Functions.BCD(octeto[n]);
                        n++;

                        CurrentData.ROA_value = ROA_value;
                    }

                    if (nextents > 3)
                    {

                        if (octeto[3][0] == 1)
                        {
                            float ARA_value = Functions.BCD(octeto[n]);
                            n++;

                            CurrentData.ARA_value = ARA_value;
                        }
                        if (octeto[3][1] == 1)
                        {
                            float SCC_value = Functions.BCD(octeto[n]);
                            n++;

                            CurrentData.SCC_value = SCC_value;
                        }
                    }
                }
            }
            Read.sumbyte(n);
        }

        // Data Item I021/400: Receiver ID
        private static void ReceiverID(string octeto1)
        {
            float ID = Functions.bintonum(octeto1);

            CurrentData.ID = ID;
        }
    }   
        
}
