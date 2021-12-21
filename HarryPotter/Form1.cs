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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(guna2Button2, "Вперёд");
            t.SetToolTip(guna2Button1, "Выход");
            this.TopMost = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            preview pr   = new preview();
            pr.Show();
            this.Hide();
        }
    }
}
