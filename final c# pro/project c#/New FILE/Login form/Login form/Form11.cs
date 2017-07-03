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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try{
            Ambulance t = new Ambulance();
            t.AmbulanceId = int.Parse(textBox1.Text);
            t.LocationId = int.Parse(textBox2.Text);
            t.Location = textBox3.Text;
            t.AmbulanceName = textBox4.Text;
            t.PhoneNumber = int.Parse(textBox5.Text);
            lqn.Ambulances.InsertOnSubmit(t);
            lqn.SubmitChanges();
            dataGridView1.DataSource = lqn.Ambulances;
        }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                int id = int.Parse(textBox6.Text);
                var que = lqn.Ambulances.Where(w => w.AmbulanceId == id).FirstOrDefault();
                que.LocationId = int.Parse(textBox7.Text);
                que.Location = textBox8.Text;
                que.AmbulanceName = textBox9.Text;
                que.PhoneNumber = int.Parse(textBox10.Text);
                lqn.SubmitChanges();
                dataGridView1.DataSource = lqn.Ambulances;
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
                Ambulance t = lqn.Ambulances.SingleOrDefault(x => x.AmbulanceId == id);
                lqn.Ambulances.DeleteOnSubmit(t);
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
                var x = from g in lqn.Ambulances
                        select new
                        {
                            AmbulanceId = g.AmbulanceId,
                            LocationId = g.LocationId,
                            Location = g.Location,
                            AmbulanceName = g.AmbulanceName,
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
