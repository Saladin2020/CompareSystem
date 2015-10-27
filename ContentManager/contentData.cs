using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareSystem
{
    class contentData
    {


        public List<string> ListTs { get; set; }

        public List<string> ListTr { get; set; }

        public List<string> ListAl { get; set; }

        public List<string> ListParam { get; set; }

        public int State { get; set; }

        public string PathPj { get; set; }


        public void getDgListTs(List<string> sender)
        {
            ListTs = sender;
        }

        public void getDgListTr(List<string> sender)
        {
            ListTr = sender;
        }

        public void getDgListAl(List<string> sender)
        {
            ListAl = sender;
        }

        public void getDgState(int sender)
        {
            State = sender;
        }

        public void getDgPathPj(string sender)
        {
            PathPj = sender;
        }

        public void getDgAllVarResult(List<string> sender1, List<string> sender2, List<string> sender3)
        {
            ListTs = sender1;
            ListTr = sender2;
            ListAl = sender3;
        }

    }
}
