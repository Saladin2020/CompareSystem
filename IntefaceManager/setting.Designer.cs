namespace CompareSystem.IntefaceManager
{
    partial class setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.detailSet = new System.Windows.Forms.Label();
            this.btSet = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btPre = new System.Windows.Forms.Button();
            this.btNxt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.settingDetailTb = new System.Windows.Forms.RichTextBox();
            this.gbParam = new System.Windows.Forms.GroupBox();
            this.tvParam = new System.Windows.Forms.TreeView();
            this.gbParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailSet
            // 
            this.detailSet.AutoSize = true;
            this.detailSet.Location = new System.Drawing.Point(10, 16);
            this.detailSet.Name = "detailSet";
            this.detailSet.Size = new System.Drawing.Size(68, 13);
            this.detailSet.TabIndex = 1;
            this.detailSet.Text = "Setting detail";
            // 
            // btSet
            // 
            this.btSet.Location = new System.Drawing.Point(349, 356);
            this.btSet.Name = "btSet";
            this.btSet.Size = new System.Drawing.Size(96, 23);
            this.btSet.TabIndex = 4;
            this.btSet.Text = "OK";
            this.btSet.UseVisualStyleBackColor = true;
            this.btSet.Click += new System.EventHandler(this.btSet_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(349, 327);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(96, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btPre
            // 
            this.btPre.Location = new System.Drawing.Point(349, 3);
            this.btPre.Name = "btPre";
            this.btPre.Size = new System.Drawing.Size(27, 23);
            this.btPre.TabIndex = 8;
            this.btPre.Text = "<";
            this.btPre.UseVisualStyleBackColor = true;
            this.btPre.Click += new System.EventHandler(this.btPre_Click);
            // 
            // btNxt
            // 
            this.btNxt.Location = new System.Drawing.Point(418, 3);
            this.btNxt.Name = "btNxt";
            this.btNxt.Size = new System.Drawing.Size(27, 23);
            this.btNxt.TabIndex = 9;
            this.btNxt.Text = ">";
            this.btNxt.UseVisualStyleBackColor = true;
            this.btNxt.Click += new System.EventHandler(this.btNxt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // settingDetailTb
            // 
            this.settingDetailTb.Enabled = false;
            this.settingDetailTb.Location = new System.Drawing.Point(13, 32);
            this.settingDetailTb.Name = "settingDetailTb";
            this.settingDetailTb.ReadOnly = true;
            this.settingDetailTb.Size = new System.Drawing.Size(432, 137);
            this.settingDetailTb.TabIndex = 0;
            this.settingDetailTb.Text = "";
            // 
            // gbParam
            // 
            this.gbParam.Controls.Add(this.tvParam);
            this.gbParam.Location = new System.Drawing.Point(13, 176);
            this.gbParam.Name = "gbParam";
            this.gbParam.Size = new System.Drawing.Size(330, 203);
            this.gbParam.TabIndex = 12;
            this.gbParam.TabStop = false;
            this.gbParam.Text = "Parameters :";
            // 
            // tvParam
            // 
            this.tvParam.Location = new System.Drawing.Point(11, 19);
            this.tvParam.Name = "tvParam";
            this.tvParam.Size = new System.Drawing.Size(313, 178);
            this.tvParam.TabIndex = 14;
            this.tvParam.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvParam_NodeMouseDoubleClick);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 392);
            this.Controls.Add(this.gbParam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btNxt);
            this.Controls.Add(this.btPre);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSet);
            this.Controls.Add(this.detailSet);
            this.Controls.Add(this.settingDetailTb);
            this.Name = "Setting";
            this.Text = "Setting";
            this.gbParam.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label detailSet;
        private System.Windows.Forms.Button btSet;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btPre;
        private System.Windows.Forms.Button btNxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox settingDetailTb;
        private System.Windows.Forms.GroupBox gbParam;
        private System.Windows.Forms.TreeView tvParam;
    }
}