namespace CompareSystem
{
    partial class newCompare_profile_Form
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
            this.bt_Back = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Finish = new System.Windows.Forms.Button();
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tsList = new System.Windows.Forms.ListBox();
            this.groupBoxTrain = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.trList = new System.Windows.Forms.ListBox();
            this.groupBoxAlgor = new System.Windows.Forms.GroupBox();
            this.alList = new System.Windows.Forms.CheckedListBox();
            this.warningLb = new System.Windows.Forms.Label();
            this.alSetBt = new System.Windows.Forms.Button();
            this.groupBoxTest.SuspendLayout();
            this.groupBoxTrain.SuspendLayout();
            this.groupBoxAlgor.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Back
            // 
            this.bt_Back.Location = new System.Drawing.Point(610, 492);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(98, 23);
            this.bt_Back.TabIndex = 12;
            this.bt_Back.Text = "Back";
            this.bt_Back.UseVisualStyleBackColor = true;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(818, 492);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(98, 23);
            this.bt_Cancel.TabIndex = 11;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Finish
            // 
            this.bt_Finish.Location = new System.Drawing.Point(714, 492);
            this.bt_Finish.Name = "bt_Finish";
            this.bt_Finish.Size = new System.Drawing.Size(98, 23);
            this.bt_Finish.TabIndex = 10;
            this.bt_Finish.Text = "Finish";
            this.bt_Finish.UseVisualStyleBackColor = true;
            this.bt_Finish.Click += new System.EventHandler(this.bt_Finish_Click);
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.Controls.Add(this.radioButton2);
            this.groupBoxTest.Controls.Add(this.radioButton1);
            this.groupBoxTest.Controls.Add(this.tsList);
            this.groupBoxTest.Location = new System.Drawing.Point(9, 12);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(300, 470);
            this.groupBoxTest.TabIndex = 13;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "Testing set";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(71, 436);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Preprocessing";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 436);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Orignal";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tsList
            // 
            this.tsList.FormattingEnabled = true;
            this.tsList.Location = new System.Drawing.Point(6, 21);
            this.tsList.Name = "tsList";
            this.tsList.Size = new System.Drawing.Size(292, 407);
            this.tsList.TabIndex = 0;
            // 
            // groupBoxTrain
            // 
            this.groupBoxTrain.Controls.Add(this.radioButton3);
            this.groupBoxTrain.Controls.Add(this.radioButton4);
            this.groupBoxTrain.Controls.Add(this.trList);
            this.groupBoxTrain.Location = new System.Drawing.Point(313, 12);
            this.groupBoxTrain.Name = "groupBoxTrain";
            this.groupBoxTrain.Size = new System.Drawing.Size(300, 470);
            this.groupBoxTrain.TabIndex = 14;
            this.groupBoxTrain.TabStop = false;
            this.groupBoxTrain.Text = "Training set";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(70, 436);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(92, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "Preprocessing";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 436);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Orignal";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // trList
            // 
            this.trList.FormattingEnabled = true;
            this.trList.Location = new System.Drawing.Point(6, 21);
            this.trList.Name = "trList";
            this.trList.Size = new System.Drawing.Size(288, 407);
            this.trList.TabIndex = 0;
            // 
            // groupBoxAlgor
            // 
            this.groupBoxAlgor.Controls.Add(this.alList);
            this.groupBoxAlgor.Controls.Add(this.warningLb);
            this.groupBoxAlgor.Controls.Add(this.alSetBt);
            this.groupBoxAlgor.Location = new System.Drawing.Point(618, 12);
            this.groupBoxAlgor.Name = "groupBoxAlgor";
            this.groupBoxAlgor.Size = new System.Drawing.Size(300, 470);
            this.groupBoxAlgor.TabIndex = 15;
            this.groupBoxAlgor.TabStop = false;
            this.groupBoxAlgor.Text = "Algorithm set";
            // 
            // alList
            // 
            this.alList.FormattingEnabled = true;
            this.alList.Location = new System.Drawing.Point(6, 21);
            this.alList.Name = "alList";
            this.alList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.alList.Size = new System.Drawing.Size(288, 409);
            this.alList.TabIndex = 3;
            // 
            // warningLb
            // 
            this.warningLb.AutoSize = true;
            this.warningLb.ForeColor = System.Drawing.Color.Red;
            this.warningLb.Location = new System.Drawing.Point(6, 438);
            this.warningLb.Name = "warningLb";
            this.warningLb.Size = new System.Drawing.Size(133, 13);
            this.warningLb.TabIndex = 2;
            this.warningLb.Text = "*Some parameter is not set";
            // 
            // alSetBt
            // 
            this.alSetBt.Location = new System.Drawing.Point(188, 433);
            this.alSetBt.Name = "alSetBt";
            this.alSetBt.Size = new System.Drawing.Size(106, 23);
            this.alSetBt.TabIndex = 1;
            this.alSetBt.Text = "Parameter set";
            this.alSetBt.UseVisualStyleBackColor = true;
            this.alSetBt.Click += new System.EventHandler(this.alSetBt_Click);
            // 
            // newCompare_profile_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 524);
            this.Controls.Add(this.groupBoxAlgor);
            this.Controls.Add(this.groupBoxTrain);
            this.Controls.Add(this.groupBoxTest);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Finish);
            this.Name = "newCompare_profile_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Compare";
            this.groupBoxTest.ResumeLayout(false);
            this.groupBoxTest.PerformLayout();
            this.groupBoxTrain.ResumeLayout(false);
            this.groupBoxTrain.PerformLayout();
            this.groupBoxAlgor.ResumeLayout(false);
            this.groupBoxAlgor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Back;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Finish;
        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.ListBox tsList;
        private System.Windows.Forms.GroupBox groupBoxTrain;
        private System.Windows.Forms.ListBox trList;
        private System.Windows.Forms.GroupBox groupBoxAlgor;
        private System.Windows.Forms.Button alSetBt;
        private System.Windows.Forms.Label warningLb;
        private System.Windows.Forms.CheckedListBox alList;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}