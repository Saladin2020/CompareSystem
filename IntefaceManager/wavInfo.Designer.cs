namespace CompareSystem.IntefaceManager
{
    partial class wavInfo
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
            this.btPlay = new System.Windows.Forms.Button();
            this.showInfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btPlay
            // 
            this.btPlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPlay.Location = new System.Drawing.Point(246, 245);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 23);
            this.btPlay.TabIndex = 0;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // showInfo
            // 
            this.showInfo.Location = new System.Drawing.Point(11, 28);
            this.showInfo.Name = "showInfo";
            this.showInfo.ReadOnly = true;
            this.showInfo.Size = new System.Drawing.Size(309, 187);
            this.showInfo.TabIndex = 1;
            this.showInfo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // WavInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showInfo);
            this.Controls.Add(this.btPlay);
            this.Name = "WavInfo";
            this.Text = "WavInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.RichTextBox showInfo;
        private System.Windows.Forms.Label label1;
    }
}