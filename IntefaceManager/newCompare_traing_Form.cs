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
    public partial class newCompare_traing_Form : Form
    {
        public newCompare_traing_Form(bool verify,string path)
        {
            InitializeComponent();
            Verify = verify;
            Path = path;
            openProject();
            showDataTrStored();
        }

        public DgData setDgListTr;
        public DgState setState;
        private List<string> pth = new List<string>();
        private bool Verify { get; set; }
        private string Path { get; set; }

        private void openProject()
        {
            if (Verify)
            {
                fileProject r = new fileProject(Path, "");
                if (r.open())
                {
                    string[] str1 = r.Data.Split(new string[] { "tr/" }, StringSplitOptions.None);
                    string[] str2 = str1[1].Split('@');
                    for (int i = 0; i < str2.Length - 1; i++)
                    {
                        listChkTr.Items.Add(str2[i]);
                        listChkTr.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void showDataTrStored()
        {
            new fileManage().ListDirectory(listShowTr, "C:\\MatlabProcessing\\soundStores" ,0);
        }

        

        private void btNext_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < listChkTr.Items.Count; i++)
            {
                if (listChkTr.GetItemChecked(i) == true)
                {
                    pth.Add(listChkTr.Items[i].ToString());
                    count++;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("No item selected !!!");
            }
            else
            {
                setDgListTr(pth);
                setState(3);
                Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            setState(0);
            Close();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            setState(1);
            Close();
        }

        private void listShowTr_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                new fileManage().ListDirectory(listChkTr, listShowTr.Text ,1);
                label1.Visible = true;
                lbShowSelect.Text = listShowTr.Text;
        }

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listChkTr.Items.Count; i++)
            {
                listChkTr.SetItemChecked(i, true);
            }
        }

        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listChkTr.Items.Count; i++)
            {
                listChkTr.SetItemChecked(i, false);
            }
        }
    }
}
