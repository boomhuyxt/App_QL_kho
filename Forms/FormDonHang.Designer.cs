namespace App_QL_kho.Forms
{
    partial class FormDonHang
    {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_filter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_trangchu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_thoiGian = new System.Windows.Forms.DateTimePicker();
            this.txt_sanPham = new System.Windows.Forms.TextBox();
            this.cmb_nhomSP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_XuatFile = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_filter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trangchu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_filter
            // 
            this.pnl_filter.Controls.Add(this.label3);
            this.pnl_filter.Controls.Add(this.cb_XuatFile);
            this.pnl_filter.Controls.Add(this.panel1);
            this.pnl_filter.Controls.Add(this.dtp_thoiGian);
            this.pnl_filter.Controls.Add(this.txt_sanPham);
            this.pnl_filter.Controls.Add(this.cmb_nhomSP);
            this.pnl_filter.Controls.Add(this.label4);
            this.pnl_filter.Controls.Add(this.label2);
            this.pnl_filter.Controls.Add(this.label1);
            this.pnl_filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_filter.Location = new System.Drawing.Point(0, 0);
            this.pnl_filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_filter.Name = "pnl_filter";
            this.pnl_filter.Size = new System.Drawing.Size(1357, 626);
            this.pnl_filter.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_trangchu);
            this.panel1.Location = new System.Drawing.Point(3, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 504);
            this.panel1.TabIndex = 12;
            // 
            // dgv_trangchu
            // 
            this.dgv_trangchu.AllowUserToOrderColumns = true;
            this.dgv_trangchu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_trangchu.BackgroundColor = System.Drawing.Color.Snow;
            this.dgv_trangchu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_trangchu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_trangchu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trangchu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_trangchu.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_trangchu.EnableHeadersVisualStyles = false;
            this.dgv_trangchu.GridColor = System.Drawing.Color.LightBlue;
            this.dgv_trangchu.Location = new System.Drawing.Point(11, -2);
            this.dgv_trangchu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_trangchu.Name = "dgv_trangchu";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_trangchu.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_trangchu.RowHeadersWidth = 62;
            this.dgv_trangchu.RowTemplate.Height = 28;
            this.dgv_trangchu.Size = new System.Drawing.Size(1337, 504);
            this.dgv_trangchu.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nhóm sản phẩm";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sản phẩm";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tồn kho";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giá bán";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dtp_thoiGian
            // 
            this.dtp_thoiGian.Location = new System.Drawing.Point(612, 18);
            this.dtp_thoiGian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_thoiGian.Name = "dtp_thoiGian";
            this.dtp_thoiGian.Size = new System.Drawing.Size(245, 22);
            this.dtp_thoiGian.TabIndex = 11;
            // 
            // txt_sanPham
            // 
            this.txt_sanPham.Location = new System.Drawing.Point(236, 59);
            this.txt_sanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sanPham.Name = "txt_sanPham";
            this.txt_sanPham.Size = new System.Drawing.Size(283, 22);
            this.txt_sanPham.TabIndex = 10;
            // 
            // cmb_nhomSP
            // 
            this.cmb_nhomSP.FormattingEnabled = true;
            this.cmb_nhomSP.Location = new System.Drawing.Point(236, 16);
            this.cmb_nhomSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_nhomSP.Name = "cmb_nhomSP";
            this.cmb_nhomSP.Size = new System.Drawing.Size(283, 24);
            this.cmb_nhomSP.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(525, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhóm sản phẩm";
            // 
            // cb_XuatFile
            // 
            this.cb_XuatFile.FormattingEnabled = true;
            this.cb_XuatFile.Items.AddRange(new object[] {
            "Tất cả",
            "PDF",
            "EXCEL",
            "WORD"});
            this.cb_XuatFile.Location = new System.Drawing.Point(612, 56);
            this.cb_XuatFile.Name = "cb_XuatFile";
            this.cb_XuatFile.Size = new System.Drawing.Size(245, 24);
            this.cb_XuatFile.TabIndex = 13;
            this.cb_XuatFile.SelectedIndexChanged += new System.EventHandler(this.cb_XuatFile_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(525, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Xuat file";
            // 
            // FormDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1357, 626);
            this.Controls.Add(this.pnl_filter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDonHang";
            this.Text = "TrangChu";
            this.pnl_filter.ResumeLayout(false);
            this.pnl_filter.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trangchu)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Panel pnl_filter;
        private System.Windows.Forms.DateTimePicker dtp_thoiGian;
        private System.Windows.Forms.TextBox txt_sanPham;
        private System.Windows.Forms.ComboBox cmb_nhomSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_trangchu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_XuatFile;
    }
    }