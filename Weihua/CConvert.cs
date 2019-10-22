
using Microsoft.International.Converters.PinYinConverter;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Weihua
{
    public class CConvert
    {
        private static Dictionary<string, string> ChineseZhuYin = new Dictionary<string, string>();
        private static bool IsRead = false;

        private static void TransWord(ref string _origin, string _chinese)
        {
            if (ChineseZhuYin.ContainsKey(_chinese))
            {
                _origin = _origin + ChineseZhuYin[_chinese] + " ";
            }
            else if (_chinese == "\r\n" || _chinese == "\n" || _chinese == "\t" || _chinese == "　")
            {
                _origin = _origin.Trim() + "\r\n";
            }
            else
            {
                _origin = _origin + _chinese;
            }
        }

        public static string ToZhuYin(string _chinese)
        {
            if (!IsRead)
            {
                string[] lines = File.ReadAllLines("bopomofo");
                foreach (string line in lines)
                {
                    string[] linedetail = line.Split(new char[] { '=' });
                    if (!ChineseZhuYin.ContainsKey(linedetail[0]))
                    {
                        ChineseZhuYin.Add(linedetail[0], linedetail[1]);
                    }
                }
                IsRead = true;
            }

            string ret = "";
            string buf = "";
            foreach (char c in _chinese)
            {
                string x = c.ToString();
                if (!ChineseZhuYin.ContainsKey(x))
                {
                    TransWord(ref ret, buf);
                    buf = "";
                    TransWord(ref ret, x);
                }
                else if (!ChineseZhuYin.ContainsKey(buf + x))
                {
                    TransWord(ref ret, buf);
                    buf = x;
                }
                else
                {
                    buf = buf + x;
                }
            }
            TransWord(ref ret, buf);
            return Remove(ret.Trim());
        }

        public static string ToPinYin(string _chinese)
        {
            string result = "";
            foreach (char c in _chinese)
            {
                if (ChineseChar.IsValidChar(c))
                {
                    ChineseChar cc = new ChineseChar(c);
                    foreach (string ccp in cc.Pinyins)
                    {
                        if (!string.IsNullOrWhiteSpace(ccp))
                        {
                            result += Regex.Replace(ccp, @"[0-9]", "").ToLower() + " ";
                            break;
                        }
                    }
                }
                else if (c.ToString() == "\r\n" || c.ToString() == "\n" || c.ToString() == "\t" || c.ToString() == "　")
                {
                    result = result.Trim() + "\r\n";
                }
            }
            return Remove(result.Trim());
        }

        private static string Remove(string _chinese)
        {
            while (_chinese.IndexOf("  ") >= 0)
            {
                _chinese = _chinese.Replace("  ", " ");
            }
            return _chinese;
        }
    }

}


