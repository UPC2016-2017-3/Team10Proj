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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqdconn = new SqlConnection();
            sqdconn.ConnectionString = "Data Source=MYCOMPUTER\\SQLEXPRESS;Initial Catalog=hotel;Integrated Security=True";
            sqdconn.Open();
            SqlCommand sqlcomm= new SqlCommand();
            sqlcomm.Connection = sqdconn;
            sqlcomm.CommandText = "select * from login  where login='"+textBox1.Text +"' and password='"+textBox2.Text +"'";
            sqlcomm.ExecuteNonQuery();
            SqlDataReader dr = sqlcomm.ExecuteReader();
            if (dr.Read())
            {
              main.isRunMain = true; 
                main M = new main();
                M.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名或者密码错误,请重新输入！");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

            sqdconn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
