using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompareSystem.ContentManager
{
    class fileBrowse
    {
        public List<string> FilePathLS { get; set; }
        public string FilePathS { get; set; }
        public fileBrowse(List<string> path, string filter)
        {
            FilePathLS = fileOpenLS(path, filter);
        }
        public fileBrowse(string path, string filter)
        {
            FilePathS = fileOpenS(path, filter);
        }
        
        private List<string> fileOpenLS(List<string> path, string filter)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = filter;//"WAV File| *.wav";
            file.Multiselect = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                foreach (var value in file.FileNames)
                {
                    if (path == null)
                    {
                        path.Add(value);
                    }
                    else if (!path.Contains(value))
                    {
                        path.Add(value);
                    }
                    else
                    {
                        MessageBox.Show("duplicate path : " + value);
                    }
                }
            }

            return path;
        }


        private string fileOpenS(string path, string filter)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = filter;//"WAV File| *.wav";

            file.Multiselect = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
            }
            return path;

        }

    }
}
