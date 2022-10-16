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

    }
}
