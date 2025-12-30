using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace App_QL_kho.Forms
{
    public partial class FormAdmin : Form
    {
        private Form activeForm = null;
        private readonly List<string> _userRoles; // Lưu danh sách vai trò

        // Constructor nhận danh sách vai trò từ Form Đăng nhập
        public FormAdmin(List<string> roles)
        {
            InitializeComponent();

            // Lưu và chuẩn hóa vai trò (viết hoa để so sánh chính xác)
            this._userRoles = roles != null
                ? roles.Select(r => r.ToUpper().Trim()).ToList()
                : new List<string>();

            // 1. Đăng ký sự kiện
            RegisterEvents();

            // 2. Thực hiện phân quyền ngay
            ApplyAuthorization();

            this.Load += (s, e) => {
                if (activeForm == null) OpenChildForm(new FormTrangChu());
            };
        }

        private void ApplyAuthorization()
        {
            // Kiểm tra các quyền cơ bản
            bool isAdmin = _userRoles.Contains("ADMIN");
            bool isManager = _userRoles.Contains("QUẢN LÝ") || _userRoles.Contains("QUAN LY");

            // Phân quyền mục Người Dùng: Chỉ ADMIN
            tsb_nguoidung.Visible = tsl_nguoidung.Visible = isAdmin;

            // Phân quyền mục Báo Cáo: ADMIN và QUẢN LÝ
            tsb_baocao.Visible = tsl_baocao.Visible = (isAdmin || isManager);
        }

        private void RegisterEvents()
        {
            // Trang chủ
            tsb_trangchu.Click += (s, e) => OpenChildForm(new FormTrangChu());
            tsl_trangchu.Click += (s, e) => OpenChildForm(new FormTrangChu());

            // Đơn hàng
            tsb_donhang.Click += (s, e) => OpenChildForm(new FormDonHang());
            tsl_donhang.Click += (s, e) => OpenChildForm(new FormDonHang());

            // Nhập kho
            tsb_nhap.Click += (s, e) => OpenChildForm(new FormNhap());
            tsl_nhap.Click += (s, e) => OpenChildForm(new FormNhap());

            // Xuất kho
            tsb_xuat.Click += (s, e) => OpenChildForm(new FormXuat());
            tsl_xuat.Click += (s, e) => OpenChildForm(new FormXuat());

            // Báo cáo
            tsb_baocao.Click += (s, e) => OpenChildForm(new FormBaoCao());
            tsl_baocao.Click += (s, e) => OpenChildForm(new FormBaoCao());

            // Người dùng
            tsb_nguoidung.Click += (s, e) => OpenChildForm(new FormNguoiDung());
            tsl_nguoidung.Click += (s, e) => OpenChildForm(new FormNguoiDung());
        }

        private void OpenChildForm(Form childForm)
        {
            // Kiểm tra tránh mở lại chính Form đang hiển thị để ngăn lỗi bộ nhớ
            if (activeForm != null && activeForm.GetType() == childForm.GetType())
                return;

            this.BeginInvoke(new Action(() =>
            {
                try
                {
                    // 1. Tạm dừng tính toán Layout để tránh xung đột resize
                    tlp_home.SuspendLayout();

                    // 2. Xử lý gỡ bỏ và giải phóng Form cũ hoàn toàn
                    if (activeForm != null)
                    {
                        tlp_home.Controls.Remove(activeForm);
                        activeForm.Close();
                        activeForm.Dispose();
                        activeForm = null;
                    }

                    // 3. Dọn dẹp ô nội dung (cột 1, hàng 0) để chắc chắn không còn control cũ
                    Control oldControl = tlp_home.GetControlFromPosition(1, 0);
                    if (oldControl != null)
                    {
                        tlp_home.Controls.Remove(oldControl);
                        oldControl.Dispose();
                    }

                    // 4. Thiết lập Form con mới
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;

                    // 5. Thêm vào container trước khi gọi lệnh Show
                    activeForm = childForm;
                    tlp_home.Controls.Add(childForm, 1, 0);

                    // Chỉ hiển thị sau khi đã được add vào container thành công
                    childForm.Show();
                    childForm.BringToFront();

                    // 6. Khôi phục lại Layout và ép buộc tính toán lại một lần duy nhất
                    tlp_home.ResumeLayout(true);
                    tlp_home.PerformLayout();
                }
                catch (Exception ex)
                {
                    if (tlp_home != null) tlp_home.ResumeLayout(true);
                    MessageBox.Show("Lỗi hiển thị Form: " + ex.Message);
                }
            }));
        }
    }
}