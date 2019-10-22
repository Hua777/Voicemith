using Microsoft.International.Converters.PinYinConverter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UTAU.NoteProperty;

namespace UTAU.Tools {
    public unsafe class Functs {
        public static string RemoveAllSpaces( string source ) {
            return Regex.Replace( source, @"\s+", "" );
        }
        public static string NextLine( string nextline ) {
            if( nextline != null && nextline.Length >= 2 && nextline != "" ) {
                if( nextline.Substring( 0, 2 ) != "\r\n" ) {
                    nextline = "\r\n" + nextline;
                }
            }
            return nextline;
        }
        #region Lyric
        public static string GetLyricPrefix( string lyric ) {
            if( lyric.Length >= 2 && lyric.Substring( 0, 2 ) == "- " ) {
                return "- ";
            } else {
                return "";
            }
        }
        static public string GetLyricPostfix( string lyric ) {
            char[] detect = { '+', '_', '0', '-', '1' };
            int i, j, oriLength = lyric.Length;
            bool find = false;
            for( i = 1 ; i < oriLength ; i++ ) {
                for( j = 0 ; j < detect.Length ; j++ ) {
                    if( lyric[ i ] == detect[ j ] ) {
                        find = true;
                        break;
                    }
                }
                if( find ) {
                    break;
                }
            }
            if( find ) {
                return lyric.Substring( i );
            }
            return "";
        }
        static public PPFixName GetLyricPPFixName( string prefix, string postfix ) {
            if( prefix == "- " && postfix == "" ) {
                return PPFixName.OutsideStrongVowel;
            } else if( prefix == "" && postfix == "" ) {
                return PPFixName.OutsideObscureSound;
            } else if( prefix == "" && postfix == "+" ) {
                return PPFixName.OutsideFullSound;
            } else if( prefix == "- " && postfix == "_i" ) {
                return PPFixName.PeaceStrongVowel;
            } else if( prefix == "" && postfix == "_i" ) {
                return PPFixName.PeaceObscureSound;
            } else if( prefix == "" && postfix == "+_i" ) {
                return PPFixName.PeaceFullSound;
            } else if( prefix == "- " && postfix == "0_iH" ) {
                return PPFixName.CantoStrongVowel;
            } else if( prefix == "" && postfix == "0_iH" ) {
                return PPFixName.CantoObscureSound;
            } else if( prefix == "" && postfix == "+0_iH" ) {
                return PPFixName.CantoFullSound;
            } else if( prefix == "- " && postfix == "-" ) {
                return PPFixName.Muffle;
            } else if( prefix == "- " && postfix == "1" ) {
                return PPFixName.SpecialDearStrongVowel;
            } else if( prefix == "" && postfix == "1" ) {
                return PPFixName.SpecialDearFullSound;
            }
            return PPFixName.NULL;
        }
        static public string GetLyricPrefix( PPFixName ppfn ) {
            switch( ppfn ) {
                case PPFixName.OutsideStrongVowel:
                case PPFixName.PeaceStrongVowel:
                case PPFixName.CantoStrongVowel:
                case PPFixName.Muffle:
                case PPFixName.SpecialDearStrongVowel:
                    return "- ";
            }
            return "";
        }
        static public string GetLyricPostfix( PPFixName ppfn ) {
            switch( ppfn ) {
                case PPFixName.OutsideStrongVowel:
                case PPFixName.OutsideObscureSound:
                    return "";
                case PPFixName.OutsideFullSound:
                    return "+";
                case PPFixName.PeaceStrongVowel:
                case PPFixName.PeaceObscureSound:
                    return "_i";
                case PPFixName.PeaceFullSound:
                    return "+_i";
                case PPFixName.CantoStrongVowel:
                case PPFixName.CantoObscureSound:
                    return "0_iH";
                case PPFixName.CantoFullSound:
                    return "+0_iH";
                case PPFixName.Muffle:
                    return "-";
                case PPFixName.SpecialDearStrongVowel:
                case PPFixName.SpecialDearFullSound:
                    return "1";
            }
            return "";
        }
        static public PPFixName GetChildPPFixName( PPFixName ppfn ) {
            switch( ppfn ) {
                case PPFixName.OutsideStrongVowel:
                case PPFixName.OutsideObscureSound:
                case PPFixName.OutsideFullSound:
                    return PPFixName.OutsideObscureSound;
                case PPFixName.PeaceStrongVowel:
                case PPFixName.PeaceObscureSound:
                case PPFixName.PeaceFullSound:
                    return PPFixName.PeaceObscureSound;
                case PPFixName.CantoStrongVowel:
                case PPFixName.CantoObscureSound:
                case PPFixName.CantoFullSound:
                    return PPFixName.CantoObscureSound;
                case PPFixName.Muffle:
                    return PPFixName.Muffle;
                case PPFixName.SpecialDearStrongVowel:
                case PPFixName.SpecialDearFullSound:
                    return PPFixName.SpecialDearFullSound;
            }
            return PPFixName.NULL;
        }
        #endregion
        public static Bitmap UstTo1D( TmpUst source, UstColor ustcolor, int width, int height, double times, int xscroll ) {
            source.SetOffsetX( times, xscroll );
            int i, end = source.Count;
            Bitmap result = new Bitmap( width, height );
            using( Graphics gresult = Graphics.FromImage( result ) ) {
                gresult.Clear( ustcolor.BgColor );
                SolidBrush onb = ustcolor.OutsideNoteBrush;
                SolidBrush pnb = ustcolor.PeaceNoteBrush;
                SolidBrush cnb = ustcolor.CantoNoteBrush;
                SolidBrush mnb = ustcolor.MuffleNoteBrush;
                SolidBrush rnb = ustcolor.RestNoteBrush;
                Pen nbp = ustcolor.NoteBorderPen;
                Font nlf = ustcolor.NoteLyricFont( height );
                SolidBrush nlb = ustcolor.NoteLyricBrush;
                Size ls = ustcolor.NoteLyricSize( height );
                float x, y = 0, w, h = height;
                float fx;
                for( i = 0 ; i < end ; ++i ) {
                    fx = x = (float) source[ i ].OffsetX;
                    w = (float) ( source[ i ].Length * times );
                    if( x + w >= ls.Width && x < 0 ) {
                        fx = 0;
                    }
                    if( source[ i ].ClearlyLyric == "R" ) {
                        gresult.FillRectangle( rnb, x, y, w, h );
                    } else {
                        switch( source[ i ].FixName ) {
                            case PPFixName.OutsideStrongVowel:
                            case PPFixName.OutsideObscureSound:
                            case PPFixName.OutsideFullSound:
                                gresult.FillRectangle( onb, x, y, w, h );
                                break;
                            case PPFixName.PeaceStrongVowel:
                            case PPFixName.PeaceObscureSound:
                            case PPFixName.PeaceFullSound:
                                gresult.FillRectangle( pnb, x, y, w, h );
                                break;
                            case PPFixName.CantoStrongVowel:
                            case PPFixName.CantoObscureSound:
                            case PPFixName.CantoFullSound:
                                gresult.FillRectangle( cnb, x, y, w, h );
                                break;
                            case PPFixName.Muffle:
                                gresult.FillRectangle( mnb, x, y, w, h );
                                break;
                            default:
                                gresult.FillRectangle( rnb, x, y, w, h );
                                break;
                        }
                    }
                    gresult.DrawRectangle( nbp, x, y, w - 1, h - 1 );
                    gresult.DrawString( source[ i ].Lyric, nlf, nlb, fx, 0 );
                }
                onb.Dispose();
                pnb.Dispose();
                cnb.Dispose();
                mnb.Dispose();
                rnb.Dispose();
                nbp.Dispose();
                nlf.Dispose();
                nlb.Dispose();
            }
            return result;
        }
        public static string Han2Pin( string han, PriorList priorlist ) {
            string onlychinese = MaintainChinese( han );
            int i, end = onlychinese.Length;
            string result = "";
            for( i = 0 ; i < end ; i++ ) {
                if( i != 0 ) {
                    result += " ";
                }
                if( priorlist.HasValue( onlychinese[ i ].ToString() ) ) {
                    result += priorlist[ onlychinese[ i ].ToString() ].ToLower();
                } else {
                    ChineseChar ch = new ChineseChar( onlychinese[ i ] );
                    result += ch.Pinyins[ 0 ].Substring( 0, ch.Pinyins[ 0 ].Length - 1 ).ToLower();
                }
            }
            return result;
        }
        public static bool IsChinese( char anychar ) {
            bool bresult = true;
            int drange = 0;
            int dstringmax = Convert.ToInt32( "9fff", 16 );
            int dstringmin = Convert.ToInt32( "4e00", 16 );
            drange = Convert.ToInt32( anychar );
            if( drange >= dstringmin && drange < dstringmax ) {
                bresult = true;
            } else {
                bresult = false;
            }
            return bresult;
        }
        public static string MaintainChinese( string anystring ) {
            int i, end = anystring.Length;
            string result = "";
            for( i = 0 ; i < end ; i++ ) {
                if( IsChinese( anystring[ i ] ) ) {
                    result += anystring[ i ];
                }
            }
            return result;
        }
        public static Encoding GetEncoding( string filename ) {
            Stream reader = File.Open( filename, FileMode.Open, FileAccess.Read );
            Encoding encoder = null;
            byte[] header = new byte[ 4 ];
            // 讀取前四個Byte
            reader.Read( header, 0, 4 );
            if( header[ 0 ] == 0xFF && header[ 1 ] == 0xFE ) {
                // UniCode File
                reader.Position = 2;
                encoder = Encoding.Unicode;
            } else if( header[ 0 ] == 0xEF && header[ 1 ] == 0xBB && header[ 2 ] == 0xBF ) {
                // UTF-8 File
                reader.Position = 3;
                encoder = Encoding.UTF8;
            } else {
                // Default Encoding File
                reader.Position = 0;
                encoder = Encoding.Default;
            }
            reader.Close();
            return encoder;
        }
    }
    public unsafe class Datas {
        public static string[] NoteProperty = new string[] { "Length", "Lyric", "NoteNum", "Envelope", "PreUtterance", "VoiceOverlap", "StartPoint", "Velocity", "Intensity", "Modulation",
            "Flags", "Label", "Tempo", "PBS", "PBW", "PBY", "PBM", "PBType", "PitchBend", "VBR" };
        public static string[] USTVersionProperty = new string[] { "Version", "Charset" };
        public static string[] USTSettingProperty = new string[] { "Tempo", "Tracks", "ProjectName", "VoiceDir", "OutFile", "CacheDir", "Tool1", "Tool2", "Mode2", "Flags" };

    }
}
