using System;
using UTAU.Tools;

namespace UTAU.NoteProperty {
    [Serializable]

    public struct PEnvelope {

        #region Constructor
        public PEnvelope( string envelope ) {
            P1 = new PointD( 0, 0 );
            P2 = new PointD( 5, 100 );
            P3 = new PointD( 35, 100 );
            P4 = new PointD( 0, 0 );
            P5 = new PointD( 10, 100 );
            Parse( envelope );
        }
        #endregion

        #region Property
        public PointD P1;
        public PointD P2;
        public PointD P3;
        public PointD P4;
        public PointD P5;
        #endregion

        #region Method
        private void Parse( string envelope ) {
            try {
                envelope = Functs.RemoveAllSpaces( envelope );
                string[] senvelope = envelope.Split( new char[] { ',' } );
                double[] senveloped = new double[ senvelope.Length ];
                if( senvelope.Length >= 7 ) {
                    int i;
                    for( i = 0 ; i < senvelope.Length ; ++i ) {
                        if( senvelope[ i ] != "%" && senvelope[ i ] != "" ) {
                            senveloped[ i ] = Convert.ToDouble( senvelope[ i ] );
                        } else {
                            senveloped[ i ] = 0;
                        }
                    }
                    P1.X = senveloped[ 0 ];
                    P2.X = senveloped[ 1 ];
                    P3.X = senveloped[ 2 ];
                    P1.Y = senveloped[ 3 ];
                    P2.Y = senveloped[ 4 ];
                    P3.Y = senveloped[ 5 ];
                    P4.Y = senveloped[ 6 ];
                }
                if( senvelope.Length >= 9 ) {
                    P4.X = senveloped[ 8 ];
                }
                if( senvelope.Length >= 10 ) {
                    P5.X = senveloped[ 9 ];
                }
                if( senvelope.Length >= 11 ) {
                    P5.Y = senveloped[ 10 ];
                }
            } catch( Exception ex ) {
                throw new Exception( "Parse envelope error.\n" + ex.ToString() );
            }
        }
        #endregion

        #region Override
        public override string ToString() {
            return P1.X + "," + P2.X + "," + P3.X + "," + P1.Y + "," + P2.Y + "," + P3.Y + "," + P4.Y + ",%," + P4.X + "," + P5.X + "," + P5.Y;
        }
        #endregion

        #region Operator
        public static implicit operator PEnvelope( string envelope ) {
            return new PEnvelope( envelope );
        }
        public static implicit operator string( PEnvelope penvelope ) {
            return penvelope.ToString();
        }
        #endregion

    }
}
