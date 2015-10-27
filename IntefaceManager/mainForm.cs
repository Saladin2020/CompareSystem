using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompareSystem.ContentManager;
using CompareSystem.IntefaceManager;
using CompareSystem.SystemManager;

namespace CompareSystem
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            initVar();
        }

        private contentData conData = new contentData();
        private nameCompareForm name;
        private newCompare_test_Form ts;
        private newCompare_traing_Form tr;
        private newCompare_algorithm_Form al;
        private newCompare_profile_Form pr;
        private openProject_Form opr;


        private void initVar()
        {
            Verify = false;
        }
        private void newCompareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //listBox1.DataSource = conData.ListTs;
            Verify = false;
            newCompareToolStripMenuItem.Enabled = false;
            if (Application.OpenForms["nameCompareForm"] as nameCompareForm == null)
            {
                callPjForm();
                callTsForm();
                callTrForm();
                callAlForm();              
            }          
            
        }
        private void appear(object sender, FormClosedEventArgs e)
        {
            if(conData.State == 0)
            {
                newCompareToolStripMenuItem.Enabled = true;
            }
            else if (conData.State == 1)
            {
                if (ts.IsDisposed)
                {
                    ts.Dispose();
                    callTsForm();
                }
                ts.Text = new splitWord(conData.PathPj, "\\", "End").Nword + " - Testing Set";
                ts.MdiParent = this;
                ts.Show();
            }
            else if (conData.State == 2)
            {
                if (tr.IsDisposed)
                {
                    tr.Dispose();
                    callTrForm();
                }
                tr.Text = new splitWord(conData.PathPj, "\\", "End").Nword + " - Training Set";
                tr.MdiParent = this;
                tr.Show();          
            }
            else if (conData.State == 3)
            {
                if (al.IsDisposed)
                {
                    al.Dispose();
                    callAlForm();
                }

                al.Text = new splitWord(conData.PathPj, "\\", "End").Nword + " - Algorithm Set";
                al.MdiParent = this;
                al.Show();
            }
            else if (conData.State == 4)
            {
                pr = new newCompare_profile_Form(conData.ListTs, conData.ListTr, conData.ListAl, Verify, Path);
                pr.Text = new splitWord(conData.PathPj, "\\", "End").Nword + " - Profile";
                pr.PathForSave = conData.PathPj;
                pr.setState = new DgState(conData.getDgState);
                pr.setData = new DgAllVarResult(conData.getDgAllVarResult);
                pr.setData(conData.ListTs, conData.ListTr, conData.ListAl);
                pr.FormClosed += new FormClosedEventHandler(appear);
                pr.MdiParent = this;
                pr.Show();
            }
            else if (conData.State == 5)
            {

                
            }
            
        }

        private void trainingSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trManage trManage = new trManage();
            trManage.MdiParent = this;
            trManage.Show();
        }

        private void algorithmSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alManage alManage = new alManage();
            alManage.MdiParent = this;
            alManage.Show();
        }

        private void callPjForm()
        {
            name = new nameCompareForm();
            name.MdiParent = this;
            name.Show();
            name.setState = new DgState(conData.getDgState);
            name.setState(conData.State);
            name.setPathPj = new DgPjN(conData.getDgPathPj);
            name.setPathPj(conData.PathPj);
            name.FormClosed += new FormClosedEventHandler(appear);
        }
        private bool Verify { get; set; }
        private string Path { get; set; }
        private void callTsForm()
        {
            ts = new newCompare_test_Form(Verify,Path);
            ts.setState = new DgState(conData.getDgState);
            ts.setState(conData.State);
            ts.setDgListTs = new DgData(conData.getDgListTs);
            ts.setDgListTs(conData.ListTs);
            ts.FormClosed += new FormClosedEventHandler(appear);
        }

        private void callTrForm()
        {
            tr = new newCompare_traing_Form(Verify, Path);
            tr.setState = new DgState(conData.getDgState);
            tr.setState(conData.State);
            tr.setDgListTr = new DgData(conData.getDgListTr);
            tr.setDgListTr(conData.ListTr);
            tr.FormClosed += new FormClosedEventHandler(appear);
        }
        private void callAlForm()
        {
            al = new newCompare_algorithm_Form(Verify,Path);
            al.setState = new DgState(conData.getDgState);
            al.setState(conData.State);
            al.setDgListAl = new DgData(conData.getDgListAl);
            al.setDgListAl(conData.ListAl);
            al.FormClosed += new FormClosedEventHandler(appear);
        }

        private void callOpenProject()
        {
            opr = new openProject_Form(Path);
            opr.MdiParent = this;
            opr.Show();
            opr.setState = new DgState(conData.getDgState);
            opr.setState(conData.State);
            opr.FormClosed += new FormClosedEventHandler(appear);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileBrowse fb = new fileBrowse(Path, "DAT File| *.dat");
            Path = fb.FilePathS;
            conData.PathPj = Path;
            if (Path != null)
            {
                Verify = true;
                if (Application.OpenForms["openProject_Form"] as openProject_Form == null)
                {
                    callOpenProject();
                    callTsForm();
                    callTrForm();
                    callAlForm();
                }
            }
            fb.FilePathS = null;
            //Path = null;
        }

    }
}
