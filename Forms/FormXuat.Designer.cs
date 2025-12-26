namespace App_QL_kho
{
    partial class FormXuat
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXuat));
            this.pnl_productInfo = new System.Windows.Forms.Panel();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.txt_sanpham = new System.Windows.Forms.TextBox();
            this.cb_camera = new System.Windows.Forms.ComboBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.txt_tensanpham = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_banxuat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox_QR = new System.Windows.Forms.PictureBox();
            this.pictureBox_barcode = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnl_productInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banxuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_productInfo
            // 
            this.pnl_productInfo.Controls.Add(this.btn_xuat);
            this.pnl_productInfo.Controls.Add(this.label4);
            this.pnl_productInfo.Controls.Add(this.label3);
            this.pnl_productInfo.Controls.Add(this.label2);
            this.pnl_productInfo.Controls.Add(this.txt_giaban);
            this.pnl_productInfo.Controls.Add(this.txt_sanpham);
            this.pnl_productInfo.Controls.Add(this.cb_camera);
            this.pnl_productInfo.Controls.Add(this.btnStop);
            this.pnl_productInfo.Controls.Add(this.txt_tensanpham);
            this.pnl_productInfo.Controls.Add(this.btnStart);
            this.pnl_productInfo.Controls.Add(this.pictureBox);
            this.pnl_productInfo.Controls.Add(this.label1);
            this.pnl_productInfo.Location = new System.Drawing.Point(941, 0);
            this.pnl_productInfo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pnl_productInfo.Name = "pnl_productInfo";
            this.pnl_productInfo.Size = new System.Drawing.Size(401, 612);
            this.pnl_productInfo.TabIndex = 1;
            // 
            // btn_xuat
            // 
            this.btn_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuat.Location = new System.Drawing.Point(23, 577);
            this.btn_xuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(100, 31);
            this.btn_xuat.TabIndex = 10;
            this.btn_xuat.Text = "Xuất";
            this.btn_xuat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 486);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giá bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 411);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txt_giaban
            // 
            this.txt_giaban.Location = new System.Drawing.Point(23, 512);
            this.txt_giaban.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_giaban.Multiline = true;
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Size = new System.Drawing.Size(364, 38);
            this.txt_giaban.TabIndex = 6;
            // 
            // txt_sanpham
            // 
            this.txt_sanpham.Location = new System.Drawing.Point(23, 437);
            this.txt_sanpham.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_sanpham.Multiline = true;
            this.txt_sanpham.Name = "txt_sanpham";
            this.txt_sanpham.Size = new System.Drawing.Size(364, 38);
            this.txt_sanpham.TabIndex = 5;
            // 
            // cb_camera
            // 
            this.cb_camera.FormattingEnabled = true;
            this.cb_camera.Location = new System.Drawing.Point(56, 42);
            this.cb_camera.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cb_camera.Name = "cb_camera";
            this.cb_camera.Size = new System.Drawing.Size(299, 24);
            this.cb_camera.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(253, 282);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(101, 33);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Tắt";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txt_tensanpham
            // 
            this.txt_tensanpham.Location = new System.Drawing.Point(23, 366);
            this.txt_tensanpham.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_tensanpham.Multiline = true;
            this.txt_tensanpham.Name = "txt_tensanpham";
            this.txt_tensanpham.Size = new System.Drawing.Size(364, 38);
            this.txt_tensanpham.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(56, 282);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 33);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Bật";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(23, 74);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(365, 197);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sản phẩm";
            // 
            // dgv_banxuat
            // 
            this.dgv_banxuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_banxuat.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_banxuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_banxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_banxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_banxuat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_banxuat.EnableHeadersVisualStyles = false;
            this.dgv_banxuat.Location = new System.Drawing.Point(0, 0);
            this.dgv_banxuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_banxuat.Name = "dgv_banxuat";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_banxuat.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_banxuat.RowHeadersWidth = 51;
            this.dgv_banxuat.RowTemplate.Height = 24;
            this.dgv_banxuat.Size = new System.Drawing.Size(936, 417);
            this.dgv_banxuat.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 159.0909F;
            this.Column1.HeaderText = "Sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 89.52187F;
            this.Column2.HeaderText = "SL";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 70.56429F;
            this.Column3.HeaderText = "Giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 80.82293F;
            this.Column4.HeaderText = "Mã QR";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // pictureBox_QR
            // 
            this.pictureBox_QR.Location = new System.Drawing.Point(144, 422);
            this.pictureBox_QR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_QR.Name = "pictureBox_QR";
            this.pictureBox_QR.Size = new System.Drawing.Size(224, 190);
            this.pictureBox_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_QR.TabIndex = 0;
            this.pictureBox_QR.TabStop = false;
            // 
            // pictureBox_barcode
            // 
            this.pictureBox_barcode.Location = new System.Drawing.Point(528, 463);
            this.pictureBox_barcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_barcode.Name = "pictureBox_barcode";
            this.pictureBox_barcode.Size = new System.Drawing.Size(296, 89);
            this.pictureBox_barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_barcode.TabIndex = 4;
            this.pictureBox_barcode.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1357, 626);
            this.Controls.Add(this.pictureBox_barcode);
            this.Controls.Add(this.pictureBox_QR);
            this.Controls.Add(this.dgv_banxuat);
            this.Controls.Add(this.pnl_productInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "FormXuat";
            this.Text = "PhieuXuat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_productInfo.ResumeLayout(false);
            this.pnl_productInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banxuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_productInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_camera;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txt_tensanpham;
        private System.Windows.Forms.DataGridView dgv_banxuat;
        private System.Windows.Forms.PictureBox pictureBox_QR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox pictureBox_barcode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_giaban;
        private System.Windows.Forms.TextBox txt_sanpham;
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

