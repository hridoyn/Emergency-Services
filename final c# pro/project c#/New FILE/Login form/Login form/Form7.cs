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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                FireService t = new FireService();
                t.FireServiceId = int.Parse(textBox1.Text);
                //t.LocationId = int.Parse(textBox2.Text);
                t.Location = textBox3.Text;
                t.StationName = textBox4.Text;
                t.PhoneNumber = int.Parse(textBox5.Text);
                lqn.FireServices.InsertOnSubmit(t);
                lqn.SubmitChanges();
                dataGridView1.DataSource = lqn.FireServices;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try{
                var x = from g in lqn.FireServices
                        select new
                        {
                            FireServiceId = g.FireServiceId,
                            LocationId = g.LocationId,
                            Location = g.Location,
                            StationName= g.StationName,
                            PhoneNumber = g.PhoneNumber

                        };
                dataGridView1.DataSource = x.ToList();
        } catch(Exception ex){
            MessageBox.Show(ex.Message);

        }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                int id = int.Parse(textBox6.Text);
                var que = lqn.FireServices.Where(w => w.FireServiceId == id).FirstOrDefault();
                que.LocationId = int.Parse(textBox7.Text);
                que.Location = textBox8.Text;
                que.StationName = textBox9.Text;
                que.PhoneNumber = int.Parse(textBox10.Text);
                lqn.SubmitChanges();
                dataGridView1.DataSource = lqn.FireServices;
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
                FireService t = lqn.FireServices.SingleOrDefault(x => x.FireServiceId == id);
                lqn.FireServices.DeleteOnSubmit(t);
                lqn.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form7_Load(object sender, EventArgs e)
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
