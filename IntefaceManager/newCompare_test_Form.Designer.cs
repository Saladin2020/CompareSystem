namespace CompareSystem
{
    partial class newCompare_test_Form
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
            this.btAdd = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.btDeselectAll = new System.Windows.Forms.Button();
            this.chkBlist = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(474, 14);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(98, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(370, 300);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(98, 23);
            this.btNext.TabIndex = 5;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(474, 300);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(98, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(474, 43);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(98, 23);
            this.btRemove.TabIndex = 7;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBlist);
            this.groupBox1.Controls.Add(this.btDeselectAll);
            this.groupBox1.Controls.Add(this.btSelectAll);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 281);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Testing list";
            // 
            // btSelectAll
            // 
            this.btSelectAll.Location = new System.Drawing.Point(7, 252);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(59, 23);
            this.btSelectAll.TabIndex = 0;
            this.btSelectAll.Text = "Select all";
            this.btSelectAll.UseVisualStyleBackColor = true;
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
            // 
            // btDeselectAll
            // 
            this.btDeselectAll.Location = new System.Drawing.Point(67, 252);
            this.btDeselectAll.Name = "btDeselectAll";
            this.btDeselectAll.Size = new System.Drawing.Size(71, 23);
            this.btDeselectAll.TabIndex = 1;
            this.btDeselectAll.Text = "Deselect all";
            this.btDeselectAll.UseVisualStyleBackColor = true;
            this.btDeselectAll.Click += new System.EventHandler(this.btDeselectAll_Click);
            // 
            // chkBlist
            // 
            this.chkBlist.FormattingEnabled = true;
            this.chkBlist.Location = new System.Drawing.Point(7, 20);
            this.chkBlist.Name = "chkBlist";
            this.chkBlist.Size = new System.Drawing.Size(442, 229);
            this.chkBlist.TabIndex = 2;
            // 
            // newCompare_test_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newCompare_test_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Compare";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btDeselectAll;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.CheckedListBox chkBlist;
    }
}