using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuoc
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

      

      

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void vềChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmgioithieu f = new frmgioithieu();
            f.Show();
        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmqlthuoc f = new frmqlthuoc();
            f.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmqlNCC f = new frmqlNCC();
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmqlKH f = new frmqlKH();
            f.Show();
        }

       

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmHoaDonBan f = new frmHoaDonBan();
            f.Show();

        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCT_HDB F = new frmCT_HDB();
            F.Show();
        }

        private void lậpHóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHDNhap f = new frmHDNhap();
            f.Show();
        }

        private void chiTiếtHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCT_HDN f = new frmCT_HDN();
            f.Show();
        }

        

        
    }
}
