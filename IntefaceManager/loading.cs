using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompareSystem.IntefaceManager
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
            this.ControlBox = false;
            pictureBox1.Load(@"img\loading-x.gif");
        }
    }
}
