using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ID_CARD
{
    public partial class leave_school : Form
    {
        string sql;
        public leave_school()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=" + fullPath_class.fullPath + ";Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();
           
            string y;
            sql = "update student set school_leaving_date ='" + this.textBox3.Text + "' where name='" + this.textBox1.Text + "' and father_name='" + this.textBox2.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, conn);


            int ct = cmd.ExecuteNonQuery();
            if (ct == 0)
                MessageBox.Show("No such record");
            else
                MessageBox.Show("Update complete and Current Status changed to 'LEFT SCHOOL'");
            sql = "update student set current_status = 'Left School' where school_leaving_date IS NOT NULL";
            cmd = new SqlCommand(sql, conn);


            ct = cmd.ExecuteNonQuery();
            
              

            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void leave_school_Load(object sender, EventArgs e)
        {

        }
    }
}
