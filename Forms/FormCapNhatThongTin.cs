using App_QL_kho.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace App_QL_kho.Forms
{
    public partial class FormCapNhatThongTin : Form
    {
        private string _tenDangNhap;

        public FormCapNhatThongTin(string tenND)
        {
            InitializeComponent();
            this._tenDangNhap = tenND;
            this.Load += FormCapNhatThongTin_Load;
        }

        private void FormCapNhatThongTin_Load(object sender, EventArgs e)
        {
            LoadComboBoxVaiTro();
            LoadThongTinNguoiDung();
        }

        private void LoadComboBoxVaiTro()
        {
            try
            {
                using (var db = new Model1())
                {
                    // Sử dụng AsNoTracking để dữ liệu luôn mới và nhẹ bộ nhớ
                    var listVaiTro = db.VaiTroes.AsNoTracking().ToList();
                    cb_vaitro.DataSource = listVaiTro;
                    cb_vaitro.DisplayMember = "TenVaiTro";
                    cb_vaitro.ValueMember = "MaVaiTro";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách vai trò: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadThongTinNguoiDung()
        {
            try
            {
                using (var db = new Model1())
                {
                    // Tải người dùng kèm theo Vai trò hiện có
                    var nd = db.NguoiDungs.Include(u => u.VaiTroes)
                               .FirstOrDefault(x => x.TenDangNhap == _tenDangNhap);

                    if (nd != null)
                    {
                        txt_nguoidung.Text = nd.TenDangNhap;
                        txt_Gmail.Text = nd.Email;
                        txt_nguoidung.Enabled = false;

                        var vaiTroHienTai = nd.VaiTroes.FirstOrDefault();
                        if (vaiTroHienTai != null)
                        {
                            cb_vaitro.SelectedValue = vaiTroHienTai.MaVaiTro;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Gmail.Text))
            {
                MessageBox.Show("Vui lòng nhập Email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Gmail.Focus();
                return;
            }

            if (cb_vaitro.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new Model1())
                {
                    // 1. Tìm thực thể cần cập nhật
                    var nd = db.NguoiDungs.Include(u => u.VaiTroes)
                               .FirstOrDefault(x => x.TenDangNhap == _tenDangNhap);

                    if (nd != null)
                    {
                        // 2. Cập nhật các trường thông tin
                        nd.Email = txt_Gmail.Text.Trim();

                        // 3. Xử lý cập nhật Quan hệ Nhiều-Nhiều (Many-to-Many)
                        int maVaiTroMoi = Convert.ToInt32(cb_vaitro.SelectedValue);

                        // Xóa toàn bộ vai trò cũ để tránh trùng lặp hoặc lỗi khóa chính
                        nd.VaiTroes.Clear();

                        // Tìm thực thể vai trò mới từ DB của Context hiện tại
                        var vaiTroMoi = db.VaiTroes.FirstOrDefault(v => v.MaVaiTro == maVaiTroMoi);
                        if (vaiTroMoi != null)
                        {
                            nd.VaiTroes.Add(vaiTroMoi);
                        }

                        // 4. Lưu thay đổi
                        db.SaveChanges();

                        MessageBox.Show("Cập nhật thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 5. Trả về kết quả và Đóng Form
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi chi tiết (bao gồm cả InnerException nếu có)
                string errorMsg = ex.InnerException != null ? ex.InnerException.InnerException.Message : ex.Message;
                MessageBox.Show("Lỗi lưu dữ liệu: " + errorMsg, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}