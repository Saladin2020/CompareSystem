using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CompareSystem.SystemManager
{
    public class processData
    {
        public object[] Res { get; set; }
        private string PthTs { get; set; }
        private string PthTr { get; set; }
        private string PthAl { get; set; }
        public processData(string pthTs, string pthTr, string pthAl)
        {

            PthTs = pthTs;
            PthTr = pthTr;
            PthAl = pthAl;
            proc();
        }
        private void proc()
        {
            MLApp.MLApp Call_Matlab = new MLApp.MLApp();
            Call_Matlab.Visible = 0;
            object result = null;
            Call_Matlab.Execute(@"cd C:\MatlabProcessing");
            try
            {
                Call_Matlab.Feval("MAIN_PROCESSING", 1, out result, PthTs, PthTr, PthAl);
                Res = result as object[];
                MessageBox.Show(Res[0].ToString());
                Call_Matlab.Quit();
                Marshal.ReleaseComObject(Call_Matlab);
            }
            catch (Exception e)
            {
                Marshal.ReleaseComObject(Call_Matlab);
                MessageBox.Show(e.ToString());
            }
            
        }
    }
}
