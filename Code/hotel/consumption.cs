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
    public partial class consumption : Form
    {
        private string sql = "";
        public consumption()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        protected bool checknontnull()
        {

            if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("客房编号不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else
                return true;

        }



        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=MYCOMPUTER\\SQLEXPRESS;Initial Catalog=hotel;Integrated Security=True";
            string _sql = "select roomid as '客房编号',消费内容,消费时间,消费金额,note as '备注' from room where roomid='" + textBox4.Text + "'";
           // string _sql = "select id as '类型编号',roomtype as '类型名称',price as '价格' from type11 where id='" + textBox4.Text + "' and roomtype='" + textBox5.Text + "' and price='" + textBox6.Text + "'";
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
                    string _sql2 = "insert into room(roomid,消费时间,消费内容,消费金额,note)values('" + textBox4.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + comboBox3.SelectedItem.ToString() + "','" + textBox6.Text.Trim() + "','" + textBox11.Text.Trim() + "')";
                    if (checknontnull())
                    {
                        SqlCommand cmd2 = new SqlCommand(_sql2, conn);
                        cmd2.ExecuteNonQuery();
                        string _sql3 = "select roomid as '客房编号',消费内容,消费时间,消费金额,note as '备注' from room";
                        SqlDataAdapter sda1 = new SqlDataAdapter(_sql3, conn);
                        DataSet ds1 = new DataSet();
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
            string _sql = "select roomid as '客房编号',消费内容,消费时间,消费金额,note as '备注' from room where roomid='" + textBox4.Text + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            conn.Open();
            string _sql2 = "update room set roomid='" + textBox4.Text.Trim() + "',消费内容='" + comboBox3.SelectedItem.ToString() + "',消费金额='" + textBox6.Text.Trim() + "',note='" + textBox11.Text.Trim() + "'";
            if (checknontnull())
            {
                SqlCommand cmd2 = new SqlCommand(_sql2, conn);
                cmd2.ExecuteNonQuery();
                string _sql3 = "select roomid as '客房编号',消费内容,消费时间,消费金额,note as '备注' from room";
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
            string _sql = "select roomid as '客房编号',消费内容,消费时间,消费金额,note as '备注' from room where roomid='" + textBox4.Text + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            conn.Open();
            string _sql2 = "delete from room where roomid='" + textBox4.Text + "'";
            SqlCommand cmd2 = new SqlCommand(_sql2, conn);
            cmd2.ExecuteNonQuery();
            string _sql3 = "select roomid as '客房编号',消费内容,消费时间,消费金额,note as '备注' from room";
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

        private void toolStripButton9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MakeSqlStr();
            string connStr = "Data Source=MYCOMPUTER\\SQLEXPRESS;Initial Catalog=hotel;Integrated Security=True";
            string _sql ="select roomid as '客房编号',消费内容,消费时间,消费金额,note as '备注' from room where 1=1" + sql;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
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
                sql = " and roomid like '%" + textBox1.Text.Trim() + "%'";
            }
            if (comboBox2.SelectedItem.ToString() != string.Empty &&comboBox2.SelectedItem.ToString()!="所有费用")
            {
                sql += " and 消费内容 like '" + comboBox2.SelectedItem.ToString() + "%'";
            }
            if (comboBox2.SelectedItem.ToString()=="所有费用")
            {
                sql = "";
            }
          

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roominformation_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
            DataGridViewCellCollection dgvcc = dgvRow.Cells;
            textBox4.Text = dgvcc[0].Value.ToString();
            textBox6.Text = dgvcc[3].Value.ToString();
            comboBox3.SelectedItem=dgvcc[1].Value.ToString();
             textBox11.Text=dgvcc[4].Value.ToString();
             textBox2.Text = dateTimePicker1.ToString();
     
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void consumption_Load(object sender, EventArgs e)
        {
            string connStr = "Data Source=MYCOMPUTER\\SQLEXPRESS;Initial Catalog=hotel;Integrated Security=True";
            string _sql = "select roomid as '客房编号',消费内容,消费时间,消费金额,note as '备注' from room";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //textBox2.Text = monthCalendar1.SelectionEnd.ToString();
            textBox2.Text = monthCalendar1.TodayDate.ToString();
           
        }
        private void selectDate(ComboBox cb)
        {
            monthCalendar1.Left = cb.Left;//设置日期控件的位置
            monthCalendar1.Top = cb.Top - monthCalendar1.Height - 10 + groupBox2.Top;
            if (cb.Text.Trim() != "")
            {
                monthCalendar1.SelectionStart = Convert.ToDateTime(cb.Text);//日历显示的时间为数据时间
                monthCalendar1.SelectionEnd = Convert.ToDateTime(cb.Text);
            }

            monthCalendar1.Visible = true;//显示日期
            monthCalendar1.Show();
        }

   

    

  
        
        }
    }

    

