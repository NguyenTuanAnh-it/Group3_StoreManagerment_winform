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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
            ketnoi = new SqlConnection(chuoiketnoi);
            hienThiNv();
        }

        private void hienThiNv()
        {
            String lenh = @"SELECT * FROM NhanVien";
            ketnoi.Open();
            thaotac = new SqlCommand(lenh, ketnoi);
            docdulieu = thaotac.ExecuteReader();
            int i = 0;
            lv_nhanVien.Items.Clear();
            while (docdulieu.Read())
            {
                DateTimePicker dtp = new DateTimePicker();
                dtp.Text = docdulieu[2].ToString();
                lv_nhanVien.Items.Add(docdulieu[0].ToString());
                lv_nhanVien.Items[i].SubItems.Add(docdulieu[1].ToString());
                lv_nhanVien.Items[i].SubItems.Add(dtp.Value.ToShortDateString());
                lv_nhanVien.Items[i].SubItems.Add(docdulieu[3].ToString());
                lv_nhanVien.Items[i].SubItems.Add(docdulieu[4].ToString());
                lv_nhanVien.Items[i].SubItems.Add(docdulieu[5].ToString());
                i++;

            }
            docdulieu.Close();
            ketnoi.Close();
            txt_manv.Text = "";
            txt_tenNv.Text = "";
            dtp_ngaySinh.Value = DateTime.Now;
            cbb_gt.Text = "";
            txt_diaChi.Text = "";
            txt_sdt.Text = "";
            btn_sua.Enabled = false;
            btn_themNv.Enabled = true;
            btn_xoa.Enabled = false;
            lv_nhanVien.SelectedItems.Clear();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void txt_manv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tenNv_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtp_ngaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbb_gt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_diaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_themNv_Click(object sender, EventArgs e)
        {
            if (txt_tenNv.Text != "" && cbb_gt.Text != "" && txt_diaChi.Text != "" && txt_sdt.Text != "")
            {
                ketnoi.Open();
                string lenh = "INSERT INTO NhanVien (HoTen, NgaySinh, GioiTinh, DiaChi, Sdt) " +
                "VALUES (@HoTen, @NgaySinh, @GioiTinh, @DiaChi, @Sdt)";


                SqlCommand thaotac = new SqlCommand(lenh, ketnoi);
                thaotac.Parameters.AddWithValue("@HoTen", txt_tenNv.Text);
                thaotac.Parameters.AddWithValue("@NgaySinh", dtp_ngaySinh.Value);
                thaotac.Parameters.AddWithValue("@GioiTinh", cbb_gt.Text);
                thaotac.Parameters.AddWithValue("@DiaChi", txt_diaChi.Text);
                thaotac.Parameters.AddWithValue("@Sdt", txt_sdt.Text);
                thaotac.ExecuteNonQuery();

                lenh = "SELECT MAX(MaNV) FROM NhanVien";
                thaotac = new SqlCommand(lenh, ketnoi);
                docdulieu = thaotac.ExecuteReader();
                string maNv = "";
                if (docdulieu.Read())
                {
                    maNv = docdulieu[0].ToString();
                }


                docdulieu.Close();
                lenh = "INSERT INTO DangNhap VALUES (@tenTk, @mKhau, @phanQuyen)";
                thaotac = new SqlCommand(lenh, ketnoi);
                thaotac.Parameters.AddWithValue("@tenTk", maNv);
                thaotac.Parameters.AddWithValue("@mKhau", maNv);
                thaotac.Parameters.AddWithValue("@phanQuyen", "NV");
                thaotac.ExecuteNonQuery();

                ketnoi.Close();
                hienThiNv();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (lv_nhanVien.SelectedItems.Count > 0)
            {
                ketnoi.Open();

                string lenh = "UPDATE NhanVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, " +
                              "DiaChi = @DiaChi, Sdt = @Sdt WHERE MaNV = @MaNV";
                SqlCommand thaotac = new SqlCommand(lenh, ketnoi);
                thaotac.Parameters.AddWithValue("@HoTen", txt_tenNv.Text);
                thaotac.Parameters.AddWithValue("@NgaySinh", dtp_ngaySinh.Value);
                thaotac.Parameters.AddWithValue("@GioiTinh", cbb_gt.Text);
                thaotac.Parameters.AddWithValue("@DiaChi", txt_diaChi.Text);
                thaotac.Parameters.AddWithValue("@Sdt", txt_sdt.Text);
                thaotac.Parameters.AddWithValue("@MaNV", txt_manv.Text);
                thaotac.ExecuteNonQuery();
                ketnoi.Close();
                hienThiNv();
            }
            else
            {
                MessageBox.Show("Vui lòng lựa chọn thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lv_nhanVien.SelectedItems.Count > 0)
            {
                string maNV = txt_manv.Text;
                ketnoi.Open();
                SqlCommand disableConstraintCmd = new SqlCommand("ALTER TABLE HoaDonBan NOCHECK CONSTRAINT FK__HoaDonBan__MaNV__59FA5E80", ketnoi);
                disableConstraintCmd.ExecuteNonQuery();

                // Xóa các bản ghi liên quan trong bảng HoaDonBan
                string deleteHdb = "DELETE FROM HoaDonBan WHERE MaNV = @maNV";
                SqlCommand deleteHdbCommand = new SqlCommand(deleteHdb, ketnoi);
                deleteHdbCommand.Parameters.AddWithValue("@maNV", maNV);
                deleteHdbCommand.ExecuteNonQuery();

                // Xóa bản ghi trong bảng NhanVien
                string deleteNhanVien = "DELETE FROM NhanVien WHERE MaNV = @maNV";
                SqlCommand deleteNhanVienCommand = new SqlCommand(deleteNhanVien, ketnoi);
                deleteNhanVienCommand.Parameters.AddWithValue("@maNV", maNV);
                deleteNhanVienCommand.ExecuteNonQuery();

                // Kích hoạt lại ràng buộc khóa ngoại
                SqlCommand enableConstraintCmd = new SqlCommand("ALTER TABLE HoaDonBan CHECK CONSTRAINT FK__HoaDonBan__MaNV__59FA5E80", ketnoi);
                enableConstraintCmd.ExecuteNonQuery();
                ketnoi.Close();
                hienThiNv();
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
                String lenh = @"SELECT * FROM NhanVien WHERE MaNV LIKE '%" + txt_timKiem.Text + "%'"
                + "OR HoTen LIKE N'%" + txt_timKiem.Text + "%'"
                 + "OR DiaChi LIKE N'%" + txt_timKiem.Text + "%'"
                  + "OR Sdt LIKE '%" + txt_timKiem.Text + "%'";
                ketnoi.Open();
                thaotac = new SqlCommand(lenh, ketnoi);
                docdulieu = thaotac.ExecuteReader();
                int i = 0;
                lv_nhanVien.Items.Clear();
                while (docdulieu.Read())
                {
                    DateTimePicker dtp = new DateTimePicker();
                    dtp.Text = docdulieu[2].ToString();
                    lv_nhanVien.Items.Add(docdulieu[0].ToString());
                    lv_nhanVien.Items[i].SubItems.Add(docdulieu[1].ToString());
                    lv_nhanVien.Items[i].SubItems.Add(dtp.Value.ToShortDateString());
                    lv_nhanVien.Items[i].SubItems.Add(docdulieu[3].ToString());
                    lv_nhanVien.Items[i].SubItems.Add(docdulieu[4].ToString());
                    lv_nhanVien.Items[i].SubItems.Add(docdulieu[5].ToString());
                    i++;

                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm", "Thông Báo", MessageBoxButtons.OK);
            }
            docdulieu.Close();
            ketnoi.Close();

        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_export_Click(object sender, EventArgs e)
        {

        }

        private void btn_boQua_Click(object sender, EventArgs e)
        {
            hienThiNv();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lv_nhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_nhanVien.SelectedItems.Count > 0)
            {
                txt_manv.Text = lv_nhanVien.SelectedItems[0].SubItems[0].Text;
                txt_tenNv.Text = lv_nhanVien.SelectedItems[0].SubItems[1].Text;
                dtp_ngaySinh.Text = lv_nhanVien.SelectedItems[0].SubItems[2].Text;
                cbb_gt.Text = lv_nhanVien.SelectedItems[0].SubItems[3].Text;
                txt_diaChi.Text = lv_nhanVien.SelectedItems[0].SubItems[4].Text;
                txt_sdt.Text = lv_nhanVien.SelectedItems[0].SubItems[5].Text;
                btn_themNv.Enabled = false;
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;

            }
        }
    }
}
