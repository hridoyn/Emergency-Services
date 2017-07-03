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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try{
             var que = from x in lqn.Logins
                          where x.SecurityQuestion.Equals(textBox2.Text)
                          & x.UserName.Equals(textBox1.Text)
                          select x;
                if (que != null)
                {
                    dataGridView1.DataSource = que;

                }
                else
                {
                    MessageBox.Show("wrong answer!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }
        }
    }

