using System;
using UTAU.Tools;

namespace UTAU.NoteProperty {
    [Serializable]

    public struct PVBR {

        #region Constructor
        public PVBR( string vbr ) {
            Length = 0;
            Period = 0;
            Depth = 0;
            FadeIn = 0;
            FadeOut = 0;
            Phase = 0;
            Offset = 0;
            Parse( vbr );
        }
        #endregion

        #region Property
        public double Length;
        public double Period;
        public double Depth;
        public double FadeIn;
        public double FadeOut;
        public double Phase;
        public double Offset;
        #endregion

        #region Method
        private void Parse( string vbr ) {
            try {
                if( vbr == "" ) {
                    return;
                }
                vbr = Functs.RemoveAllSpaces( vbr );
                string[] svbr = vbr.Split( new char[] { ',' } );
                Length = Convert.ToDouble( svbr[ 0 ] );
                Period = Convert.ToDouble( svbr[ 1 ] );
                Depth = Convert.ToDouble( svbr[ 2 ] );
                FadeIn = Convert.ToDouble( svbr[ 3 ] );
                FadeOut = Convert.ToDouble( svbr[ 4 ] );
                Phase = Convert.ToDouble( svbr[ 5 ] );
                Offset = Convert.ToDouble( svbr[ 6 ] );
            } catch( Exception ex ) {
                throw new Exception( "Parse VBR error.\n" + ex.ToString() );
            }
        }
        #endregion

        #region Override
        public override string ToString() {
            return Length + "," + Period + "," + Depth + "," + FadeIn + "," + FadeOut + "," + Phase + "," + Offset + ",";
        }
        #endregion

        #region Operator
        public static implicit operator PVBR( string vbr ) {
            return new PVBR( vbr );
        }
        public static implicit operator string( PVBR pvbr ) {
            return pvbr.ToString();
        }
        #endregion

    }
}
