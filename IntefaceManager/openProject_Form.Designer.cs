namespace CompareSystem.IntefaceManager
{
    partial class openProject_Form
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
            this.btSP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTs = new System.Windows.Forms.TextBox();
            this.tbTr = new System.Windows.Forms.TextBox();
            this.tbAl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSP
            // 
            this.btSP.Location = new System.Drawing.Point(15, 191);
            this.btSP.Name = "btSP";
            this.btSP.Size = new System.Drawing.Size(163, 23);
            this.btSP.TabIndex = 0;
            this.btSP.Text = "Show profile";
            this.btSP.UseVisualStyleBackColor = true;
            this.btSP.Click += new System.EventHandler(this.btSP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Testing set :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Training set :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Algorithm set :";
            // 
            // tbTs
            // 
            this.tbTs.Location = new System.Drawing.Point(96, 83);
            this.tbTs.Name = "tbTs";
            this.tbTs.ReadOnly = true;
            this.tbTs.Size = new System.Drawing.Size(82, 20);
            this.tbTs.TabIndex = 7;
            // 
            // tbTr
            // 
            this.tbTr.Location = new System.Drawing.Point(96, 112);
            this.tbTr.Name = "tbTr";
            this.tbTr.ReadOnly = true;
            this.tbTr.Size = new System.Drawing.Size(82, 20);
            this.tbTr.TabIndex = 8;
            // 
            // tbAl
            // 
            this.tbAl.Location = new System.Drawing.Point(96, 141);
            this.tbAl.Name = "tbAl";
            this.tbAl.ReadOnly = true;
            this.tbAl.Size = new System.Drawing.Size(82, 20);
            this.tbAl.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Project :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of set";
            // 
            // openProject_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 226);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAl);
            this.Controls.Add(this.tbTr);
            this.Controls.Add(this.tbTs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "openProject_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTs;
        private System.Windows.Forms.TextBox tbTr;
        private System.Windows.Forms.TextBox tbAl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}