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
    public partial class newCompare_test_Form : Form
    {
        public newCompare_test_Form(bool verify, string path)
        {
            InitializeComponent();
            this.ControlBox = false;
            Verify = verify;
            Path = path;
            openProject();
        }
        
        public DgData setDgListTs;
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
                    string[] str1 = r.Data.Split(new string[] { "ts/" }, StringSplitOptions.None);
                    string[] str2 = str1[1].Split('@');
                    for (int i = 0; i < str2.Length - 1; i++)
                    {
                        chkBlist.Items.Add(str2[i]);
                        chkBlist.SetItemChecked(i, true);
                        pathData.Add(str2[i]);
                    }
                }
            }
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < chkBlist.Items.Count; i++)
            {
                if (chkBlist.GetItemChecked(i) == true)
                {
                    pth.Add(chkBlist.Items[i].ToString());
                    count++;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("No item selected !!!");
            }
            else
            {
                setDgListTs(pth);
                setState(2);
                Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            setState(0);
            Close();
        }

        // path 
        private List<string> pathData = new List<string>();
        //add items
        private void btAdd_Click(object sender, EventArgs e)
        {

            fileBrowse f = new fileBrowse(pathData, "WAV File| *.wav");
            //chkBlist.DataSource = null;
            pathData = f.FilePathLS;
            setDgListTs(pathData);
            chkBlist.DataSource = pathData;
            for (int i = 0; i < chkBlist.Items.Count; i++)
            {
                chkBlist.SetItemChecked(i, true);
            }
        }

        //remove items
        private void btRemove_Click(object sender, EventArgs e)
        {
            for (int x = chkBlist.CheckedIndices.Count -1; x >= 0; x--)
            {
                int index = chkBlist.CheckedIndices[x];
                pathData.RemoveAt(index);
            }
            for (int x = chkBlist.CheckedIndices.Count - 1; x >= 0; x--)
            {
                chkBlist.SetItemCheckState(x, 0); // Clear all Checkbox
            }
            chkBlist.DataSource = null;
            chkBlist.DataSource = pathData;
            setDgListTs(pathData);
        }

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkBlist.Items.Count; i++)
            {
                chkBlist.SetItemChecked(i, true);
            }
        }

        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkBlist.Items.Count; i++)
            {
                chkBlist.SetItemChecked(i, false);
            }
        }

    }

}
