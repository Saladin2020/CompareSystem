using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CompareSystem.DBManager;

namespace CompareSystem.IntefaceManager
{
    public partial class trManage : Form
    {
        public trManage()
        {
            InitializeComponent();
            showDataTrStored();
        }

        //show
        private void showDataTrStored()
        {
            new fileManage().ListDirectory(chkBlistTr, "C:\\MatlabProcessing\\soundStores\\", 1);            
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog addData = new FolderBrowserDialog();
            addData.SelectedPath = @"C:\";
            
            if(addData.ShowDialog() == DialogResult.OK)
            {
                string[] temp = addData.SelectedPath.Split('\\');
                DirectoryInfo s = new DirectoryInfo(addData.SelectedPath);
                DirectoryInfo d = new DirectoryInfo("C:\\MatlabProcessing\\soundStores\\" + temp[temp.Length - 1]);
                new fileManage().CopyFolder(s, d); 
                showDataTrStored();
                chkBlistTr.ExpandAll();

            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            fileManage chk = new fileManage();
            List<string> pth = new List<string>();


            for (int i = 0; i < chk.GetCheckedNodes(chkBlistTr.Nodes, chkBlistTr).Count; i++)
            {
                pth.Add(chk.GetCheckedNodes(chkBlistTr.Nodes, chkBlistTr)[i]);
            }
            for (int i = pth.Count - 1; i >= 0; i--)
            {
                if ((File.GetAttributes(pth[i]) & FileAttributes.Directory) != FileAttributes.Directory)
                {
                    try
                    {
                        chk.DeleteFileAndFolder(pth[i], "file");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    try
                    {
                        chk.DeleteFileAndFolder(pth[i], "dir");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }

                showDataTrStored();
                chkBlistTr.ExpandAll();

            }
        }


        private void chkBlistTr_AfterCheck(object sender, TreeViewEventArgs e)
        {
            /*foreach (TreeNode node in chkBlistTr.Nodes)
            {
                if (chkBlistTr.GetChecked(node) == TriStateTreeView.CheckState.Checked)
                    MessageBox.Show(chkBlistTr.GetChecked(node) + "");
            }*/
        }

        private void chkBlistTr_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string[] temp = e.Node.Text.Split('.');
            if ((temp[temp.Length - 1]).ToLower() == "wav")
            {
                wavInfo detail = new wavInfo(e.Node.Text);
                detail.MdiParent = this.ParentForm;
                detail.Show();
            }
            chkBlistTr.ExpandAll();
        }

        //checkbox

        //-----------------------------------------------------------------



    }
}
