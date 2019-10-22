using System;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using UTAU.NoteProperty;

namespace UTAU.Tools {
    public class Voicer {
        public static void Play( PPFixName fixname ) {
            Play( VoiceDir + "." + (int) fixname + ".wav" );
        }
        public static void PlayEgg() {
            Play( VoiceDir + "." + EggWav );
        }
        private static void Play(string filepath ) {
            if( Player != null ) {
                Player.Dispose();
                Player = null;
            }
            Assembly a = Assembly.GetExecutingAssembly();
            Stream s = a.GetManifestResourceStream( filepath );
            Player = new SoundPlayer( s );
            Player.Play();
        }

        private static string EggWav = "egg.wav";
        private static string VoiceDir = "UTAU.Resources.Voice";
        private static SoundPlayer Player = new SoundPlayer();
    }
}
