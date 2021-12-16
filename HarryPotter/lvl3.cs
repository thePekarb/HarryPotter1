using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarryPotter
{
    public partial class lvl3 : Form
    {
        public lvl3()
        {
            InitializeComponent();
        }

      


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "А";
            guna2TextBox1.Visible = true;
        }

        private void lvl3_Load(object sender, EventArgs e)
        {
          
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "Д";
            guna2TextBox1.Visible = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "К";
            guna2TextBox1.Visible = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "Р";
            guna2TextBox1.Visible = true;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "Н";
            guna2TextBox1.Visible = true;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "О";
            guna2TextBox1.Visible = true;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "Л";
            guna2TextBox1.Visible = true;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "М";
            guna2TextBox1.Visible = true;
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "Й";
            guna2TextBox1.Visible = true;
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "Ф";
            guna2TextBox1.Visible = true;
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "!";
            guna2TextBox1.Visible = true;
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "И";
            guna2TextBox1.Visible = true;
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "В";
            guna2TextBox1.Visible = true;
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "-";
            guna2TextBox1.Visible = true;
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "Ы";
            guna2TextBox1.Visible = true;
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "С";
            guna2TextBox1.Visible = true;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += " ";
            guna2TextBox1.Visible = true;
        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2TextBox1.Text == "ДРАКО МАЛФОЙ")
            {
                lvl4 lvl4 = new lvl4();
               lvl4.Show();
                this.Hide();
            }
        }

        private void guna2CustomRadioButton1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "ДРАКО МАЛФОЙ")
            {
                lvl4 lvl4 = new lvl4();
                lvl4.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
