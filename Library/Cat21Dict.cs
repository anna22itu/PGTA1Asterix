using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class CAT21Dict
    {
        public static string[] methods = { "AircraftOperationalStatus", "DataSourceIdentification", "ServiceIdentification", "ServiceManagement", "EmitterCategory", "TargetReportDescriptor", "Mode3/ACode", "TimeofApplicabilityforPosition", "TimeofApplicabilityforVelocity", "TimeofMessageReceptionforPosition", "TimeofMessageReceptionforPositionHighPrecision", "TimeofMessageReceptionforVelocity", "TimeofMessageReceptionforVelocityHighPrecision", "TimeofReportTransmission", "TargetAddress", "QualityIndicators", "TrajectoryIntent", "PositioninWGS84coordinates", "HighResolutionPositionWGS84Coordinates", "MessageAmplitude", "GeometricHeight", "FlightLevel", "SelectedAltitude", "FinalStateSelectedAltitude", "AirSpeed", "TrueAirSpeed", "MagneticHeading", "BarometricVerticalRate", "GeometricVerticalRate", "AirborneGroundVector", "TrackNumber", "TrackAngleRate", "TargetIdentification", "TargetStatus", "MOPSVersion", "MetInformation", "RollAngle", "ModeSMBData", "ACASResolutionAdvisoryReport", "SurfaceCapabilitiesandCharacteristics", "DataAges", "ReceiverID" };

        // 008
        public static IDictionary<int, string> AircraftOperationalStatus_RA = new Dictionary<int, string>() { { 0, "TCAS II or ACAS RA not active" }, { 1, "TCAS RA active" } };

        public static IDictionary<int, string> AircraftOperationalStatus_TC = new Dictionary<int, string>() { { 0, "no capability for Trajectory Change Reports" }, { 1, "support for TC+0 reports only" }, { 2, "support for multiple TC reports" }, { 3, "reserved" } };

        public static IDictionary<int, string> AircraftOperationalStatus_TS = new Dictionary<int, string>() { { 0, "no capability to support Target State Reports" }, { 1, "capable of supporting target State Reports" } };

        public static IDictionary<int, string> AircraftOperationalStatus_ARV = new Dictionary<int, string>() { { 0, "no capability to generate ARV-reports" }, { 1, "capable of generate ARV-reports" } };
        
        public static IDictionary<int, string> AircraftOperationalStatus_CDTIA = new Dictionary<int, string>() { { 0, "CDTI not operational" }, { 1, "CDTI operational" } };

        public static IDictionary<int, string> AircraftOperationalStatus_TCAS = new Dictionary<int, string>() { { 0, "TCAS operationaL" }, { 1, "TCAS not operational" } };

        public static IDictionary<int, string> AircraftOperationalStatus_SA = new Dictionary<int, string>() { { 0, "Antenna Diversity" }, { 1, "Single Antenna only" } };


        // 020
        public static IDictionary<int, string> EmitterCategory_ECAT = new Dictionary<int, string>() { { 0, "No ADS-B Emitter Category Information" }, { 1, "light aircraft <= 15500 lbs" }, { 2, "15500 lbs < small aircraft <75000 lbs" }, { 3, "75000 lbs < medium a/c < 300000 lbs" }, { 4, "High Vortex Large" }, { 5, "300000 lbs <= heavy aircraft" }, { 6, " highly manoeuvrable (5g acceleration capability) and high speed (>400 knots cruise)" }, { 7, "reserved" }, { 8, "reserved" }, { 9, "reserved" }, { 10, "rotocraft" }, { 11, "glider / sailplane" }, { 12, "lighter-than-air" }, { 13, "unmanned aerial vehicle" }, { 14, "space / transatmospheric vehicle" }, { 15, "ultralight / handglider / paraglider" }, { 16, "parachutist / skydiver" }, { 17, "reserved" }, { 18, "reserved" }, { 19, "reserved" }, { 20, "surface emergency vehicle" }, { 21, " surface service vehicle" }, { 22, "fixed ground or tethered obstruction" }, { 23, "cluster obstacle" }, { 24, "line obstacle" } };


        // 040
        public static IDictionary<int, string> TargetReportDescriptor_ATP = new Dictionary<int, string>() { { 0, "24-Bit ICAO address" }, { 1, "Duplicate addres" }, { 2, "Surface vehicle address" }, { 3, "Anonymous address" }, { 4, "Reserved for future use" }, { 5, "Reserved for future use" }, { 6, "Reserved for future use" }, { 7, "Reserved for future use" } };

        public static IDictionary<int, string> TargetReportDescriptor_ARC = new Dictionary<int, string>() { { 0, "25 ft" }, { 1,"100 ft" }, { 2, "Unknown" }, { 3, "Invalid" } };

        public static IDictionary<int, string> TargetReportDescriptor_RC = new Dictionary<int, string>() { { 0, "Default" }, { 1, "Range Check passed, CPR Validation pending" } };

        public static IDictionary<int, string> TargetReportDescriptor_RAB = new Dictionary<int, string>() { { 0, "Report from target transponder" }, { 1, "Report from field monitor (fixed transponder)" } };


        public static IDictionary<int, string> TargetReportDescriptor_DCR = new Dictionary<int, string>() { { 0, "No differential correction (ADS-B)" }, { 1, "Differential correction (ADS-B)" } };

        public static IDictionary<int, string> TargetReportDescriptor_GBS = new Dictionary<int, string>() { { 0, "Ground Bit not set" }, { 1, "Ground Bit set" } };

        public static IDictionary<int, string> TargetReportDescriptor_SIM = new Dictionary<int, string>() { { 0, "Actual target report" }, { 1, "Simulated target report" } };

        public static IDictionary<int, string> TargetReportDescriptor_TST = new Dictionary<int, string>() { { 0, "Default" }, { 1, "Test Target" } };

        public static IDictionary<int, string> TargetReportDescriptor_SAA = new Dictionary<int, string>() { { 0, "Equipment capable to provide Selected Altitude" }, { 1, "Equipment not capable to provide Selected Altitude" } };

        public static IDictionary<int, string> TargetReportDescriptor_CL = new Dictionary<int, string>() { { 0, "Report valid" }, { 1, "Report suspect" }, { 2, "No information" }, { 3, "Reserved for future use" } };



        public static IDictionary<int, string> TargetReportDescriptor_LLC = new Dictionary<int, string>() { { 0, "Default" }, { 1, "Target is suspect (see note)" } };

        public static IDictionary<int, string> TargetReportDescriptor_IPC = new Dictionary<int, string>() { { 0, "Default" }, { 1, "Independent Position Check failed " } };

        public static IDictionary<int, string> TargetReportDescriptor_NOGO = new Dictionary<int, string>() { { 0, "NOGO-bit not set" }, { 1, "NOGO-bit set" } };

        public static IDictionary<int, string> TargetReportDescriptor_CPR = new Dictionary<int, string>() { { 0, "CPR Validation correct" }, { 1, "CPR Validation failed" } };

        public static IDictionary<int, string> TargetReportDescriptor_LDPJ = new Dictionary<int, string>() { { 0, "LDPJ not detected" }, { 1, "LDPJ detected" } };

        public static IDictionary<int, string> TargetReportDescriptor_RCF = new Dictionary<int, string>() { { 0, "default" }, { 1, "Range Check failed" } };



        public static IDictionary<int, string> TargetReportDescriptor_TBC_element = new Dictionary<int, string>() { { 0, "Element not populated" }, { 1, "Element populated" } };



        public static IDictionary<int, string> TargetReportDescriptor_MBC_element = new Dictionary<int, string>() { { 0, "Element not populated" }, { 1, "Element populated" } };


        // 074 
        public static IDictionary<string, string> TimeMessageReceptionPosition_HP_FSI = new Dictionary<string, string>() { { "11", "Reserved" }, { "10", "TOMRp whole seconds = (I021/073) Whole seconds – 1" }, { "01", "TOMRp whole seconds = (I021/073) Whole seconds + 1" }, { "11", "TOMRp whole seconds = (I021/073) Whole seconds" } };


        // 076
        public static IDictionary<string, string> TimeMessageReceptionVelocity_HP_FSI = new Dictionary<string, string>() { { "11", "Reserved" }, { "10", "TOMRp whole seconds = (I021/073) Whole seconds – 1" }, { "01", "TOMRp whole seconds = (I021/073) Whole seconds + 1" }, { "11", "TOMRp whole seconds = (I021/073) Whole seconds" } };


        // 110
        public static IDictionary<int, string> TrajectoryIntent_TIS = new Dictionary<int, string>() { { 0, "Absence of Subfield #1" }, { 1, "Presence of Subfield #1" } };
        
        public static IDictionary<int, string> TrajectoryIntent_TID = new Dictionary<int, string>() { { 0, "Absence of Subfield #2" }, { 1, "Presence of Subfield #2" } };



        public static IDictionary<int, string> TrajectoryIntent_NAV = new Dictionary<int, string>() { { 0, "Trajectory Intent Data is available for this aircraft" }, { 1, "Trajectory Intent Data is not available for this aircraft" } };

        public static IDictionary<int, string> TrajectoryIntent_NVB = new Dictionary<int, string>() { { 0, "Trajectory Intent Data is valid" }, { 1, "Trajectory Intent Data is not valid" } };


        public static IDictionary<int, string> TrajectoryIntent_TCA = new Dictionary<int, string>() { { 0, "TCP number available" }, { 1, "TCP number not available" } };

        public static IDictionary<int, string> TrajectoryIntent_NC = new Dictionary<int, string>() { { 0, "TCP compliance" }, { 1, "TCP non-compliance" } };
        
        public static IDictionary<int, string> TrajectoryIntent_PointType = new Dictionary<int, string>() { { 0, "Unknown" }, { 1, "Fly by waypoint (LT)" }, { 2, "Fly over waypoint (LT)" }, { 3, "Hold pattern (LT)" }, { 4, "Procedure hold (LT)" }, { 5, "Procedure turn (LT)" }, { 6, "RF leg (LT)" }, { 7, "Top of climb (VT)" }, { 8, "Top of descent (VT)" }, { 9, "Start of level (VT)" }, { 10, "Cross-over altitude (VT)" }, { 11, "Transition altitude (VT)" } };

        public static IDictionary<string, string> TrajectoryIntent_TD = new Dictionary<string, string>() { { "00", "N/A" }, { "01", "Turn right" }, { "10", "Turn left" }, { "11", "No turn" } };

        public static IDictionary<int, string> TrajectoryIntent_TRA = new Dictionary<int, string>() { { 0, "TTR not available" }, { 1, "TTR available" } };
        
        public static IDictionary<int, string> TrajectoryIntent_TOA = new Dictionary<int, string>() { { 0, "TOV available" }, { 1, "TOV not available" } };


        // 146
        public static IDictionary<int, string> SelectedAltitude_SAS = new Dictionary<int, string>() { { 0, "No source information provided" }, { 1, "Source Information provided" } };

        public static IDictionary<string, string> SelectedAltitude_Source = new Dictionary<string, string>() { { "00", "Unknown" }, { "01", "Aircraft Altitude (Holding Altitude)" }, { "10", "MCP/FCU Selected Altitude" }, { "11", "FMS Selected Altitude" } };


        // 147
        public static IDictionary<int, string> AltitudeFinal_MV = new Dictionary<int, string>() { { 0, "Not active or unknown" }, { 1, "Active" } };

        public static IDictionary<int, string> AltitudeFinal_AH = new Dictionary<int, string>() { { 0, "Not active or unknown" }, { 1, "Active" } };

        public static IDictionary<int, string> AltitudeFinal_AM = new Dictionary<int, string>() { { 0, "Not active or unknown" }, { 1, "Active" } };


        // 150
        public static IDictionary<int, string> AirSpeed_IM = new Dictionary<int, string>() { { 0, "IAS" }, { 1, "Mach" } };


        // 151
        public static IDictionary<int, string> TrueAirSpeed_RE = new Dictionary<int, string>() { { 0, "Value in defined range" }, { 1, "Value exceeds defined range" } };


        // 155
        public static IDictionary<int, string> BarometricVerticalRate_RE = new Dictionary<int, string>() { { 0, "Value in defined range" }, { 1, "Value exceeds defined range" } };


        // 155
        public static IDictionary<int, string> GeometricVerticalRate_RE = new Dictionary<int, string>() { { 0, "Value in defined range" }, { 1, "Value exceeds defined range" } };


        // 157
        public static IDictionary<int, string> AirborneGroundVector_RE = new Dictionary<int, string>() { { 0, "Value in defined range" }, { 1, "Value exceeds defined range" } };


        // 200
        public static IDictionary<int, string> TargetStatus_ICF = new Dictionary<int, string>() { { 0, "No intent change active" }, { 1, "Intent change flag raised" } };

        public static IDictionary<int, string> TargetStatus_LNAV = new Dictionary<int, string>() { { 0, "LNAV Mode engaged" }, { 1, "LNAV Mode not engaged" } };

        public static IDictionary<int, string> TargetStatus_ME = new Dictionary<int, string>() { { 0, "No military emergency" }, { 1, "Military emergency" } };

        public static IDictionary<int, string> TargetStatus_PS = new Dictionary<int, string>() { { 0, "No emergency / not reported" }, { 1, "General emergency" }, { 2, "Lifeguard / medical emergency" }, { 3, "Minimum fuel" }, { 4, "No communications" }, { 5, "Unlawful interference" }, { 6, "“Downed” Aircraft" } };

        public static IDictionary<int, string> TargetStatus_SS= new Dictionary<int, string>() { { 0, "No condition reported" }, { 1, "Permanent Alert (Emergency condition)" }, { 2, "Temporary Alert (change in Mode 3/A Code other than emergency)" }, { 3, "SPI set" } };


        // 210
        public static IDictionary<int, string> MOPSVersion_VNS = new Dictionary<int, string>() { { 0, "The MOPS Version is supported by the GS" }, { 1, "The MOPS Version is not supported by the GS" } };

        public static IDictionary<int, string> MOPSVersion_VN = new Dictionary<int, string>() { { 0, "ED102/DO-260 [Ref. 8]" }, { 1, "DO-260A [Ref. 9]" }, { 2, "ED102A/DO-260B [Ref. 10]" }, { 3, "ED-102B/DO-260C [Ref. 11]" } };

        public static IDictionary<int, string> MOPSVersion_LTT = new Dictionary<int, string>() { { 0, "Other" }, { 1, "UAT" }, { 2, "1090 ES" }, { 3, "VDL 4" }, { 4, "Not assigned" }, { 5, "Not assigned" }, { 6, "Not assigned" }, { 7, "Not assigned" } };


        // 220
        public static IDictionary<int, string> MetInformation_WS = new Dictionary<int, string>() { { 0, "Absence of Subfield #1" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> MetInformation_WD = new Dictionary<int, string>() { { 0, "Absence of Subfield #2" }, { 1, "Presence of Subfield #2" } };

        public static IDictionary<int, string> MetInformation_TMP = new Dictionary<int, string>() { { 0, "Absence of Subfield #3" }, { 1, "Presence of Subfield #3" } };

        public static IDictionary<int, string> MetInformation_TRB = new Dictionary<int, string>() { { 0, "Absence of Subfield #4" }, { 1, "Presence of Subfield #4" } };


        // 271
        public static IDictionary<int, string> SurfaceCapabilities_POA = new Dictionary<int, string>() { { 0, "Position transmitted is not ADS-B position reference point" }, { 1, "Position transmitted is the ADS-B position reference point" } };

        public static IDictionary<int, string> SurfaceCapabilities_CDTI = new Dictionary<int, string>() { { 0, "CDTI not operationa" }, { 1, "CDTI operational" } };

        public static IDictionary<int, string> SurfaceCapabilities_B2 = new Dictionary<int, string>() { { 0, "≥ 70 Watts" }, { 1, "< 70 Watts" } };

        public static IDictionary<int, string> SurfaceCapabilities_RAS = new Dictionary<int, string>() { { 0, "Aircraft not receiving ATC-services" }, { 1, "Aircraft receiving ATC services" } };

        public static IDictionary<int, string> SurfaceCapabilities_IDENT = new Dictionary<int, string>() { { 0, "IDENT switch not active" }, { 1, "IDENT switch active" } };



        public static IDictionary<int, string> SurfaceCapabilities_LengthWidth = new Dictionary<int, string>() { { 0, "" }, { 1, "" }, { 2, "" }, { 3, "" } , { 4, "" }, { 5, "" } , { 6, "IDENT switch not active" }, { 7, "IDENT switch active" } , { 8, "IDENT switch not active" }, { 9, "IDENT switch active" } , { 10, "IDENT switch not active" }, { 11, "IDENT switch active" } , { 12, "IDENT switch not active" }, { 13, "IDENT switch active" } , { 14, "IDENT switch not active" }, { 15, "IDENT switch active" } };


        // 295
        public static IDictionary<int, string> DataAges_AOS = new Dictionary<int, string>() { { 0, "Absence of Subfield #1" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_TRD = new Dictionary<int, string>() { { 0, "Absence of Subfield #2" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_M3A = new Dictionary<int, string>() { { 0, "Absence of Subfield #3" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_QI = new Dictionary<int, string>() { { 0, "Absence of Subfield #4" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_TI = new Dictionary<int, string>() { { 0, "Absence of Subfield #5" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_MAM = new Dictionary<int, string>() { { 0, "Absence of Subfield #6" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_GH = new Dictionary<int, string>() { { 0, "Absence of Subfield #7" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_FL = new Dictionary<int, string>() { { 0, "Absence of Subfield #8" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_SAL = new Dictionary<int, string>() { { 0, "Absence of Subfield #9" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_FSA = new Dictionary<int, string>() { { 0, "Absence of Subfield #10" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_AS = new Dictionary<int, string>() { { 0, "Absence of Subfield #11" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_TAS = new Dictionary<int, string>() { { 0, "Absence of Subfield #12" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_MH = new Dictionary<int, string>() { { 0, "Absence of Subfield #13" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_BVR = new Dictionary<int, string>() { { 0, "Absence of Subfield #14" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_GVR = new Dictionary<int, string>() { { 0, "Absence of Subfield #15" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_GV = new Dictionary<int, string>() { { 0, "Absence of Subfield #16" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_TAR = new Dictionary<int, string>() { { 0, "Absence of Subfield #17" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_TIdentification = new Dictionary<int, string>() { { 0, "Absence of Subfield #18" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_TS = new Dictionary<int, string>() { { 0, "Absence of Subfield #19" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_MET = new Dictionary<int, string>() { { 0, "Absence of Subfield #20" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_ROA = new Dictionary<int, string>() { { 0, "Absence of Subfield #21" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_ARA = new Dictionary<int, string>() { { 0, "Absence of Subfield #22" }, { 1, "Presence of Subfield #1" } };

        public static IDictionary<int, string> DataAges_SCC = new Dictionary<int, string>() { { 0, "Absence of Subfield #23" }, { 1, "Presence of Subfield #1" } };





    }
}
