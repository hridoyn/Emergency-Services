using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                var que = (from x in lqn.Areas
                           where x.LocationId.Equals(textBox1.Text)
                           select x).FirstOrDefault();

                if (que != null)
                {
                    this.Hide();
                    Form3 s1 = new Form3(textBox1.Text);
                    s1.Show();
                }
                else
                {
                    MessageBox.Show("Please check your entry again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {

                var x = from g in lqn.Areas
                        select new
                        {
                            Location = g.Location,
                            LocationId = g.LocationId
                        };
                dataGridView1.DataSource = x.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
             Form1 ss = new Form1();
            ss.Show();
        }


        /* this.Hide();
         Form s3 = new Form();
         s3.Show();*/
    }

}
