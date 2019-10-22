using System;

namespace UTAU.Tools {
    [Serializable]
    public struct PointD {

        #region Constructor
        public PointD( double x, double y ) {
            X = x;
            Y = y;
        }
        #endregion

        #region Property
        public double X;
        public double Y;
        #endregion

        #region Override
        public override string ToString() {
            return "(" + X + ", " + Y + ")";
        }
        #endregion

    }
}
