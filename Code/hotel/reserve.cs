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
    public partial class reserve : Form
    {
        DataSet myst = new DataSet();
        SqlDataAdapter myda;
        protected CurrencyManager cmOrders;//用于数据导航控制
        public reserve()
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
                   myda.Update(myst);
                }
                else
                    MessageBox.Show("表中为空，已无可删除数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
           /* string connStr = @"Data Source=MYCOMPUTER\SQLEXPRESS;Initial Catalog=hotel;Integrated Security=True";
            DialogResult ret = MessageBox.Show("确定要删除记录吗？",
                                               "删除",
                                               MessageBoxButtons.OKCancel,
                                               MessageBoxIcon.Question);
            if (ret == DialogResult.Cancel)
            {
                return;
            }
            string _sql = "delete from XS where XH='" + stuXH.Text + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                ModifyForm_Load(null, null);
                if (rows == 1)
                {
                    MessageBox.Show("删除成功！",
                                    "提示",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            finally
            {
                conn.Close();
            }*/
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            bool canSubmit;
            canSubmit = this.CheckNotNull();
            if (canSubmit == false)//有非空值字段为空，不允许提交
            {
                return;
            }
            cmOrders.EndCurrentEdit();
            if (myst.GetChanges() != null)
            {
                try
                {
                    myda.Update(myst);
                    SetModifyMode(false);
                }
                catch (Exception express)
                {
                    MessageBox.Show(express.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    myst.RejectChanges();
                }
            }
            return;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            try
				{
					cmOrders.CancelCurrentEdit();  //取消编辑
					SetModifyMode(false);
				}
				catch(Exception express)
				{
					MessageBox.Show(express.ToString(),"提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				return;
			}
        }
    }

