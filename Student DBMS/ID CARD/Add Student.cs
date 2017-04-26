using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ID_CARD
{
    public partial class add_db : Form

    {
        string sql;
        public add_db()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_db_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename="+fullPath_class.fullPath+";Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();







            sql = "insert into student VALUES('" + this.textBox1.Text + "', '" + this.textBox2.Text + "', '" + this.textBox3.Text + "', '" + this.textBox7.Text + "', '" + this.textBox8.Text + "', '" + this.textBox9.Text + "', '" + this.textBox4.Text + "', '" + this.textBox5.Text + "', '" + this.textBox6.Text + "', '" + this.textBox11.Text + "', '" + this.textBox10.Text+"', '', '')";
            SqlCommand cmd = new SqlCommand(sql, conn);

            int ct = cmd.ExecuteNonQuery();
            MessageBox.Show("Record Added");
            conn.Close();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        
    }
}
