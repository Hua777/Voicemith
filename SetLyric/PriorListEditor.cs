using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UTAU.Tools;

namespace SetLyric {
    public partial class PriorListEditor : Form {

        #region constructor
        public PriorListEditor() {
            InitializeComponent();
        }
        #endregion

        #region public property
        public PriorList PList {
            get {
                return _PList;
            }
            set {
                _PList = value;
                Loader();
            }
        }
        #endregion

        #region private property
        private PriorList _PList = null;
        #endregion

        #region event
        private void PriorListEditor_Load( object sender, EventArgs e ) {
            Loader();
        }
        private void LV_PList_SelectedIndexChanged( object sender, EventArgs e ) {
            if( LV_PList.SelectedItems.Count > 0 ) {
                ListViewItem tmplvi = LV_PList.SelectedItems[ 0 ];
                if( tmplvi != null ) {
                    TB_Key.Text = tmplvi.SubItems[ 0 ].Text;
                    TB_Value.Text = tmplvi.SubItems[ 1 ].Text;
                }
            }
        }
        private void TB_ValueKey_TextChanged( object sender, EventArgs e ) {
            if( LV_PList.SelectedItems.Count > 0 ) {
                ListViewItem tmplvi = LV_PList.SelectedItems[ 0 ];
                if( tmplvi != null ) {
                    TextBox tmptb = (TextBox) sender;
                    string val = tmptb.Text;
                    if( val != "" ) {
                        string tag = tmptb.Tag.ToString();
                        if( tag == "Key" ) {
                            tmplvi.SubItems[ 0 ].Text = val;
                        } else if( tag == "Value" ) {
                            tmplvi.SubItems[ 1 ].Text = val;
                        }
                    }
                }
            }
        }
        private void BTN_Add_Click( object sender, EventArgs e ) {
            ListViewItem tmplvi = new ListViewItem( "(請輸入)" );
            tmplvi.SubItems.Add( "(請輸入)" );
            LV_PList.Items.Insert( 0, tmplvi );
        }
        private void BTN_Remove_Click( object sender, EventArgs e ) {
            if( LV_PList.SelectedItems.Count > 0 ) {
                ListViewItem tmplvi = LV_PList.SelectedItems[ 0 ];
                LV_PList.Items.Remove( tmplvi );
            }
        }
        private void BTN_Save_Click( object sender, EventArgs e ) {
            Saver();
            this.DialogResult = DialogResult.OK;
        }
        private void BTN_Cancel_Click( object sender, EventArgs e ) {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion

        #region private method
        private void Loader() {
            if( _PList != null ) {
                LV_PList.Items.Clear();
                foreach( KeyValuePair<string, string> tmpkvp in _PList.Values ) {
                    ListViewItem tmplvi = new ListViewItem( tmpkvp.Key );
                    tmplvi.SubItems.Add( tmpkvp.Value );
                    LV_PList.Items.Add( tmplvi );
                }
            }
        }
        private void Saver() {
            if( _PList != null ) {
                _PList.Values.Clear();
                foreach( ListViewItem tmplvi in LV_PList.Items ) {
                    _PList.SetValue( tmplvi.SubItems[ 0 ].Text, tmplvi.SubItems[ 1 ].Text );
                }
            }
        }
        #endregion

    }
}
