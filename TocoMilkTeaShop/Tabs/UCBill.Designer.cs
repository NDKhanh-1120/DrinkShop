
namespace TocoMilkTeaShop.Tabs
{
    partial class UCBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteThis = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btDisplayByDay = new System.Windows.Forms.Button();
            this.btDisplayByMouth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbStatistical = new System.Windows.Forms.Label();
            this.btDisplayAllBills = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.Time,
            this.EmployeeName,
            this.Total,
            this.DeleteThis});
            this.dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(302, 44);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowTemplate.Height = 50;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1004, 558);
            this.dgv.TabIndex = 0;
            // 
            // BillID
            // 
            this.BillID.DataPropertyName = "BillID";
            this.BillID.HeaderText = "Mã ";
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Thời gian";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 350;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Tên nhân viên";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 250;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Tổng thanh toán";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 250;
            // 
            // DeleteThis
            // 
            this.DeleteThis.HeaderText = "Xóa";
            this.DeleteThis.Name = "DeleteThis";
            this.DeleteThis.ReadOnly = true;
            this.DeleteThis.Width = 50;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Location = new System.Drawing.Point(38, 10);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(291, 28);
            this.dtp.TabIndex = 1;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // btDisplayByDay
            // 
            this.btDisplayByDay.BackColor = System.Drawing.Color.White;
            this.btDisplayByDay.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplayByDay.Location = new System.Drawing.Point(35, 106);
            this.btDisplayByDay.Name = "btDisplayByDay";
            this.btDisplayByDay.Size = new System.Drawing.Size(169, 45);
            this.btDisplayByDay.TabIndex = 2;
            this.btDisplayByDay.Text = "Xem trong ngày";
            this.btDisplayByDay.UseVisualStyleBackColor = false;
            this.btDisplayByDay.Click += new System.EventHandler(this.btDisplayByDay_Click);
            // 
            // btDisplayByMouth
            // 
            this.btDisplayByMouth.BackColor = System.Drawing.Color.White;
            this.btDisplayByMouth.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplayByMouth.Location = new System.Drawing.Point(35, 157);
            this.btDisplayByMouth.Name = "btDisplayByMouth";
            this.btDisplayByMouth.Size = new System.Drawing.Size(169, 45);
            this.btDisplayByMouth.TabIndex = 2;
            this.btDisplayByMouth.Text = "Xem trong tháng";
            this.btDisplayByMouth.UseVisualStyleBackColor = false;
            this.btDisplayByMouth.Click += new System.EventHandler(this.btDisplayByMouth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng doanh thu :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(50, 273);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(23, 19);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "lbl";
            // 
            // lbStatistical
            // 
            this.lbStatistical.AutoSize = true;
            this.lbStatistical.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatistical.Location = new System.Drawing.Point(362, 13);
            this.lbStatistical.Name = "lbStatistical";
            this.lbStatistical.Size = new System.Drawing.Size(81, 21);
            this.lbStatistical.TabIndex = 4;
            this.lbStatistical.Text = "Thống kê";
            // 
            // btDisplayAllBills
            // 
            this.btDisplayAllBills.BackColor = System.Drawing.Color.White;
            this.btDisplayAllBills.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplayAllBills.Location = new System.Drawing.Point(35, 55);
            this.btDisplayAllBills.Name = "btDisplayAllBills";
            this.btDisplayAllBills.Size = new System.Drawing.Size(169, 45);
            this.btDisplayAllBills.TabIndex = 2;
            this.btDisplayAllBills.Text = "Hiển thị tất cả";
            this.btDisplayAllBills.UseVisualStyleBackColor = false;
            this.btDisplayAllBills.Click += new System.EventHandler(this.btDisplayAllBills_Click);
            // 
            // UCBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lbStatistical);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDisplayAllBills);
            this.Controls.Add(this.btDisplayByMouth);
            this.Controls.Add(this.btDisplayByDay);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.dgv);
            this.Name = "UCBill";
            this.Size = new System.Drawing.Size(1350, 635);
            this.Load += new System.EventHandler(this.UCBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btDisplayByDay;
        private System.Windows.Forms.Button btDisplayByMouth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteThis;
        private System.Windows.Forms.Label lbStatistical;
        private System.Windows.Forms.Button btDisplayAllBills;
    }
}
