using System;
using System.Windows.Forms;
using UTAU;
using UTAU.NoteProperty;
using UTAU.Tools;
using System.Windows.Forms.ChangeLanguage;
using System.IO;
using System.Diagnostics;

namespace SetLyricAbs {
    public partial class Index : Form {

        #region constructor
        public Index( string[] args ) {
            if( args.Length != 1 ) {
                MessageBox.Show( "Please use this plugin in utau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                Environment.Exit( 1 );
            }
            InitializeComponent();
            ODE.UColor = UColor;
            ODE.Ust = new TmpUst( args[ 0 ], true );
        }
        #endregion

        #region private property
        private UstColor UColor = new UstColor( "./color", true );
        private PriorList PList = new PriorList( "./prior", true );
        private PriorListEditor PListEditor = new PriorListEditor();
        #endregion

        #region event
        private void Index_Load( object sender, EventArgs e ) {
            CB_ClearLyric.Checked = Properties.Settings.Default.Clear;
            CB_Sound.Checked = Properties.Settings.Default.Sound;
            CB_Lang.SelectedItem = Properties.Settings.Default.Lang;

            ReadLang();

            BTN_FixName_OS.BackColor = UColor.OutsideNoteBgColor;
            BTN_FixName_OM.BackColor = UColor.OutsideNoteBgColor;
            BTN_FixName_OC.BackColor = UColor.OutsideNoteBgColor;

            BTN_FixName_PS.BackColor = UColor.PeaceNoteBgColor;
            BTN_FixName_PM.BackColor = UColor.PeaceNoteBgColor;
            BTN_FixName_PC.BackColor = UColor.PeaceNoteBgColor;

            BTN_FixName_CS.BackColor = UColor.CantoNoteBgColor;
            BTN_FixName_CM.BackColor = UColor.CantoNoteBgColor;
            BTN_FixName_CC.BackColor = UColor.CantoNoteBgColor;

            BTN_FixName_M.BackColor = UColor.MuffleNoteBgColor;

            PListEditor.PList = PList;
        }
        private void Index_FormClosing( object sender, FormClosingEventArgs e ) {
            PList.Save();
            Properties.Settings.Default.Clear = CB_ClearLyric.Checked;
            Properties.Settings.Default.Sound = CB_Sound.Checked;
            Properties.Settings.Default.Lang = CB_Lang.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }
        private void TextBox_KeyDown( object sender, KeyEventArgs e ) {
            if( e.Modifiers == Keys.Control && e.KeyCode == Keys.A ) {
                ( (TextBox) sender ).SelectAll();
                e.SuppressKeyPress = true;
            } else if( e.Modifiers == Keys.None && e.KeyCode == Keys.Enter ) {
                Converter();
                e.SuppressKeyPress = true;
            }
        }
        private void TextBox_ChangeSize( object sender, MouseEventArgs e ) {
            TextBox tmptextbox = (TextBox) sender;
        }
        private void BTN_Convert_Click( object sender, EventArgs e ) {
            Converter();
        }
        private void CB_Lang_SelectedIndexChanged( object sender, EventArgs e ) {
            ChangeLang( CB_Lang.SelectedItem.ToString() );
        }
        private void TB_CLyric_TextChanged( object sender, EventArgs e ) {
            LyricSeter();
        }
        private void BTN_Save_Click( object sender, EventArgs e ) {
            ODE.Ust.Save();
            this.Close();
        }
        private void BTN_Cancel_Click( object sender, EventArgs e ) {
            this.Close();
        }
        private void BTN_prior_Click( object sender, EventArgs e ) {
            PListEditor.ShowDialog();
        }
        private void BTN_ZoomIn_Click( object sender, EventArgs e ) {
            ODE.ZoomIn();
        }
        private void BTN_ZoomOut_Click( object sender, EventArgs e ) {
            ODE.ZoomOut();
        }
        private void BTN_FixName_Click( object sender, EventArgs e ) {
            Button tmpbutton = (Button) sender;
            string tag = tmpbutton.Tag.ToString();
            string[] tags = tag.Split( new char[] { ',' } );
            ODE.FixName = (PPFixName) Convert.ToInt32( tags[ 0 ] );
            LB_FixNameValue.Text = tags[ 1 ];
            if( CB_Sound.Checked ) {
                Voicer.Play( ODE.FixName );
            }
        }
        private void PN_Egg_Click( object sender, EventArgs e ) {
            Voicer.PlayEgg();
        }
        private void BTN_Import_Click( object sender, EventArgs e ) {
            if( OFD.ShowDialog() == DialogResult.OK ) {
                if( CB_ClearLyric.Checked ) {
                    TB_OLyric.Text = "";
                }
                foreach( string file in OFD.FileNames ) {
                    if( TB_OLyric.Text.Length >= 2 && TB_OLyric.Text.Substring( TB_OLyric.Text.Length - 2, 2 ) != "\r\n" ) {
                        TB_OLyric.Text += "\r\n";
                    }
                    TB_OLyric.Text += File.ReadAllText( file, Functs.GetEncoding( file ) );
                }
            }
        }
        private void LB_Designed_Click( object sender, EventArgs e ) {
            Process.Start( "http://nsysu.ga/Hua777" );
        }
        private void PB_VMLogo_Click( object sender, EventArgs e ) {
            Process.Start( "http://www.voicemith.com/" );
        }
        #endregion

        #region private method
        private void Converter() {
            string output = TB_OLyric.Text;
            if( output != "" ) {
                TB_CLyric.Text = Functs.Han2Pin( output, PList );
            }
        }
        private void ChangeLang( string tag ) {
            switch( tag ) {
                case "繁體中文":
                    Language.Apply( this, "zh-tw" );
                    Language.Apply( PListEditor, "zh-tw" );
                    break;
                case "简体中文":
                    Language.Apply( this, "zh-cn" );
                    Language.Apply( PListEditor, "zh-cn" );
                    break;
                case "日文":
                    Language.Apply( this, "ja-jp" );
                    Language.Apply( PListEditor, "ja-jp" );
                    break;
                default:
                    Language.Apply( this, "en-us" );
                    Language.Apply( PListEditor, "en-us" );
                    break;
            }
        }
        private void LyricSeter() {
            if( ODE.Ust != null ) {
                string output = TB_CLyric.Text;
                if( output != "" ) {
                    string[] newlyric = output.Split( new char[] { ' ' } );
                    int i, j, end1 = newlyric.Length, end2 = ODE.Ust.Count;
                    for( i = 0, j = 0 ; i < end2 && j < end1 ; i++ ) {
                        if( ODE.Ust[ i ].CanEdit ) {
                            ODE.Ust[ i ].ClearlyLyric = newlyric[ j ];
                            j++;
                        }
                    }
                    ODE.ReDraw();
                }
            }
        }
        private void ReadLang() {
            string langfile = "lang";
            if( File.Exists( langfile ) ) {
                string readtoend = File.ReadAllText( langfile, Functs.GetEncoding( langfile ) );
                CB_Lang.SelectedItem = readtoend;
                File.Delete( langfile );
            }
        }
        #endregion
    }
}
