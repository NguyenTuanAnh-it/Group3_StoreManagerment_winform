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
    public partial class frmMatHang : Form
    {
        String chuoiketnoi = new SQL().getChuoi();
        SqlConnection ketnoi;
        SqlCommand thaotac;
        SqlDataReader docdulieu;
        public frmMatHang()
        {
            InitializeComponent();
            ketnoi = new SqlConnection(chuoiketnoi);
            hienThiMh();
        }

        private void hienThiMh()
        {
            String lenh = @"SELECT * FROM MatHang";
            ketnoi.Open();
            thaotac = new SqlCommand(lenh, ketnoi);
            docdulieu = thaotac.ExecuteReader();
            int i = 0;
            lv_matHang.Items.Clear();
            while (docdulieu.Read())
            {
                lv_matHang.Items.Add(docdulieu[0].ToString());
                lv_matHang.Items[i].SubItems.Add(docdulieu[1].ToString());
                lv_matHang.Items[i].SubItems.Add(docdulieu[2].ToString());
                lv_matHang.Items[i].SubItems.Add(docdulieu[3].ToString());
                lv_matHang.Items[i].SubItems.Add(docdulieu[4].ToString());
                lv_matHang.Items[i].SubItems.Add(docdulieu[5].ToString());
                lv_matHang.Items[i].SubItems.Add(docdulieu[6].ToString());
                i++;

            }
            docdulieu.Close();
            ketnoi.Close();
            txt_maMh.Text = "";
            txt_tenMh.Text = "";
            cbb_loaiHang.Text = "";
            txt_donGia.Text = "";
            txt_xuatXu.Text = "";
            txt_soLuong.Text = "";
            cbb_donVi.Text = "";
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            lv_matHang.SelectedItems.Clear();
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_tenMh.Text != "" && cbb_loaiHang.Text != "" && txt_donGia.Text != "" && txt_xuatXu.Text != "" && txt_soLuong.Text != "" && cbb_donVi.Text != "")
            {
                ketnoi.Open();
                string lenh = "INSERT INTO MatHang (tenMH, loaiHang, donGia, xuatXu, soLuongTon, donVi) " +
                "VALUES (@tenMH, @loaiHang, @donGia, @xuatXu, @soLuongTon, @donVi)";

                SqlCommand thaotac = new SqlCommand(lenh, ketnoi);
                thaotac.Parameters.AddWithValue("@tenMH", txt_tenMh.Text);
                thaotac.Parameters.AddWithValue("@loaiHang", cbb_loaiHang.Text);
                thaotac.Parameters.AddWithValue("@donGia", int.Parse(txt_donGia.Text));
                thaotac.Parameters.AddWithValue("@xuatXu", txt_xuatXu.Text);
                thaotac.Parameters.AddWithValue("@soLuongTon", int.Parse(txt_soLuong.Text));
                thaotac.Parameters.AddWithValue("@donVi", cbb_donVi.Text);

                thaotac.ExecuteNonQuery();
                ketnoi.Close();
                hienThiMh();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (lv_matHang.SelectedItems.Count > 0)
            {
                ketnoi.Open();

                string lenh = "UPDATE MatHang SET tenMH = @tenMH, loaiHang = @loaiHang, donGia = @donGia, " +
                              "xuatXu = @xuatXu, soLuongTon = @soLuongTon, donVi = @donVi WHERE MaMH = @MaMH";
                SqlCommand thaotac = new SqlCommand(lenh, ketnoi);
                thaotac.Parameters.AddWithValue("@MaMH", lv_matHang.SelectedItems[0].Text);
                thaotac.Parameters.AddWithValue("@tenMH", txt_tenMh.Text);
                thaotac.Parameters.AddWithValue("@loaiHang", cbb_loaiHang.Text);
                thaotac.Parameters.AddWithValue("@donGia", int.Parse(txt_donGia.Text));
                thaotac.Parameters.AddWithValue("@xuatXu", txt_xuatXu.Text);
                thaotac.Parameters.AddWithValue("@soLuongTon", int.Parse(txt_soLuong.Text));
                thaotac.Parameters.AddWithValue("@donVi", cbb_donVi.Text);
                thaotac.ExecuteNonQuery();
                ketnoi.Close();
                hienThiMh();
            }
            else
            {
                MessageBox.Show("Vui lòng lựa chọn thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lv_matHang.SelectedItems.Count > 0)
            {


                string maMh = txt_maMh.Text;
                ketnoi.Open();

                // Xóa các bản ghi liên quan trong bảng ChiTietHoaDonNhap
                string deleteChiTietHoaDonNhap = "DELETE FROM ChiTietHoaDonNhap WHERE MaMH = @maMh";
                SqlCommand deleteChiTietHoaDonNhapCommand = new SqlCommand(deleteChiTietHoaDonNhap, ketnoi);
                deleteChiTietHoaDonNhapCommand.Parameters.AddWithValue("@maMh", maMh);
                deleteChiTietHoaDonNhapCommand.ExecuteNonQuery();

                // Xóa bản ghi trong bảng MatHang
                string deleteMatHang = "DELETE FROM MatHang WHERE MaMH = @maMh";
                SqlCommand deleteMatHangCommand = new SqlCommand(deleteMatHang, ketnoi);
                deleteMatHangCommand.Parameters.AddWithValue("@maMh", maMh);
                deleteMatHangCommand.ExecuteNonQuery();





                ketnoi.Close();
                hienThiMh();
            }
            else
            {
                MessageBox.Show("Vui lòng lựa chọn thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {

        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            hienThiMh();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lv_matHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_matHang.SelectedItems.Count > 0)
            {
                txt_maMh.Text = lv_matHang.SelectedItems[0].SubItems[0].Text;
                txt_tenMh.Text = lv_matHang.SelectedItems[0].SubItems[1].Text;
                cbb_loaiHang.Text = lv_matHang.SelectedItems[0].SubItems[2].Text;
                txt_donGia.Text = lv_matHang.SelectedItems[0].SubItems[3].Text;
                txt_xuatXu.Text = lv_matHang.SelectedItems[0].SubItems[4].Text;
                txt_soLuong.Text = lv_matHang.SelectedItems[0].SubItems[5].Text;
                cbb_donVi.Text = lv_matHang.SelectedItems[0].SubItems[6].Text;
                btn_them.Enabled = false;
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;

            }
        }
    }
}
