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
                lvl5 lvl5 = new lvl5();
                lvl5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильное число");


                guna2TextBox1.Clear();
                

            }

        }

        private void lvl4_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "Вперёд");
            t.SetToolTip(label1, "Выход");
            this.TopMost = true;
        }
    }
}
