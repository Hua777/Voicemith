using System;
using System.Threading;
using System.Windows.Forms;
using UTAU.NoteProperty;
using UTAU.Tools;

namespace UTAU {
    public partial class OneDEditor : UserControl {

        #region constructor
        public OneDEditor() {
            InitializeComponent();
        }
        public OneDEditor( TmpUst ust ) {
            _Ust = ust;
            InitializeComponent();
        }
        #endregion

        #region public property
        public double Times {
            get {
                return _Times;
            }
        }
        public int XScroll {
            get {
                return HSB.Value;
            }
            set {
                HSB.Value = value;
            }
        }
        public TmpUst Ust {
            get {
                return _Ust;
            }
            set {
                _Ust = value;
                Loader();
            }
        }
        public UstColor UColor = new UstColor();
        public PPFixName FixName = PPFixName.OutsideObscureSound;
        #endregion

        #region private property
        private TmpUst _Ust = null;
        private int _ITimes = 3;
        private double _Times {
            get {
                return _ITimes / 10D;
            }
        }
        private Thread _LoaderThread = null;
        #endregion

        #region event
        private void OneDEditor_Load( object sender, EventArgs e ) {
            this.ParentForm.FormClosing += ( s, evt ) => {
                if( _LoaderThread != null ) {
                    _LoaderThread.Abort();
                    _LoaderThread = null;
                }
            };
            this.PB.MouseWheel += PB_MouseWheel;
            CheckForIllegalCrossThreadCalls = false;
            Loader();
        }
        private void OneDEditor_SizeChanged( object sender, EventArgs e ) {
            Loader();
        }
        private void HSB_ValueChanged( object sender, EventArgs e ) {
            Loader();
        }
        private void PB_MouseDown( object sender, MouseEventArgs e ) {
            if( e.Button == MouseButtons.Left ) {
                Clicker( e.Location.X );
            }
        }
        private void PB_MouseMove( object sender, MouseEventArgs e ) {
            if( e.Button == MouseButtons.Left ) {
                Clicker( e.Location.X );
            }
        }
        private void PB_MouseWheel( object sender, MouseEventArgs e ) {
            if( ModifierKeys == Keys.Control ) {
                if( e.Delta > 0 ) {
                    ZoomIn();
                } else if( e.Delta < 0 ) {
                    ZoomOut();
                }
            } else {
                if( e.Delta > 0 ) {
                    if( HSB.Value - HSB.LargeChange >= HSB.Minimum ) {
                        HSB.Value -= HSB.LargeChange;
                    } else {
                        HSB.Value = HSB.Minimum;
                    }
                } else if( e.Delta < 0 ) {
                    if( HSB.Value + HSB.LargeChange <= HSB.Maximum ) {
                        HSB.Value += HSB.LargeChange;
                    } else {
                        HSB.Value = HSB.Maximum;
                    }
                }
            }
        }
        #endregion

        #region public method
        public void ReDraw() {
            Loader();
        }
        public void ZoomIn() {
            if( _Ust != null ) {
                double tmptimes = Times;
                if( _ITimes + 1 <= 20 ) {
                    ++_ITimes;
                    Loader();
                }
            }
        }
        public void ZoomOut() {
            if( _Ust != null ) {
                double tmptimes = Times;
                if( _ITimes - 1 >= 1 ) {
                    --_ITimes;
                    Loader();
                }
            }
        }
        #endregion

        #region private method
        private void Clicker( double offsetx ) {
            if( _Ust != null ) {
                Note tmpnote = _Ust.SearchByOffsetX( offsetx );
                if( tmpnote != null && tmpnote.CanEdit ) {
                    tmpnote.FixName = this.FixName;
                    Loader();
                }
            }
        }
        private void Loader() {
            /*
            if( _LoaderThread != null ) {
                _LoaderThread.Abort();
                _LoaderThread = null;
            }
            _LoaderThread = new Thread( _Loader );
            _LoaderThread.Start();
            */
            _Loader();
        }
        private void _Loader() {
            if( _Ust != null ) {
                double length = _Ust.Length * _Times;
                if( HSB.Width >= length ) {
                    HSB.Maximum = 0;
                    HSB.Value = 0;
                    HSB.Visible = false;
                } else {
                    HSB.Maximum = (int) length;
                    HSB.SmallChange = (int) ( (double) HSB.Maximum / _Ust.Count );
                    HSB.LargeChange = (int) ( (double) HSB.Maximum / ( _Ust.Count - 1 > 0 ? _Ust.Count - 1 : 1 ) );
                    HSB.Visible = true;
                }
                PB.Image = _Ust.To1D( UColor, PB.Width, PB.Height, _Times, HSB.Value );
            }
        }
        #endregion

    }
}
