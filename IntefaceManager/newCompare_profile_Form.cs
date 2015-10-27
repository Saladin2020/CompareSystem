using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using CompareSystem.IntefaceManager;
using CompareSystem.ContentManager;
using CompareSystem.DBManager;
using CompareSystem.SystemManager;

namespace CompareSystem
{
    public partial class newCompare_profile_Form : Form
    {
        public newCompare_profile_Form(List<string> ts, List<string> tr, List<string> al, bool verify, string path)
        {
            InitializeComponent();
            this.ControlBox = false;
            Verify = verify;
            Path = path;
            ConTs = ts;
            ConTr = tr;
            ConAl = al;
            if (Verify)
            {
                openProject();
            }
            else
            {
                cP.InfoReturn = "empty";
            }
            showProfile();
            //setData(ConTs, ConTr, ConAl);
            
        }
        public DgState setState;
        public DgAllVarResult setData;
        public string PathForSave { get; set; }
        private bool Verify { get; set; }
        private string Path { get; set; }
        private List<string> ConTs { get; set; }
        private List<string> ConTr { get; set; }
        private List<string> ConAl { get; set; }
        private contentParam cP = new contentParam();

        private void openProject()
        {
            string temp1 = "", temp2 = "";
            fileProject r = new fileProject(Path, "");
            if (r.open())
            {
                string[] str1 = r.Data.Split(new string[] { "al/" }, StringSplitOptions.None);
                string[] str2 = str1[1].Split('@');
                //MessageBox.Show(Path);
                for (int i = 0; i < str2.Length - 1; i++)
                {
                    string[] str3 = str2[i].Split(new string[] { ">" }, StringSplitOptions.None);
                    string[] str4 = str3[1].Split(new string[] { ":" }, StringSplitOptions.None);
                    for (int j = 0; j < str4.Length - 1; j++)
                    {
                        string[] str5 = str4[j].Split(new string[] { "," }, StringSplitOptions.None);
                        temp1 = temp1 + str5[0] + "," + str5[1] + ":";
                    }
                    temp2 = temp2 + temp1 + "|";
                    temp1 = "";
                }
            }
            PathForSave = Path;
            cP.InfoReturn = temp2;
            MessageBox.Show(cP.InfoReturn);
        }

        private void showProfile()
        {
            tsList.Enabled = false;
            tsList.SelectionMode = SelectionMode.None;
            trList.Enabled = false;
            trList.SelectionMode = SelectionMode.None;
            alList.Enabled = false;
            alList.SelectionMode = SelectionMode.None;
            tsList.DataSource = ConTs;
            trList.DataSource = ConTr;
            alList.DataSource = ConAl;
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            setState(0);
            Close();
        }
        private loading load = new loading();
        private void bt_Finish_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < alList.Items.Count; i++)
            {
                if (alList.GetItemChecked(i) == true)
                {
                    count++;
                }
            }
            if (count < alList.Items.Count)
            {
                MessageBox.Show("No item selected !!!");
            }
            else
            {
                string data = "ts/" + new stringCombine(ConTs).NewForm + "ts/" + "tr/" + new stringCombine(ConTr).NewForm + "tr/" + "al/" + cP.Info + "al/";
                if (Verify)
                {
                    new fileProject(PathForSave, data).create(0);
                }
                else
                {
                    new fileProject(PathForSave, data).create(1);
                }
                Thread f = new Thread(new ThreadStart(process));
                f.Start();
                loadingForWait();
            }
        }
        private void loadingForWait()
        {
            load.FormBorderStyle = FormBorderStyle.FixedSingle;
            load.MaximizeBox = false;
            load.MinimizeBox = false;
            load.ShowDialog();
        }
        private void process()
        {
            object[] res = new processData(new stringCombine(ConTs).NewForm, new stringCombine(ConTr).NewForm, cP.Info).Res;
            if (res[0].ToString() != null)
            {               
                if (load.InvokeRequired)
                {
                    load.Invoke((MethodInvoker)delegate()
                    {
                        load.Close();
                    });
                }
            }
        }





        private setting setting;
        private void alSetBt_Click(object sender, EventArgs e)
        {
            alSetBt.Enabled = false;
            setting = new setting(ConAl,cP.InfoReturn);
            cP.Chk = alList;
            setting.setChk = new DgChkBox(cP.getDgChkBox);
            setting.setParam = new DgParam(cP.getDgInfo);
            setting.setReturnValue = new DgReturnValue(cP.getDgReturnValue);
            setting.MdiParent = this.ParentForm;
            setting.Show();
            setting.FormClosed +=new FormClosedEventHandler(btEnable);
        }
        public void btEnable(object sender,FormClosedEventArgs e)
        {
            alSetBt.Enabled = true;
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            setState(3);
            Close();
        }

    }
}
