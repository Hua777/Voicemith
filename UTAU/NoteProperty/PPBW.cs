using System;
using System.Collections.Generic;
using UTAU.Tools;

namespace UTAU.NoteProperty {
    [Serializable]

    public struct PPBW {

        #region Constructor
        public PPBW( string pbw ) {
            Ps = new List<double>();
            Parse( pbw );
        }
        #endregion

        #region Property
        public List<double> Ps;
        #endregion

        #region Method
        private void Parse( string pbw ) {
            try {
                if( pbw == "" ) {
                    return;
                }
                pbw = Functs.RemoveAllSpaces( pbw );
                string[] spbw = pbw.Split( new char[] { ',' } );
                int i;
                for( i = 0 ; i < spbw.Length ; ++i ) {
                    try {
                        Ps.Add( Convert.ToDouble( spbw[ i ] ) );
                    } catch {
                        Ps.Add( 0 );
                    }
                }
            } catch( Exception ex ) {
                throw new Exception( "Parse PBW error.\n" + ex.ToString() );
            }
        }
        #endregion

        #region Override
        public override string ToString() {
            string result = "";
            int i;
            for( i = 0 ; i < Ps.Count ; ++i ) {
                if( i != 0 ) {
                    result += ",";
                }
                result += Ps[ i ].ToString();
            }
            return result;
        }
        #endregion

        #region Operator
        public static implicit operator PPBW( string pbw ) {
            return new PPBW( pbw );
        }
        public static implicit operator string( PPBW ppbw ) {
            return ppbw.ToString();
        }
        #endregion

    }
}
