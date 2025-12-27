using System;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace App_QL_kho.Services
{
    public static class ExportService
    {
        public static void ExportToExcel(DataGridView dgv, string path)
        {
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null) return;

            excelApp.DisplayAlerts = false;
            Excel.Workbooks workbooks = excelApp.Workbooks;
            Excel.Workbook workbook = workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

            try
            {
                // Xuất Header
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }

                // Xuất Data
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }

                // Lệnh quan trọng: Lưu và đóng
                workbook.SaveAs(path);
                workbook.Close();
            }
            finally
            {
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                GC.Collect(); // Dọn dẹp bộ nhớ ngay lập tức
            }
        }

        public static void ExportToPDF(DataGridView dgv, string path)
        {
            // Sử dụng font hỗ trợ tiếng Việt nếu cần (BaseFont)
            Document doc = new Document(PageSize.A4.Rotate());
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(doc, fs);
                doc.Open();
                PdfPTable table = new PdfPTable(dgv.Columns.Count);

                foreach (DataGridViewColumn col in dgv.Columns)
                    table.AddCell(new Phrase(col.HeaderText));

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        table.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
                }
                doc.Add(table);
                doc.Close(); // Đóng stream để ghi file xuống đĩa
            }
        }

        public static void ExportToWord(DataGridView dgv, string path)
        {
            Word.Application wordApp = new Word.Application();
            wordApp.DisplayAlerts = Word.WdAlertLevel.wdAlertsNone;
            Word.Documents docs = wordApp.Documents;
            Word.Document doc = docs.Add();

            try
            {
                Word.Table table = doc.Tables.Add(doc.Range(), dgv.Rows.Count + 1, dgv.Columns.Count);
                table.Borders.Enable = 1;

                for (int i = 0; i < dgv.Columns.Count; i++)
                    table.Cell(1, i + 1).Range.Text = dgv.Columns[i].HeaderText;

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        table.Cell(i + 2, j + 1).Range.Text = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }

                doc.SaveAs2(path);
                doc.Close();
            }
            finally
            {
                wordApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(doc);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
                GC.Collect();
            }
        }
    }
}