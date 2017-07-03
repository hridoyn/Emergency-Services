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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                var que = (from x in lqn.Logins
                           where x.UserName.Equals(textBox1.Text)
                           & x.Password.Equals(textBox2.Text)
                           select x).FirstOrDefault();
                if (que != null)

                {
                    this.Hide();
                    Form2 ss = new Form2();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Please check your username and Password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 ss = new Form13();
            ss.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {



        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 ss = new Form12();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 ss = new Form14();
            ss.Show();
        }


    }
}