using System;
using System.Windows.Forms;

namespace SetLyricAbs {
    static class Program {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main( string[] args ) {
            try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault( false );
                Application.Run( new Index( args ) );
            } catch(Exception ex) {
                MessageBox.Show( ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
