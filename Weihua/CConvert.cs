
using Microsoft.International.Converters.PinYinConverter;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Weihua
{
    public class CConvert
    {
        /// <summary>
        /// 中文轉注音字典
        /// </summary>
        private static readonly Dictionary<string, string> ChineseZhuYin = ReadChineseZhuYinFile();

        /// <summary>
        /// 讀取中文轉注音字典
        /// </summary>
        /// <param name="filename">字典檔案，chinese=zhuyin 此種格式</param>
        /// <returns>字典</returns>
        private static Dictionary<string, string> ReadChineseZhuYinFile(string filename = "bopomofo")
        {
            Dictionary<string, string> tmp = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] linedetail = line.Split(new char[] { '=' });
                if (!tmp.ContainsKey(linedetail[0]))
                {
                    tmp.Add(linedetail[0], linedetail[1]);
                }
            }
            return tmp;
        }

        public static string ToZhuYin(string _chinese)
        {
            List<string> zhuYinList = new List<string>();
            foreach (char c in _chinese)
            {
                string x = c.ToString();
                if (ChineseZhuYin.ContainsKey(x))
                {
                    zhuYinList.Add(ChineseZhuYin[x]);
                }
                else
                {
                    zhuYinList.Add(x);
                }
            }
            string result = string.Join(" ", zhuYinList);
            return ReplaceMultipleSpaceToOneSpace(result);
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
            return ReplaceMultipleSpaceToOneSpace(result.Trim());
        }

        private static string ReplaceMultipleSpaceToOneSpace(string _chinese)
        {
            while (_chinese.IndexOf("  ") >= 0)
            {
                _chinese = _chinese.Replace("  ", " ");
            }
            return _chinese;
        }
    }

}


