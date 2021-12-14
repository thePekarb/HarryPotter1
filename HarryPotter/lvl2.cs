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

        int p_size_r1 = 0;
        int p_size_r2 = 0;
        int p_size_r3 = 0;
        int p_size_r4 = 0;
        int p_size_l1 = 0;
        int p_size_l2 = 0;
        int p_size_l3 = 0;
        int p_size_l4 = 0;

        int m_panel_id;



        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox2.Image == null) return;
            m_panel_id = 1;
            pictureBox2.DoDragDrop(pictureBox2.Image, DragDropEffects.Copy | DragDropEffects.Move);

        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            p_size_r1 = m_panel_id;
            List<string> dek = new List<string>();
            string deks = (string)e.Data.GetData(DataFormats.Text);
            pictureBox1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void lvl2_Load(object sender, EventArgs e)
        {
            ((Control)pictureBox1).AllowDrop = true;
        }
    }
}
