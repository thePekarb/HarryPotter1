﻿using System;
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
    public partial class lvl4 : Form
    {
        public lvl4()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string otvet = guna2TextBox1.Text;
            string vvod = "4";


            if (vvod == otvet)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Неправильное число");


                guna2TextBox1.Clear();
                

            }

        }
    }
}
