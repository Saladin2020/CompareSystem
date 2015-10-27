namespace CompareSystem
{
    partial class newCompare_algorithm_Form
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
            this.btBack = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listChkAl = new System.Windows.Forms.CheckedListBox();
            this.btDeselectAll = new System.Windows.Forms.Button();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(58, 303);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(98, 23);
            this.btBack.TabIndex = 12;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(266, 303);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(98, 23);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(162, 303);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(98, 23);
            this.btNext.TabIndex = 10;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listChkAl);
            this.groupBox1.Controls.Add(this.btDeselectAll);
            this.groupBox1.Controls.Add(this.btSelectAll);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 284);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm set list";
            // 
            // listChkAl
            // 
            this.listChkAl.FormattingEnabled = true;
            this.listChkAl.Location = new System.Drawing.Point(7, 20);
            this.listChkAl.Name = "listChkAl";
            this.listChkAl.Size = new System.Drawing.Size(341, 229);
            this.listChkAl.TabIndex = 2;
            // 
            // btDeselectAll
            // 
            this.btDeselectAll.Location = new System.Drawing.Point(64, 249);
            this.btDeselectAll.Name = "btDeselectAll";
            this.btDeselectAll.Size = new System.Drawing.Size(79, 23);
            this.btDeselectAll.TabIndex = 1;
            this.btDeselectAll.Text = "Deselect all";
            this.btDeselectAll.UseVisualStyleBackColor = true;
            this.btDeselectAll.Click += new System.EventHandler(this.btDeselectAll_Click);
            // 
            // btSelectAll
            // 
            this.btSelectAll.Location = new System.Drawing.Point(5, 249);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(59, 23);
            this.btSelectAll.TabIndex = 0;
            this.btSelectAll.Text = "Select all";
            this.btSelectAll.UseVisualStyleBackColor = true;
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
            // 
            // newCompare_algorithm_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btNext);
            this.Name = "newCompare_algorithm_Form";
            this.Text = "New Compare";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btDeselectAll;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.CheckedListBox listChkAl;
    }
}