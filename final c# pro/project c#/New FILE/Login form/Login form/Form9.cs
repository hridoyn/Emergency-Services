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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                Police t = new Police();
                t.PoliceId = int.Parse(textBox1.Text);
                t.LocationId = int.Parse(textBox2.Text);
                t.Location = textBox3.Text;
                t.StationName = textBox4.Text;
                t.PhoneNumber = int.Parse(textBox5.Text);
                lqn.Polices.InsertOnSubmit(t);
                lqn.SubmitChanges();
                dataGridView1.DataSource = lqn.Polices;
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
                int id = int.Parse(textBox6.Text);
                var que = lqn.Polices.Where(w => w.PoliceId == id).FirstOrDefault();
                que.LocationId = int.Parse(textBox7.Text);
                que.Location = textBox8.Text;
                que.StationName = textBox9.Text;
                que.PhoneNumber = int.Parse(textBox10.Text);
                lqn.SubmitChanges();
                dataGridView1.DataSource = lqn.Polices;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                int id = int.Parse(textBox11.Text);
                Police t = lqn.Polices.SingleOrDefault(x => x.PoliceId == id);
                lqn.Polices.DeleteOnSubmit(t);
                lqn.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                var x = from g in lqn.Polices
                        select new
                        {
                            PoliceId = g.PoliceId,
                            LocationId = g.LocationId,
                            Location = g.Location,
                            StationName = g.StationName,
                            PhoneNumber = g.PhoneNumber

                        };
                dataGridView1.DataSource = x.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 ss = new Form10();
            ss.Show();
        }
    }
}
