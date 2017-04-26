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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Data|*.mdf";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {

                            fullPath_class.fullPath = openFileDialog1.FileName;
                            File.WriteAllText("location.txt", fullPath_class.fullPath);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Original error: " + ex.Message);
                }

                main_menu t = new main_menu();
                this.Hide();
                t.ShowDialog();
                this.Close();

               

            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            try
            {

                fullPath_class.fullPath = File.ReadAllText("location.txt");
            }

            catch
            {

                File.Create("location.txt");

            }
            fullPath_class.fullPath = File.ReadAllText("location.txt");

            if (fullPath_class.fullPath != "")
            {


                main_menu t = new main_menu();
                this.Hide();
                t.ShowDialog();
                this.Close();


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
