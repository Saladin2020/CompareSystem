namespace CompareSystem.IntefaceManager
{
    partial class parameterSet
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
            this.setLb = new System.Windows.Forms.Label();
            this.setValueTb = new System.Windows.Forms.TextBox();
            this.btSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setLb
            // 
            this.setLb.AutoSize = true;
            this.setLb.Location = new System.Drawing.Point(13, 24);
            this.setLb.Name = "setLb";
            this.setLb.Size = new System.Drawing.Size(0, 13);
            this.setLb.TabIndex = 0;
            // 
            // setValueTb
            // 
            this.setValueTb.Location = new System.Drawing.Point(16, 54);
            this.setValueTb.Name = "setValueTb";
            this.setValueTb.Size = new System.Drawing.Size(255, 20);
            this.setValueTb.TabIndex = 1;
            // 
            // btSet
            // 
            this.btSet.Location = new System.Drawing.Point(277, 54);
            this.btSet.Name = "btSet";
            this.btSet.Size = new System.Drawing.Size(39, 23);
            this.btSet.TabIndex = 2;
            this.btSet.Text = "Set";
            this.btSet.UseVisualStyleBackColor = true;
            this.btSet.Click += new System.EventHandler(this.btSet_Click);
            // 
            // ParameterSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 93);
            this.Controls.Add(this.btSet);
            this.Controls.Add(this.setValueTb);
            this.Controls.Add(this.setLb);
            this.Name = "ParameterSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parameter Set";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label setLb;
        private System.Windows.Forms.TextBox setValueTb;
        private System.Windows.Forms.Button btSet;
    }
}