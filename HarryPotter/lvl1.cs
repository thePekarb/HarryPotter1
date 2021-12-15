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
    public partial class lvl1 : Form
    {
        public lvl1()
        {
            InitializeComponent();
        }



        public static bool flag = false;
        public static bool green = false;
        public static bool blue = false;
        public static bool red = false;


        private void button8_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;

                button8.BackColor = Color.Yellow;

            }
            if (green == true)
            {
                green = false;

                button8.BackColor = Color.SeaGreen;

            }
            if (blue == true)
            {
                blue = false;

                button8.BackColor = Color.SkyBlue;

            }
            if (red == true)
            {
                red = false;

                button8.BackColor = Color.IndianRed;

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;

                button9.BackColor = Color.Yellow;

            }
            if (green == true)
            {
                green = false;

                button9.BackColor = Color.SeaGreen;

            }
            if (blue == true)
            {
                blue = false;

                button9.BackColor = Color.SkyBlue;

            }
            if (red == true)
            {
                red = false;

                button9.BackColor = Color.IndianRed;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flag = true;


            //button5.BackColor = Color.Yellow;
            //button6.BackColor = Color.Yellow;



        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;

                button5.BackColor = Color.Yellow;

            }
            if (green == true)
            {
                green = false;

                button5.BackColor = Color.SeaGreen;

            }
            if (blue == true)
            {
                blue = false;

                button5.BackColor = Color.SkyBlue;

            }
            if (red == true)
            {
                red = false;

                button5.BackColor = Color.IndianRed;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;

                button6.BackColor = Color.Yellow;

            }
            if (green == true)
            {
                green = false;

                button6.BackColor = Color.SeaGreen;

            }
            if (blue == true)
            {
                blue = false;

                button6.BackColor = Color.SkyBlue;

            }
            if (red == true)
            {
                red = false;

                button6.BackColor = Color.IndianRed;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;

                button11.BackColor = Color.Yellow;

            }
            if (green == true)
            {
                green = false;

                button11.BackColor = Color.SeaGreen;

            }
            if (blue == true)
            {
                blue = false;

                button11.BackColor = Color.SkyBlue;

            }
            if (red == true)
            {
                red = false;

                button11.BackColor = Color.IndianRed;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;

                button12.BackColor = Color.Yellow;

            }
            if (green == true)
            {
                green = false;

                button12.BackColor = Color.SeaGreen;

            }
            if (blue == true)
            {
                blue = false;

                button12.BackColor = Color.SkyBlue;

            }
            if (red == true)
            {
                red = false;

                button12.BackColor = Color.IndianRed;

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;

                button14.BackColor = Color.Yellow;

            }
            if (green == true)
            {
                green = false;

                button14.BackColor = Color.SeaGreen;

            }
            if (blue == true)
            {
                blue = false;

                button14.BackColor = Color.SkyBlue;

            }
            if (red == true)
            {
                red = false;

                button14.BackColor = Color.IndianRed;

            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;

                button15.BackColor = Color.Yellow;

            }

            if (green == true)
            {
                green = false;

                button15.BackColor = Color.SeaGreen;

            }
            if (blue == true)
            {
                blue = false;

                button15.BackColor = Color.SkyBlue;

            }
            if (red == true)
            {
                red = false;

                button15.BackColor = Color.IndianRed;

            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            green = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            blue = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            red = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //if (button8.BackColor = Color.Yellow && button12.BackColor = Color.Yellow)
            //{

            //}
           

           
        }
    }
}
