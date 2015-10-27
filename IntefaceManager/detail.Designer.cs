namespace CompareSystem.IntefaceManager
{
    partial class detail
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
            this.alNameLb = new System.Windows.Forms.Label();
            this.alParamLb = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.rbName = new System.Windows.Forms.RichTextBox();
            this.rbParam = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // alNameLb
            // 
            this.alNameLb.AutoSize = true;
            this.alNameLb.Location = new System.Drawing.Point(10, 15);
            this.alNameLb.Name = "alNameLb";
            this.alNameLb.Size = new System.Drawing.Size(33, 13);
            this.alNameLb.TabIndex = 2;
            this.alNameLb.Text = "LPC :";
            // 
            // alParamLb
            // 
            this.alParamLb.AutoSize = true;
            this.alParamLb.Location = new System.Drawing.Point(10, 162);
            this.alParamLb.Name = "alParamLb";
            this.alParamLb.Size = new System.Drawing.Size(106, 13);
            this.alParamLb.TabIndex = 3;
            this.alParamLb.Text = "Parameter (needed) :";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(386, 308);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(468, 308);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.Location = new System.Drawing.Point(13, 32);
            this.rbName.Name = "rbName";
            this.rbName.ReadOnly = true;
            this.rbName.Size = new System.Drawing.Size(530, 121);
            this.rbName.TabIndex = 9;
            this.rbName.Text = "";
            // 
            // rbParam
            // 
            this.rbParam.Location = new System.Drawing.Point(13, 181);
            this.rbParam.Name = "rbParam";
            this.rbParam.ReadOnly = true;
            this.rbParam.Size = new System.Drawing.Size(530, 121);
            this.rbParam.TabIndex = 10;
            this.rbParam.Text = "";
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 343);
            this.Controls.Add(this.rbParam);
            this.Controls.Add(this.rbName);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.alParamLb);
            this.Controls.Add(this.alNameLb);
            this.Name = "Detail";
            this.Text = "Detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alNameLb;
        private System.Windows.Forms.Label alParamLb;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.RichTextBox rbName;
        private System.Windows.Forms.RichTextBox rbParam;
    }
}