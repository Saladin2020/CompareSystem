using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace CompareSystem.IntefaceManager
{
    public partial class wavInfo : Form
    {
        public wavInfo(string pth)
        {
            InitializeComponent();
            showWavInfo(pth);
        }
        private string GetTrChk { get; set; }
        private void showWavInfo(string pth)
        {
            GetTrChk = pth;
            string temp = "";
            FileInfo fileInfo = new FileInfo(GetTrChk);
            temp = temp + "Name : " + fileInfo.Name + "\n\n";
            DateTime dc = fileInfo.CreationTime;
            temp = temp + "Created : " + dc.ToString() + "\n\n";
            temp = temp + "Type : " + fileInfo.Extension.ToUpper() + "\n\n";
            temp = temp + "Size : " + fileInfo.Length.ToString() + "\n\n";
            temp = temp + "Location : " + fileInfo.FullName + "\n\n";
            label1.Text = "[ " + fileInfo.Name + " ]";
            showInfo.Text = temp;
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer(GetTrChk);
            playSound.Play();
        }
    }
}
