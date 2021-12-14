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
    public partial class preview : Form
    {
        public preview()
        {
            InitializeComponent();
        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lvl1 lv1 = new lvl1();
            lv1.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
