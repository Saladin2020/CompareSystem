using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompareSystem.DBManager;
using System.IO;

namespace CompareSystem.IntefaceManager
{
    public partial class alManage : Form
    {
        public alManage()
        {
            InitializeComponent();
            showDataAlStored();
        }

        

        //show
        private void showDataAlStored()
        {
            new fileManage().ListDirectory(chkBlistAl, "C:\\MatlabProcessing\\algorithmStores", 0);
            chkBlistAl.ExpandAll();
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog addData = new FolderBrowserDialog();
            addData.SelectedPath = @"C:\";

            if (addData.ShowDialog() == DialogResult.OK)
            {
                string[] temp = addData.SelectedPath.Split('\\');
                DirectoryInfo s = new DirectoryInfo(addData.SelectedPath);
                DirectoryInfo d = new DirectoryInfo("C:\\MatlabProcessing\\algorithmStores\\"+temp[temp.Length-1]);
                string chk = addData.SelectedPath+"\\main.m";
                if (File.Exists(chk))
                {
                    new fileManage().CopyFolder(s, d);
                }
                else 
                {
                    MessageBox.Show("File : " + chk + " is not found !!");
                }
                showDataAlStored();
                chkBlistAl.ExpandAll();

            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            fileManage chk = new fileManage();
            List<string> pth = new List<string>();

            for (int i = 0; i < chk.GetCheckedNodes(chkBlistAl.Nodes, chkBlistAl).Count; i++)
            {
                pth.Add(chk.GetCheckedNodes(chkBlistAl.Nodes, chkBlistAl)[i]);
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

                showDataAlStored();
                chkBlistAl.ExpandAll();
            }
        }


        private void chkBlistAl_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if ((true == File.Exists(e.Node.Text + "\\main.m")))
            {
                detail detail = new detail(e.Node.Text);
                detail.MdiParent = this.ParentForm;
                detail.Show();
            }
            else
            {
                MessageBox.Show(e.Node.Text + "\\main.m "+ " Doesn't Exists !!!");
            }
            chkBlistAl.ExpandAll();
        }
    }
}
