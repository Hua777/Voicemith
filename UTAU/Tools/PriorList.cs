using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace UTAU.Tools {
    [Serializable]
    public class PriorList {

        #region constructor
        public PriorList( string priorfile = "", bool ispath = false ) {
            string readtoend = priorfile;
            _FilePath = priorfile;
            if( ispath ) {
                if( File.Exists( priorfile ) ) {
                    readtoend = File.ReadAllText( priorfile, Functs.GetEncoding( priorfile ) );
                } else {
                    readtoend = "";
                }
            }
            Parse( readtoend );
        }
        public string this[ string key ] {
            get {
                return GetValue( key );
            }
            set {
                SetValue( key, value );
            }
        }
        #endregion

        #region pubilc property
        public Dictionary<string, string> Values {
            get {
                return _Values;
            }
        }
        #endregion

        #region private property
        private Dictionary<string, string> _Values = new Dictionary<string, string>();
        private string _FilePath = "";
        #endregion

        #region pubilc method
        public bool HasValue( string key ) {
            if( _Values.ContainsKey( key ) ) {
                return true;
            } else {
                return false;
            }
        }
        public void SetValue( string key, string value ) {
            if( _Values.ContainsKey( key ) ) {
                _Values[ key ] = value;
            } else {
                _Values.Add( key, value );
            }
        }
        public void Save() {
            if( _FilePath != "" ) {
                File.WriteAllText( _FilePath, ToString(), Encoding.Unicode );
            }
        }
        #endregion

        #region private method
        private string GetValue( string key ) {
            if( _Values.ContainsKey( key ) ) {
                return _Values[ key ];
            } else {
                return null;
            }
        }
        private void Parse( string group ) {
            try {
                Regex pattern = new Regex( @"(.+)=(.+)" );
                foreach( Match keyvaluepair in pattern.Matches( group ) ) {
                    string key = keyvaluepair.Groups[ 1 ].ToString().Trim();
                    string value = keyvaluepair.Groups[ 2 ].ToString().Trim();
                    SetValue( key, value );
                }
            } catch( Exception ex ) {
                Console.WriteLine( "Parse color file key value error.\n" + ex.ToString() );
            }
        }
        #endregion

        #region override
        public override string ToString() {
            string result = "";
            foreach( KeyValuePair<string, string> tmpkvp in _Values ) {
                result += Functs.NextLine( tmpkvp.Key + "=" + tmpkvp.Value );
            }
            return result;
        }
        #endregion

    }
}
