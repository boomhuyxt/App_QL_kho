namespace App_QL_kho.Forms
{
    partial class BaoCao_thang
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SoluongConTon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SanPhamBanChay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SoluongBanRa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tongDanhThu = new System.Windows.Forms.TextBox();
            this.dgv_baocao = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.cb_xuat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baocao)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(312, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "số luộng cồn tồn";
            // 
            // txt_SoluongConTon
            // 
            this.txt_SoluongConTon.Location = new System.Drawing.Point(444, 460);
            this.txt_SoluongConTon.Name = "txt_SoluongConTon";
            this.txt_SoluongConTon.Size = new System.Drawing.Size(137, 20);
            this.txt_SoluongConTon.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(291, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "sản phảm bán chạy";
            // 
            // txt_SanPhamBanChay
            // 
            this.txt_SanPhamBanChay.Location = new System.Drawing.Point(444, 421);
            this.txt_SanPhamBanChay.Name = "txt_SanPhamBanChay";
            this.txt_SanPhamBanChay.Size = new System.Drawing.Size(137, 20);
            this.txt_SanPhamBanChay.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "số lượng đã xuất ra";
            // 
            // txt_SoluongBanRa
            // 
            this.txt_SoluongBanRa.Location = new System.Drawing.Point(161, 460);
            this.txt_SoluongBanRa.Name = "txt_SoluongBanRa";
            this.txt_SoluongBanRa.Size = new System.Drawing.Size(126, 20);
            this.txt_SoluongBanRa.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "tổng danh thu";
            // 
            // txt_tongDanhThu
            // 
            this.txt_tongDanhThu.Location = new System.Drawing.Point(141, 421);
            this.txt_tongDanhThu.Name = "txt_tongDanhThu";
            this.txt_tongDanhThu.Size = new System.Drawing.Size(119, 20);
            this.txt_tongDanhThu.TabIndex = 10;
            // 
            // dgv_baocao
            // 
            this.dgv_baocao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_baocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_baocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_baocao.Location = new System.Drawing.Point(12, 29);
            this.dgv_baocao.Name = "dgv_baocao";
            this.dgv_baocao.Size = new System.Drawing.Size(994, 376);
            this.dgv_baocao.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TÊN SẢN PHẨM";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SỐ LƯỢNG";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "GIÁ BÁN";
            this.Column4.Name = "Column4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(593, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Xuất file";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // cb_xuat
            // 
            this.cb_xuat.FormattingEnabled = true;
            this.cb_xuat.Location = new System.Drawing.Point(667, 419);
            this.cb_xuat.Name = "cb_xuat";
            this.cb_xuat.Size = new System.Drawing.Size(121, 21);
            this.cb_xuat.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(592, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "tìm kiếm";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(667, 460);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(137, 20);
            this.txt_TimKiem.TabIndex = 21;
            // 
            // BaoCao_thang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1018, 509);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.cb_xuat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_SoluongConTon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_SanPhamBanChay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SoluongBanRa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tongDanhThu);
            this.Controls.Add(this.dgv_baocao);
            this.Name = "BaoCao_thang";
            this.Text = "BaoCao_thang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baocao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SoluongConTon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SanPhamBanChay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SoluongBanRa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tongDanhThu;
        private System.Windows.Forms.DataGridView dgv_baocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label5;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ComboBox cb_xuat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TimKiem;
    }
}