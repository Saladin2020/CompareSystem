using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CompareSystem.DBManager
{
    class fileManage
    {
        //traversal for show all path in subfolder (slc = 1) , traversal for only root and directory (slc = 0)  and traversal for only file in directory (slc = 2) to TreeView
        public void ListDirectory(TreeView treeView, string path, int slc)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo , slc));
        }

        private TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo, int slc)
        {
            var directoryNode = new TreeNode(directoryInfo.FullName);
            if (slc == 1 || slc == 0)
            {
                foreach (var directory in directoryInfo.GetDirectories())
                    directoryNode.Nodes.Add(CreateDirectoryNode(directory, slc));
            }
            if (slc == 1 || slc == 2)
            {
                foreach (var file in directoryInfo.GetFiles())
                    directoryNode.Nodes.Add(new TreeNode(file.FullName));
            }
            return directoryNode;
        }
        //-------------------------------------------------------------------//
        //traversal for show in listview
        public void ListDirectory(ListBox listBox, string path , int slc)
        {
            if (slc == 0)
            {
                string[] temp = Directory.GetDirectories(path);
                listBox.DataSource = temp;
            }
            if (slc == 1)
            {
                string[] temp = Directory.GetFiles(path);
                listBox.DataSource = temp;
            }
        }



        //-------------------------------------------------------------------//

        //add
        public void CopyFolder(DirectoryInfo source, DirectoryInfo target)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                if (!(Directory.Exists(target.FullName)))
                {
                    startInfo.Arguments = "/C md " + target.FullName;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();

                }
                string cmd = "/c xcopy ";
                startInfo.Arguments = cmd + source.FullName + " " + target.FullName + " /e /y";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception e)
            {
                string[] temp = e.ToString().Split('\'');
                string ex = temp[0] + "\n" + temp[1];
                temp = ex.Split(new string[] { ": " }, StringSplitOptions.None);
                MessageBox.Show("" + temp[1]);
            }
        }

        //remove
        public List<string> GetCheckedNodes(TreeNodeCollection nodes, TriStateTreeView list)
        {
            List<string> nodeList = new List<string>();
            if (nodes == null)
            {
                return nodeList;
            }

            foreach (TreeNode childNode in nodes)
            {
                if (list.GetChecked(childNode) == TriStateTreeView.CheckState.Checked)
                {
                    nodeList.Add(childNode.Text);
                }
                nodeList.AddRange(GetCheckedNodes(childNode.Nodes, list));
            }
            return nodeList;
        }

        public void DeleteFileAndFolder(String source, string atr)
        {
            FolderBrowserDialog addData = new FolderBrowserDialog();
            addData.SelectedPath = source;
            if (atr == "dir")
            {
                DirectoryInfo s = new DirectoryInfo(addData.SelectedPath);
                s.Delete(true);
            }
            else if (atr == "file")
            {
                FileInfo s = new FileInfo(addData.SelectedPath);
                s.Delete();
            }
        }

    }
}
