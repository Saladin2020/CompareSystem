using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareSystem.SystemManager
{
    class splitWord
    {
        public string Nword { get; set; }
        public splitWord(string word, string strSpl, string sn)
        {
            List<string> str = new List<string>();
            string[] temp = word.Split(new string[]{strSpl}, StringSplitOptions.None);
            for (int i = 0; i < temp.Length; i++)
            {
                str.Add(temp[i]);
            }
            if (sn == "End")
            {
                Nword = str[temp.Length - 1];
            }
            else if (sn == "Start")
            {
                Nword = str[0];
            }
            else 
            {
                Nword = "null";
            }
        }
    }
}
