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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                Login t = new Login();
               
                t.UserName = textBox1.Text;
                t.Password = textBox2.Text;
                t.SecurityQuestion = textBox3.Text;
                lqn.Logins.InsertOnSubmit(t);
                lqn.SubmitChanges();
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                var x = from g in lqn.Logins
                        where g.UserName.Equals(textBox1.Text)
                        select new
                        {
                            UserName = g.UserName,
                            Password = g.Password,
                            SecurityQuestion = g.SecurityQuestion
                        };
            

                dataGridView1.DataSource= x.ToList();
               
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
    }

        
}
