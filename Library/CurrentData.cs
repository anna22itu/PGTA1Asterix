using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CurrentData
    {
        ///// CAT10 /////

        //000
        public static string MessageType;

        //010
        public static int SAC = 0;
        public static int SIC = 0;

        //020
        public static string TYP = "";
        public static string DCR = "";
        public static string CHN = "";
        public static string GBS = "";
        public static string CRT = "";
        public static string SIM = "";
        public static string TST = "";
        public static string RAB = "";
        public static string LOP = "";
        public static string TOT = "";
        public static string SPI = "";

        //040
        public static float rho = 0;
        public static float delta = 0;

        //041
        public static float latitude = 0;
        public static float longitude = 0;

        //042
        public static float xpos = 0;
        public static float ypos = 0;

        //060
        public static string ModeV = "";
        public static string ModeG = "";
        public static string ModeL = "";

        //090
        public static string FLV = "";
        public static string FlG = "";
        public static int FL = 0;

        //091
        public static float Height = 0;

        //131
        public static int PAM = 0;

        //140
        public static float TimeDay = 0;

        //161
        public static int TrackNumber = 0;

        //170
        public static string CNF = "";
        public static string TRE = "";
        public static string CST = "";
        public static string MAH = "";
        public static string TCC = "";
        public static string STH = "";

        public static string TOM = "";
        public static string DOU= "";
        public static string MRS = "";

        public static string GHO = "";


        //200
        public static float GroundSpeed = 0;
        public static float TrackAngle = 0;

        //202
        public static float Vx = 0;
        public static float Vy = 0;

        //210
        public static float Ax = 0;
        public static float Ay = 0;

        //220
        public static string TargetAddress = "";

        //245
        public static string STI = "";
        public static string TargetIdentification = "";

        //250
        public static float REP = 0;
        public static float MB = 0;
        public static float BDS1 = 0;
        public static float BDS2 = 0;

        //270
        public static int LengthLSB = 0;
        public static float OrientationLSB = 0;
        public static int WidthLSB = 0;

        //300
        public static string VFI = "";

        //319
        public static string TRB = "";
        public static string MSG = "";

        //500
        public static float SDx = 0;
        public static float SDy = 0;
        public static float Covariance = 0;

        //550
        public static string NOGO = "";
        public static string OVL = "";
        public static string TSV = "";
        public static string DIV = "";
        public static string TTF = "";





        ///// CAT21 /////

        //008
        public static string RA = "";
        public static string TC = "";
        public static string TS = "";
        public static string ARV = "";
        public static string CDTIA = "";
        public static string TCAS = "";
        public static string SA = "";

        //010
            //SAME AS CAT10

        //015
        public static float ServiceIdentification = 0;

        //016
        public static float RP = 0;

        //020
        public static string ECAT = "";

        //040
        public static string ATP = "";
        public static string ARC = "";
        public static string RC = "";
        public static string RAB_21 = "";

        public static string DCR_21 = "";
        public static string GBS_21 = "";
        public static string SIM_21 = "";
        public static string TST_21 = "";
        public static string SAA = "";
        public static string CL = "";

        public static string LLC = "";
        public static string IPC = "";
        public static string NOGO_21 = "";
        public static string CPR = "";
        public static string LDPJ = "";
        public static string RCF = "";

        public static string TBC_element = "";
        public static float TBC_value = 0;

        public static string MBC_element = "";
        public static float MBC_value = 0;

        //071
        public static float TimeApplicabilityPosition = 0;

        //072
        public static float TimeApplicabilityVelocity = 0;

        //073
        public static float TimeMessagePosition = 0;

        //074
        public static float TimeMessagePosition_HP = 0;
        public static string FSI_Pos = "";

        //075
        public static float TimeMessageVelocity = 0;

        //076
        public static float TimeMessageVelocity_HP = 0;
        public static string FSI_Vel = "";

        //077
        public static float TimeAsterixTransmission = 0;

        //080
        public static float TargerAddress = 0;

        //110
        public static string TIS = "";
        public static string TID = "";

        public static string NAV = "";
        public static string NVB = "";

        public static float REP_21 = 0;
        public static string TCA = "";
        public static string NC = "";
        public static float TCP = 0;
        public static float Altitude = 0;
        public static float Latitude = 0;
        public static float Longitude = 0;
        public static string PointType = "";
        public static string TD = "";
        public static string TRA = "";
        public static string TOA = "";
        public static float TOV = 0;
        public static float TTR = 0;

        //130
        public static float Latitude_WGS = 0;
        public static float Longitude_WGS = 0;

        //131
        public static float Latitude_WGS_HP = 0;
        public static float Longitude_WGS_HP = 0;

        //132
        public static float MAM = 0;

        //140
        public static float GH = 0;

        //145
        public static float FL_21 = 0;

        //146
        public static string SAS = "";
        public static string Source = "";
        public static float SelectedAltitude = 0;

        //148
        public static string MV = "";
        public static string AH = "";
        public static string AM = "";
        public static float AltitudeFinal = 0;

        //150
        public static string IM = "";
        public static float AirSpeed = 0;

        //151
        public static string RE = "";
        public static float TrueAirSpeed = 0;

        //152
        public static float MagneticHeading = 0;

        //155
        public static string RE_VR = "";
        public static float BarometricVerticalRate = 0;

        //157
        public static string RE_G = "";
        public static float GeometricVerticalRate = 0;

        //157
        public static string RE_A = "";
        public static float GroundSpeed_21 = 0;
        public static float TrackAngle_21 = 0;

        //161
        public static int TrackNumber_21 = 0;

        //165
        public static float TrackAngleRate = 0;

    }


}  




