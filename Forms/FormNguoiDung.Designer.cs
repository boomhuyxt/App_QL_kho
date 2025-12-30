namespace App_QL_kho.Forms
{
    partial class FormNguoiDung
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
            this.gb_profile = new System.Windows.Forms.GroupBox();
            this.NHANVIEN = new System.Windows.Forms.RadioButton();
            this.QUANLY = new System.Windows.Forms.RadioButton();
            this.ADMIN = new System.Windows.Forms.RadioButton();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_chan = new System.Windows.Forms.Button();
            this.txt_timkiemTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_nguoidung = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoidung)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_profile
            // 
            this.gb_profile.Controls.Add(this.NHANVIEN);
            this.gb_profile.Controls.Add(this.QUANLY);
            this.gb_profile.Controls.Add(this.ADMIN);
            this.gb_profile.Controls.Add(this.btn_sua);
            this.gb_profile.Controls.Add(this.btn_chan);
            this.gb_profile.Controls.Add(this.txt_timkiemTen);
            this.gb_profile.Controls.Add(this.label3);
            this.gb_profile.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_profile.ForeColor = System.Drawing.Color.White;
            this.gb_profile.Location = new System.Drawing.Point(11, 12);
            this.gb_profile.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gb_profile.Name = "gb_profile";
            this.gb_profile.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gb_profile.Size = new System.Drawing.Size(996, 79);
            this.gb_profile.TabIndex = 3;
            this.gb_profile.TabStop = false;
            this.gb_profile.Text = "Thông tin tài khoản";
            // 
            // NHANVIEN
            // 
            this.NHANVIEN.AutoSize = true;
            this.NHANVIEN.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHANVIEN.Location = new System.Drawing.Point(568, 31);
            this.NHANVIEN.Name = "NHANVIEN";
            this.NHANVIEN.Size = new System.Drawing.Size(135, 29);
            this.NHANVIEN.TabIndex = 19;
            this.NHANVIEN.TabStop = true;
            this.NHANVIEN.Text = "NHÂN VIÊN";
            this.NHANVIEN.UseVisualStyleBackColor = true;
            // 
            // QUANLY
            // 
            this.QUANLY.AutoSize = true;
            this.QUANLY.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUANLY.Location = new System.Drawing.Point(432, 31);
            this.QUANLY.Name = "QUANLY";
            this.QUANLY.Size = new System.Drawing.Size(109, 29);
            this.QUANLY.TabIndex = 18;
            this.QUANLY.TabStop = true;
            this.QUANLY.Text = "QUẢN LÝ";
            this.QUANLY.UseVisualStyleBackColor = true;
            // 
            // ADMIN
            // 
            this.ADMIN.AutoSize = true;
            this.ADMIN.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMIN.Location = new System.Drawing.Point(305, 31);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(96, 29);
            this.ADMIN.TabIndex = 17;
            this.ADMIN.TabStop = true;
            this.ADMIN.Text = "ADMIN";
            this.ADMIN.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(871, 26);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(105, 40);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_chan
            // 
            this.btn_chan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btn_chan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chan.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chan.ForeColor = System.Drawing.Color.Black;
            this.btn_chan.Location = new System.Drawing.Point(753, 26);
            this.btn_chan.Name = "btn_chan";
            this.btn_chan.Size = new System.Drawing.Size(105, 40);
            this.btn_chan.TabIndex = 15;
            this.btn_chan.Text = "Chặn";
            this.btn_chan.UseVisualStyleBackColor = false;
            this.btn_chan.Click += new System.EventHandler(this.btn_chan_Click);
            // 
            // txt_timkiemTen
            // 
            this.txt_timkiemTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.txt_timkiemTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_timkiemTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiemTen.ForeColor = System.Drawing.Color.White;
            this.txt_timkiemTen.Location = new System.Drawing.Point(86, 39);
            this.txt_timkiemTen.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_timkiemTen.Name = "txt_timkiemTen";
            this.txt_timkiemTen.Size = new System.Drawing.Size(203, 25);
            this.txt_timkiemTen.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tìm kiếm";
            // 
            // dgv_nguoidung
            // 
            this.dgv_nguoidung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nguoidung.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nguoidung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_nguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nguoidung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_nguoidung.EnableHeadersVisualStyles = false;
            this.dgv_nguoidung.Location = new System.Drawing.Point(12, 96);
            this.dgv_nguoidung.Name = "dgv_nguoidung";
            this.dgv_nguoidung.RowHeadersWidth = 51;
            this.dgv_nguoidung.Size = new System.Drawing.Size(995, 404);
            this.dgv_nguoidung.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "HỌ TÊN";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "EMAIL";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NGAY TẠO";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "VAI TRÒ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "HIỆN TRẠNG";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // FormNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1018, 508);
            this.Controls.Add(this.dgv_nguoidung);
            this.Controls.Add(this.gb_profile);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FormNguoiDung";
            this.Text = "FormNguoiDung";
            this.gb_profile.ResumeLayout(false);
            this.gb_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoidung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_profile;
        private System.Windows.Forms.TextBox txt_timkiemTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_nguoidung;
        private System.Windows.Forms.Button btn_chan;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.RadioButton NHANVIEN;
        private System.Windows.Forms.RadioButton QUANLY;
        private System.Windows.Forms.RadioButton ADMIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}