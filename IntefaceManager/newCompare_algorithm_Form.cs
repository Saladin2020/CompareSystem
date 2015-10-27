using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompareSystem.DBManager;

namespace CompareSystem
{
    public partial class newCompare_algorithm_Form : Form
    {
        public newCompare_algorithm_Form(bool verify, string path)
        {
            InitializeComponent();
            Verify = verify;
            Path = path;
            showDataAlStored();
            openProject();
        }
        private void showDataAlStored()
        {
            new fileManage().ListDirectory(listChkAl, "C:\\MatlabProcessing\\algorithmStores", 0);
        }

        public DgData setDgListAl;
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
                    string[] str1 = r.Data.Split(new string[] { "al/" }, StringSplitOptions.None);
                    string[] str2 = str1[1].Split('@');
                    for (int i = 0; i < str2.Length - 1; i++)
                    {
                        string[] str3 = str2[i].Split(new string[] { ">" }, StringSplitOptions.None);
                        for (int j = 0; j < listChkAl.Items.Count; j++)
                        {
                            if (listChkAl.Items[j].ToString().ToLower() == str3[0].ToLower())
                            {
                                listChkAl.SetItemChecked(j, true);
                            }
                        }
                    }
                }
            }
        }

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listChkAl.Items.Count; i++)
            {
                listChkAl.SetItemChecked(i, true);
            }
        }

        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listChkAl.Items.Count; i++)
            {
                listChkAl.SetItemChecked(i, false);
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < listChkAl.Items.Count; i++)
            {
                if (listChkAl.GetItemChecked(i) == true)
                {
                    pth.Add(listChkAl.Items[i].ToString());
                    count++;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("No item selected !!!");
            }
            else
            {
                setDgListAl(pth);
                setState(4);
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
            setState(2);
            Close();
        }
    }
}
