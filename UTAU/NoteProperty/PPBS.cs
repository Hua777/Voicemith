using System;
using UTAU.Tools;

namespace UTAU.NoteProperty {
    [Serializable]

    public struct PPBS {

        #region Constructor
        public PPBS( string pbs ) {
            P = new PointD( 0, 0 );
            Parse( pbs );
        }
        #endregion

        #region Property
        public PointD P;
        #endregion

        #region Method
        private void Parse( string pbs ) {
            try {
                if( pbs == "" ) {
                    return;
                }
                pbs = Functs.RemoveAllSpaces( pbs );
                string[] spbs = pbs.Split( new char[] { ';' } );
                if( spbs.Length >= 1 ) {
                    P.X = Convert.ToDouble( spbs[ 0 ] );
                }
                if( spbs.Length >= 2 ) {
                    P.Y = Convert.ToDouble( spbs[ 1 ] );
                }
            } catch( Exception ex ) {
                throw new Exception( "Parse PBS error.\n" + ex.ToString() );
            }
        }
        #endregion

        #region Override
        public override string ToString() {
            return P.X + ";" + P.Y;
        }
        #endregion

        #region Operator
        public static implicit operator PPBS( string pbs ) {
            return new PPBS( pbs );
        }
        public static implicit operator string( PPBS ppbs ) {
            return ppbs.ToString();
        }
        #endregion

    }
}
