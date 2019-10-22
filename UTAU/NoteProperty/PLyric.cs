using System;
using UTAU.Tools;

namespace UTAU.NoteProperty {
    [Serializable]
    public struct PLyric {

        #region Constructor
        public PLyric( string lyric ) {
            _ClearlyLyric = lyric;
            _FixName = PPFixName.OutsideObscureSound;
            Parse( lyric );
        }
        #endregion

        #region Public Property
        public string Prefix {
            get {
                return Functs.GetLyricPrefix( _FixName );
            }
        }
        public string Postfix {
            get {
                return Functs.GetLyricPostfix( _FixName );
            }
        }
        public string Lyric {
            get {
                return Prefix + _ClearlyLyric + Postfix;
            }
            set {
                Parse( value );
            }
        }
        public string ClearlyLyric {
            get {
                return _ClearlyLyric;
            }
            set {
                _ClearlyLyric = ParseStr( value );
            }
        }
        public PPFixName FixName {
            get {
                return _FixName;
            }
            set {
                _FixName = value;
            }
        }
        #endregion

        #region Property
        private string _ClearlyLyric;
        private PPFixName _FixName;
        #endregion

        #region Override
        public override string ToString() {
            return Lyric;
        }
        #endregion

        #region Method
        private void Parse( string lyric ) {
            _ClearlyLyric = lyric;
            string prefix = Functs.GetLyricPrefix( _ClearlyLyric );
            string postfix = Functs.GetLyricPostfix( _ClearlyLyric );
            if( prefix != "" ) {
                _ClearlyLyric = _ClearlyLyric.Replace( prefix, "" );
            }
            if( postfix != "" ) {
                _ClearlyLyric = _ClearlyLyric.Replace( postfix, "" );
            }
            _FixName = Functs.GetLyricPPFixName( prefix, postfix );
        }
        private string ParseStr( string lyric ) {
            string tmpclearlyric = lyric;
            string prefix = Functs.GetLyricPrefix( tmpclearlyric );
            string postfix = Functs.GetLyricPostfix( tmpclearlyric );
            if( prefix != "" ) {
                tmpclearlyric = tmpclearlyric.Replace( prefix, "" );
            }
            if( postfix != "" ) {
                tmpclearlyric = tmpclearlyric.Replace( postfix, "" );
            }
            return tmpclearlyric;
        }
        #endregion

        #region Operator
        public static implicit operator PLyric( string lyric ) {
            return new PLyric( lyric );
        }
        public static implicit operator string( PLyric plyric ) {
            return plyric.ToString();
        }
        #endregion

    }

    public enum PPFixName {
        OutsideStrongVowel,
        OutsideObscureSound,
        OutsideFullSound,
        PeaceStrongVowel,
        PeaceObscureSound,
        PeaceFullSound,
        CantoStrongVowel,
        CantoObscureSound,
        CantoFullSound,
        Muffle,
        SpecialDearStrongVowel,
        SpecialDearFullSound,
        NULL
    }
}
