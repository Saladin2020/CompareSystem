namespace CompareSystem.IntefaceManager
{
    partial class alManage
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
            this.chkBlistAl = new CompareSystem.TriStateTreeView();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkBlistAl
            // 
            this.chkBlistAl.ImageIndex = 1;
            this.chkBlistAl.Location = new System.Drawing.Point(23, 39);
            this.chkBlistAl.Name = "chkBlistAl";
            this.chkBlistAl.SelectedImageIndex = 1;
            this.chkBlistAl.Size = new System.Drawing.Size(482, 235);
            this.chkBlistAl.TabIndex = 6;
            this.chkBlistAl.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.chkBlistAl_NodeMouseDoubleClick);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(511, 68);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 5;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(511, 39);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // alManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 312);
            this.Controls.Add(this.chkBlistAl);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.MaximumSize = new System.Drawing.Size(625, 351);
            this.Name = "alManage";
            this.Text = "Algorithm Manage";
            this.ResumeLayout(false);

        }

        #endregion

        private TriStateTreeView chkBlistAl;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd;
        //public event TreeNodeMouseClickEventHandler NodeMouseDoubleClick;
    }
}