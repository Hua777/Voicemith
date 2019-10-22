using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UTAU.NoteProperty;
using UTAU.Tools;

namespace UTAU {
    [Serializable]
    public class Note {

        #region constructor
        public Note() {
            Length = 480;
            Lyric = "a";
            NoteNum = 60;
        }
        public Note( double length ) {
            Length = length;
            Lyric = "a";
            NoteNum = 60;
        }
        public Note( double length, string lyric ) {
            Length = length;
            Lyric = lyric;
            NoteNum = 60;
        }
        public Note( double length, string lyric, int notenum ) {
            Length = length;
            Lyric = lyric;
            NoteNum = notenum;
        }
        public Note( string notegroup ) {
            Length = 480;
            Lyric = "a";
            NoteNum = 60;
            Parse( notegroup );
        }
        #endregion

        #region public can be changed property
        public double Length {
            get {
                return (double) GetValue( "Length" );
            }
            set {
                SetValue( "Length", value );
            }
        }
        public PLyric Lyric {
            get {
                return (PLyric) GetValue( "Lyric" );
            }
            set {
                SetValue( "Lyric", value );
            }
        }
        public int NoteNum {
            get {
                return (int) GetValue( "NoteNum" );
            }
            set {
                SetValue( "NoteNum", value );
            }
        }
        public PEnvelope Envelope {
            get {
                return (PEnvelope) GetValue( "Envelope" );
            }
            set {
                SetValue( "Envelope", value );
            }
        }
        public double PreUtterance {
            get {
                return (double) GetValue( "PreUtterance" );
            }
            set {
                SetValue( "PreUtterance", value );
            }
        }
        public double VoiceOverlap {
            get {
                return (double) GetValue( "VoiceOverlap" );
            }
            set {
                SetValue( "VoiceOverlap", value );
            }
        }
        public double StartPoint {
            get {
                return (double) GetValue( "StartPoint" );
            }
            set {
                SetValue( "StartPoint", value );
            }
        }
        public double Velocity {
            get {
                return (double) GetValue( "Velocity" );
            }
            set {
                SetValue( "Velocity", value );
            }
        }
        public double Intensity {
            get {
                return (double) GetValue( "Intensity" );
            }
            set {
                SetValue( "Intensity", value );
            }
        }
        public double Modulation {
            get {
                return (double) GetValue( "Modulation" );
            }
            set {
                SetValue( "Modulation", value );
            }
        }
        public string Flags {
            get {
                return (string) GetValue( "Flags" );
            }
            set {
                SetValue( "Flags", value );
            }
        }
        public string Label {
            get {
                return (string) GetValue( "Label" );
            }
            set {
                SetValue( "Label", value );
            }
        }
        public double Tempo {
            get {
                return (double) GetValue( "Tempo" );
            }
            set {
                SetValue( "Tempo", value );
            }
        }
        public PPBS PBS {
            get {
                return (PPBS) GetValue( "PBS" );
            }
            set {
                SetValue( "PBS", value );
            }
        }
        public PPBW PBW {
            get {
                return (PPBW) GetValue( "PBW" );
            }
            set {
                SetValue( "PBW", value );
            }
        }
        public PPBY PBY {
            get {
                return (PPBY) GetValue( "PBY" );
            }
            set {
                SetValue( "PBY", value );
            }
        }
        public PPBM PBM {
            get {
                return (PPBM) GetValue( "PBM" );
            }
            set {
                SetValue( "PBM", value );
            }
        }
        public int PBType {
            get {
                return (int) GetValue( "PBType" );
            }
            set {
                SetValue( "PBType", value );
            }
        }
        public PPitchBend PitchBend {
            get {
                return (PPitchBend) GetValue( "PitchBend" );
            }
            set {
                SetValue( "PitchBend", value );
            }
        }
        public PVBR VBR {
            get {
                return (PVBR) GetValue( "VBR" );
            }
            set {
                SetValue( "VBR", value );
            }
        }
        #endregion

