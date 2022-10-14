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

        // 000
        public static IDictionary<int, string> MessageType = new Dictionary<int, string>() { {1, "Target Report" }, { 2, "Start of Update Cycle" }, { 3, "Periodic Status Message" }, { 4, "Event-triggered Status Message" } };

        // 020
        public static IDictionary<string, string> TargetReportDescriptor_TYP = new Dictionary<string, string>() { {"000", "SSR multilateration" }, { "001", "Mode S multilateration" }, { "010", "ADS-B" }, { "011", "PSR" }, { "100", "Magnetic Loop System" }, { "101", "HF multilateration" }, { "110", "Not defined" }, { "111", "Other types" } };

        public static IDictionary<string, string> TargetReportDescriptor_LOP = new Dictionary<string, string>() { {"00", "Undetermined" }, { "01", "Loop start" }, { "10", "Loop finish" } };

        public static IDictionary<string, string> TargetReportDescriptor_TOT = new Dictionary<string, string>() { { "00", "Undetermined" }, { "01", "Aircraft" }, { "10", "Ground vehicle" }, { "11", "Helicopter" } };

        // 060
        public static IDictionary<int, string> Mode3ACodeOctalRepresentation_V = new Dictionary<int, string>() { { 0, "Code validated" }, { 1, "Code not validated" } };

        public static IDictionary<int, string> Mode3ACodeOctalRepresentation_G = new Dictionary<int, string>() { { 0, "Default" }, { 1, "Garbled code" } };

        public static IDictionary<int, string> Mode3ACodeOctalRepresentation_L = new Dictionary<int, string>() { { 0, "Mode-3/A code derived from the reply of the transponder" }, { 1, "Mode-3/A code not extracted during the last scan" } };

        //090
        public static IDictionary<int, string> FligthLevel_V = new Dictionary<int, string>() { { 0, "Code validated" }, { 1, "Code not validated" } };

        public static IDictionary<int, string> FligthLevel_G = new Dictionary<int, string>() { { 0, "Default" }, { 1, "Garbled code" } };

        //170
        public static IDictionary<int, string> TrackStatus_CNF = new Dictionary<int, string>() { { 0, "Confirmed track" }, { 1, "Track in initialisation phase" } };

        public static IDictionary<int, string> TrackStatus_TRE = new Dictionary<int, string>() { { 0, "Default" }, { 1, "Last report for a track" } };

        public static IDictionary<string, string> TrackStatus_CST = new Dictionary<string, string>() { { "00", "No extrapolation" }, { "01", " Predictable extrapolation due to sensor refresh period (see NOTE) " }, { "10", "Predictable extrapolation in masked area" }, { "11", "Extrapolation due to unpredictable absence of detection" } };

        public static IDictionary<int, string> TrackStatus_MAH = new Dictionary<int, string>() { { 0, "Default" }, { 1, "Horizontal manoeuvre" } };

        public static IDictionary<int, string> TrackStatus_TCC = new Dictionary<int, string>() { { 0, "Tracking performed in 'Sensor Plane', i.e. neither slant range correction nor projection was applied" }, { 1, "Slant range correction and a suitable projection technique are used to track in a 2D.reference plane, tangential to the earth model at the Sensor Site co-ordinates" } };

        public static IDictionary<int, string> TrackStatus_STH = new Dictionary<int, string>() { { 0, "Measured position" }, { 1, "Smoothed position" } };

        //
    }
}
