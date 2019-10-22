using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SetLyricInstaller {
    public partial class Index : Form {

        #region constructor
        public Index() {
            InitializeComponent();
        }
        #endregion

        #region private property
        private string PluginName = "Voicemith - SetLyricAbs4 - Release";
        private string PluginZip = "plugin.zip";
        private string Lang = "lang";
        #endregion

        #region event
        private void Index_Load( object sender, EventArgs e ) {
            CB_Lang.SelectedIndex = 0;
            Chooser( FindUtauInstallLocation() );
        }
        private void BTN_Choose_Click( object sender, EventArgs e ) {
            if( FBD.ShowDialog() == DialogResult.OK ) {
                Chooser( FBD.SelectedPath );
            }
        }
        private void BTN_Install_Click( object sender, EventArgs e ) {
            Cursor = Cursors.WaitCursor;
            try {
                string pluginpath = AppendPath( FBD.SelectedPath, "plugins" );
                if( Directory.Exists( pluginpath ) ) {
                    if( CheckFileExist() ) {
                        string f = AppendPath( pluginpath, PluginName );
                        if( Directory.Exists( f ) ) {
                            DirectoryInfo di = new DirectoryInfo( f );
                            di.Delete( true );
                        }
                        string f_lang = AppendPath( f, Lang );
                        string lang = CB_Lang.SelectedItem.ToString();
                        Thread.Sleep( 100 );
                        Directory.CreateDirectory( f );
                        Thread.Sleep( 100 );
                        File.WriteAllText( f_lang, lang, Encoding.Unicode );
                        Thread.Sleep( 100 );
                        UnZipFile( PluginZip, f );
                        Environment.Exit( 0 );
                    }
                } else {
                    if( MessageBox.Show( "Cannot found the plugin folder to install.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error ) == DialogResult.OK ) {
                        Environment.Exit( 1 );
                    }
                }
            } catch( Exception ex ) {
                File.AppendAllText( "error.log", ex.ToString(), Encoding.Unicode );
                if( MessageBox.Show( "Unknown error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error ) == DialogResult.OK ) {
                    Environment.Exit( 2 );
                }
            }
        }
        private void BTN_Cancel_Click( object sender, EventArgs e ) {
            Environment.Exit( 0 );
        }
        #endregion

        #region private method
        private string FindUtauInstallLocation() {
            List<string> UtauInstallLocation = new List<string>();
            UtauInstallLocation.Add( @"C:\Program Files (x86)\UTAU" );
            UtauInstallLocation.Add( @"C:\Program Files\UTAU" );
            UtauInstallLocation.Add( @"C:\UTAU" );
            UtauInstallLocation.Add( @"D:\Program Files (x86)\UTAU" );
            UtauInstallLocation.Add( @"D:\Program Files\UTAU" );
            UtauInstallLocation.Add( @"F:\Program Files (x86)\UTAU" );
            UtauInstallLocation.Add( @"F:\Program Files\UTAU" );
            foreach( string location in UtauInstallLocation ) {
                if( Directory.Exists( location ) ) {
                    return location;
                }
            }
            return @"C:\";
        }
        private void Chooser(string location) {
            FBD.SelectedPath = location;
            TB_UtauInstallLocation.Text = location;
        }
        private string AppendPath( string head, string tail ) {
            if( head != null && tail != null && head.Length > 0 && tail.Length > 0 ) {
                if( head[ head.Length - 1 ] != '\\' && tail[ 0 ] != '\\' ) {
                    head += '\\';
                }
            } else {
                if( head == null ) {
                    head = "";
                }
                if( tail == null ) {
                    tail = "";
                }
            }
            return head + tail;
        }
        private bool CheckFileExist() {
            if( !File.Exists( PluginZip ) ) {
                MessageBox.Show( "You miss zip.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }
            return true;
        }
        #endregion

        #region sample
        private void UnZipFile( string from, string to ) {
            using( ZipFile DotZip = ZipFile.Read( from ) ) {
                DotZip.ExtractAll( to );
            }
        }
        #endregion

    }
}
