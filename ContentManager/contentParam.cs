using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompareSystem.ContentManager
{
    class contentParam
    {
        public CheckedListBox Chk { get; set; }
        public string Lv { get; set; }
        public string Info;
        public string InfoReturn { get; set; }
        public void getDgChkBox(string sender)
        {
            for (int i = 0; i < Chk.Items.Count; i++)
            {
                if (sender == Chk.Items[i].ToString())
                {
                    Chk.SetItemChecked(i, true);
                }
            }

        }

        public void getDgValue(string sender)
        {
            Lv = sender;
        }

        public void getDgInfo(string info)
        {
            Info = info;
        }

        public void getDgReturnValue(string info)
        {
            InfoReturn = info;
        }

    }
}