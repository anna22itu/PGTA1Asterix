using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CAT10Dict
    {
        public static string[] methods = { "DataSourceIdentifier", "MessageType", "TargetReportDescriptor", "TimeOfDay", "PositionWGS84Coordinates", "MeasuredPositionPolarCoordinates", "PositionCartesianCoordinates", "CalculatedTrackVelocityPolarCoordinates", "CalculatedTrackVelocityCartesianCoordinates", "TrackNumber", "TrackStatus", "Mode3ACodeOctalRepresentation", "TargetAddress", "TargetIdentification", "ModeSMBData", "VehicleFleetIdentification", "FlightLevelBinaryRepresentation", "MeasuredHeight", "TargetSizeOrientation", "SystemStatus", "PreprogrammedMessage", "StandardDeviationPosition", "Presence", "AmplitudePrimaryPlot", "CalculatedAcceleration" };
        
        // 000
        public static IDictionary<int, string> MessageType = new Dictionary<int, string>() { {1, "Target Report" }, { 2, "Start of Update Cycle" }, { 3, "Periodic Status Message" }, { 4, "Event-triggered Status Message" } };


        // 020
        public static IDictionary<string, string> TargetReportDescriptor_TYP = new Dictionary<string, string>() { {"000", "SSR multilateration" }, { "001", "Mode S multilateration" }, { "010", "ADS-B" }, { "011", "PSR" }, { "100", "Magnetic Loop System" }, { "101", "HF multilateration" }, { "110", "Not defined" }, { "111", "Other types" } };

        public static IDictionary<int, string> TargetReportDescriptor_DCR = new Dictionary<int, string>() { { 0, "No differential correction (ADS-B)" }, { 1, "Differential correction (ADS-B)" } };

        public static IDictionary<int, string> TargetReportDescriptor_CHN = new Dictionary<int, string>() { { 0, "Chain 1" }, { 1, "Chain 2" } };

        public static IDictionary<int, string> TargetReportDescriptor_GBS = new Dictionary<int, string>() { { 0, "Transponder Ground bit not set" }, { 1, "Transponder Ground bit set" } };

        public static IDictionary<int, string> TargetReportDescriptor_CRT = new Dictionary<int, string>() { { 0, "No Corrupted reply in multilateration" }, { 1, "Corrupted replies in multilateration" } };


        public static IDictionary<int, string> TargetReportDescriptor_SIM = new Dictionary<int, string>() { { 0, "Actual target report" }, { 1, "Simulated target report " } };

        public static IDictionary<int, string> TargetReportDescriptor_TST = new Dictionary<int, string>() { { 0, "Default" }, { 1, "Test Target" } };

        public static IDictionary<int, string> TargetReportDescriptor_RAB = new Dictionary<int, string>() { { 0, "Report from target transponder" }, { 1, "Report from field monitor (fixed transponder)" } };

        public static IDictionary<string, string> TargetReportDescriptor_LOP = new Dictionary<string, string>() { {"00", "Undetermined" }, { "01", "Loop start" }, { "10", "Loop finish" } };

        public static IDictionary<string, string> TargetReportDescriptor_TOT = new Dictionary<string, string>() { { "00", "Undetermined" }, { "01", "Aircraft" }, { "10", "Ground vehicle" }, { "11", "Helicopter" } };


        public static IDictionary<int, string> TargetReportDescriptor_SPI = new Dictionary<int, string>() { { 0, "Absence of SPI " }, { 1, "Special Position Identification" } };


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


        public static IDictionary<string, string> TrackStatus_TOM = new Dictionary<string, string>() { { "00", "Unknown type of movement" }, { "01", "Taking-off" }, { "10", "Landing" }, { "11", "Other types of movement" } };

        public static IDictionary<string, string> TrackStatus_DOU = new Dictionary<string, string>() { { "000", "No doubt" }, { "001", "Doubtful correlation (undetermined reason)" }, { "010", "Doubtful correlation in clutter" }, { "011", "Loss of accuracy" }, { "100", "Loss of accuracy in clutter" }, { "101", " Unstable track" }, { "110", "Previously coasted" } };

        public static IDictionary<string, string> TrackStatus_MRS = new Dictionary<string, string>() { { "00", "Unknown type of movement" }, { "01", "Taking-off" }, { "10", "Landing" }, { "11", "Other types of movement" } };


        public static IDictionary<int, string> TrackStatus_GHO = new Dictionary<int, string>() { { 0, "Default" }, { 1, "Ghost track" } };


        //245
        public static IDictionary<string, string> TargetIdentification_STI = new Dictionary<string, string>() { { "00", "Callsign or registration downlinked from transponde" }, { "01", "Callsign not downlinked from transponde" }, { "10", "Registration not downlinked from transponder" } };

        public static IDictionary<string, string> TargetIdentification_octetos = new Dictionary<string, string>() { { "000001", "A" }, { "000010", "B" }, { "000011", "C" }, { "000100", "D" }, { "000101", "E" }, { "000110", "F" }, { "000111", "G" }, { "001000", "H" }, { "001001", "I" }, { "001010", "J" }, { "001011", "K" }, { "001100", "L" }, { "001101", "M" }, { "001110", "N" }, { "001111", "O" }, { "010000", "P" }, { "010001", "Q" }, { "010010", "R" }, { "010011", "S" }, { "010100", "T" }, { "010101", "U" }, { "010110", "V" }, { "010111", "W" }, { "011000", "X" }, { "011001", "Y" }, { "011010", "Z" }, { "100000", " " }, { "110000", "0" }, { "110001", "1" }, { "110010", "2" }, { "110011", "3" }, { "110100", "4" }, { "110101", "5" }, { "110110", "6" }, { "110111", "7" }, { "111000", "8" }, { "111001", "9" } };

        public static string[,] TargetIdentification = new string[16, 4] { { "", "P", " ", "0" }, { "A", "Q", "", "1" }, { "B", "R", "", "2" }, { "C", "S", "", "3" }, { "D", "T", "", "4" }, { "E", "U", "", "5" }, { "F", "V", "", "6" }, { "G", "W", "", "7" }, { "H", "X", "", "8" }, { "I", "Y", "", "9" }, { "J", "Z", "", "" }, { "K", "", "", "" }, { "L", "", "", "" }, { "M", "", "", "" }, { "N", "", "", "" }, { "O", "", "", "" } };


        //300
        public static IDictionary<int, string> VehicleFleetIdentification_VFI = new Dictionary<int, string>() { { 0, "Unknown" }, { 1, "ATC equipment maintenance" }, { 2, "Airport maintenance" }, { 3, "Fire" }, { 4, "Bird scarer" }, { 5, "Snow plough" }, { 6, "Runway sweeper" }, { 7, "Emergency" }, { 8, "Police" }, { 9, "Bus" }, { 10, "Tug (push/tow)" }, { 11, "Grass cutter" }, { 12, "Fuel" }, { 13, "Baggage" }, { 14, "Catering" }, { 15, "Aircraft maintenance" }, { 16, "Flyco(follow me)" } };


        //310
        public static IDictionary<int, string> PreprogrammedMessage_TRB = new Dictionary<int, string>() { { 0, "Default" }, { 1, "In Trouble" } };
        
        public static IDictionary<int, string> PreprogrammedMessage_MSG = new Dictionary<int, string>() { { 1, "Towing aircraf" }, { 2, "'Follow me' operation" }, { 3, "Runway check" }, { 4, "Emergency operation (fire, medical…)" }, { 5, "Work in progress (maintenance, birds scarer, sweepers…)" } };


        //550
        public static IDictionary<string, string> SystemStatus_NOGO = new Dictionary<string, string>() { { "00", "Operational" }, { "01", "Degraded" }, { "10", "NOGO" } };

        public static IDictionary<int, string> SystemStatus_OVL = new Dictionary<int, string>() { { 0, "No overload" }, { 1, "Overload" } };

        public static IDictionary<int, string> SystemStatus_TSV = new Dictionary<int, string>() { { 0, "valid" }, { 1, "invalid" } };

        public static IDictionary<int, string> SystemStatus_DIV = new Dictionary<int, string>() { { 0, "Normal Operation" }, { 1, "Diversity degraded" } };

        public static IDictionary<int, string> SystemStatus_TTF = new Dictionary<int, string>() { { 0, "Test Target Operative" }, { 1, "Test Target Failure" } };




    }
}
