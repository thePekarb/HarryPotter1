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
    public partial class lvl6 : Form
    {
        public lvl6()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string otvet = guna2TextBox1.Text.ToLower();
            string vvod = "провод";
            string otvet1 = guna2TextBox2.Text.ToLower();
            string vvod1 = "порт";
            string otvet2 = guna2TextBox3.Text.ToLower();
            string vvod2 = "монитор";
            string otvet3 = guna2TextBox4.Text.ToLower();
            string vvod3 = "принтер";
            string otvet4 = guna2TextBox5.Text.ToLower();
            string vvod4 = "килобайт";
            string otvet5 = guna2TextBox6.Text.ToLower(); 
            string vvod5 = "программа";
            string otvet6 = guna2TextBox7.Text.ToLower();
            string vvod6= "дисковод";
            string otvet7 = guna2TextBox8.Text.ToLower();
            string vvod7 = "сканер";
            string otvet8 = guna2TextBox9.Text.ToLower();
            string vvod8 = "драйвер";
            string otvet9 = guna2TextBox10.Text.ToLower();
            string vvod9 = "микросхема";


            if (vvod == otvet && vvod1 == otvet1 && vvod2 == otvet2 && vvod3 == otvet3 && vvod4 == otvet4 && vvod5 == otvet5 && vvod6 == otvet6 && vvod7 == otvet7 && vvod8 == otvet8 && vvod9 == otvet9  )
            {
                Application.Exit(); 
            }
            else
            {
                MessageBox.Show("задание выполнено не правильно");


                


            }
        }
    }
}
