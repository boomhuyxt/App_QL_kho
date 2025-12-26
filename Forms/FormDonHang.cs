using App_QL_kho.Data;
using App_QL_kho.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
// Thư viện hỗ trợ xuất file
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace App_QL_kho.Forms
{
    public partial class FormDonHang : Form
    {
        public FormDonHang()
        {
            InitializeComponent();
            // Đăng ký sự kiện
            this.Load += FormDonHang_Load;
            this.txt_sanPham.TextChanged += (s, e) => FilterData();
            this.cmb_nhomSP.SelectedIndexChanged += (s, e) => FilterData();
            this.dtp_thoiGian.ValueChanged += (s, e) => FilterData();
            this.cb_XuatFile.SelectedIndexChanged += cb_XuatFile_SelectedIndexChanged;
        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadComboboxNhom();
            FilterData();
        }

        private void SetupDataGridView()
        {
            dgv_trangchu.AutoGenerateColumns = false;
            Column1.DataPropertyName = "Stt";
            Column2.DataPropertyName = "TenNhom";
            Column3.DataPropertyName = "TenSP";
            Column4.DataPropertyName = "TonKho";
            Column5.DataPropertyName = "GiaBan";
        }

        private void LoadComboboxNhom()
        {
            try
            {
                using (var db = new Model1())
                {
                    var listNhom = db.NhomSanPhams.ToList();
                    listNhom.Insert(0, new NhomSanPham { MaNhom = -1, TenNhom = "Tất cả nhóm" });
                    cmb_nhomSP.DataSource = listNhom;
                    cmb_nhomSP.DisplayMember = "TenNhom";
                    cmb_nhomSP.ValueMember = "MaNhom";
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void FilterData()
        {
            try
            {
                using (var db = new Model1())
                {
                    DateTime selectedDate = dtp_thoiGian.Value.Date;
                    var query = from sp in db.SanPhams
                                join nhom in db.NhomSanPhams on sp.MaNhom equals nhom.MaNhom
                                select new
                                {
                                    MaSP = sp.MaSP,
                                    TenNhom = nhom.TenNhom,
                                    TenSP = sp.TenSP,
                                    TonKho = sp.SoLuong,
                                    GiaBan = sp.GiaXuat,
                                    NgayNhap = db.CT_PhieuNhap.Where(ct => ct.MaSP == sp.MaSP).Max(ct => (DateTime?)ct.PhieuNhap.NgayNhap)
                                };

                    if (!string.IsNullOrWhiteSpace(txt_sanPham.Text))
                        query = query.Where(x => x.TenSP.ToLower().Contains(txt_sanPham.Text.ToLower()));

                    if (cmb_nhomSP.SelectedValue != null && (int)cmb_nhomSP.SelectedValue != -1)
                        query = query.Where(x => x.TenNhom == cmb_nhomSP.Text);

                    query = query.Where(x => x.NgayNhap >= selectedDate);

                    dgv_trangchu.DataSource = query.ToList().Select((x, index) => new Model_TrangChu
                    {
                        Stt = index + 1,
                        MaSP = x.MaSP,
                        TenNhom = x.TenNhom,
                        TenSP = x.TenSP,
                        TonKho = x.TonKho,
                        GiaBan = x.GiaBan,
                        NgayNhapGanNhat = x.NgayNhap
                    }).ToList();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        // --- XỬ LÝ XUẤT FILE ---
        private void cb_XuatFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_XuatFile.SelectedItem == null) return;
            string selectedType = cb_XuatFile.SelectedItem.ToString().ToUpper();

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                switch (selectedType)
                {
                    case "EXCEL":
                        sfd.Filter = "Excel Workbook|*.xlsx";
                        if (sfd.ShowDialog() == DialogResult.OK) ExportToExcel(sfd.FileName);
                        break;
                    case "PDF":
                        sfd.Filter = "PDF File|*.pdf";
                        if (sfd.ShowDialog() == DialogResult.OK) ExportToPDF(sfd.FileName);
                        break;
                    case "WORD":
                        sfd.Filter = "Word Document|*.docx";
                        if (sfd.ShowDialog() == DialogResult.OK) ExportToWord(sfd.FileName);
                        break;
                    case "TẤT CẢ":
                        sfd.Title = "Đặt tên file chung để xuất";
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            string dir = Path.GetDirectoryName(sfd.FileName);
                            string name = Path.GetFileNameWithoutExtension(sfd.FileName);
                            ExportToExcel(Path.Combine(dir, name + ".xlsx"));
                            ExportToPDF(Path.Combine(dir, name + ".pdf"));
                            ExportToWord(Path.Combine(dir, name + ".docx"));
                            MessageBox.Show("Đã xuất tất cả định dạng!");
                        }
                        break;
                }
            }
        }

        private void ExportToExcel(string path)
        {
            var excelApp = new Excel.Application();
            var workbook = excelApp.Workbooks.Add();
            var sheet = (Excel.Worksheet)workbook.Sheets[1];
            for (int i = 0; i < dgv_trangchu.Columns.Count; i++) sheet.Cells[1, i + 1] = dgv_trangchu.Columns[i].HeaderText;
            for (int i = 0; i < dgv_trangchu.Rows.Count; i++)
                for (int j = 0; j < dgv_trangchu.Columns.Count; j++)
                    sheet.Cells[i + 2, j + 1] = dgv_trangchu.Rows[i].Cells[j].Value?.ToString();
            workbook.SaveAs(path);
            excelApp.Quit();
        }

        private void ExportToPDF(string path)
        {
            Document doc = new Document(PageSize.A4.Rotate());
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();
            PdfPTable table = new PdfPTable(dgv_trangchu.Columns.Count);
            foreach (DataGridViewColumn col in dgv_trangchu.Columns) table.AddCell(new Phrase(col.HeaderText));
            foreach (DataGridViewRow row in dgv_trangchu.Rows)
                foreach (DataGridViewCell cell in row.Cells) table.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
            doc.Add(table);
            doc.Close();
        }

        private void ExportToWord(string path)
        {
            var wordApp = new Word.Application();
            var doc = wordApp.Documents.Add();
            var table = doc.Tables.Add(doc.Range(), dgv_trangchu.Rows.Count + 1, dgv_trangchu.Columns.Count);
            table.Borders.Enable = 1;
            for (int i = 0; i < dgv_trangchu.Columns.Count; i++) table.Cell(1, i + 1).Range.Text = dgv_trangchu.Columns[i].HeaderText;
            for (int i = 0; i < dgv_trangchu.Rows.Count; i++)
                for (int j = 0; j < dgv_trangchu.Columns.Count; j++)
                    table.Cell(i + 2, j + 1).Range.Text = dgv_trangchu.Rows[i].Cells[j].Value?.ToString();
            doc.SaveAs2(path);
            wordApp.Quit();
        }
    }
}