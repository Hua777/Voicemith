using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChineseConverter
{
    public partial class ChineseConverter : Form
    {
        public ChineseConverter()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private Thread ConvertThread = null;

        private void ChineseConverter_Load(object sender, EventArgs e)
        {
            CB_Clear.Checked = Properties.Settings.Default.Clear;
            TB_ConvertType.Value = Properties.Settings.Default.ConvertType;
        }

        private void ChineseConverter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ConvertThread != null)
            {
                ConvertThread.Abort();
                ConvertThread = null;
            }
            Properties.Settings.Default.Clear = CB_Clear.Checked;
            Properties.Settings.Default.ConvertType = TB_ConvertType.Value;
            Properties.Settings.Default.Save();
        }

        private void BTN_Convert_Click(object sender, EventArgs e)
        {
            if (ConvertThread != null)
            {
                ConvertThread.Abort();
                ConvertThread = null;
            }
            ConvertThread = new Thread(Convert);
            ConvertThread.Start();
        }

        private void Convert()
        {
            try
            {
                Enabled = false;
                string getstring = null;
                if (TB_ConvertType.Value == 0)
                {
                    getstring = Weihua.CConvert.ToZhuYin(TB_Origin.Text);
                }
                else if (TB_ConvertType.Value == 1)
                {
                    getstring = Weihua.CConvert.ToPinYin(TB_Origin.Text);
                }
                Enabled = true;
                TB_Result.Text = getstring;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Enabled = true;
            }
        }

        private void TB_Origin_DragDrop(object sender, DragEventArgs e)
        {
            string[] filelist = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string s = "";
            foreach (string file in filelist)
            {
                s += File.ReadAllText(file, GetEncoding(file)) + "\r\n";
            }
            if (CB_Clear.Checked)
            {
                TB_Origin.Text = s;
            }
            else
            {
                TB_Origin.Text += s;
            }
        }

        private void TB_Origin_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void TB_SelectAll(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
                e.SuppressKeyPress = true;
            }
        }

        public static Encoding GetEncoding(string filename)
        {
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode;
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode;
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.Default;
        }
    }
}
