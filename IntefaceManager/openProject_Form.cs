using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompareSystem.DBManager;
using CompareSystem.SystemManager;

namespace CompareSystem.IntefaceManager
{
    public partial class openProject_Form : Form
    {
        public openProject_Form(string path)
        {
            InitializeComponent();
            Path = path;
            detail();
        }
        public DgState setState;
        private string Path { get; set; }
        private void detail()
        {
            string[] str1;
            string[] str2;
            fileProject r = new fileProject(Path, "");
            if (r.open())
            {
                str1 = r.Data.Split(new string[] { "ts/" }, StringSplitOptions.None);
                str2 = str1[1].Split('@');
                tbTs.Text = (str2.Length - 1) + "";
                str1 = r.Data.Split(new string[] { "tr/" }, StringSplitOptions.None);
                str2 = str1[1].Split('@');
                tbTr.Text = (str2.Length - 1) + "";
                str1 = r.Data.Split(new string[] { "al/" }, StringSplitOptions.None);
                str2 = str1[1].Split('@');
                tbAl.Text = (str2.Length - 1) + "";
                label5.Text = new splitWord(Path, "\\", "End").Nword;
            }
        }
        private void btSP_Click(object sender, EventArgs e)
        {
            setState(1);
            Close();
        }

    }
}
