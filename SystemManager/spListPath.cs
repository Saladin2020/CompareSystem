using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareSystem
{
    public class spListPath
    {
        public List<string> SendList { get; set; }
        private List<string> spl(List<string> list)
        {
            List<string> f = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                string[] name = list[i].Split('\\');
                f.Add(name[name.Length - 1]);
            }
            return f;
        }
        public spListPath(List<string> list)
        {
            SendList = spl(list);
        }
    }
}
