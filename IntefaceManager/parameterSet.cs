using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompareSystem.IntefaceManager
{
    public partial class parameterSet : Form
    {
        public parameterSet(string name, string info, int index)
        {
            InitializeComponent();
            NameP = name;
            Info = info;
            Index = index;
            setLb.Text = "Setting Parameter : " + NameP;
            this.ControlBox = false;
        }

        private string Info { get; set; }
        private string NameP { get; set; }
        private int Index { get; set; }
        public DgSetValue setValue;

        private string setNewValue()
        {
            string[] temp1 = Info.Split(':');
            string[] temp2 = temp1[Index].Split(',');
            return setValueTb.Text;
        }

        private void btSet_Click(object sender, EventArgs e)
        {
            if (setValueTb.Text != "")
            {
                string st = "";
                string[] temp1 = Info.Split(':');
                for (int i = 0; i < temp1.Length-1; i++)
                {
                    string[] temp2 = temp1[i].Split(',');
                    if (temp1[Index] == temp1[i])
                    {
                        st = st + temp2[0] + "," + setNewValue();
                    }
                    else
                    {
                        st = st + temp2[0] + "," + temp2[1];
                    }
                    st = st + ":";
                }
                setValue(st);
                Close();
            }
            else
            {
                MessageBox.Show("Parameter \"" + NameP + "\" is not set");
            }
        }
    }
}
