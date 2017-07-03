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
    public partial class Form3 : Form
    {
        public Form3(string n)
        {
            InitializeComponent();
            label1.Text = n;

           

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sahajjoDataContext lqn = new sahajjoDataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Hridoy\Documents\ProjectData.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

            try
            {
                if (checkBox1.Checked)
                {

                    var x = from g in lqn.Ambulances
                            where g.LocationId == int.Parse(label1.Text)
                            select new
                            {
                                AmbulanceName = g.AmbulanceName,
                                PhoneNumber = g.PhoneNumber
                            };
                    dataGridView1.DataSource = x.ToList();
                }

                else if(checkBox2.Checked)
                {

                    var x = from g in lqn.FireServices
                            where g.LocationId == int.Parse(label1.Text)
                            select new
                            {
                                StationName =g.StationName,
                                PhoneNumber = g.PhoneNumber
                            };
                    dataGridView1.DataSource = x.ToList();
                }
                else if(checkBox3.Checked)
                {
                    var x = from g in lqn.Hospitals
                            where g.LocationId == int.Parse(label1.Text)
                            select new
                            {
                                HospitalName = g.HospitalName,
                                PhoneNumber = g.PhoneNumber
                            };
                    dataGridView1.DataSource = x.ToList();
                }
                else if (checkBox4.Checked)
                {

                    
                            var x = from g in lqn.BloodBanks
                            where g.LocationId == int.Parse(label1.Text)
                            select new
                            {
                                BloodBankName = g.Name,
                                PhoneNumber = g.PhoneNumber
                            };
                    dataGridView1.DataSource = x.ToList();
                }
                else if(checkBox5.Checked)
                {

                    var x = from g in lqn.Polices
                            where g.LocationId == int.Parse(label1.Text)
                            select new
                            {
                                StationName=g.StationName,

                                PhoneNumber = g.PhoneNumber
                            };
                    dataGridView1.DataSource = x.ToList();


                }
               
                else
                {
                    MessageBox.Show("Please check again");
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
            Form2 s2 = new Form2();
            s2.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
            else
            {
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



