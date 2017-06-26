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
    public partial class roominformation : Form
    {
        private string sql = "";
        public roominformation()
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
            if (comboBox1.SelectedItem.ToString() == "")
            {
                MessageBox.Show("客房类型不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (textBox6.Text.Trim() == "")
            {
                MessageBox.Show("楼层不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show("床数不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (textBox8.Text.Trim() == "")
            {
                MessageBox.Show("额定人数不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            string _sql = "select roomid as '客房编号',roomtype as '客房类型',floorid as '楼层',limited as '额定人数',bed as '床数',description as '客房描述',note as '备注',roomstatus as '状态' from room where roomid='"+textBox4.Text+"'";
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
                    string _sql2 = "insert into room(roomid,floorid,limited,bed,description,note,roomstatus,roomtype)values('" + textBox4.Text.Trim() + "','" + textBox6.Text.Trim() + "','" + textBox8.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox9.Text.Trim() + "','" + textBox11.Text.Trim() + "','" + comboBox3.SelectedItem.ToString() + "','" + comboBox1.SelectedItem.ToString()+ "')";
                    if (checknontnull())
                    {
                        SqlCommand cmd2 = new SqlCommand(_sql2, conn);
                        cmd2.ExecuteNonQuery();
                        string _sql3 = "select roomid as '客房编号',roomtype as '客房类型',floorid as '楼层',limited as '额定人数',bed as '床数',description as '客房描述',note as '备注',roomstatus as '状态' from room";
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
            string _sql = "select roomid as '客房编号',roomtype as '客房类型',floorid as '楼层',limited as '额定人数',bed as '床数',description as '客房描述',note as '备注',roomstatus as '状态' from room where roomid='" + textBox4.Text + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            conn.Open();
            string _sql2 = "update room set floorid='" + textBox6.Text.Trim() + "',limited='" + textBox8.Text.Trim() + "',bed='" + textBox5.Text.Trim() + "',description='" + textBox9.Text.Trim() + "',note='" + textBox11.Text.Trim() + "',roomstatus='" + comboBox3.SelectedItem.ToString() + "',roomtype='" + comboBox1.SelectedItem.ToString()+ "'where roomid='"+textBox4.Text.Trim()+"' ";
            if (checknontnull())
            {
                SqlCommand cmd2 = new SqlCommand(_sql2, conn);
                cmd2.ExecuteNonQuery();
                string _sql3 = "select roomid as '客房编号',roomtype as '客房类型',floorid as '楼层',limited as '额定人数',bed as '床数',description as '客房描述',note as '备注',roomstatus as '状态' from room";
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
            string _sql = "select roomid as '客房编号',roomtype as '客房类型',floorid as '楼层',limited as '额定人数',bed as '床数',description as '客房描述',note as '备注',roomstatus as '状态' from room where roomid='" + textBox4.Text + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            conn.Open();
            string _sql2 = "delete from room where roomid='" + textBox4.Text + "'";
            SqlCommand cmd2 = new SqlCommand(_sql2, conn);
            cmd2.ExecuteNonQuery();
            string _sql3 = "select roomid as '客房编号',roomtype as '客房类型',floorid as '楼层',limited as '额定人数',bed as '床数',description as '客房描述',note as '备注',roomstatus as '状态' from room ";
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
            string _sql ="select roomid as '客房编号',roomtype as '客房类型',floorid as '楼层',limited as '额定人数',bed as '床数',description as '客房描述',note as '备注',roomstatus as '状态' from room where 1=1" + sql;
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
            if (comboBox2.SelectedItem.ToString() != string.Empty && comboBox2.SelectedItem.ToString() != "所有类型" || comboBox2.SelectedItem.ToString() != "所有类型" && comboBox4.SelectedItem.ToString() == "所有状态")
            {
                sql += " and roomtype like '" + comboBox2.SelectedItem.ToString() + "%'";
            }
            if (comboBox2.SelectedItem.ToString() == "所有类型" && comboBox4.SelectedItem.ToString() == "所有状态")
            { 
                sql = "";
            }
            if (comboBox4.SelectedItem.ToString() != string.Empty && comboBox4.SelectedItem.ToString() != "所有状态" || comboBox2.SelectedItem.ToString() == "所有类型" && comboBox4.SelectedItem.ToString() != "所有状态")
            {
                sql += " and roomstatus like '%" + comboBox4.SelectedItem.ToString() + "%'";
            }
     

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roominformation_Load(object sender, EventArgs e)
        {
            string connStr = "Data Source=MYCOMPUTER\\SQLEXPRESS;Initial Catalog=hotel;Integrated Security=True";
            string _sql = "select roomid as '客房编号',roomtype as '客房类型',floorid as '楼层',limited as '额定人数',bed as '床数',description as '客房描述',note as '备注',roomstatus as '状态' from room";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
            DataGridViewCellCollection dgvcc = dgvRow.Cells;
            textBox4.Text = dgvcc[0].Value.ToString();
            comboBox1.SelectedItem=dgvcc[1].Value.ToString();
            textBox6.Text = dgvcc[2].Value.ToString();
            textBox8.Text = dgvcc[3].Value.ToString();
            textBox5.Text = dgvcc[4].Value.ToString();
            comboBox3.SelectedItem=dgvcc[7].Value.ToString();
             textBox9.Text=dgvcc[5].Value.ToString();
             textBox11.Text=dgvcc[6].Value.ToString();
     
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

    

  
        
        }
    }

    

