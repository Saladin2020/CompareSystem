using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareSystem.ContentManager;

namespace CompareSystem.ContentManager
{
    class stringCombine
    {
        public string NewForm { get; set; }
        public stringCombine(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                NewForm = NewForm + list[i] + "@";
            }
        }
        public stringCombine(List<string> list, InfoDetail.Info[] info)
        {
            for (int i = 0; i < info.Length; i++)
            {
                NewForm = NewForm + list[i] + ">" + info[i].Str + "@";
            }
        }
    }
}
