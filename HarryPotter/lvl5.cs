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
    public partial class lvl5 : Form
    {
        public lvl5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = (pictureBox1.BackColor == Color.IndianRed) ? Color.Transparent : Color.IndianRed;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = (pictureBox2.BackColor == Color.IndianRed) ? Color.Transparent : Color.IndianRed;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.BackColor = (pictureBox3.BackColor == Color.IndianRed) ? Color.Transparent : Color.IndianRed;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.BackColor = (pictureBox4.BackColor == Color.IndianRed) ? Color.Transparent : Color.IndianRed;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.BackColor = (pictureBox5.BackColor == Color.IndianRed) ? Color.Transparent : Color.IndianRed;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.BackColor = (pictureBox6.BackColor == Color.IndianRed) ? Color.Transparent : Color.IndianRed;
        }

        private void guna2CustomRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton2_Click(object sender, EventArgs e)
        {
            if(pictureBox1.BackColor == Color.IndianRed &&
                pictureBox4.BackColor == Color.IndianRed &&
                pictureBox5.BackColor == Color.IndianRed &&
                pictureBox6.BackColor == Color.IndianRed
                )
            {
                label3.Visible = true;
                pictureBox7.Visible = true;
            }
            else
            {
                label5.Visible = true;
                pictureBox8.Visible = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(label3.Visible = true)
            {
                Application.Exit();
            }
        }
    }
}
