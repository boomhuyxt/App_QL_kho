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
                    // Nạp người dùng và danh sách vai trò kèm theo
                    var nd = db.NguoiDungs.Include(u => u.VaiTroes)
                               .FirstOrDefault(x => x.TenDangNhap == _tenDangNhap);

                    if (nd != null)
                    {
                        txt_nguoidung.Text = nd.TenDangNhap;
                        txt_Gmail.Text = nd.Email;
                        txt_nguoidung.Enabled = false;

                        // Hiển thị vai trò hiện tại (lấy vai trò đầu tiên nếu có)
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
            if (cb_vaitro.SelectedValue == null) return;

            try
            {
                using (var db = new Model1())
                {
                    // 1. Tải User kèm theo danh sách vai trò hiện tại (Eager Loading)
                    var user = db.NguoiDungs.Include(u => u.VaiTroes)
                                 .FirstOrDefault(x => x.TenDangNhap == _tenDangNhap);

                    if (user != null)
                    {
                        // 2. Cập nhật Email
                        user.Email = txt_Gmail.Text.Trim();
                        int maVaiTroMoi = Convert.ToInt32(cb_vaitro.SelectedValue);

                        // 3. Cập nhật bảng trung gian NguoiDung_VaiTro
                        // EF sẽ tự động xóa dòng cũ và thêm dòng mới trong bảng trung gian
                        user.VaiTroes.Clear(); // Xóa các vai trò cũ

                        var vaiTroMoi = db.VaiTroes.Find(maVaiTroMoi);
                        if (vaiTroMoi != null)
                        {
                            user.VaiTroes.Add(vaiTroMoi); // Thêm vai trò mới vào tập hợp
                        }

                        // 4. Lưu thay đổi
                        db.SaveChanges();

                        MessageBox.Show("Cập nhật thành công!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }
    }
}