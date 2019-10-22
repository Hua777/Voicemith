namespace ChineseConverter
{
    partial class ChineseConverter
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChineseConverter));
            this.TLP = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.TB_Origin = new System.Windows.Forms.TextBox();
            this.BTN_Convert = new System.Windows.Forms.Button();
            this.CB_Clear = new System.Windows.Forms.CheckBox();
            this.TLP_RightTop = new System.Windows.Forms.TableLayoutPanel();
            this.LB_PinYin = new System.Windows.Forms.Label();
            this.LB_ZhuYin = new System.Windows.Forms.Label();
            this.TB_ConvertType = new System.Windows.Forms.TrackBar();
            this.LB_CopyRight = new System.Windows.Forms.Label();
            this.TLP.SuspendLayout();
            this.TLP_RightTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_ConvertType)).BeginInit();
            this.SuspendLayout();
            // 
            // TLP
            // 
            this.TLP.ColumnCount = 3;
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP.Controls.Add(this.TB_Result, 2, 1);
            this.TLP.Controls.Add(this.TB_Origin, 0, 1);
            this.TLP.Controls.Add(this.BTN_Convert, 1, 1);
            this.TLP.Controls.Add(this.CB_Clear, 0, 0);
            this.TLP.Controls.Add(this.TLP_RightTop, 2, 0);
            this.TLP.Controls.Add(this.LB_CopyRight, 2, 2);
            this.TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP.Location = new System.Drawing.Point(0, 0);
            this.TLP.Margin = new System.Windows.Forms.Padding(0);
            this.TLP.Name = "TLP";
            this.TLP.RowCount = 3;
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TLP.Size = new System.Drawing.Size(1184, 461);
            this.TLP.TabIndex = 0;
            // 
            // TB_Result
            // 
            this.TB_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Result.Location = new System.Drawing.Point(655, 28);
            this.TB_Result.Multiline = true;
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_Result.Size = new System.Drawing.Size(526, 405);
            this.TB_Result.TabIndex = 5;
            this.TB_Result.TabStop = false;
            this.TB_Result.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_SelectAll);
            // 
            // TB_Origin
            // 
            this.TB_Origin.AllowDrop = true;
            this.TB_Origin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Origin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Origin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TB_Origin.Location = new System.Drawing.Point(3, 28);
            this.TB_Origin.Multiline = true;
            this.TB_Origin.Name = "TB_Origin";
            this.TB_Origin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_Origin.Size = new System.Drawing.Size(526, 405);
            this.TB_Origin.TabIndex = 0;
            this.TB_Origin.TabStop = false;
            this.TB_Origin.DragDrop += new System.Windows.Forms.DragEventHandler(this.TB_Origin_DragDrop);
            this.TB_Origin.DragEnter += new System.Windows.Forms.DragEventHandler(this.TB_Origin_DragEnter);
            this.TB_Origin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_SelectAll);
            // 
            // BTN_Convert
            // 
            this.BTN_Convert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Convert.Location = new System.Drawing.Point(535, 28);
            this.BTN_Convert.Name = "BTN_Convert";
            this.BTN_Convert.Size = new System.Drawing.Size(114, 405);
            this.BTN_Convert.TabIndex = 6;
            this.BTN_Convert.TabStop = false;
            this.BTN_Convert.Text = "轉換";
            this.BTN_Convert.UseVisualStyleBackColor = true;
            this.BTN_Convert.Click += new System.EventHandler(this.BTN_Convert_Click);
            // 
            // CB_Clear
            // 
            this.CB_Clear.AutoSize = true;
            this.CB_Clear.Location = new System.Drawing.Point(3, 3);
            this.CB_Clear.Name = "CB_Clear";
            this.CB_Clear.Size = new System.Drawing.Size(183, 19);
            this.CB_Clear.TabIndex = 7;
            this.CB_Clear.TabStop = false;
            this.CB_Clear.Text = "拉入檔案時，清空原有歌詞。";
            this.CB_Clear.UseVisualStyleBackColor = true;
            // 
            // TLP_RightTop
            // 
            this.TLP_RightTop.ColumnCount = 3;
            this.TLP_RightTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLP_RightTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_RightTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLP_RightTop.Controls.Add(this.LB_PinYin, 2, 0);
            this.TLP_RightTop.Controls.Add(this.LB_ZhuYin, 0, 0);
            this.TLP_RightTop.Controls.Add(this.TB_ConvertType, 1, 0);
            this.TLP_RightTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_RightTop.Location = new System.Drawing.Point(652, 0);
            this.TLP_RightTop.Margin = new System.Windows.Forms.Padding(0);
            this.TLP_RightTop.Name = "TLP_RightTop";
            this.TLP_RightTop.RowCount = 1;
            this.TLP_RightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_RightTop.Size = new System.Drawing.Size(532, 25);
            this.TLP_RightTop.TabIndex = 8;
            // 
            // LB_PinYin
            // 
            this.LB_PinYin.AutoSize = true;
            this.LB_PinYin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_PinYin.Location = new System.Drawing.Point(485, 0);
            this.LB_PinYin.Name = "LB_PinYin";
            this.LB_PinYin.Size = new System.Drawing.Size(44, 25);
            this.LB_PinYin.TabIndex = 2;
            this.LB_PinYin.Text = "拼音";
            this.LB_PinYin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_ZhuYin
            // 
            this.LB_ZhuYin.AutoSize = true;
            this.LB_ZhuYin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_ZhuYin.Location = new System.Drawing.Point(3, 0);
            this.LB_ZhuYin.Name = "LB_ZhuYin";
            this.LB_ZhuYin.Size = new System.Drawing.Size(44, 25);
            this.LB_ZhuYin.TabIndex = 0;
            this.LB_ZhuYin.Text = "注音";
            this.LB_ZhuYin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_ConvertType
            // 
            this.TB_ConvertType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_ConvertType.LargeChange = 1;
            this.TB_ConvertType.Location = new System.Drawing.Point(50, 0);
            this.TB_ConvertType.Margin = new System.Windows.Forms.Padding(0);
            this.TB_ConvertType.Maximum = 1;
            this.TB_ConvertType.Name = "TB_ConvertType";
            this.TB_ConvertType.Size = new System.Drawing.Size(432, 25);
            this.TB_ConvertType.TabIndex = 3;
            this.TB_ConvertType.TabStop = false;
            // 
            // LB_CopyRight
            // 
            this.LB_CopyRight.AutoSize = true;
            this.LB_CopyRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_CopyRight.Location = new System.Drawing.Point(652, 436);
            this.LB_CopyRight.Margin = new System.Windows.Forms.Padding(0);
            this.LB_CopyRight.Name = "LB_CopyRight";
            this.LB_CopyRight.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.LB_CopyRight.Size = new System.Drawing.Size(532, 25);
            this.LB_CopyRight.TabIndex = 9;
            this.LB_CopyRight.Text = "©2017 Hua777, Inc.";
            this.LB_CopyRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChineseConverter
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.TLP);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1200, 500);
            this.Name = "ChineseConverter";
            this.Text = "中文字轉換";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChineseConverter_FormClosing);
            this.Load += new System.EventHandler(this.ChineseConverter_Load);
            this.TLP.ResumeLayout(false);
            this.TLP.PerformLayout();
            this.TLP_RightTop.ResumeLayout(false);
            this.TLP_RightTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_ConvertType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP;
        private System.Windows.Forms.TextBox TB_Origin;
        private System.Windows.Forms.TextBox TB_Result;
        private System.Windows.Forms.Button BTN_Convert;
        private System.Windows.Forms.CheckBox CB_Clear;
        private System.Windows.Forms.TableLayoutPanel TLP_RightTop;
        private System.Windows.Forms.Label LB_PinYin;
        private System.Windows.Forms.Label LB_ZhuYin;
        private System.Windows.Forms.TrackBar TB_ConvertType;
        private System.Windows.Forms.Label LB_CopyRight;
    }
}

