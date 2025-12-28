namespace App_QL_kho.Forms
{
    partial class FormBaoCao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtp_ToDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_FromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_thang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_nam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_giaNhap_thang = new System.Windows.Forms.TextBox();
            this.txt_giaBan_thang = new System.Windows.Forms.TextBox();
            this.txt_giaBan_nam = new System.Windows.Forms.TextBox();
            this.txt_giaNhap_nam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_chitietbaocao = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_thang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_nam)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_ToDate
            // 
            this.dtp_ToDate.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dtp_ToDate.CalendarMonthBackground = System.Drawing.Color.Snow;
            this.dtp_ToDate.CalendarTitleBackColor = System.Drawing.Color.LightCoral;
            this.dtp_ToDate.CalendarTitleForeColor = System.Drawing.Color.Firebrick;
            this.dtp_ToDate.CalendarTrailingForeColor = System.Drawing.Color.RosyBrown;
            this.dtp_ToDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ToDate.Location = new System.Drawing.Point(305, 23);
            this.dtp_ToDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ToDate.Name = "dtp_ToDate";
            this.dtp_ToDate.Size = new System.Drawing.Size(135, 25);
            this.dtp_ToDate.TabIndex = 2;
            // 
            // dtp_FromDate
            // 
            this.dtp_FromDate.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dtp_FromDate.CalendarMonthBackground = System.Drawing.Color.Snow;
            this.dtp_FromDate.CalendarTitleBackColor = System.Drawing.Color.LightCoral;
            this.dtp_FromDate.CalendarTitleForeColor = System.Drawing.Color.Firebrick;
            this.dtp_FromDate.CalendarTrailingForeColor = System.Drawing.Color.RosyBrown;
            this.dtp_FromDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FromDate.Location = new System.Drawing.Point(120, 23);
            this.dtp_FromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_FromDate.Name = "dtp_FromDate";
            this.dtp_FromDate.Size = new System.Drawing.Size(135, 25);
            this.dtp_FromDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(268, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "~";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian";
            // 
            // chart_thang
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_thang.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_thang.Legends.Add(legend3);
            this.chart_thang.Location = new System.Drawing.Point(42, 78);
            this.chart_thang.Name = "chart_thang";
            this.chart_thang.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_thang.Series.Add(series3);
            this.chart_thang.Size = new System.Drawing.Size(420, 300);
            this.chart_thang.TabIndex = 28;
            this.chart_thang.Text = "chart1";
            // 
            // chart_nam
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_nam.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_nam.Legends.Add(legend4);
            this.chart_nam.Location = new System.Drawing.Point(546, 78);
            this.chart_nam.Name = "chart_nam";
            this.chart_nam.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart_nam.Series.Add(series4);
            this.chart_nam.Size = new System.Drawing.Size(420, 300);
            this.chart_nam.TabIndex = 29;
            this.chart_nam.Text = "chart2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(134, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Theo tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(682, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Theo Năm";
            // 
            // txt_giaNhap_thang
            // 
            this.txt_giaNhap_thang.Location = new System.Drawing.Point(131, 414);
            this.txt_giaNhap_thang.Multiline = true;
            this.txt_giaNhap_thang.Name = "txt_giaNhap_thang";
            this.txt_giaNhap_thang.Size = new System.Drawing.Size(239, 27);
            this.txt_giaNhap_thang.TabIndex = 32;
            // 
            // txt_giaBan_thang
            // 
            this.txt_giaBan_thang.Location = new System.Drawing.Point(131, 447);
            this.txt_giaBan_thang.Multiline = true;
            this.txt_giaBan_thang.Name = "txt_giaBan_thang";
            this.txt_giaBan_thang.Size = new System.Drawing.Size(239, 27);
            this.txt_giaBan_thang.TabIndex = 33;
            // 
            // txt_giaBan_nam
            // 
            this.txt_giaBan_nam.Location = new System.Drawing.Point(664, 447);
            this.txt_giaBan_nam.Multiline = true;
            this.txt_giaBan_nam.Name = "txt_giaBan_nam";
            this.txt_giaBan_nam.Size = new System.Drawing.Size(239, 27);
            this.txt_giaBan_nam.TabIndex = 35;
            // 
            // txt_giaNhap_nam
            // 
            this.txt_giaNhap_nam.Location = new System.Drawing.Point(664, 414);
            this.txt_giaNhap_nam.Multiline = true;
            this.txt_giaNhap_nam.Name = "txt_giaNhap_nam";
            this.txt_giaNhap_nam.Size = new System.Drawing.Size(239, 27);
            this.txt_giaNhap_nam.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Giá nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Giá bán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(573, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 39;
            this.label7.Text = "Giá bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(572, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "Giá nhập";
            // 
            // cb_chitietbaocao
            // 
            this.cb_chitietbaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chitietbaocao.FormattingEnabled = true;
            this.cb_chitietbaocao.Items.AddRange(new object[] {
            "Báo cáo theo tháng",
            "Báo cáo theo năm"});
            this.cb_chitietbaocao.Location = new System.Drawing.Point(618, 23);
            this.cb_chitietbaocao.Name = "cb_chitietbaocao";
            this.cb_chitietbaocao.Size = new System.Drawing.Size(144, 26);
            this.cb_chitietbaocao.TabIndex = 40;
            this.cb_chitietbaocao.SelectedIndexChanged += new System.EventHandler(this.cb_chitietbaocao_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(473, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 24);
            this.label9.TabIndex = 41;
            this.label9.Text = "Chi tiết báo cáo";
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1018, 509);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_chitietbaocao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_giaBan_nam);
            this.Controls.Add(this.txt_giaNhap_nam);
            this.Controls.Add(this.txt_giaBan_thang);
            this.Controls.Add(this.txt_giaNhap_thang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart_nam);
            this.Controls.Add(this.chart_thang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_FromDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_ToDate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.chart_thang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_nam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_ToDate;
        private System.Windows.Forms.DateTimePicker dtp_FromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_thang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_giaNhap_thang;
        private System.Windows.Forms.TextBox txt_giaBan_thang;
        private System.Windows.Forms.TextBox txt_giaBan_nam;
        private System.Windows.Forms.TextBox txt_giaNhap_nam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_chitietbaocao;
        private System.Windows.Forms.Label label9;
    }
}