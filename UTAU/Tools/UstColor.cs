using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UTAU.NoteProperty;

namespace UTAU.Tools {
    [Serializable]
    public class UstColor {

        #region constructor
        public UstColor( string colorfile = "", bool ispath = false ) {
            BgColor = Color.White;

            NoteBorderColor = Color.Black;
            NoteBorderWidth = 1;

            OutsideNoteBgColor = Color.Green;
            PeaceNoteBgColor = Color.Pink;
            CantoNoteBgColor = Color.Beige;
            MuffleNoteBgColor = Color.Purple;
            RestNoteBgColor = Color.Gray;

            NoteLyricColor = Color.Black;
            NoteLyricFontFamily = "微軟正黑體";

            string readtoend = colorfile;
            if( ispath ) {
                if( File.Exists( colorfile ) ) {
                    readtoend = File.ReadAllText( colorfile, Functs.GetEncoding( colorfile ) );
                } else {
                    readtoend = "";
                }
            }
            Parse( readtoend );
        }
        #endregion

        #region public can be changed property
        #region background
        public Color BgColor {
            get {
                return (Color) GetValue( "BgColor" );
            }
            set {
                SetValue( "BgColor", value );
            }
        }
        #endregion
        #region note
        public Color NoteBorderColor {
            get {
                return (Color) GetValue( "NoteBorderColor" );
            }
            set {
                SetValue( "NoteBorderColor", value );
            }
        }
        public int NoteBorderWidth {
            get {
                return (int) GetValue( "NoteBorderWidth" );
            }
            set {
                SetValue( "NoteBorderWidth", value );
            }
        }

        public Color OutsideNoteBgColor {
            get {
                return (Color) GetValue( "OutsideNoteBgColor" );
            }
            set {
                SetValue( "OutsideNoteBgColor", value );
            }
        }
        public Color PeaceNoteBgColor {
            get {
                return (Color) GetValue( "PeaceNoteBgColor" );
            }
            set {
                SetValue( "PeaceNoteBgColor", value );
            }
        }
        public Color CantoNoteBgColor {
            get {
                return (Color) GetValue( "CantoNoteBgColor" );
            }
            set {
                SetValue( "CantoNoteBgColor", value );
            }
        }
        public Color MuffleNoteBgColor {
            get {
                return (Color) GetValue( "MuffleNoteBgColor" );
            }
            set {
                SetValue( "MuffleNoteBgColor", value );
            }
        }
        public Color RestNoteBgColor {
            get {
                return (Color) GetValue( "RestNoteBgColor" );
            }
            set {
                SetValue( "RestNoteBgColor", value );
            }
        }

        public Color NoteLyricColor {
            get {
                return (Color) GetValue( "NoteLyricColor" );
            }
            set {
                SetValue( "NoteLyricColor", value );
            }
        }
        public string NoteLyricFontFamily {
            get {
                return (string) GetValue( "NoteLyricFontFamily" );
            }
            set {
                SetValue( "NoteLyricFontFamily", value );
            }
        }
        #endregion
        #endregion

        #region public cannot be changed property
        public SolidBrush BgBrush {
            get {
                return new SolidBrush( BgColor );
            }
        }
        public Pen NoteBorderPen {
            get {
                return new Pen( NoteBorderColor, NoteBorderWidth );
            }
        }
        public SolidBrush OutsideNoteBrush {
            get {
                return new SolidBrush( OutsideNoteBgColor );
            }
        }
        public SolidBrush PeaceNoteBrush {
            get {
                return new SolidBrush( PeaceNoteBgColor );
            }
        }
        public SolidBrush CantoNoteBrush {
            get {
                return new SolidBrush( CantoNoteBgColor );
            }
        }
        public SolidBrush MuffleNoteBrush {
            get {
                return new SolidBrush( MuffleNoteBgColor );
            }
        }
        public SolidBrush RestNoteBrush {
            get {
                return new SolidBrush( RestNoteBgColor );
            }
        }
        public SolidBrush NoteLyricBrush {
            get {
                return new SolidBrush( NoteLyricColor );
            }
        }
        #endregion

        #region private property
        private Dictionary<string, object> _Values = new Dictionary<string, object>();
        #endregion

        #region pubilc method
        public Font NoteLyricFont( int height ) {
            return new Font( NoteLyricFontFamily, NoteLyricFontSize( height ) );
        }
        public float NoteLyricFontSize( int height ) {
            int i = 9;
            for( ; ; i++ ) {
                Font textfont = new Font( NoteLyricFontFamily, i );
                Size textsize = TextRenderer.MeasureText( "永", textfont );
                if( textsize.Height > height ) {
                    break;
                }
                textfont.Dispose();
            }
            return i - 1;
        }
        public Size NoteLyricSize( int height ) {
            int i = 9;
            for( ; ; i++ ) {
                Font textfont = new Font( NoteLyricFontFamily, i );
                Size textsize = TextRenderer.MeasureText( "永", textfont );
                if( textsize.Height > height ) {
                    return textsize;
                }
                textfont.Dispose();
            }
        }
        public void SetValue( string key, byte r, byte g, byte b ) {
            if( key.Contains( "Color" ) ) {
                Color tmpcolor = Color.FromArgb( r, g, b );
                SetValue( key, tmpcolor );
            } else {
                throw new Exception( "Cannot set property that is not a color." );
            }
        }
        #endregion

        #region private method
        private object DetectValue( string key, string value ) {
            switch( key ) {
                case "NoteBorderWidth":
                    return Convert.ToInt32( value );
                case "NoteLyricFontFamily":
                    return value;
                default:
                    if( value != "" ) {
                        value = Functs.RemoveAllSpaces( value );
                        string[] rgbarray = value.Split( new char[] { ',' } );
                        if( rgbarray.Length == 3 ) {
                            Color tmpcolor = Color.FromArgb( Convert.ToByte( rgbarray[ 0 ] ), Convert.ToByte( rgbarray[ 1 ] ), Convert.ToByte( rgbarray[ 2 ] ) );
                            return tmpcolor;
                        }
                    }
                    return null;
            }
        }
        private void SetValue( string key, object value ) {
            if( value != null ) {
                if( _Values.ContainsKey( key ) ) {
                    _Values[ key ] = value;
                } else {
                    _Values.Add( key, value );
                }
            }
        }
        private object GetValue(string key) {
            if( _Values.ContainsKey( key ) ) {
                return _Values[ key ];
            } else {
                return null;
            }
        }
        private void Parse( string group ) {
            try {
                Regex pattern = new Regex( @"(.+)\=(.*)" );
                foreach( Match keyvaluepair in pattern.Matches( group ) ) {
                    string key = keyvaluepair.Groups[ 1 ].ToString().Trim();
                    string value = keyvaluepair.Groups[ 2 ].ToString().Trim();
                    SetValue( key, DetectValue( key, value ) );
                }
            } catch( Exception ex ) {
                Console.WriteLine( "Parse color file key value error.\n" + ex.ToString() );
            }
        }
        #endregion

    }
}
