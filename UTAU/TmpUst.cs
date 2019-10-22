using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UTAU.Tools;

namespace UTAU {
    [Serializable]
    public class TmpUst {

        #region constructor
        public TmpUst( string ustfile, bool ispath = false ) {
            string readtoend = ustfile;
            _FilePath = ustfile;
            if( ispath ) {
                if( File.Exists( ustfile ) ) {
                    readtoend = File.ReadAllText( ustfile, Functs.GetEncoding( ustfile ) );
                } else {
                    readtoend = "";
                }
            }
            Parse( readtoend );
        }
        public Note this[ int index ] {
            get {
                return _Notes[ index ];
            }
            set {
                _Notes[ index ] = value;
            }
        }
        #endregion

        #region public can be changed property
        public string Version {
            get {
                return (string) GetValue( "Version" );
            }
            set {
                SetValue( "Version", value );
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
        public int Tracks {
            get {
                return (int) GetValue( "Tracks" );
            }
            set {
                SetValue( "Tracks", value );
            }
        }
        public string ProjectName {
            get {
                return (string) GetValue( "ProjectName" );
            }
            set {
                SetValue( "ProjectName", value );
            }
        }
        public string VoiceDir {
            get {
                return (string) GetValue( "VoiceDir" );
            }
            set {
                SetValue( "VoiceDir", value );
            }
        }
        public string OutFile {
            get {
                return (string) GetValue( "OutFile" );
            }
            set {
                SetValue( "OutFile", value );
            }
        }
        public string CacheDir {
            get {
                return (string) GetValue( "CacheDir" );
            }
            set {
                SetValue( "CacheDir", value );
            }
        }
        public string Tool1 {
            get {
                return (string) GetValue( "Tool1" );
            }
            set {
                SetValue( "Tool1", value );
            }
        }
        public string Tool2 {
            get {
                return (string) GetValue( "Tool2" );
            }
            set {
                SetValue( "Tool2", value );
            }
        }
        public bool Mode2 {
            get {
                return (bool) GetValue( "Mode2" );
            }
            set {
                SetValue( "Mode2", value );
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
        #endregion

        #region other property
        public int Count {
            get {
                return _Notes.Count;
            }
        }
        public double Length {
            get {
                double length = 0;
                foreach( Note tmpnote in _Notes ) {
                    length += tmpnote.Length;
                }
                return length;
            }
        }
        #endregion

        #region private property
        private Dictionary<string, object> _Values = new Dictionary<string, object>();
        private List<Note> _Notes = new List<Note>();
        private bool _SetOffsetX = false;
        private string _FilePath = "";
        #endregion

        #region public method
        public void SetOffsetX( double times, int xscroll ) {
            double offset = 0;
            foreach( Note tmpnote in _Notes ) {
                tmpnote.OffsetX = offset * times - xscroll;
                tmpnote.OffsetXEnd = tmpnote.OffsetX + tmpnote.Length * times;
                offset += tmpnote.Length;
            }
            _SetOffsetX = true;
        }
        public Bitmap To1D( UstColor ustcolor, int width, int height, double times, int xscroll ) {
            return Functs.UstTo1D( this, ustcolor, width, height, times, xscroll );
        }
        public Note SearchByOffsetX( double offsetx ) {
            if( _SetOffsetX ) {
                int low = 0, high = Count - 1;
                while( low <= high ) {
                    int mid = ( low + high ) / 2;
                    if( _Notes[ mid ].OffsetX <= offsetx && offsetx < _Notes[ mid ].OffsetXEnd ) {
                        return _Notes[ mid ];
                    } else if( offsetx < _Notes[ mid ].OffsetX ) {
                        high = mid - 1;
                    } else if( _Notes[ mid ].OffsetXEnd <= offsetx ) {
                        low = mid + 1;
                    }
                }
                return null;
            } else {
                throw new Exception( "you have not set offset x." );
            }
        }
        public void Save() {
            if( _FilePath != "" ) {
                File.WriteAllText( _FilePath, ToString(), Encoding.Default );
            }
        }
        #endregion

        #region private method
        private object DetectValue( string key, string value ) {
            switch( key ) {
                case "Tempo":
                    return Convert.ToDouble( value );
                case "Tracks":
                    return Convert.ToInt32( value );
                case "Mode2":
                    return Convert.ToBoolean( value );
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
        private void Parse( string ustfile ) {
            try {
                Regex pattern = new Regex( @"\[#(.*)\]\r*\n*([^\[]*)\r*\n*" );
                foreach( Match group in pattern.Matches( ustfile ) ) {
                    string title = group.Groups[ 1 ].ToString();
                    string value = group.Groups[ 2 ].ToString();
                    if( title == "VERSION" ) {
                        Version = value;
                    } else if( title == "SETTING" ) {
                        ParseKeyValue( value );
                    } else {
                        Note tmpnote = new Note( value );
                        _Notes.Add( tmpnote );
                        if( title == "NEXT" ) {
                            tmpnote.NoteType = NoteTypeInTmpUST.Next;
                        } else if( title == "PREV" ) {
                            tmpnote.NoteType = NoteTypeInTmpUST.Prev;
                        }
                    }
                }
            } catch( Exception ex ) {
                Console.WriteLine( "Parse ust file error.\n" + ex.ToString() );
            }
        }
        private void ParseKeyValue( string group ) {
            try {
                Regex pattern = new Regex( @"(.+)=(.*)\r*\n*" );
                foreach( Match keyvaluepair in pattern.Matches( group ) ) {
                    string key = keyvaluepair.Groups[ 1 ].ToString().Trim();
                    string value = keyvaluepair.Groups[ 2 ].ToString().Trim();
                    SetValue( key, DetectValue( key, value ) );
                }
            } catch( Exception ex ) {
                Console.WriteLine( "Parse ust file key value error.\n" + ex.ToString() );
            }
        }
        #endregion

        #region override
        public override string ToString() {
            string result = "[#VERSION]";
            result += Functs.NextLine( Version );
            int i, end = Datas.USTVersionProperty.Length;
            result += Functs.NextLine( "[#SETTING]" );
            end = Datas.USTSettingProperty.Length;
            for( i = 0 ; i < end ; ++i ) {
                if( HasValue( Datas.USTSettingProperty[ i ] ) ) {
                    result += Functs.NextLine( Datas.USTSettingProperty[ i ] + "=" + GetValue( Datas.USTSettingProperty[ i ] ).ToString() );
                }
            }
            end = _Notes.Count;
            for( i = 0 ; i < end ; ++i ) {
                result += Functs.NextLine( _Notes[ i ].ToString() );
            }
            return result;
        }
        #endregion

    }
}
