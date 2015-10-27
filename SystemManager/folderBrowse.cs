using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompareSystem.ContentManager
{
    class folderBrowse
    {
        public string Fbd { get; set; }
        public folderBrowse()
        {
            Fbd = fbdOpen();
        }
        private string fbdOpen()
        {
            string path = null;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = @"C:\";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            return path;
        }
    }
}
