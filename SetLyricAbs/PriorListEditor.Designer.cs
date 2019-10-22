namespace SetLyricAbs {
    partial class PriorListEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriorListEditor));
            this.TLP = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Value = new System.Windows.Forms.TextBox();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.LV_PList = new System.Windows.Forms.ListView();
            this.LV_PList_CHKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_PList_CHValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTN_Save = new System.Windows.Forms.Button();
            this.TB_Key = new System.Windows.Forms.TextBox();
            this.FLP_1_R = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_Remove = new System.Windows.Forms.Button();
            this.TLP.SuspendLayout();
            this.FLP_1_R.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP
            // 
            resources.ApplyResources(this.TLP, "TLP");
            this.TLP.Controls.Add(this.TB_Value, 1, 2);
            this.TLP.Controls.Add(this.BTN_Cancel, 1, 3);
            this.TLP.Controls.Add(this.LV_PList, 0, 1);
            this.TLP.Controls.Add(this.BTN_Save, 0, 3);
            this.TLP.Controls.Add(this.TB_Key, 0, 2);
            this.TLP.Controls.Add(this.FLP_1_R, 1, 0);
            this.TLP.Name = "TLP";
            // 
            // TB_Value
            // 
            resources.ApplyResources(this.TB_Value, "TB_Value");
            this.TB_Value.Name = "TB_Value";
            this.TB_Value.Tag = "Value";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.BTN_Cancel, "BTN_Cancel");
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.TabStop = false;
            this.BTN_Cancel.UseVisualStyleBackColor = false;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // LV_PList
            // 
            this.LV_PList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LV_PList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LV_PList_CHKey,
            this.LV_PList_CHValue});
            this.TLP.SetColumnSpan(this.LV_PList, 2);
            resources.ApplyResources(this.LV_PList, "LV_PList");
            this.LV_PList.FullRowSelect = true;
            this.LV_PList.MultiSelect = false;
            this.LV_PList.Name = "LV_PList";
            this.LV_PList.UseCompatibleStateImageBehavior = false;
            this.LV_PList.View = System.Windows.Forms.View.Details;
            this.LV_PList.SelectedIndexChanged += new System.EventHandler(this.LV_PList_SelectedIndexChanged);
            // 
            // LV_PList_CHKey
            // 
            resources.ApplyResources(this.LV_PList_CHKey, "LV_PList_CHKey");
            // 
            // LV_PList_CHValue
            // 
            resources.ApplyResources(this.LV_PList_CHValue, "LV_PList_CHValue");
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.Color.Snow;
            resources.ApplyResources(this.BTN_Save, "BTN_Save");
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.TabStop = false;
            this.BTN_Save.UseVisualStyleBackColor = false;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // TB_Key
            // 
            resources.ApplyResources(this.TB_Key, "TB_Key");
            this.TB_Key.Name = "TB_Key";
            this.TB_Key.Tag = "Key";
            // 
            // FLP_1_R
            // 
            this.FLP_1_R.Controls.Add(this.BTN_Add);
            this.FLP_1_R.Controls.Add(this.BTN_Remove);
            resources.ApplyResources(this.FLP_1_R, "FLP_1_R");
            this.FLP_1_R.Name = "FLP_1_R";
            // 
            // BTN_Add
            // 
            resources.ApplyResources(this.BTN_Add, "BTN_Add");
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_Remove
            // 
            resources.ApplyResources(this.BTN_Remove, "BTN_Remove");
            this.BTN_Remove.Name = "BTN_Remove";
            this.BTN_Remove.UseVisualStyleBackColor = true;
            this.BTN_Remove.Click += new System.EventHandler(this.BTN_Remove_Click);
            // 
            // PriorListEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PriorListEditor";
            this.Load += new System.EventHandler(this.PriorListEditor_Load);
            this.TLP.ResumeLayout(false);
            this.TLP.PerformLayout();
            this.FLP_1_R.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP;
        private System.Windows.Forms.ListView LV_PList;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.TextBox TB_Value;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TextBox TB_Key;
        private System.Windows.Forms.FlowLayoutPanel FLP_1_R;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Remove;
        public System.Windows.Forms.ColumnHeader LV_PList_CHKey;
        public System.Windows.Forms.ColumnHeader LV_PList_CHValue;
    }
}