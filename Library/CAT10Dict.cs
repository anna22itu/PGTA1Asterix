using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class CAT10Dict
    {
        public static string[] methods = { "MessageType", "DataSourceIdentifier", "TargetReportDescriptor", "MeasuredPositionPolarCoordinates", "PositionWGS84Coordinates", "PositionCartesianCoordinates", "Mode3ACodeOctalRepresentation", "FlightLevelBinaryRepresentation", "MeasuredHeight", "AmplitudePrimaryPlot", "TimeOfDay", "TrackNumber", "TrackStatus", "CalculatedTrackVelocityPolarCoordinates", "CalculatedTrackVelocityCartesianCoordinates", "CalculatedAcceleration", "TargetAddress", "TargetIdentification", "ModeSMBData", "TargetSizeOrientation", "Presence", "VehicleFleetIdentification", "PreprogrammedMessage", "StandardDeviationPosition", "SystemStatus" };

        public static IDictionary<int, string> MessageType = new Dictionary<int, string>() { {1, "Target Report" }, { 2, "Start of Update Cycle" }, { 3, "Periodic Status Message" }, { 4, "Event-triggered Status Message" } };

        public static IDictionary<string, string> TargetReportDescriptor_TYP = new Dictionary<string, string>() { {"000", "SSR multilateration" }, { "001", "Mode S multilateration" }, { "010", "ADS-B" }, { "011", "PSR" }, { "100", "Magnetic Loop System" }, { "101", "HF multilateration" }, { "110", "Not defined" }, { "111", "Other types" } };

        public static IDictionary<string, string> TargetReportDescriptor_LOP = new Dictionary<string, string>() { {"00", "Undetermined" }, { "01", "Loop start" }, { "10", "Loop finish" } };

        public static IDictionary<string, string> TargetReportDescriptor_TOT = new Dictionary<string, string>() { { "00", "Undetermined" }, { "01", "Aircraft" }, { "10", "Ground vehicle" }, { "11", "Helicopter" } };

    }
}
