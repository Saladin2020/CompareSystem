using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompareSystem.ContentManager;
using CompareSystem.DBManager;

namespace CompareSystem
{
    public partial class nameCompareForm : Form
    {
        public nameCompareForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        public DgState setState;
        public DgPjN setPathPj;
        private folderBrowse path;
        private void btBrowse_Click(object sender, EventArgs e)
        {
            path =  new folderBrowse();
            textPathName.Text = path.Fbd;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (textPjName.Text != "" && textPathName.Text != "")
            {
                string temp = textPathName.Text + "\\" + textPjName.Text + ".dat";
                if(new fileProject(temp,textPjName.Text).create(0))
                {
                    setState(1);
                    setPathPj(temp);
                    Close();
                }
                
            }
            else
            {
                MessageBox.Show("Please input project name and location for store");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            setState(0);
            Close();
        }
    }
}
