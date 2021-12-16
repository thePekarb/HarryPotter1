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
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            lvl1 lvl1   = new lvl1();
            lvl1.Show();
            this.Hide();
        }
    }
}
