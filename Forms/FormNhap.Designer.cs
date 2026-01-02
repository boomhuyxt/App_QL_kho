namespace App_QL_kho.Forms
{
    partial class FormNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhap));
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_nhapdonhang = new System.Windows.Forms.DataGridView();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txt_tensanpham = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_gianhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_giaxuat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_nhomsanpham = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nhapthongtin = new System.Windows.Forms.Panel();
            this.pictureBoxBarCord = new System.Windows.Forms.PictureBox();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapdonhang)).BeginInit();
            this.nhapthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarCord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // Column5
            // 
            this.Column5.FillWeight = 120.8137F;
            this.Column5.HeaderText = "Giá Xuất";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 137.5899F;
            this.Column3.HeaderText = "Giá Nhập";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 57.26455F;
            this.Column2.HeaderText = "SL";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 90.9321F;
            this.Column4.HeaderText = "Nhóm sản phẩm";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 93.39974F;
            this.Column1.HeaderText = "Sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // dgv_nhapdonhang
            // 
            this.dgv_nhapdonhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nhapdonhang.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nhapdonhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_nhapdonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhapdonhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_nhapdonhang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_nhapdonhang.EnableHeadersVisualStyles = false;
            this.dgv_nhapdonhang.Location = new System.Drawing.Point(12, 14);
            this.dgv_nhapdonhang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgv_nhapdonhang.Name = "dgv_nhapdonhang";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nhapdonhang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_nhapdonhang.RowHeadersWidth = 51;
            this.dgv_nhapdonhang.RowTemplate.Height = 24;
            this.dgv_nhapdonhang.Size = new System.Drawing.Size(962, 534);
            this.dgv_nhapdonhang.TabIndex = 11;
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhap.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Location = new System.Drawing.Point(206, 648);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(135, 55);
            this.btnNhap.TabIndex = 13;
            this.btnNhap.Text = "Nhập ";
            this.btnNhap.UseVisualStyleBackColor = false;
            // 
            // txt_tensanpham
            // 
            this.txt_tensanpham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.txt_tensanpham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tensanpham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tensanpham.ForeColor = System.Drawing.Color.White;
            this.txt_tensanpham.Location = new System.Drawing.Point(52, 143);
            this.txt_tensanpham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tensanpham.Name = "txt_tensanpham";
            this.txt_tensanpham.Size = new System.Drawing.Size(446, 34);
            this.txt_tensanpham.TabIndex = 14;
            // 
            // txt_soluong
            // 
            this.txt_soluong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.txt_soluong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soluong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.ForeColor = System.Drawing.Color.White;
            this.txt_soluong.Location = new System.Drawing.Point(52, 365);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(446, 34);
            this.txt_soluong.TabIndex = 15;
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.txt_gianhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gianhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gianhap.ForeColor = System.Drawing.Color.White;
            this.txt_gianhap.Location = new System.Drawing.Point(52, 475);
            this.txt_gianhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.Size = new System.Drawing.Size(446, 34);
            this.txt_gianhap.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 38);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 38);
            this.label3.TabIndex = 18;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 428);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 38);
            this.label4.TabIndex = 19;
            this.label4.Text = "Giá nhập";
            // 
            // txt_giaxuat
            // 
            this.txt_giaxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.txt_giaxuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_giaxuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaxuat.ForeColor = System.Drawing.Color.White;
            this.txt_giaxuat.Location = new System.Drawing.Point(52, 589);
            this.txt_giaxuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_giaxuat.Name = "txt_giaxuat";
            this.txt_giaxuat.Size = new System.Drawing.Size(446, 34);
            this.txt_giaxuat.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 538);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 38);
            this.label5.TabIndex = 21;
            this.label5.Text = "Giá xuất";
            // 
            // cb_nhomsanpham
            // 
            this.cb_nhomsanpham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.cb_nhomsanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_nhomsanpham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nhomsanpham.ForeColor = System.Drawing.Color.White;
            this.cb_nhomsanpham.FormattingEnabled = true;
            this.cb_nhomsanpham.Location = new System.Drawing.Point(52, 248);
            this.cb_nhomsanpham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_nhomsanpham.Name = "cb_nhomsanpham";
            this.cb_nhomsanpham.Size = new System.Drawing.Size(446, 36);
            this.cb_nhomsanpham.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 38);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nhóm sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 54);
            this.label1.TabIndex = 24;
            this.label1.Text = "Thông tin sản phẩm";
            // 
            // nhapthongtin
            // 
            this.nhapthongtin.Controls.Add(this.label1);
            this.nhapthongtin.Controls.Add(this.label6);
            this.nhapthongtin.Controls.Add(this.cb_nhomsanpham);
            this.nhapthongtin.Controls.Add(this.label5);
            this.nhapthongtin.Controls.Add(this.txt_giaxuat);
            this.nhapthongtin.Controls.Add(this.label4);
            this.nhapthongtin.Controls.Add(this.label3);
            this.nhapthongtin.Controls.Add(this.label2);
            this.nhapthongtin.Controls.Add(this.txt_gianhap);
            this.nhapthongtin.Controls.Add(this.txt_soluong);
            this.nhapthongtin.Controls.Add(this.txt_tensanpham);
            this.nhapthongtin.Controls.Add(this.btnNhap);
            this.nhapthongtin.Location = new System.Drawing.Point(980, 14);
            this.nhapthongtin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nhapthongtin.Name = "nhapthongtin";
            this.nhapthongtin.Size = new System.Drawing.Size(544, 725);
            this.nhapthongtin.TabIndex = 8;
            // 
            // pictureBoxBarCord
            // 
            this.pictureBoxBarCord.Location = new System.Drawing.Point(598, 589);
            this.pictureBoxBarCord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxBarCord.Name = "pictureBoxBarCord";
            this.pictureBoxBarCord.Size = new System.Drawing.Size(318, 151);
            this.pictureBoxBarCord.TabIndex = 10;
            this.pictureBoxBarCord.TabStop = false;
            this.pictureBoxBarCord.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Location = new System.Drawing.Point(124, 555);
            this.pictureBoxQR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(368, 209);
            this.pictureBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQR.TabIndex = 9;
            this.pictureBoxQR.TabStop = false;
            // 
            // FormNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1527, 783);
            this.Controls.Add(this.dgv_nhapdonhang);
            this.Controls.Add(this.pictureBoxBarCord);
            this.Controls.Add(this.pictureBoxQR);
            this.Controls.Add(this.nhapthongtin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNhap";
            this.Text = "FormNhap";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapdonhang)).EndInit();
            this.nhapthongtin.ResumeLayout(false);
            this.nhapthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarCord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgv_nhapdonhang;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txt_tensanpham;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_gianhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_giaxuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_nhomsanpham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel nhapthongtin;
        private System.Windows.Forms.PictureBox pictureBoxQR;
        private System.Windows.Forms.PictureBox pictureBoxBarCord;
    }
}