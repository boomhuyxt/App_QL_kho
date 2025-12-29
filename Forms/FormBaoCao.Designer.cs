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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_chitietbaocao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_FromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_ToDate = new System.Windows.Forms.DateTimePicker();
            this.chart_nam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_thang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_gianhap_than = new System.Windows.Forms.TextBox();
            this.txt_giaba_thang = new System.Windows.Forms.TextBox();
            this.txt_gianhap_nam = new System.Windows.Forms.TextBox();
            this.txt_giaban_nam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_nam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_thang)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(882, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 32);
            this.label9.TabIndex = 49;
            this.label9.Text = "Chi tiết ";
            // 
            // cb_chitietbaocao
            // 
            this.cb_chitietbaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chitietbaocao.FormattingEnabled = true;
            this.cb_chitietbaocao.Items.AddRange(new object[] {
            "Báo cáo theo tháng",
            "Báo cáo theo năm"});
            this.cb_chitietbaocao.Location = new System.Drawing.Point(988, 50);
            this.cb_chitietbaocao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_chitietbaocao.Name = "cb_chitietbaocao";
            this.cb_chitietbaocao.Size = new System.Drawing.Size(214, 37);
            this.cb_chitietbaocao.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(550, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 28);
            this.label2.TabIndex = 44;
            this.label2.Text = "~";
            // 
            // dtp_FromDate
            // 
            this.dtp_FromDate.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dtp_FromDate.CalendarMonthBackground = System.Drawing.Color.Snow;
            this.dtp_FromDate.CalendarTitleBackColor = System.Drawing.Color.LightCoral;
            this.dtp_FromDate.CalendarTitleForeColor = System.Drawing.Color.Firebrick;
            this.dtp_FromDate.CalendarTrailingForeColor = System.Drawing.Color.RosyBrown;
            this.dtp_FromDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FromDate.Location = new System.Drawing.Point(344, 50);
            this.dtp_FromDate.Name = "dtp_FromDate";
            this.dtp_FromDate.Size = new System.Drawing.Size(200, 34);
            this.dtp_FromDate.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(222, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Thời gian";
            // 
            // dtp_ToDate
            // 
            this.dtp_ToDate.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dtp_ToDate.CalendarMonthBackground = System.Drawing.Color.Snow;
            this.dtp_ToDate.CalendarTitleBackColor = System.Drawing.Color.LightCoral;
            this.dtp_ToDate.CalendarTitleForeColor = System.Drawing.Color.Firebrick;
            this.dtp_ToDate.CalendarTrailingForeColor = System.Drawing.Color.RosyBrown;
            this.dtp_ToDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ToDate.Location = new System.Drawing.Point(582, 50);
            this.dtp_ToDate.Name = "dtp_ToDate";
            this.dtp_ToDate.Size = new System.Drawing.Size(200, 34);
            this.dtp_ToDate.TabIndex = 47;
            this.dtp_ToDate.ValueChanged += new System.EventHandler(this.dtp_ToDate_ValueChanged);
            // 
            // chart_nam
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_nam.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_nam.Legends.Add(legend1);
            this.chart_nam.Location = new System.Drawing.Point(815, 150);
            this.chart_nam.Name = "chart_nam";
            this.chart_nam.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_nam.Series.Add(series1);
            this.chart_nam.Size = new System.Drawing.Size(618, 411);
            this.chart_nam.TabIndex = 51;
            this.chart_nam.Text = "chart1";
            // 
            // chart_thang
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_thang.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_thang.Legends.Add(legend2);
            this.chart_thang.Location = new System.Drawing.Point(93, 150);
            this.chart_thang.Name = "chart_thang";
            this.chart_thang.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_thang.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_thang.Series.Add(series2);
            this.chart_thang.Size = new System.Drawing.Size(618, 411);
            this.chart_thang.TabIndex = 52;
            this.chart_thang.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(212, 578);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 45);
            this.label3.TabIndex = 53;
            this.label3.Text = "Doanh thu theo tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(980, 578);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 45);
            this.label4.TabIndex = 53;
            this.label4.Text = "Doanh thu theo năm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(93, 639);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 32);
            this.label5.TabIndex = 54;
            this.label5.Text = "Giá nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(89, 685);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 32);
            this.label6.TabIndex = 54;
            this.label6.Text = "Giá bán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(809, 639);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 32);
            this.label7.TabIndex = 54;
            this.label7.Text = "Giá nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(809, 685);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 32);
            this.label8.TabIndex = 54;
            this.label8.Text = "Giá bán";
            // 
            // txt_gianhap_than
            // 
            this.txt_gianhap_than.Location = new System.Drawing.Point(220, 645);
            this.txt_gianhap_than.Name = "txt_gianhap_than";
            this.txt_gianhap_than.Size = new System.Drawing.Size(316, 26);
            this.txt_gianhap_than.TabIndex = 55;
            // 
            // txt_giaba_thang
            // 
            this.txt_giaba_thang.Location = new System.Drawing.Point(220, 692);
            this.txt_giaba_thang.Name = "txt_giaba_thang";
            this.txt_giaba_thang.Size = new System.Drawing.Size(316, 26);
            this.txt_giaba_thang.TabIndex = 55;
            // 
            // txt_gianhap_nam
            // 
            this.txt_gianhap_nam.Location = new System.Drawing.Point(988, 639);
            this.txt_gianhap_nam.Name = "txt_gianhap_nam";
            this.txt_gianhap_nam.Size = new System.Drawing.Size(316, 26);
            this.txt_gianhap_nam.TabIndex = 55;
            // 
            // txt_giaban_nam
            // 
            this.txt_giaban_nam.Location = new System.Drawing.Point(988, 686);
            this.txt_giaban_nam.Name = "txt_giaban_nam";
            this.txt_giaban_nam.Size = new System.Drawing.Size(316, 26);
            this.txt_giaban_nam.TabIndex = 55;
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1527, 783);
            this.Controls.Add(this.txt_giaban_nam);
            this.Controls.Add(this.txt_giaba_thang);
            this.Controls.Add(this.txt_gianhap_nam);
            this.Controls.Add(this.txt_gianhap_than);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart_nam);
            this.Controls.Add(this.chart_thang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_chitietbaocao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_FromDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_ToDate);
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.chart_nam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_thang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_chitietbaocao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_FromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_ToDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_nam;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_thang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_gianhap_than;
        private System.Windows.Forms.TextBox txt_giaba_thang;
        private System.Windows.Forms.TextBox txt_gianhap_nam;
        private System.Windows.Forms.TextBox txt_giaban_nam;
    }
}