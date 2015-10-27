using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CompareSystem.IntefaceManager
{
    public partial class detail : Form
    {
        public detail(string pth)
        {
            InitializeComponent();
            showDetail(pth);
            
        }

        private string GetAlChk { get; set; }

        private void showDetail(string pth)
        {
            GetAlChk = pth;
            string file = GetAlChk + "\\main.m";
            StreamReader reader = new StreamReader(file);
            rbName.Text = reader.ReadToEnd();
            reader.Close();

            reader = new StreamReader(file);
            string temp = reader.ReadLine();
            string param = "";
            //remove '(' and ')'
            string[] sp = temp.Split('(');
            sp = sp[1].Split(')');
            //split 
            sp = sp[0].Split(',');

            for (int i = 0; i < sp.Length; i++)
            {
                param = param + (i + 1) + ".) " + sp[i] + "\n";
            }
            string[] lname = GetAlChk.Split('\\');
            alNameLb.Text = lname[lname.Length - 1];
            rbParam.Text = param;
        }

    }
}
