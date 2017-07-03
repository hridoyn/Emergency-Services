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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                Hospital t = new Hospital();
                t.HospitalId = int.Parse(textBox1.Text);
                t.LocationId = int.Parse(textBox2.Text);
                t.Location = textBox3.Text;
                t.HospitalName = textBox4.Text;
                t.PhoneNumber = int.Parse(textBox5.Text);
                lqn.Hospitals.InsertOnSubmit(t);
                lqn.SubmitChanges();
                dataGridView1.DataSource = lqn.Hospitals.ToList();
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
                var que = lqn.Hospitals.Where(w => w.HospitalId == id).FirstOrDefault();
                que.LocationId = int.Parse(textBox7.Text);
                que.Location = textBox8.Text;
                que.HospitalName = textBox9.Text;
                que.PhoneNumber = int.Parse(textBox10.Text);
                lqn.SubmitChanges();
                dataGridView1.DataSource = lqn.Hospitals;
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
                Hospital t = lqn.Hospitals.SingleOrDefault(x => x.HospitalId == id);
                lqn.Hospitals.DeleteOnSubmit(t);
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
                var x = from g in lqn.Hospitals
                        select new
                        {
                            HospitalId = g.HospitalId,
                            LocationId = g.LocationId,
                            Location = g.Location,
                            HospitalName = g.HospitalName,
                            PhoneNumber = g.PhoneNumber

                        };
                dataGridView1.DataSource = x.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 ss = new Form10();
            ss.Show();
        }
    }
}
