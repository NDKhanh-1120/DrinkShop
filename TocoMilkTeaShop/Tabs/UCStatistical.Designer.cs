
namespace TocoMilkTeaShop.Tabs
{
    partial class UCStatistical
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTypeOfTime = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbInterest = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbdtpFrom = new System.Windows.Forms.Label();
            this.lbdtpTo = new System.Windows.Forms.Label();
            this.lbChooseMouth = new System.Windows.Forms.Label();
            this.dtpMouth = new System.Windows.Forms.DateTimePicker();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại thời gian";
            // 
            // cbbTypeOfTime
            // 
            this.cbbTypeOfTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeOfTime.FormattingEnabled = true;
            this.cbbTypeOfTime.Items.AddRange(new object[] {
            "Theo tháng",
            "Theo khoảng thời gian"});
            this.cbbTypeOfTime.Location = new System.Drawing.Point(183, 59);
            this.cbbTypeOfTime.Name = "cbbTypeOfTime";
            this.cbbTypeOfTime.Size = new System.Drawing.Size(198, 29);
            this.cbbTypeOfTime.TabIndex = 1;
            this.cbbTypeOfTime.SelectedIndexChanged += new System.EventHandler(this.cbbTypeOfTime_SelectedIndexChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(533, 59);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 28);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.Visible = false;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(895, 60);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 28);
            this.dtpTo.TabIndex = 2;
            this.dtpTo.Visible = false;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(63, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doanh thu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(352, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chi phí :";
            // 
            // lbRevenue
            // 
            this.lbRevenue.AutoSize = true;
            this.lbRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbRevenue.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevenue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRevenue.Location = new System.Drawing.Point(169, 139);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(19, 21);
            this.lbRevenue.TabIndex = 3;
            this.lbRevenue.Text = "0";
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbCost.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCost.Location = new System.Drawing.Point(432, 139);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(19, 21);
            this.lbCost.TabIndex = 3;
            this.lbCost.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(837, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lãi :";
            // 
            // lbInterest
            // 
            this.lbInterest.AutoSize = true;
            this.lbInterest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbInterest.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInterest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbInterest.Location = new System.Drawing.Point(892, 139);
            this.lbInterest.Name = "lbInterest";
            this.lbInterest.Size = new System.Drawing.Size(19, 21);
            this.lbInterest.TabIndex = 3;
            this.lbInterest.Text = "0";
            this.lbInterest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(42, 223);
            this.chart.Name = "chart";
            series1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValuesPerPoint = 10;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Chi phí";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Lãi";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(1241, 381);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart";
            this.toolTip.SetToolTip(this.chart, "?");
            this.chart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 88);
            this.panel1.TabIndex = 5;
            // 
            // lbdtpFrom
            // 
            this.lbdtpFrom.AutoSize = true;
            this.lbdtpFrom.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdtpFrom.Location = new System.Drawing.Point(414, 62);
            this.lbdtpFrom.Name = "lbdtpFrom";
            this.lbdtpFrom.Size = new System.Drawing.Size(114, 21);
            this.lbdtpFrom.TabIndex = 0;
            this.lbdtpFrom.Text = "Ngày bắt đầu";
            this.lbdtpFrom.Visible = false;
            // 
            // lbdtpTo
            // 
            this.lbdtpTo.AutoSize = true;
            this.lbdtpTo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdtpTo.Location = new System.Drawing.Point(775, 65);
            this.lbdtpTo.Name = "lbdtpTo";
            this.lbdtpTo.Size = new System.Drawing.Size(118, 21);
            this.lbdtpTo.TabIndex = 0;
            this.lbdtpTo.Text = "Ngày kết thúc";
            this.lbdtpTo.Visible = false;
            // 
            // lbChooseMouth
            // 
            this.lbChooseMouth.AutoSize = true;
            this.lbChooseMouth.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChooseMouth.Location = new System.Drawing.Point(414, 62);
            this.lbChooseMouth.Name = "lbChooseMouth";
            this.lbChooseMouth.Size = new System.Drawing.Size(100, 21);
            this.lbChooseMouth.TabIndex = 0;
            this.lbChooseMouth.Text = "Chọn tháng";
            // 
            // dtpMouth
            // 
            this.dtpMouth.CustomFormat = "MM/yyyy";
            this.dtpMouth.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMouth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMouth.Location = new System.Drawing.Point(533, 59);
            this.dtpMouth.Name = "dtpMouth";
            this.dtpMouth.Size = new System.Drawing.Size(200, 28);
            this.dtpMouth.TabIndex = 2;
            this.dtpMouth.ValueChanged += new System.EventHandler(this.dtpMouth_ValueChanged);
            // 
            // UCStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lbdtpFrom);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.lbInterest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRevenue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpMouth);
            this.Controls.Add(this.cbbTypeOfTime);
            this.Controls.Add(this.lbChooseMouth);
            this.Controls.Add(this.lbdtpTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UCStatistical";
            this.Size = new System.Drawing.Size(1350, 635);
            this.Load += new System.EventHandler(this.UCStatistical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTypeOfTime;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRevenue;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbInterest;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbdtpFrom;
        private System.Windows.Forms.Label lbdtpTo;
        private System.Windows.Forms.Label lbChooseMouth;
        private System.Windows.Forms.DateTimePicker dtpMouth;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
