﻿namespace SetLyricAbs {
    partial class Index {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.PN_Top = new System.Windows.Forms.Panel();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_prior = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Import = new System.Windows.Forms.Button();
            this.CB_Lang = new System.Windows.Forms.ComboBox();
            this.CB_Sound = new System.Windows.Forms.CheckBox();
            this.CB_ClearLyric = new System.Windows.Forms.CheckBox();
            this.PN_Lyric = new System.Windows.Forms.Panel();
            this.BTN_Convert = new System.Windows.Forms.Button();
            this.TB_CLyric = new System.Windows.Forms.TextBox();
            this.TB_OLyric = new System.Windows.Forms.TextBox();
            this.GB_3 = new System.Windows.Forms.GroupBox();
            this.PB_VMLogo = new System.Windows.Forms.PictureBox();
            this.BTN_FixName_M = new System.Windows.Forms.Button();
            this.GB_3_2 = new System.Windows.Forms.GroupBox();
            this.GB_3_2_2 = new System.Windows.Forms.GroupBox();
            this.BTN_FixName_CC = new System.Windows.Forms.Button();
            this.BTN_FixName_CM = new System.Windows.Forms.Button();
            this.BTN_FixName_CS = new System.Windows.Forms.Button();
            this.GB_3_2_1 = new System.Windows.Forms.GroupBox();
            this.PN_Egg = new System.Windows.Forms.Panel();
            this.BTN_FixName_PC = new System.Windows.Forms.Button();
            this.BTN_FixName_PM = new System.Windows.Forms.Button();
            this.BTN_FixName_PS = new System.Windows.Forms.Button();
            this.GB_3_1 = new System.Windows.Forms.GroupBox();
            this.LB_Designed = new System.Windows.Forms.Label();
            this.BTN_FixName_OC = new System.Windows.Forms.Button();
            this.BTN_FixName_OM = new System.Windows.Forms.Button();
            this.BTN_FixName_OS = new System.Windows.Forms.Button();
            this.PN_Info = new System.Windows.Forms.Panel();
            this.BTN_ZoomIn = new System.Windows.Forms.Button();
            this.BTN_ZoomOut = new System.Windows.Forms.Button();
            this.LB_FixNameKey = new System.Windows.Forms.Label();
            this.LB_FixNameValue = new System.Windows.Forms.Label();
            this.ODE = new UTAU.OneDEditor();
            this.PN_Top.SuspendLayout();
            this.PN_Lyric.SuspendLayout();
            this.GB_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_VMLogo)).BeginInit();
            this.GB_3_2.SuspendLayout();
            this.GB_3_2_2.SuspendLayout();
            this.GB_3_2_1.SuspendLayout();
            this.GB_3_1.SuspendLayout();
            this.PN_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // OFD
            // 
            resources.ApplyResources(this.OFD, "OFD");
            this.OFD.Multiselect = true;
            // 
            // PN_Top
            // 
            resources.ApplyResources(this.PN_Top, "PN_Top");
            this.PN_Top.Controls.Add(this.BTN_Save);
            this.PN_Top.Controls.Add(this.BTN_prior);
            this.PN_Top.Controls.Add(this.BTN_Cancel);
            this.PN_Top.Controls.Add(this.BTN_Import);
            this.PN_Top.Controls.Add(this.CB_Lang);
            this.PN_Top.Controls.Add(this.CB_Sound);
            this.PN_Top.Controls.Add(this.CB_ClearLyric);
            this.PN_Top.Name = "PN_Top";
            // 
            // BTN_Save
            // 
            resources.ApplyResources(this.BTN_Save, "BTN_Save");
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.TabStop = false;
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_prior
            // 
            resources.ApplyResources(this.BTN_prior, "BTN_prior");
            this.BTN_prior.Name = "BTN_prior";
            this.BTN_prior.TabStop = false;
            this.BTN_prior.UseVisualStyleBackColor = true;
            this.BTN_prior.Click += new System.EventHandler(this.BTN_prior_Click);
            // 
            // BTN_Cancel
            // 
            resources.ApplyResources(this.BTN_Cancel, "BTN_Cancel");
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.TabStop = false;
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Import
            // 
            resources.ApplyResources(this.BTN_Import, "BTN_Import");
            this.BTN_Import.Name = "BTN_Import";
            this.BTN_Import.TabStop = false;
            this.BTN_Import.UseVisualStyleBackColor = true;
            this.BTN_Import.Click += new System.EventHandler(this.BTN_Import_Click);
            // 
            // CB_Lang
            // 
            resources.ApplyResources(this.CB_Lang, "CB_Lang");
            this.CB_Lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Lang.FormattingEnabled = true;
            this.CB_Lang.Items.AddRange(new object[] {
            resources.GetString("CB_Lang.Items"),
            resources.GetString("CB_Lang.Items1"),
            resources.GetString("CB_Lang.Items2"),
            resources.GetString("CB_Lang.Items3")});
            this.CB_Lang.Name = "CB_Lang";
            this.CB_Lang.TabStop = false;
            this.CB_Lang.SelectedIndexChanged += new System.EventHandler(this.CB_Lang_SelectedIndexChanged);
            // 
            // CB_Sound
            // 
            resources.ApplyResources(this.CB_Sound, "CB_Sound");
            this.CB_Sound.Checked = true;
            this.CB_Sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Sound.Name = "CB_Sound";
            this.CB_Sound.TabStop = false;
            this.CB_Sound.UseVisualStyleBackColor = true;
            // 
            // CB_ClearLyric
            // 
            resources.ApplyResources(this.CB_ClearLyric, "CB_ClearLyric");
            this.CB_ClearLyric.Checked = true;
            this.CB_ClearLyric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_ClearLyric.Name = "CB_ClearLyric";
            this.CB_ClearLyric.TabStop = false;
            this.CB_ClearLyric.UseVisualStyleBackColor = true;
            // 
            // PN_Lyric
            // 
            resources.ApplyResources(this.PN_Lyric, "PN_Lyric");
            this.PN_Lyric.Controls.Add(this.BTN_Convert);
            this.PN_Lyric.Controls.Add(this.TB_CLyric);
            this.PN_Lyric.Controls.Add(this.TB_OLyric);
            this.PN_Lyric.Name = "PN_Lyric";
            // 
            // BTN_Convert
            // 
            resources.ApplyResources(this.BTN_Convert, "BTN_Convert");
            this.BTN_Convert.Name = "BTN_Convert";
            this.BTN_Convert.TabStop = false;
            this.BTN_Convert.UseVisualStyleBackColor = true;
            this.BTN_Convert.Click += new System.EventHandler(this.BTN_Convert_Click);
            // 
            // TB_CLyric
            // 
            resources.ApplyResources(this.TB_CLyric, "TB_CLyric");
            this.TB_CLyric.Name = "TB_CLyric";
            this.TB_CLyric.Tag = "C";
            this.TB_CLyric.TextChanged += new System.EventHandler(this.TB_CLyric_TextChanged);
            // 
            // TB_OLyric
            // 
            resources.ApplyResources(this.TB_OLyric, "TB_OLyric");
            this.TB_OLyric.Name = "TB_OLyric";
            this.TB_OLyric.Tag = "O";
            // 
            // GB_3
            // 
            resources.ApplyResources(this.GB_3, "GB_3");
            this.GB_3.Controls.Add(this.PB_VMLogo);
            this.GB_3.Controls.Add(this.BTN_FixName_M);
            this.GB_3.Controls.Add(this.GB_3_2);
            this.GB_3.Controls.Add(this.GB_3_1);
            this.GB_3.Name = "GB_3";
            this.GB_3.TabStop = false;
            // 
            // PB_VMLogo
            // 
            resources.ApplyResources(this.PB_VMLogo, "PB_VMLogo");
            this.PB_VMLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_VMLogo.Image = global::SetLyricAbs.Properties.Resources.voicemithsm;
            this.PB_VMLogo.Name = "PB_VMLogo";
            this.PB_VMLogo.TabStop = false;
            this.PB_VMLogo.Click += new System.EventHandler(this.PB_VMLogo_Click);
            // 
            // BTN_FixName_M
            // 
            resources.ApplyResources(this.BTN_FixName_M, "BTN_FixName_M");
            this.BTN_FixName_M.Name = "BTN_FixName_M";
            this.BTN_FixName_M.TabStop = false;
            this.BTN_FixName_M.Tag = "9,Inside voice bank Muffle";
            this.BTN_FixName_M.UseVisualStyleBackColor = true;
            this.BTN_FixName_M.Click += new System.EventHandler(this.BTN_FixName_Click);
            // 
            // GB_3_2
            // 
            resources.ApplyResources(this.GB_3_2, "GB_3_2");
            this.GB_3_2.Controls.Add(this.GB_3_2_2);
            this.GB_3_2.Controls.Add(this.GB_3_2_1);
            this.GB_3_2.Name = "GB_3_2";
            this.GB_3_2.TabStop = false;
            // 
            // GB_3_2_2
            // 
            resources.ApplyResources(this.GB_3_2_2, "GB_3_2_2");
            this.GB_3_2_2.Controls.Add(this.BTN_FixName_CC);
            this.GB_3_2_2.Controls.Add(this.BTN_FixName_CM);
            this.GB_3_2_2.Controls.Add(this.BTN_FixName_CS);
            this.GB_3_2_2.Name = "GB_3_2_2";
            this.GB_3_2_2.TabStop = false;
            // 
            // BTN_FixName_CC
            // 
            resources.ApplyResources(this.BTN_FixName_CC, "BTN_FixName_CC");
            this.BTN_FixName_CC.Name = "BTN_FixName_CC";
            this.BTN_FixName_CC.TabStop = false;
            this.BTN_FixName_CC.Tag = "8,Inside voice bank Canto Complete";
            this.BTN_FixName_CC.UseVisualStyleBackColor = true;
            this.BTN_FixName_CC.Click += new System.EventHandler(this.BTN_FixName_Click);
            // 
            // BTN_FixName_CM
            // 
            resources.ApplyResources(this.BTN_FixName_CM, "BTN_FixName_CM");
            this.BTN_FixName_CM.Name = "BTN_FixName_CM";
            this.BTN_FixName_CM.TabStop = false;
            this.BTN_FixName_CM.Tag = "7,Inside voice bank Canto Middle";
            this.BTN_FixName_CM.UseVisualStyleBackColor = true;
            this.BTN_FixName_CM.Click += new System.EventHandler(this.BTN_FixName_Click);
            // 
            // BTN_FixName_CS
            // 
            resources.ApplyResources(this.BTN_FixName_CS, "BTN_FixName_CS");
            this.BTN_FixName_CS.Name = "BTN_FixName_CS";
            this.BTN_FixName_CS.TabStop = false;
            this.BTN_FixName_CS.Tag = "6,Inside voice bank Canto Start";
            this.BTN_FixName_CS.UseVisualStyleBackColor = true;
            this.BTN_FixName_CS.Click += new System.EventHandler(this.BTN_FixName_Click);
            // 
            // GB_3_2_1
            // 
            resources.ApplyResources(this.GB_3_2_1, "GB_3_2_1");
            this.GB_3_2_1.Controls.Add(this.PN_Egg);
            this.GB_3_2_1.Controls.Add(this.BTN_FixName_PC);
            this.GB_3_2_1.Controls.Add(this.BTN_FixName_PM);
            this.GB_3_2_1.Controls.Add(this.BTN_FixName_PS);
            this.GB_3_2_1.Name = "GB_3_2_1";
            this.GB_3_2_1.TabStop = false;
            // 
            // PN_Egg
            // 
            resources.ApplyResources(this.PN_Egg, "PN_Egg");
            this.PN_Egg.Name = "PN_Egg";
            this.PN_Egg.Click += new System.EventHandler(this.PN_Egg_Click);
            // 
            // BTN_FixName_PC
            // 
            resources.ApplyResources(this.BTN_FixName_PC, "BTN_FixName_PC");
            this.BTN_FixName_PC.Name = "BTN_FixName_PC";
            this.BTN_FixName_PC.TabStop = false;
            this.BTN_FixName_PC.Tag = "5,Inside voice bank Peace Complete";
            this.BTN_FixName_PC.UseVisualStyleBackColor = true;
            this.BTN_FixName_PC.Click += new System.EventHandler(this.BTN_FixName_Click);
            // 
            // BTN_FixName_PM
            // 
            resources.ApplyResources(this.BTN_FixName_PM, "BTN_FixName_PM");
            this.BTN_FixName_PM.Name = "BTN_FixName_PM";
            this.BTN_FixName_PM.TabStop = false;
            this.BTN_FixName_PM.Tag = "4,Inside voice bank Peace Middle";
            this.BTN_FixName_PM.UseVisualStyleBackColor = true;
            this.BTN_FixName_PM.Click += new System.EventHandler(this.BTN_FixName_Click);
            // 
            // BTN_FixName_PS
            // 
            resources.ApplyResources(this.BTN_FixName_PS, "BTN_FixName_PS");
            this.BTN_FixName_PS.Name = "BTN_FixName_PS";
            this.BTN_FixName_PS.TabStop = false;
            this.BTN_FixName_PS.Tag = "3,Inside voice bank Peace Start";
            this.BTN_FixName_PS.UseVisualStyleBackColor = true;
            this.BTN_FixName_PS.Click += new System.EventHandler(this.BTN_FixName_Click);
            // 
            // GB_3_1
            // 
            resources.ApplyResources(this.GB_3_1, "GB_3_1");
            this.GB_3_1.Controls.Add(this.LB_Designed);
            this.GB_3_1.Controls.Add(this.BTN_FixName_OC);
            this.GB_3_1.Controls.Add(this.BTN_FixName_OM);
            this.GB_3_1.Controls.Add(this.BTN_FixName_OS);
            this.GB_3_1.Name = "GB_3_1";
            this.GB_3_1.TabStop = false;
            // 
            // LB_Designed
            // 
            resources.ApplyResources(this.LB_Designed, "LB_Designed");
            this.LB_Designed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_Designed.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LB_Designed.Name = "LB_Designed";
            this.LB_Designed.Click += new System.EventHandler(this.LB_Designed_Click);
            // 
            // BTN_FixName_OC
            // 
            resources.ApplyResources(this.BTN_FixName_OC, "BTN_FixName_OC");
            this.BTN_FixName_OC.Name = "BTN_FixName_OC";
            this.BTN_FixName_OC.TabStop = false;
            this.BTN_FixName_OC.Tag = "2,Outside voice bank Complete";
            this.BTN_FixName_OC.UseVisualStyleBackColor = true;
            this.BTN_FixName_OC.Click += new System.EventHandler(this.BTN_FixName_Click);
            // 
            // BTN_FixName_OM
            // 
            resources.ApplyResources(this.BTN_FixName_OM, "BTN_FixName_OM");
            this.BTN_FixName_OM.Name = "BTN_FixName_OM";
            this.BTN_FixName_OM.TabStop = false;
            this.BTN_FixName_OM.Tag = "1,Outside voice bank Middle";
            this.BTN_FixName_OM.UseVisualStyleBackColor = true;
            this.BTN_FixName_OM.Click += new System.EventHandler(this.BTN_FixName_Click);
            // 
            // BTN_FixName_OS
            // 
            resources.ApplyResources(this.BTN_FixName_OS, "BTN_FixName_OS");
            this.BTN_FixName_OS.Name = "BTN_FixName_OS";
            this.BTN_FixName_OS.TabStop = false;
            this.BTN_FixName_OS.Tag = "0,Outside voice bank Start";
            this.BTN_FixName_OS.UseVisualStyleBackColor = true;
            this.BTN_FixName_OS.Click += new System.EventHandler(this.BTN_FixName_Click);
            // 
            // PN_Info
            // 
            resources.ApplyResources(this.PN_Info, "PN_Info");
            this.PN_Info.Controls.Add(this.BTN_ZoomIn);
            this.PN_Info.Controls.Add(this.BTN_ZoomOut);
            this.PN_Info.Controls.Add(this.LB_FixNameKey);
            this.PN_Info.Controls.Add(this.LB_FixNameValue);
            this.PN_Info.Name = "PN_Info";
            // 
            // BTN_ZoomIn
            // 
            resources.ApplyResources(this.BTN_ZoomIn, "BTN_ZoomIn");
            this.BTN_ZoomIn.BackColor = System.Drawing.Color.White;
            this.BTN_ZoomIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ZoomIn.Name = "BTN_ZoomIn";
            this.BTN_ZoomIn.TabStop = false;
            this.BTN_ZoomIn.UseVisualStyleBackColor = false;
            this.BTN_ZoomIn.Click += new System.EventHandler(this.BTN_ZoomIn_Click);
            // 
            // BTN_ZoomOut
            // 
            resources.ApplyResources(this.BTN_ZoomOut, "BTN_ZoomOut");
            this.BTN_ZoomOut.BackColor = System.Drawing.Color.White;
            this.BTN_ZoomOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ZoomOut.Name = "BTN_ZoomOut";
            this.BTN_ZoomOut.TabStop = false;
            this.BTN_ZoomOut.UseVisualStyleBackColor = false;
            this.BTN_ZoomOut.Click += new System.EventHandler(this.BTN_ZoomOut_Click);
            // 
            // LB_FixNameKey
            // 
            resources.ApplyResources(this.LB_FixNameKey, "LB_FixNameKey");
            this.LB_FixNameKey.Name = "LB_FixNameKey";
            // 
            // LB_FixNameValue
            // 
            resources.ApplyResources(this.LB_FixNameValue, "LB_FixNameValue");
            this.LB_FixNameValue.Name = "LB_FixNameValue";
            // 
            // ODE
            // 
            resources.ApplyResources(this.ODE, "ODE");
            this.ODE.Name = "ODE";
            this.ODE.Ust = null;
            this.ODE.XScroll = 0;
            // 
            // Index
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ODE);
            this.Controls.Add(this.PN_Info);
            this.Controls.Add(this.GB_3);
            this.Controls.Add(this.PN_Lyric);
            this.Controls.Add(this.PN_Top);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Index";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Index_FormClosing);
            this.Load += new System.EventHandler(this.Index_Load);
            this.PN_Top.ResumeLayout(false);
            this.PN_Top.PerformLayout();
            this.PN_Lyric.ResumeLayout(false);
            this.PN_Lyric.PerformLayout();
            this.GB_3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_VMLogo)).EndInit();
            this.GB_3_2.ResumeLayout(false);
            this.GB_3_2_2.ResumeLayout(false);
            this.GB_3_2_1.ResumeLayout(false);
            this.GB_3_1.ResumeLayout(false);
            this.GB_3_1.PerformLayout();
            this.PN_Info.ResumeLayout(false);
            this.PN_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Panel PN_Top;
        private System.Windows.Forms.CheckBox CB_ClearLyric;
        private System.Windows.Forms.CheckBox CB_Sound;
        private System.Windows.Forms.ComboBox CB_Lang;
        private System.Windows.Forms.Button BTN_Import;
        private System.Windows.Forms.Button BTN_prior;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Panel PN_Lyric;
        private System.Windows.Forms.TextBox TB_OLyric;
        private System.Windows.Forms.TextBox TB_CLyric;
        private System.Windows.Forms.Button BTN_Convert;
        private System.Windows.Forms.GroupBox GB_3;
        private System.Windows.Forms.GroupBox GB_3_1;
        private System.Windows.Forms.GroupBox GB_3_2;
        private System.Windows.Forms.GroupBox GB_3_2_1;
        private System.Windows.Forms.GroupBox GB_3_2_2;
        private System.Windows.Forms.Button BTN_FixName_M;
        private System.Windows.Forms.Button BTN_FixName_CC;
        private System.Windows.Forms.Button BTN_FixName_CM;
        private System.Windows.Forms.Button BTN_FixName_CS;
        private System.Windows.Forms.Button BTN_FixName_PC;
        private System.Windows.Forms.Button BTN_FixName_PM;
        private System.Windows.Forms.Button BTN_FixName_PS;
        private System.Windows.Forms.Button BTN_FixName_OC;
        private System.Windows.Forms.Button BTN_FixName_OM;
        private System.Windows.Forms.Button BTN_FixName_OS;
        private System.Windows.Forms.Label LB_Designed;
        private System.Windows.Forms.Panel PN_Egg;
        private System.Windows.Forms.PictureBox PB_VMLogo;
        private System.Windows.Forms.Panel PN_Info;
        private System.Windows.Forms.Label LB_FixNameKey;
        private System.Windows.Forms.Label LB_FixNameValue;
        private System.Windows.Forms.Button BTN_ZoomIn;
        private System.Windows.Forms.Button BTN_ZoomOut;
        private UTAU.OneDEditor ODE;
    }
}

