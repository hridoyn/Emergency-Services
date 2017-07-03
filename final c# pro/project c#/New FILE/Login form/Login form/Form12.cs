using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login_form
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                var que = (from x in lqn.Admins
                           where x.UserName.Equals(textBox1.Text)
                           & x.Password.Equals(textBox2.Text)
                           select x).FirstOrDefault();
                if (que != null)
                {
                    this.Hide();
                    Form10 ss = new Form10();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }
        }
    }

