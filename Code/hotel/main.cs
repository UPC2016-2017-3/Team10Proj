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
    public partial class main : Form
    {
        public login mylogin;
        public static bool isRunMain = false;
        public main(login my)
        {
            InitializeComponent();
            mylogin = my;
        }



        private void 客房类型设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomtype type = new roomtype();
            type.MdiParent = this;
            type.Show();
        }

        private void 客房信息设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roominformation info = new roominformation();
            info.MdiParent = this;
            info.Show();
        }

        private void 房间物品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consumption con = new consumption();
            con.MdiParent = this;
            con.Show();
        }

        private void 预定管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reserve rev = new reserve();
            rev.MdiParent = this;
            rev.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {
            string connStr = "Data Source=MYCOMPUTER\\SQLEXPRESS;Initial Catalog=hotel;Integrated Security=True";
            string _sql = "select user_name from login where user_name='" + mylogin.textBox1.Text.Trim() + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            conn.Open();
            SqlDataReader sqlDr = cmd.ExecuteReader();
            if (sqlDr.Read())
            {
                if (mylogin.textBox1.Text.Equals("dingliangping"))
                {
                    item11.Enabled = false;
                    item12.Enabled = false;
                    item13.Enabled = false;

                }
                if (mylogin.textBox1.Text.Equals("songhuihui") || mylogin.textBox1.Text.Equals("liujiang"))
                {
                    item1.Enabled = false;
                    item2.Enabled = false;
                    item3.Enabled = false;
                    item6.Enabled = false;
                    item7.Enabled = false;
                    item8.Enabled = false;
                    item9.Enabled = false;
                    item10.Enabled = false;
                    item12.Enabled = false;
                    item13.Enabled = false;

                }
                if (mylogin.textBox1.Text.Equals("xiaoming"))
                {
                    item1.Enabled = false;
                    item2.Enabled = false;
                    item3.Enabled = false;
                    item6.Enabled = false;
                    item7.Enabled = false;
                    item8.Enabled = false;
                    item9.Enabled = false;
                    item10.Enabled = false;
                    item11.Enabled = false;
                    item13.Enabled = false;

                }
            }
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
               
            }

        private void menuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            string connStr = "Data Source=MYCOMPUTER\\SQLEXPRESS;Initial Catalog=hotel;Integrated Security=True";
            string _sql = "select user_name from login where user_name='" + mylogin.textBox1.Text.Trim() + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            conn.Open();
            SqlDataReader sqlDr = cmd.ExecuteReader();
            if (sqlDr.Read())
            {
                if (mylogin.textBox1.Text.Equals("dingliangping"))
                {
                    item11.Enabled = false;
                    item12.Enabled = false;
                    item13.Enabled = false;

                }
                if (mylogin.textBox1.Text.Equals("songhuihui") || mylogin.textBox1.Text.Equals("liujiang"))
                {
                    item1.Enabled = false;
                    item2.Enabled = false;
                    item3.Enabled = false;
                    item6.Enabled = false;
                    item7.Enabled = false;
                    item8.Enabled = false;
                    item9.Enabled = false;
                    item10.Enabled = false;
                    item12.Enabled = false;
                    item13.Enabled = false;

                }
                if (mylogin.textBox1.Text.Equals("xiaoming"))
                {
                    item1.Enabled = false;
                    item2.Enabled = false;
                    item3.Enabled = false;
                    item6.Enabled = false;
                    item7.Enabled = false;
                    item8.Enabled = false;
                    item9.Enabled = false;
                    item10.Enabled = false;
                    item11.Enabled = false;
                    item13.Enabled = false;

                }
            }
        }
        //}

    
    }
}
