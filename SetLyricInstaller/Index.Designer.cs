namespace SetLyricInstaller {
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
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.TB_UtauInstallLocation = new System.Windows.Forms.TextBox();
            this.BTN_Choose = new System.Windows.Forms.Button();
            this.BTN_Install = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.CB_Lang = new System.Windows.Forms.ComboBox();
            this.LB_Lang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FBD
            // 
            this.FBD.Description = "Your UTAU install location";
            // 
            // TB_UtauInstallLocation
            // 
            this.TB_UtauInstallLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_UtauInstallLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_UtauInstallLocation.Location = new System.Drawing.Point(12, 12);
            this.TB_UtauInstallLocation.Name = "TB_UtauInstallLocation";
            this.TB_UtauInstallLocation.ReadOnly = true;
            this.TB_UtauInstallLocation.Size = new System.Drawing.Size(470, 16);
            this.TB_UtauInstallLocation.TabIndex = 0;
            this.TB_UtauInstallLocation.TabStop = false;
            this.TB_UtauInstallLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTN_Choose
            // 
            this.BTN_Choose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Choose.Location = new System.Drawing.Point(272, 34);
            this.BTN_Choose.Name = "BTN_Choose";
            this.BTN_Choose.Size = new System.Drawing.Size(210, 23);
            this.BTN_Choose.TabIndex = 1;
            this.BTN_Choose.TabStop = false;
            this.BTN_Choose.Text = "Choose Utau Install Location";
            this.BTN_Choose.UseVisualStyleBackColor = true;
            this.BTN_Choose.Click += new System.EventHandler(this.BTN_Choose_Click);
            // 
            // BTN_Install
            // 
            this.BTN_Install.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Install.Location = new System.Drawing.Point(356, 62);
            this.BTN_Install.Name = "BTN_Install";
            this.BTN_Install.Size = new System.Drawing.Size(60, 23);
            this.BTN_Install.TabIndex = 2;
            this.BTN_Install.TabStop = false;
            this.BTN_Install.Text = "Install";
            this.BTN_Install.UseVisualStyleBackColor = true;
            this.BTN_Install.Click += new System.EventHandler(this.BTN_Install_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Cancel.Location = new System.Drawing.Point(422, 62);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(60, 23);
            this.BTN_Cancel.TabIndex = 3;
            this.BTN_Cancel.TabStop = false;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // CB_Lang
            // 
            this.CB_Lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Lang.FormattingEnabled = true;
            this.CB_Lang.Items.AddRange(new object[] {
            "繁體中文",
            "English",
            "简体中文",
            "日文"});
            this.CB_Lang.Location = new System.Drawing.Point(12, 62);
            this.CB_Lang.Name = "CB_Lang";
            this.CB_Lang.Size = new System.Drawing.Size(150, 24);
            this.CB_Lang.TabIndex = 4;
            // 
            // LB_Lang
            // 
            this.LB_Lang.AutoSize = true;
            this.LB_Lang.Location = new System.Drawing.Point(12, 37);
            this.LB_Lang.Name = "LB_Lang";
            this.LB_Lang.Size = new System.Drawing.Size(100, 16);
            this.LB_Lang.TabIndex = 5;
            this.LB_Lang.Text = "Plugin language";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 97);
            this.Controls.Add(this.LB_Lang);
            this.Controls.Add(this.CB_Lang);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Install);
            this.Controls.Add(this.BTN_Choose);
            this.Controls.Add(this.TB_UtauInstallLocation);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installer for windows: Insert Chinese texts into Pin-yin";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.TextBox TB_UtauInstallLocation;
        private System.Windows.Forms.Button BTN_Choose;
        private System.Windows.Forms.Button BTN_Install;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.ComboBox CB_Lang;
        private System.Windows.Forms.Label LB_Lang;
    }
}

