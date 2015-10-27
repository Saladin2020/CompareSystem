using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace CompareSystem.DBManager
{
    public class fileProject
    {
        public string Path { get; set; }
        public string Data { get; set; }
        public fileProject(string path, string data)
        {
            Path = path;
            Data = data;
        }
        public bool create(int slt)
        {
            bool i = true;
            if (slt == 0)
            {
                if (File.Exists(Path))
                {
                    DialogResult dialogResult = MessageBox.Show("Replace", "No", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        i = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        i = false;
                    }
                }
            }
            else if (slt == 1)
            {
                i = true;
            }
            if (i == true)
            {
                using (FileStream fs = File.Create(Path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(Data);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }
            return i;
        }
        public bool open()
        {
            bool i = false;
            if (File.Exists(Path))
            {
                FileStream FileInput = new FileStream(Path, FileMode.Open);
                StreamReader sr = new StreamReader(FileInput);
                Data = sr.ReadToEnd();
                sr.Close();
                i = true;
            }
            return i;
        }
    }
}
