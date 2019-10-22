using System;
using System.Collections.Generic;
using UTAU.Tools;

namespace UTAU.NoteProperty {
    [Serializable]

    public struct PPitchBend {

        #region Constructor
        public PPitchBend( string pitchband ) {
            Ps = new List<double>();
            Parse( pitchband );
        }
        #endregion

        #region Property
        public List<double> Ps;
        #endregion

        #region Method
        private void Parse( string pitchband ) {
            try {
                if( pitchband == "" ) {
                    return;
                }
                pitchband = Functs.RemoveAllSpaces( pitchband );
                string[] spitchband = pitchband.Split( new char[] { ',' } );
                int i;
                for( i = 0 ; i < spitchband.Length ; ++i ) {
                    try {
                        Ps.Add( Convert.ToDouble( spitchband[ i ] ) );
                    } catch {
                        Ps.Add( 0 );
                    }
                }
            } catch( Exception ex ) {
                throw new Exception( "Parse PitchBand error.\n" + ex.ToString() );
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
        public static implicit operator PPitchBend( string pitchband ) {
            return new PPitchBend( pitchband );
        }
        public static implicit operator string( PPitchBend ppitchband ) {
            return ppitchband.ToString();
        }
        #endregion

    }
}
