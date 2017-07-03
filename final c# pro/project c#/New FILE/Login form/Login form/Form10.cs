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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 ss = new Form5();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 ss = new Form6();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 ss = new Form7();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 ss = new Form8();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 ss = new Form9();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 ss = new Form11();
            ss.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 ss = new Form12();
            ss.Show();
        }
    }
}
