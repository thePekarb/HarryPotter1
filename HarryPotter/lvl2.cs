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
    public partial class lvl2 : Form
    {
        public lvl2()
        {
            InitializeComponent();
        }

        int p_size_r1 = 1;
        int p_size_r2 = 1;
        int p_size_r3 = 1;
        int p_size_r4 = 1;
        int p_size_l1 = 1;
        int p_size_l2 = 1;
        int p_size_l3 = 1;
        int p_size_l4 = 1;

        int m_panel_id;



        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox2.Image == null) return;
            p_size_l1 = 1;
            pictureBox2.DoDragDrop(pictureBox2.Image, DragDropEffects.Copy | DragDropEffects.Move);

        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            p_size_r1 = p_size_l1;
            List<string> dek = new List<string>();
            string deks = (string)e.Data.GetData(DataFormats.Text);
            pictureBox1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void lvl2_Load(object sender, EventArgs e)
        {
            ((Control)pictureBox1).AllowDrop = true;
            ((Control)pictureBox4).AllowDrop = true;
            ((Control)pictureBox6).AllowDrop = true;
            ((Control)pictureBox8).AllowDrop = true;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox3.Image == null) return;
            p_size_l2 = 1;
            pictureBox3.DoDragDrop(pictureBox3.Image, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox5.Image == null) return;
            m_panel_id = 1;
            pictureBox5.DoDragDrop(pictureBox5.Image, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox7.Image == null) return;
            m_panel_id = 1;
            pictureBox7.DoDragDrop(pictureBox7.Image, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void pictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            p_size_r2 = p_size_l2;
            List<string> dek = new List<string>();
            string deks = (string)e.Data.GetData(DataFormats.Text);
            pictureBox4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox6_DragDrop(object sender, DragEventArgs e)
        {
            p_size_r3 = m_panel_id;
            List<string> dek = new List<string>();
            string deks = (string)e.Data.GetData(DataFormats.Text);
            pictureBox6.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox8_DragDrop(object sender, DragEventArgs e)
        {
            p_size_r4 = m_panel_id;
            List<string> dek = new List<string>();
            string deks = (string)e.Data.GetData(DataFormats.Text);
            pictureBox8.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(p_size_r1 == p_size_l1 & p_size_r2 == p_size_l2)
            {
               lvl3 lvl3    = new lvl3();   
                lvl3.Show();
                this.Hide();
            }
        }
    }
}
