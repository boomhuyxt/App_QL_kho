using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QL_kho.Forms
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void cb_chitietbaocao_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn mục nào chưa
            if (cb_chitietbaocao.SelectedItem == null) return;

            string selectedItem = cb_chitietbaocao.SelectedItem.ToString();

            // 2. Sử dụng cấu trúc switch-case để mở Form tương ứng
            switch (selectedItem)
            {
                case "Báo cáo theo tháng": // Đảm bảo chuỗi này khớp chính xác với nội dung trong ComboBox
                    BaoCao_thang frmThang = new BaoCao_thang();
                    frmThang.StartPosition = FormStartPosition.CenterScreen; // Hiển thị giữa màn hình
                    frmThang.Show(); // Dùng .Show() để mở song song, .ShowDialog() nếu muốn khóa form chính
                    break;

                case "Báo cáo theo năm":
                    BaoCaoNam frmNam = new BaoCaoNam();
                    frmNam.StartPosition = FormStartPosition.CenterScreen;
                    frmNam.Show();
                    break;

                default:
                    // Có thể thêm thông báo hoặc xử lý mục khác nếu cần
                    break;
            }

            // 3. Tùy chọn: Reset lại ComboBox về trạng thái ban đầu sau khi chọn xong
            // cb_chitietbaocao.SelectedIndex = -1; 
        }
    }
}
