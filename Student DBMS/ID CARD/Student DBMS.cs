using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ID_CARD
{
    public partial class main_menu : Form
    {
        public main_menu()

        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            review_DB y = new review_DB();
            this.Hide();
            y.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_db z = new add_db();
            this.Hide();
            z.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            update q = new update();
            this.Hide();
            q.ShowDialog();
            this.Show();
        }

        private void main_menu_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Welcome m = new Welcome();
            File.WriteAllText("location.txt", "");
            this.Hide();
            m.ShowDialog();
            this.Show();
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            leave_school q = new leave_school();
            this.Hide();
            q.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            remove_db f = new remove_db();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
     
        }
    }

