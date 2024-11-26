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
    public partial class FrmKhachHang : Form
    {
        String chuoiketnoi = new SQL().getChuoi();
        SqlConnection ketnoi;
        SqlCommand thaotac;
        SqlDataReader docdulieu;
        public FrmKhachHang()
        {
            InitializeComponent();
            ketnoi = new SqlConnection(chuoiketnoi);
            hienThiKh();
        }
        private void hienThiKh()
        {
            String lenh = @"SELECT * FROM KhachHang";
            ketnoi.Open();
            thaotac = new SqlCommand(lenh, ketnoi);
            docdulieu = thaotac.ExecuteReader();
            int i = 0;
            lv_khachHang.Items.Clear();
            while (docdulieu.Read())
            {
                DateTimePicker dtp = new DateTimePicker();
                dtp.Text = docdulieu[2].ToString();
                lv_khachHang.Items.Add(docdulieu[0].ToString());
                lv_khachHang.Items[i].SubItems.Add(docdulieu[1].ToString());
                lv_khachHang.Items[i].SubItems.Add(dtp.Value.ToShortDateString());
                lv_khachHang.Items[i].SubItems.Add(docdulieu[3].ToString());
                lv_khachHang.Items[i].SubItems.Add(docdulieu[4].ToString());
                lv_khachHang.Items[i].SubItems.Add(docdulieu[5].ToString());
                i++;

            }
            docdulieu.Close();
            ketnoi.Close();
            txt_maKh.Text = "";
            txt_hoTen.Text = "";
            dtp_ngaySinh.Value = DateTime.Now;
            cbb_gioiTinh.Text = "";
            txt_diaChi.Text = "";
            txt_sdt.Text = "";
            btn_sua.Enabled = false;
            btn_themkh.Enabled = true;
            btn_xoa.Enabled = false;
            lv_khachHang.SelectedItems.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbb_loaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_themkh_Click(object sender, EventArgs e)
        {

            if (txt_hoTen.Text != "" && cbb_gioiTinh.Text != "" && txt_diaChi.Text != "" && txt_sdt.Text != "")
            {
                ketnoi.Open();
                string lenh = "INSERT INTO KhachHang (HoTen, NgaySinh, GioiTinh, DiaChi, Sdt) " +
                "VALUES (@HoTen, @NgaySinh, @GioiTinh, @DiaChi, @Sdt)";

                SqlCommand thaotac = new SqlCommand(lenh, ketnoi);
                thaotac.Parameters.AddWithValue("@HoTen", txt_hoTen.Text);
                thaotac.Parameters.AddWithValue("@NgaySinh", dtp_ngaySinh.Value);
                thaotac.Parameters.AddWithValue("@GioiTinh", cbb_gioiTinh.Text);
                thaotac.Parameters.AddWithValue("@DiaChi", txt_diaChi.Text);
                thaotac.Parameters.AddWithValue("@Sdt", txt_sdt.Text);
                thaotac.ExecuteNonQuery();
                ketnoi.Close();
                hienThiKh();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (lv_khachHang.SelectedItems.Count > 0)
            {
                ketnoi.Open();

                string lenh = "UPDATE KhachHang SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, " +
                              "DiaChi = @DiaChi, Sdt = @Sdt WHERE MaKH = @MaKH";
                SqlCommand thaotac = new SqlCommand(lenh, ketnoi);
                thaotac.Parameters.AddWithValue("@HoTen", txt_hoTen.Text);
                thaotac.Parameters.AddWithValue("@NgaySinh", dtp_ngaySinh.Value);
                thaotac.Parameters.AddWithValue("@GioiTinh", cbb_gioiTinh.Text);
                thaotac.Parameters.AddWithValue("@DiaChi", txt_diaChi.Text);
                thaotac.Parameters.AddWithValue("@Sdt", txt_sdt.Text);
                thaotac.Parameters.AddWithValue("@MaKH", txt_maKh.Text);
                thaotac.ExecuteNonQuery();
                ketnoi.Close();
                hienThiKh();
            }
            else
            {
                MessageBox.Show("Vui lòng lựa chọn thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lv_khachHang.SelectedItems.Count > 0)
            {
                string maKh = txt_maKh.Text;
                ketnoi.Open();

                // Xóa các bản ghi liên quan trong bảng HoaDonBan
                string deleteHoaDonBan = "DELETE FROM HoaDonBan WHERE MaKH = @maKh";
                SqlCommand deleteHoaDonBanCommand = new SqlCommand(deleteHoaDonBan, ketnoi);
                deleteHoaDonBanCommand.Parameters.AddWithValue("@maKh", maKh);
                deleteHoaDonBanCommand.ExecuteNonQuery();

                // Xóa bản ghi trong bảng KhachHang
                string deleteKhachHang = "DELETE FROM KhachHang WHERE MaKH = @maKh";
                SqlCommand deleteKhachHangCommand = new SqlCommand(deleteKhachHang, ketnoi);
                deleteKhachHangCommand.Parameters.AddWithValue("@maKh", maKh);
                deleteKhachHangCommand.ExecuteNonQuery();

                ketnoi.Close();
                hienThiKh();
            }
            else
            {
                MessageBox.Show("Vui lòng lựa chọn thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (txt_timKiem.Text != "")
            {
                String lenh = @"SELECT * FROM KhachHang WHERE MaKH LIKE '%" + txt_timKiem.Text + "%'"
                + "OR HoTen LIKE N'%" + txt_timKiem.Text + "%'"
                 + "OR DiaChi LIKE N'%" + txt_timKiem.Text + "%'"
                  + "OR Sdt LIKE '%" + txt_timKiem.Text + "%'";
                ketnoi.Open();
                thaotac = new SqlCommand(lenh, ketnoi);
                docdulieu = thaotac.ExecuteReader();
                int i = 0;
                lv_khachHang.Items.Clear();
                while (docdulieu.Read())
                {
                    DateTimePicker dtp = new DateTimePicker();
                    dtp.Text = docdulieu[2].ToString();
                    lv_khachHang.Items.Add(docdulieu[0].ToString());
                    lv_khachHang.Items[i].SubItems.Add(docdulieu[1].ToString());
                    lv_khachHang.Items[i].SubItems.Add(dtp.Value.ToShortDateString());
                    lv_khachHang.Items[i].SubItems.Add(docdulieu[3].ToString());
                    lv_khachHang.Items[i].SubItems.Add(docdulieu[4].ToString());
                    lv_khachHang.Items[i].SubItems.Add(docdulieu[5].ToString());
                    i++;

                }
                docdulieu.Close();
                ketnoi.Close();
            }
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            hienThiKh();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lv_khachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_khachHang.SelectedItems.Count > 0)
            {
                txt_maKh.Text = lv_khachHang.SelectedItems[0].SubItems[0].Text;
                txt_hoTen.Text = lv_khachHang.SelectedItems[0].SubItems[1].Text;
                dtp_ngaySinh.Text = lv_khachHang.SelectedItems[0].SubItems[2].Text;
                cbb_gioiTinh.Text = lv_khachHang.SelectedItems[0].SubItems[3].Text;
                txt_diaChi.Text = lv_khachHang.SelectedItems[0].SubItems[4].Text;
                txt_sdt.Text = lv_khachHang.SelectedItems[0].SubItems[5].Text;
                btn_themkh.Enabled = false;
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;

            }
        }
    }
}
