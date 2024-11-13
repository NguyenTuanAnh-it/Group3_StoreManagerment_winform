using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLT_Nhom3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýChungToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void gioiHanNV()
        {
            quảnLýNhânViênToolStripMenuItem.Enabled = false;
            quảnLýMặtHầngToolStripMenuItem.Enabled = false;
            quảnLýNhậpHàngToolStripMenuItem.Enabled = false;
            thốngKêBáoToolStripMenuItem.Enabled = false;
        }
        private void quảnLýMặtHầngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatHang frm = new frmMatHang();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien frmnv = new FrmNhanVien();
            this.Hide();
            frmnv.ShowDialog();
            this.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhachHang frm = new FrmKhachHang();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void lậpĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDonMua frm = new FrmHoaDonMua();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDonBan frm = new FrmHoaDonBan();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
