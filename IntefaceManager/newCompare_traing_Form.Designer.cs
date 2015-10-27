namespace CompareSystem
{
    partial class newCompare_traing_Form
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbShowSelect = new System.Windows.Forms.Label();
            this.listShowTr = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btDeselectAll = new System.Windows.Forms.Button();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.listChkTr = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(474, 303);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(98, 23);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(370, 303);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(98, 23);
            this.btNext.TabIndex = 7;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(266, 303);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(98, 23);
            this.btBack.TabIndex = 9;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Training set list:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Selection :";
            this.label1.Visible = false;
            // 
            // lbShowSelect
            // 
            this.lbShowSelect.AutoSize = true;
            this.lbShowSelect.Location = new System.Drawing.Point(13, 274);
            this.lbShowSelect.Name = "lbShowSelect";
            this.lbShowSelect.Size = new System.Drawing.Size(0, 13);
            this.lbShowSelect.TabIndex = 19;
            // 
            // listShowTr
            // 
            this.listShowTr.FormattingEnabled = true;
            this.listShowTr.Location = new System.Drawing.Point(12, 26);
            this.listShowTr.Name = "listShowTr";
            this.listShowTr.Size = new System.Drawing.Size(264, 225);
            this.listShowTr.TabIndex = 20;
            this.listShowTr.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listShowTr_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDeselectAll);
            this.groupBox1.Controls.Add(this.btSelectAll);
            this.groupBox1.Controls.Add(this.listChkTr);
            this.groupBox1.Location = new System.Drawing.Point(283, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 225);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files :";
            // 
            // btDeselectAll
            // 
            this.btDeselectAll.Location = new System.Drawing.Point(82, 199);
            this.btDeselectAll.Name = "btDeselectAll";
            this.btDeselectAll.Size = new System.Drawing.Size(70, 23);
            this.btDeselectAll.TabIndex = 26;
            this.btDeselectAll.Text = "Deselect all";
            this.btDeselectAll.UseVisualStyleBackColor = true;
            this.btDeselectAll.Click += new System.EventHandler(this.btDeselectAll_Click);
            // 
            // btSelectAll
            // 
            this.btSelectAll.Location = new System.Drawing.Point(11, 199);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(70, 23);
            this.btSelectAll.TabIndex = 25;
            this.btSelectAll.Text = "Select all";
            this.btSelectAll.UseVisualStyleBackColor = true;
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
            // 
            // listChkTr
            // 
            this.listChkTr.FormattingEnabled = true;
            this.listChkTr.Location = new System.Drawing.Point(11, 15);
            this.listChkTr.Name = "listChkTr";
            this.listChkTr.Size = new System.Drawing.Size(267, 184);
            this.listChkTr.TabIndex = 24;
            // 
            // newCompare_traing_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listShowTr);
            this.Controls.Add(this.lbShowSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btNext);
            this.Name = "newCompare_traing_Form";
            this.Text = "New Compare";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbShowSelect;
        private System.Windows.Forms.ListBox listShowTr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btDeselectAll;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.CheckedListBox listChkTr;
    }
}