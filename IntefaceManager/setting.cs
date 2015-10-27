using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CompareSystem.ContentManager;
using System.Text.RegularExpressions;

namespace CompareSystem.IntefaceManager
{
    public partial class setting : Form
    {
        public setting(List<string> alList,string returnInfo)
        {
            InitializeComponent();
            chkFile(alList, returnInfo);
            settingParam();
            if (RtInfo != "empty")
            {
                updateVarParam();
            }
            updateParam();
        }


        private InfoDetail.Info[] infoDt;
        private int index = 0;
        private List<string> GetAlChk { get; set; }
        public DgChkBox setChk;
        public DgParam setParam;
        private contentParam cP;
        private string RtInfo { get; set; }

        private void chkFile(List<string> alList,string returnInfo)
        {
            btPre.Enabled = false;
            GetAlChk = alList;
            RtInfo = returnInfo;
            cP = new contentParam();
            infoDt = new InfoDetail.Info[GetAlChk.Count];
            label2.Text = (index + 1) + " | " + (GetAlChk.Count);
        }
        private void settingParam()
        {
            for (int i = 0; i < GetAlChk.Count; i++)
            {
                string param = "";
                string file = GetAlChk[i] + "\\main.m";
                StreamReader reader = new StreamReader(file);
                param = param + reader.ReadToEnd() + "\n";
                infoDt[i].TRich = param;
                reader.Close();

                reader = new StreamReader(file);
                string temp = reader.ReadLine();

                //remove '(' and ')'
                string[] sp = temp.Split('(');
                sp = sp[1].Split(')');
                //split 
                sp = sp[0].Split(new string[] { ", " }, StringSplitOptions.None);
                for (int j = 0; j < sp.Length; j++)
                {
                    infoDt[i].TParamName = sp[j];
                    infoDt[i].TParamValue = "null";
                    infoDt[i].Str = infoDt[i].Str + infoDt[i].TParamName + "," + infoDt[i].TParamValue + ":";
                }
            }
        }


        private void updateVarParam()
        {
            for (int i = 0; i < GetAlChk.Count; i++)
            {
                string param = "";
                string file = GetAlChk[i] + "\\main.m";
                StreamReader reader = new StreamReader(file);
                param = param + reader.ReadToEnd() + "\n";
                infoDt[i].TRich = param;
                reader.Close();
            }
            string[] temp1 = RtInfo.Split('|');
            for (int i = 0; i < temp1.Length - 1; i++)
            {
                infoDt[i].Str = "";
                string[] temp2 = temp1[i].Split(':');
                for (int j = 0; j < temp2.Length-1; j++)
                {
                    string[] temp3 = temp2[j].Split(',');
                    infoDt[i].TParamName = temp3[0];
                    infoDt[i].TParamValue = temp3[1];
                    infoDt[i].Str = infoDt[i].Str + infoDt[i].TParamName + "," + infoDt[i].TParamValue + ":";
                }
            }
        }


        private void updateParam()
        {
            settingDetailTb.Text = infoDt[index].TRich;
            tvParam.Nodes.Clear();
            string[] temp1 = infoDt[index].Str.Split(':');
            for (int i = 0; i < temp1.Length; i++)
            {
                string[] temp2 = temp1[i].Split(',');
                for (int j = 1; j < temp2.Length; j++)
                {
                    tvParam.Nodes.Add(temp2[0]);
                    tvParam.Nodes[i].Nodes.Add(temp2[j]);               
                }
            }
        }

        private void btPre_Click(object sender, EventArgs e)
        {
            index--;
            label2.Text = (index + 1) + " | " + (GetAlChk.Count);
            if (index == 0)
            {
                btPre.Enabled = false;
            }

            if (index < 0)
            {
                index = 0;
            }
            else
            {
                btNxt.Enabled = true;
                updateParam();
            }
        }

        private void btNxt_Click(object sender, EventArgs e)
        {
            index++;
            label2.Text = (index + 1) + " | " + (GetAlChk.Count);
            if (index == GetAlChk.Count - 1)
            {
                btNxt.Enabled = false;
            }

            if (index >= GetAlChk.Count)
            {
                index = GetAlChk.Count - 1;
            }
            else
            {
                btPre.Enabled = true;
                updateParam();
            }
        }


        public DgReturnValue setReturnValue;
        private string rT = "";
        private void btSet_Click(object sender, EventArgs e)
        {
            var regex = new Regex("null");
            for (int i = 0; i < infoDt.Length; i++)
            {
                if (!(regex.IsMatch(infoDt[i].Str)))
                {
                    setChk(GetAlChk[i]);
                }
                rT = rT + infoDt[i].Str + "|";
            }
            //MessageBox.Show(new stringCombine(GetAlChk, infoDt).NewForm);
            //string strCom = new stringCombine(GetAlChk, infoDt).NewForm;
            setReturnValue(rT);
            setParam(new stringCombine(GetAlChk, infoDt).NewForm);
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void tvParam_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.IsSelected)
            {
                if (tvParam.SelectedNode.Level == 0)
                {
                    try
                    {
                        tvParam.Nodes[e.Node.Index].Nodes.Clear();
                        parameterSet paramSet = new parameterSet(tvParam.Nodes[e.Node.Index].Text, infoDt[index].Str, e.Node.Index);
                        paramSet.setValue = new DgSetValue(cP.getDgValue);
                        paramSet.FormClosed += new FormClosedEventHandler(callSet);
                        paramSet.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                        MessageBox.Show(ex.ToString());
                        MessageBox.Show("Please choose a correct parameter !!!");
                    }
                }
            }
        }
         void callSet(object sender,FormClosedEventArgs e)
        {
            infoDt[index].Str = cP.Lv;
            updateParam();
        }
    }
}