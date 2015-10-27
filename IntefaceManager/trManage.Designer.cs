namespace CompareSystem.IntefaceManager
{
    partial class trManage
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
            this.components = new System.ComponentModel.Container();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.chkBlistTr = new CompareSystem.TriStateTreeView();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(522, 30);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(522, 59);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 2;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // chkBlistTr
            // 
            this.chkBlistTr.ImageIndex = 1;
            this.chkBlistTr.Location = new System.Drawing.Point(34, 30);
            this.chkBlistTr.Name = "chkBlistTr";
            this.chkBlistTr.SelectedImageIndex = 1;
            this.chkBlistTr.Size = new System.Drawing.Size(482, 235);
            this.chkBlistTr.TabIndex = 3;
            this.chkBlistTr.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.chkBlistTr_AfterCheck);
            this.chkBlistTr.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.chkBlistTr_NodeMouseDoubleClick);
            // 
            // trManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 312);
            this.Controls.Add(this.chkBlistTr);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.MaximumSize = new System.Drawing.Size(625, 351);
            this.Name = "trManage";
            this.Text = "Training Manage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private TriStateTreeView chkBlistTr;
    }
}