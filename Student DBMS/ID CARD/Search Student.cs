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
    public partial class review_DB : Form
    {

        string sql;
        public review_DB()
        {
            InitializeComponent();
        }

        private void review_DB_Load(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=" + fullPath_class.fullPath + ";Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();

            //(2)query string
            string search = comboBox1.Text;
            sql = "Select * from student";

            //(3)create command object
          cmd = new SqlCommand(sql, conn);

            //(4)create dataReader
            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {


                comboBox1.Items.Add(dr["name"].ToString() + ", " + dr["father_name"].ToString() + ", " + dr["class_sec"].ToString() + ", Admission Number = " + dr["admission_number"].ToString());

               

            }
            dr.Close();
            conn.Close();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String x ="";

            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=" + fullPath_class.fullPath + ";Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();
            
            //(2)query string
            string search;
            string name = "";
            string father_name = "";
            string temp = "";

            search = comboBox1.Text;
           
            int l = search.IndexOf(",");
            if (l > 0)
            {
                name = search.Substring(0, l);
            }
            l = l + 1;
            if (l > 0 )
            {
                temp = search.Substring(l);
            }

            l = temp.IndexOf(",");
            if (l > 0)
            {
                father_name = search.Substring(0, l);
            }
            
            
            sql = "Select * from student where name = '" + name + "'";

            //(3)create command object
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            //(4)create dataReader
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {   
                string s = dr["current_status"].ToString();


                if (s == "Studying")
                {
                    x = "NULL";
                }
                else
                    x = dr["school_leaving_date"].ToString();

                MessageBox.Show("Admission Number = " + dr["admission_number"] + "\n" + "Admission Date = " + dr["admission_date"] + "\n" + "Name = " + dr["name"] + "\n" + "Father's Name = " + dr["father_name"] + "\n" + "Mother's Name = " + dr["mother_name"] + "\n" + "Address = " + dr["address"] + "\n" + "Class and Section = " + dr["class_sec"] + "\n" + "DOB = " + dr["dob"] + "\n" + "Blood Group = " + dr["blood_group"] + "\n" + "Father's Phone Number = " + dr["father_num"] + "\n" + "Mother's Phone Number = " + dr["mother_num"] + "\n" + "Current Status = " + dr["current_status"] + "\n" + "Leaving Date = " + x);


                
            }

            else
                MessageBox.Show("No such Record");

            dr.Close();
            conn.Close();
           

        }


        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

            
        }
    }
}
