using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLT_Nhom3
{
    public partial class DangNhap : Form
    {
        string chuoi = new SQL().getChuoi();
        SqlConnection ketnoi;
        SqlCommand thaotac;
        SqlDataReader docdulieu;
        public DangNhap()
        {
            InitializeComponent();
            ketnoi = new SqlConnection(chuoi);
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            if (txb_user.Text == "" || txb_pass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                string pQ = "";
                ketnoi.Open();
                String lenh = @"SELECT phanQuyen FROM DangNhap WHERE tenTK = '" + txb_user.Text + "' AND mKhau = '" + txb_pass.Text + "'";
                thaotac = new SqlCommand(lenh, ketnoi);
                docdulieu = thaotac.ExecuteReader();
                if (!docdulieu.Read())
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    pQ = docdulieu[0].ToString();


                }
                ketnoi.Close();
                docdulieu.Close();



                if (pQ == "AD" && cb_quanLy.Checked)
                {
                    this.Hide();
                    Form1 frm_main = new Form1();
                    frm_main.ShowDialog();
                    this.Show();
                }
                else if (pQ == "NV" && !cb_quanLy.Checked)
                {
                    this.Hide();
                    Form1 frm_main = new Form1();
                    frm_main.gioiHanNV();
                    frm_main.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Không đủ quyển hạn!");
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
