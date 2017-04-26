using System;
using System.IO;
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
    public partial class remove_db : Form
    {
        string sql;
        public remove_db()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {








            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=" + fullPath_class.fullPath + ";Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();

            sql = "delete student where name='" + this.textBox1.Text + "' and father_name ='" + this.textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            int ct = cmd.ExecuteNonQuery();
            if (ct == 0)
            { MessageBox.Show("No such Student"); }
            
            else
                MessageBox.Show("Record deleted");

            conn.Close();
        }

        private void remove_db_Load(object sender, EventArgs e)
        {

        }
    }
}
