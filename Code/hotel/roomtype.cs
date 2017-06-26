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
    public partial class roomtype : Form
    {
        private string sql = "";

        public roomtype()
        {
            InitializeComponent();
        }
        protected bool checknontnull()
        {

            if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("类型编号不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show("类型名称不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (textBox6.Text.Trim() == "")
            {
                MessageBox.Show("价格不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else 
                return true;
        
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }


        

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            
            string connStr = "Data Source=MYCOMPUTER\\SQLEXPRESS;Initial Catalog=hotel;Integrated Security=True";
            string _sql = "select id as '类型编号',roomtype as '类型名称',price as '价格' from type11 where id='" + textBox4.Text + "' and roomtype='" + textBox5.Text + "' and price='" + textBox6.Text + "'";
            //string _sql = "select count(*) from  type11";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            //检查是否有该记录，有就关闭连接，无则添加
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("已有该记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                //添加新记录
                else
                {
                    string _sql2 = "insert into type11(id,roomtype,price)values('" + textBox4.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox6.Text.Trim() + "')";
                    if (checknontnull())
                    {SqlCommand cmd2 = new SqlCommand(_sql2, conn);                   
                    cmd2.ExecuteNonQuery();
                    string _sql3 = " select id as '类型编号',roomtype as '类型名称',price as '价格' from type11 ";                    
                    SqlDataAdapter sda1 = new SqlDataAdapter(_sql3, conn);
                    DataSet ds1= new DataSet();
                    sda1.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                        MessageBox.Show("添加成功！",
                                       "提示",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                    }
                }
            }
            finally
            {
                conn.Close();
            }

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
            string connStr = "Data Source=MYCOMPUTER\\SQLEXPRESS;Initial Catalog=hotel;Integrated Security=True";
            string _sql = "select id as '类型编号',roomtype as '类型名称',price as '价格' from type11 where id='" + textBox4.Text + "' and roomtype='" + textBox5.Text + "' and price='" + textBox6.Text + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            conn.Open();
            string _sql2 ="update type11 set roomtype='"+textBox5.Text+"',price='"+textBox6.Text+"' where id='"+textBox4.Text+"'" ;
                 if (checknontnull())
                 { SqlCommand cmd2 = new SqlCommand(_sql2, conn);
            cmd2.ExecuteNonQuery();
            string _sql3 = " select id as '类型编号',roomtype as '类型名称',price as '价格' from type11 ";
                    SqlDataAdapter sda = new SqlDataAdapter(_sql3, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    MessageBox.Show("修改成功！",
                                        "提示",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                conn.Close();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

            string connStr = "Data Source=MYCOMPUTER\\SQLEXPRESS;Initial Catalog=hotel;Integrated Security=True";
            DialogResult ret = MessageBox.Show("确定要删除记录吗？",
                                               "删除",
                                               MessageBoxButtons.OKCancel,
                                               MessageBoxIcon.Question);
            string _sql = "select id as '类型编号',roomtype as '类型名称',price as '价格' from type11 where id='" + textBox4.Text + "' and roomtype='" + textBox5.Text + "' and price='" + textBox6.Text + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            conn.Open();
            string _sql2 = "delete from type11 where id='" + textBox4.Text + "'";
            SqlCommand cmd2 = new SqlCommand(_sql2, conn);
            cmd2.ExecuteNonQuery();
            string _sql3 = "select id as '类型编号',roomtype as '类型名称',price as '价格' from type11 ";
            SqlDataAdapter sda = new SqlDataAdapter(_sql3, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            MessageBox.Show("删除成功！",
                             "提示",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
            conn.Close();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
           
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MakeSqlStr();
            string connStr = "Data Source=MYCOMPUTER\\SQLEXPRESS;Initial Catalog=hotel;Integrated Security=True";
            string _sql = "select id as '类型编号',roomtype as '类型名称',price as '价格' from type11 where 1=1"+sql;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
           
        }

        private void roomtype_Load(object sender, EventArgs e)
        {
            string connStr = "Data Source=MYCOMPUTER\\SQLEXPRESS;Initial Catalog=hotel;Integrated Security=True";
            string _sql = "select id as '类型编号',roomtype as '类型名称',price as '价格' from type11";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }
        private void MakeSqlStr()
        {
            //清空上次的查询字符串
            sql = "";
            if (textBox1.Text.Trim() != string.Empty)
            {
                sql = " and id like '%" + textBox1.Text.Trim() + "%'";
            }
            if (textBox2.Text.Trim() != string.Empty)
            {
                sql += " and roomtype like '%" + textBox2.Text.Trim() + "%'";
            }
            if (textBox3.Text.Trim() != string.Empty)
            {
                sql += " and price like '%" + textBox3.Text.Trim() + "%'";
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
 
            DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
            DataGridViewCellCollection dgvcc = dgvRow.Cells;
            textBox4.Text = dgvcc[0].Value.ToString();
            textBox5.Text = dgvcc[1].Value.ToString();
            textBox6.Text = dgvcc[2].Value.ToString();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar <= '9' && e.KeyChar >= '0') || e.KeyChar == '.' || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
        }
    }

