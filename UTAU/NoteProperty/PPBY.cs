using System;
using System.Collections.Generic;
using UTAU.Tools;

namespace UTAU.NoteProperty {
    [Serializable]

    public struct PPBY {

        #region Constructor
        public PPBY( string pby ) {
            Ps = new List<double>();
            Parse( pby );
        }
        #endregion

        #region Property
        public List<double> Ps;
        #endregion

        #region Method
        private void Parse( string pby ) {
            try {
                if( pby == "" ) {
                    return;
                }
                pby = Functs.RemoveAllSpaces( pby );
                string[] spby = pby.Split( new char[] { ',' } );
                int i;
                for( i = 0 ; i < spby.Length ; ++i ) {
                    try {
                        Ps.Add( Convert.ToDouble( spby[ i ] ) );
                    } catch {
                        Ps.Add( 0 );
                    }
                }
            } catch( Exception ex ) {
                throw new Exception( "Parse PBY error.\n" + ex.ToString() );
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
        public static implicit operator PPBY( string pby ) {
            return new PPBY( pby );
        }
        public static implicit operator string( PPBY ppby ) {
            return ppby.ToString();
        }
        #endregion

    }
}