        #region public cannot be changed Propery
        public double Preuttr {
            get {
                return (double) GetValue( "Preuttr" );
            }
            set {
                SetValue( "Preuttr", value );
            }
        }
        public double Overlap {
            get {
                return (double) GetValue( "Overlap" );
            }
            set {
                SetValue( "Overlap", value );
            }
        }
        public double Stpoint {
            get {
                return (double) GetValue( "Stpoint" );
            }
            set {
                SetValue( "Stpoint", value );
            }
        }
        public string Filename {
            get {
                return (string) GetValue( "Filename" );
            }
            set {
                SetValue( "Filename", value );
            }
        }
        public string Cache {
            get {
                return (string) GetValue( "Cache" );
            }
            set {
                SetValue( "Cache", value );
            }
        }
        public string Alias {
            get {
                return (string) GetValue( "Alias" );
            }
            set {
                SetValue( "Alias", value );
            }
        }
        public string ClearlyLyric {
            get {
                return Lyric.ClearlyLyric;
            }
            set {
                PLyric tmpplyric = Lyric;
                tmpplyric.ClearlyLyric = value;
                SetValue( "Lyric", tmpplyric );
            }
        }
        public bool CannotEdit {
            get {
                return ClearlyLyric == "R" || NoteType == NoteTypeInTmpUST.Prev || NoteType == NoteTypeInTmpUST.Next;
            }
        }
        public bool CanEdit {
            get {
                return !CannotEdit;
            }
        }
        #endregion

        #region other public property
        public NoteTypeInTmpUST NoteType = NoteTypeInTmpUST.Original;
        public PPFixName FixName {
            get {
                return Lyric.FixName;
            }
            set {
                var tmplyric = Lyric;
                tmplyric.FixName = value;
                Lyric = tmplyric;
            }
        }
        public double OffsetX = 0;
        public double OffsetXEnd = 0;
        #endregion

        #region private property
        private Dictionary<string, object> _Values = new Dictionary<string, object>();
        #endregion

        #region other private property
        #endregion

        #region method
        private object DetectValue( string key, string value ) {
            switch( key ) {
                case "Length":
                case "PreUtterance":
                case "VoiceOverlap":
                case "StartPoint":
                case "Velocity":
                case "Intensity":
                case "Modulation":
                case "Tempo":
                    return Convert.ToDouble( value );
                case "NoteNum":
                case "PBType":
                    return Convert.ToInt32( value );
                case "Envelope":
                    return new PEnvelope( value );
                case "PBS":
                    return new PPBS( value );
                case "PBW":
                    return new PPBW( value );
                case "PBY":
                    return new PPBY( value );
                case "PBM":
                    return new PPBM( value );
                case "PitchBend":
                    return new PPitchBend( value );
                case "VBR":
                    return new PVBR( value );
                case "Lyric":
                    return new PLyric( value );
                default:
                    return value;
            }
        }
        private void SetValue( string key, object value ) {
            if( _Values.ContainsKey( key ) ) {
                _Values[ key ] = value;
            } else {
                _Values.Add( key, value );
            }
        }
        private object GetValue( string key ) {
            if( _Values.ContainsKey( key ) ) {
                return _Values[ key ];
            } else {
                return null;
            }
        }
        private bool HasValue( string key ) {
            if( _Values.ContainsKey( key ) ) {
                return true;
            } else {
                return false;
            }
        }
        private void Parse( string notegroup ) {
            try {
                Regex pattern = new Regex( @"(.+)\=(.*)\r*\n*" );
                foreach( Match keyvaluepair in pattern.Matches( notegroup ) ) {
                    string key = keyvaluepair.Groups[ 1 ].ToString().Trim();
                    string value = keyvaluepair.Groups[ 2 ].ToString().Trim();
                    SetValue( key, DetectValue( key, value ) );
                }
            } catch(Exception ex) {
                Console.WriteLine( "Parse note group error.\n" + ex.ToString() );
            }
        }
        #endregion

        #region override
        public override string ToString() {
            string result = "[#0000]";
            if( NoteType == NoteTypeInTmpUST.Next ) {
                result = "[#NEXT]";
            } else if( NoteType == NoteTypeInTmpUST.Prev ) {
                result = "[#PREV]";
            } else if( NoteType == NoteTypeInTmpUST.Delete ) {
                result = "[#DELETE]";
            } else if( NoteType == NoteTypeInTmpUST.Insert ) {
                result = "[#INSERT]";
            }
            int i, end = Datas.NoteProperty.Length;
            for( i = 0 ; i < end ; ++i ) {
                if( HasValue( Datas.NoteProperty[ i ] ) ) {
                    result += Functs.NextLine( Datas.NoteProperty[ i ] + "=" + GetValue( Datas.NoteProperty[ i ] ).ToString() );
                }
            }
            return result;
        }
        #endregion

    }

    public enum NoteTypeInTmpUST {
        Original, Insert, Delete, Prev, Next
    }

}
