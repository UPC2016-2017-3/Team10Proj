using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotel
{
    public partial class parent : Form
    {
        protected CurrencyManager cmOrders;//用于数据导航控制
        public parent()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void parent_Load(object sender, EventArgs e)
        {

        }

        

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            cmOrders.AddNew();//新增一条记录
            SetDefaultValue();//设置默认值				
            SetModifyMode(true);//设置控件只读等属性
        }

        protected virtual void SetModifyMode(bool blnEdit)
        {
            btnSearch.Enabled = !blnEdit;
        }

        //--------------供派生窗体重载，设置默认值------------
        protected virtual void SetDefaultValue()
        {
            return;
        }
        protected virtual bool CheckNotNull()
        {
            return (true);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            SetModifyMode(true);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认删除？", "删除数据", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                if (cmOrders.Count > 0)//立即从数据集中删除
                {
                    cmOrders.RemoveAt(cmOrders.Position);
                  //  da1.Update(dataSet11);
                }
                else
                    MessageBox.Show("表中为空，已无可删除数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
