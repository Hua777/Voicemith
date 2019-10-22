using System;
using System.Collections.Generic;
using UTAU.Tools;

namespace UTAU.NoteProperty {
    [Serializable]

    public struct PPBM {

        #region Constructor
        public PPBM( string pbm ) {
            Ps = new List<char>();
            Parse( pbm );
        }
        #endregion

        #region Property
        public List<char> Ps;
        #endregion

        #region Method
        private void Parse( string pbm ) {
            try {
                if( pbm == "" ) {
                    return;
                }
                pbm = Functs.RemoveAllSpaces( pbm );
                string[] spbm = pbm.Split( new char[] { ',' } );
                int i;
                for( i = 0 ; i < spbm.Length ; ++i ) {
                    try {
                        Ps.Add( spbm[ i ][ 0 ] );
                    } catch {
                        Ps.Add( ' ' );
                    }
                }
            } catch( Exception ex ) {
                throw new Exception( "Parse PBM error.\n" + ex.ToString() );
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
                if( Ps[ i ] != ' ' ) {
                    result += Ps[ i ].ToString();
                }
            }
            return result;
        }
        #endregion

        #region Operator
        public static implicit operator PPBM( string pbm ) {
            return new PPBM( pbm );
        }
        public static implicit operator string( PPBM ppbm ) {
            return ppbm.ToString();
        }
        #endregion

    }
}
