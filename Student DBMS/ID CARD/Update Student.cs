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
    public partial class update : Form
    {
        string sql;
        public update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {






            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=" + fullPath_class.fullPath + ";Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();
            String x = comboBox1.Text.ToString();
            string y;

            if (x == "Name" || x == "Father's Name" || x == "Mother's Name" || x == "Class and Section" || x == "DOB" || x == "Blood Group" || x == "Address")
            {
                if (x == "Name")
                    y = "name";
                else if (x == "Father's Name")
                    y = "father_name";
                else if (x == "Mother's Name")
                    y = "mother_name";
                else if (x == "Class and Section")
                    y = "class_sec";
                else if (x == "DOB")
                    y = "dob";
                else if (x == "Blood Group")
                    y = "blood_group";
                else
                    y = "address";

                sql = "update student set " + y + "='" + this.textBox2.Text + "' where name='" + this.textBox1.Text + "' and father_name='" + this.textBox3.Text + "'";

            }
            else
            {
                if (x == "Father's Phone Number")
                    y = "father_num";
                else
                    y = "mother_num";
                sql = "update student set " +y+ "=" + this.textBox3.Text + " where name='" + this.textBox1.Text + "' and ";
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
           

            int ct = cmd.ExecuteNonQuery();
            if (ct == 0)
                MessageBox.Show("No such record");
            else 
                MessageBox.Show("Update complete");

            conn.Close();

        }

        private void update_Load(object sender, EventArgs e)
        {

        }
    }
}
