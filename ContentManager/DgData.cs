using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompareSystem.ContentManager;

namespace CompareSystem
{
    public delegate void DgData(List<string> sender); // data store in main
    public delegate void DgState(int sender); // state to change form
    public delegate void DgPjN(string sender); // name project
    public delegate void DgChkBox(string sender); // setting
    public delegate void DgSetValue(string sender); // set param value
    public delegate void DgParam(string sender); // send param info setting to algorithm for combine 
    public delegate void DgReturnValue(string sender);
    public delegate void DgAllVarResult(List<string> sender1, List<string> sender2, List<string> sender3);
}
