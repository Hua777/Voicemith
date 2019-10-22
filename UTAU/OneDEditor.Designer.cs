namespace UTAU {
    partial class OneDEditor {
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.TLP = new System.Windows.Forms.TableLayoutPanel();
            this.HSB = new System.Windows.Forms.HScrollBar();
            this.PB = new System.Windows.Forms.PictureBox();
            this.TLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // TLP
            // 
            this.TLP.ColumnCount = 1;
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.Controls.Add(this.HSB, 0, 1);
            this.TLP.Controls.Add(this.PB, 0, 0);
            this.TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP.Location = new System.Drawing.Point(0, 0);
            this.TLP.Margin = new System.Windows.Forms.Padding(0);
            this.TLP.Name = "TLP";
            this.TLP.RowCount = 2;
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TLP.Size = new System.Drawing.Size(700, 70);
            this.TLP.TabIndex = 0;
            // 
            // HSB
            // 
            this.HSB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HSB.Location = new System.Drawing.Point(0, 55);
            this.HSB.Name = "HSB";
            this.HSB.Size = new System.Drawing.Size(700, 15);
            this.HSB.SmallChange = 10;
            this.HSB.TabIndex = 0;
            this.HSB.ValueChanged += new System.EventHandler(this.HSB_ValueChanged);
            // 
            // PB
            // 
            this.PB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB.Location = new System.Drawing.Point(0, 0);
            this.PB.Margin = new System.Windows.Forms.Padding(0);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(700, 55);
            this.PB.TabIndex = 1;
            this.PB.TabStop = false;
            this.PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_MouseDown);
            this.PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_MouseMove);
            // 
            // OneDEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TLP);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OneDEditor";
            this.Size = new System.Drawing.Size(700, 70);
            this.Load += new System.EventHandler(this.OneDEditor_Load);
            this.SizeChanged += new System.EventHandler(this.OneDEditor_SizeChanged);
            this.TLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP;
        private System.Windows.Forms.HScrollBar HSB;
        private System.Windows.Forms.PictureBox PB;
    }
}
