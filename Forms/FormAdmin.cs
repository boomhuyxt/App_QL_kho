using System;
using System.Windows.Forms;

namespace App_QL_kho.Forms
{
    public partial class FormAdmin : Form
    {
        private Form activeForm = null;

        public FormAdmin()
        {
            InitializeComponent();
            RegisterEvents();

            this.Load += (s, e) => {
                if (activeForm == null) OpenChildForm(new FormTrangChu());
            };
        }

        private void RegisterEvents()
        {
            tsb_trangchu.Click += (s, e) => OpenChildForm(new FormTrangChu());
            tsl_trangchu.Click += (s, e) => OpenChildForm(new FormTrangChu());

            // Sửa lỗi nhấn vào Đơn hàng
            tsb_donhang.Click += (s, e) => OpenChildForm(new FormDonHang());
            tsl_donhang.Click += (s, e) => OpenChildForm(new FormDonHang());

            tsb_nhap.Click += (s, e) => OpenChildForm(new FormNhap());
            tsl_nhap.Click += (s, e) => OpenChildForm(new FormNhap());

            tsb_xuat.Click += (s, e) => OpenChildForm(new FormXuat());
            tsl_xuat.Click += (s, e) => OpenChildForm(new FormXuat());

            tsb_baocao.Click += (s, e) => OpenChildForm(new FormBaoCao());
            tsl_baocao.Click += (s, e) => OpenChildForm(new FormBaoCao());

            tsb_nguoidung.Click += (s, e) => OpenChildForm(new FormNguoiDung());
            tsl_nguoidung.Click += (s, e) => OpenChildForm(new FormNguoiDung());
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null && activeForm.GetType() == childForm.GetType()) return;

            this.BeginInvoke(new Action(() =>
            {
                try
                {
                    // 1. Tạm dừng Layout
                    tlp_home.SuspendLayout();

                    // 2. Thiết lập Form con TRƯỚC KHI gán
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;

                    // 3. Xử lý Form cũ
                    if (activeForm != null)
                    {
                        activeForm.Hide(); // Ẩn trước để giải phóng giao diện nhanh
                        activeForm.Close();
                        activeForm.Dispose();
                    }

                    // 4. Xóa sạch ô nội dung một cách an toàn
                    Control oldControl = tlp_home.GetControlFromPosition(1, 0);
                    while (oldControl != null)
                    {
                        tlp_home.Controls.Remove(oldControl);
                        if (!oldControl.IsDisposed) oldControl.Dispose();
                        oldControl = tlp_home.GetControlFromPosition(1, 0);
                    }

                    // 5. HIỆN FORM CON TRƯỚC KHI ADD (Để Windows ko phải resize khi form đang ẩn)
                    childForm.Show();

                    // 6. Thêm vào TableLayoutPanel
                    activeForm = childForm;
                    tlp_home.Controls.Add(childForm, 1, 0);
                    childForm.BringToFront();

                    // 7. Tiếp tục Layout mà KHÔNG ép buộc resize sâu (tham số false)
                    tlp_home.ResumeLayout(false);
                    tlp_home.PerformLayout(); // Ép thực hiện vẽ lại sau khi đã ổn định
                }
                catch (Exception ex)
                {
                    string msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                    MessageBox.Show("Lỗi hiển thị Form: " + msg);
                    if (tlp_home != null) tlp_home.ResumeLayout(true);
                }
            }));
        }
    }
}