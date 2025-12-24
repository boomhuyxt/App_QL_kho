namespace App_QL_kho
{
    partial class FormTrangChu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            this.tlp_home = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_orderManagement = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_filter = new System.Windows.Forms.Panel();
            this.dtp_thoiGian = new System.Windows.Forms.DateTimePicker();
            this.txt_sanPham = new System.Windows.Forms.TextBox();
            this.cmb_trangThai = new System.Windows.Forms.ComboBox();
            this.cmb_nhomSP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tlp_home.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderManagement)).BeginInit();
            this.pnl_filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_home
            // 
            this.tlp_home.ColumnCount = 2;
            this.tlp_home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlp_home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tlp_home.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tlp_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_home.Location = new System.Drawing.Point(0, 0);
            this.tlp_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlp_home.Name = "tlp_home";
            this.tlp_home.RowCount = 1;
            this.tlp_home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_home.Size = new System.Drawing.Size(1087, 516);
            this.tlp_home.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_orderManagement, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnl_filter, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(89, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(995, 512);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgv_orderManagement
            // 
            this.dgv_orderManagement.AllowUserToOrderColumns = true;
            this.dgv_orderManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_orderManagement.BackgroundColor = System.Drawing.Color.Snow;
            this.dgv_orderManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orderManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_orderManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_orderManagement.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_orderManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_orderManagement.EnableHeadersVisualStyles = false;
            this.dgv_orderManagement.GridColor = System.Drawing.Color.LightBlue;
            this.dgv_orderManagement.Location = new System.Drawing.Point(3, 104);
            this.dgv_orderManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_orderManagement.Name = "dgv_orderManagement";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orderManagement.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_orderManagement.RowHeadersWidth = 62;
            this.dgv_orderManagement.RowTemplate.Height = 28;
            this.dgv_orderManagement.Size = new System.Drawing.Size(989, 406);
            this.dgv_orderManagement.TabIndex = 2;
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
            this.Column5.HeaderText = "Mã QR";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // pnl_filter
            // 
            this.pnl_filter.Controls.Add(this.dtp_thoiGian);
            this.pnl_filter.Controls.Add(this.txt_sanPham);
            this.pnl_filter.Controls.Add(this.cmb_trangThai);
            this.pnl_filter.Controls.Add(this.cmb_nhomSP);
            this.pnl_filter.Controls.Add(this.label4);
            this.pnl_filter.Controls.Add(this.label3);
            this.pnl_filter.Controls.Add(this.label2);
            this.pnl_filter.Controls.Add(this.label1);
            this.pnl_filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_filter.Location = new System.Drawing.Point(3, 2);
            this.pnl_filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_filter.Name = "pnl_filter";
            this.pnl_filter.Size = new System.Drawing.Size(989, 98);
            this.pnl_filter.TabIndex = 0;
            // 
            // dtp_thoiGian
            // 
            this.dtp_thoiGian.Location = new System.Drawing.Point(617, 59);
            this.dtp_thoiGian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_thoiGian.Name = "dtp_thoiGian";
            this.dtp_thoiGian.Size = new System.Drawing.Size(179, 22);
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
            // cmb_trangThai
            // 
            this.cmb_trangThai.FormattingEnabled = true;
            this.cmb_trangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Còn tồn kho",
            "Đã xuất kho"});
            this.cmb_trangThai.Location = new System.Drawing.Point(617, 17);
            this.cmb_trangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_trangThai.Name = "cmb_trangThai";
            this.cmb_trangThai.Size = new System.Drawing.Size(283, 24);
            this.cmb_trangThai.TabIndex = 8;
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
            this.label4.Location = new System.Drawing.Point(524, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(524, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trạng thái";
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
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1087, 516);
            this.Controls.Add(this.tlp_home);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTrangChu";
            this.Text = "TrangChu";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.tlp_home.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderManagement)).EndInit();
            this.pnl_filter.ResumeLayout(false);
            this.pnl_filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_home;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnl_filter;
        private System.Windows.Forms.DateTimePicker dtp_thoiGian;
        private System.Windows.Forms.TextBox txt_sanPham;
        private System.Windows.Forms.ComboBox cmb_trangThai;
        private System.Windows.Forms.ComboBox cmb_nhomSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_orderManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}