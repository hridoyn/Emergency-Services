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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                int id = int.Parse(textBox6.Text);
                var que = lqn.BloodBanks.Where(w => w.BloodBankId == id).FirstOrDefault();
                que.LocationId = int.Parse(textBox7.Text);
                que.Location = textBox8.Text;
                que.Name = textBox9.Text;
                que.PhoneNumber = int.Parse(textBox10.Text);
                lqn.SubmitChanges();
                dataGridView1.DataSource = lqn.BloodBanks;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                BloodBank t = new BloodBank();
                t.BloodBankId = int.Parse(textBox1.Text);
                t.LocationId = int.Parse(textBox2.Text);
                t.Location = textBox3.Text;
                t.Name = textBox4.Text;
                t.PhoneNumber = int.Parse(textBox5.Text);
                lqn.BloodBanks.InsertOnSubmit(t);
                lqn.SubmitChanges();
                dataGridView1.DataSource = lqn.BloodBanks;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {
                int id = int.Parse(textBox11.Text);
                BloodBank t = lqn.BloodBanks.SingleOrDefault(x => x.BloodBankId == id);
                lqn.BloodBanks.DeleteOnSubmit(t);
                lqn.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            try
            {

                var x = from g in lqn.BloodBanks
                        select new
                        {
                            BloodBankId = g.BloodBankId,
                            LocationId = g.LocationId,
                            Location = g.Location,
                            Name = g.Name,
                            PhoneNumber = g.PhoneNumber

                        };
                dataGridView1.DataSource = x.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
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
