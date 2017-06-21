using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel
{
    public partial class main : Form
    {
        public static bool isRunMain = false;
        public main()
        {
            InitializeComponent();
        }

        private void 更新折扣信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 更新房源ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 办理入住ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkin check = new checkin();
            check.MdiParent = this;
            check.Show();
        }
    }
}
