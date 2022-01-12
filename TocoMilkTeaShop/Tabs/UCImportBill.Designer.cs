
namespace TocoMilkTeaShop.Tabs
{
    partial class UCImportBill
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
            this.dgvImportBill = new System.Windows.Forms.DataGridView();
            this.ImportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiperName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbImportBilllID = new System.Windows.Forms.TextBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.tbShiperName = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.dtpSelect = new System.Windows.Forms.DateTimePicker();
            this.btDisplayByDate = new System.Windows.Forms.Button();
            this.btDisplayByMouth = new System.Windows.Forms.Button();
            this.btDisplayAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.btDisplayToday = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btRemove = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImportBill
            // 
            this.dgvImportBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImportBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImportID,
            this.Time,
            this.CompanyName,
            this.ShiperName,
            this.Total,
            this.Note});
            this.dgvImportBill.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImportBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImportBill.Location = new System.Drawing.Point(206, 104);
            this.dgvImportBill.Name = "dgvImportBill";
            this.dgvImportBill.ReadOnly = true;
            this.dgvImportBill.RowHeadersVisible = false;
            this.dgvImportBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImportBill.Size = new System.Drawing.Size(1104, 499);
            this.dgvImportBill.TabIndex = 0;
            this.dgvImportBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImportBill_CellClick);
            this.dgvImportBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImportBill_CellDoubleClick);
            this.dgvImportBill.SelectionChanged += new System.EventHandler(this.dgvImportBill_SelectionChanged);
            // 
            // ImportID
            // 
            this.ImportID.DataPropertyName = "ImportID";
            this.ImportID.HeaderText = "Mã hóa đơn nhập";
            this.ImportID.Name = "ImportID";
            this.ImportID.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Thời gian nhập";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 200;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "Tên công ty";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 200;
            // 
            // ShiperName
            // 
            this.ShiperName.DataPropertyName = "ShiperName";
            this.ShiperName.HeaderText = "Tên người giao";
            this.ShiperName.Name = "ShiperName";
            this.ShiperName.ReadOnly = true;
            this.ShiperName.Width = 200;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Tổng thanh toán";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 150;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi chú";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên công ty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(701, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên người giao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(901, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ghi chú";
            // 
            // tbImportBilllID
            // 
            this.tbImportBilllID.Location = new System.Drawing.Point(206, 41);
            this.tbImportBilllID.Name = "tbImportBilllID";
            this.tbImportBilllID.Size = new System.Drawing.Size(99, 20);
            this.tbImportBilllID.TabIndex = 2;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(507, 41);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(192, 20);
            this.tbCompanyName.TabIndex = 2;
            // 
            // tbShiperName
            // 
            this.tbShiperName.Location = new System.Drawing.Point(705, 42);
            this.tbShiperName.Name = "tbShiperName";
            this.tbShiperName.Size = new System.Drawing.Size(194, 20);
            this.tbShiperName.TabIndex = 2;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(905, 42);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(405, 21);
            this.tbNote.TabIndex = 2;
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "dd/MM/yyyy";
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(311, 41);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(190, 20);
            this.dtp.TabIndex = 4;
            // 
            // dtpSelect
            // 
            this.dtpSelect.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSelect.CustomFormat = "dd/MM/yyyy";
            this.dtpSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSelect.Location = new System.Drawing.Point(21, 104);
            this.dtpSelect.Name = "dtpSelect";
            this.dtpSelect.Size = new System.Drawing.Size(150, 26);
            this.dtpSelect.TabIndex = 4;
            this.dtpSelect.ValueChanged += new System.EventHandler(this.dtpSelect_ValueChanged);
            // 
            // btDisplayByDate
            // 
            this.btDisplayByDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDisplayByDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplayByDate.Location = new System.Drawing.Point(21, 185);
            this.btDisplayByDate.Name = "btDisplayByDate";
            this.btDisplayByDate.Size = new System.Drawing.Size(150, 35);
            this.btDisplayByDate.TabIndex = 5;
            this.btDisplayByDate.Text = "Hiển thị theo ngày";
            this.btDisplayByDate.UseVisualStyleBackColor = false;
            this.btDisplayByDate.Click += new System.EventHandler(this.btDisplayByDate_Click);
            // 
            // btDisplayByMouth
            // 
            this.btDisplayByMouth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDisplayByMouth.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplayByMouth.Location = new System.Drawing.Point(21, 226);
            this.btDisplayByMouth.Name = "btDisplayByMouth";
            this.btDisplayByMouth.Size = new System.Drawing.Size(150, 35);
            this.btDisplayByMouth.TabIndex = 5;
            this.btDisplayByMouth.Text = "Hiển thị theo tháng";
            this.btDisplayByMouth.UseVisualStyleBackColor = false;
            this.btDisplayByMouth.Click += new System.EventHandler(this.btDisplayByMouth_Click);
            // 
            // btDisplayAll
            // 
            this.btDisplayAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDisplayAll.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplayAll.Location = new System.Drawing.Point(21, 267);
            this.btDisplayAll.Name = "btDisplayAll";
            this.btDisplayAll.Size = new System.Drawing.Size(150, 35);
            this.btDisplayAll.TabIndex = 5;
            this.btDisplayAll.Text = "Hiển thị tất cả";
            this.btDisplayAll.UseVisualStyleBackColor = false;
            this.btDisplayAll.Click += new System.EventHandler(this.btDisplayAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng chi phí";
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.AutoSize = true;
            this.lbTotalCost.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCost.Location = new System.Drawing.Point(77, 405);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(19, 21);
            this.lbTotalCost.TabIndex = 6;
            this.lbTotalCost.Text = "0";
            // 
            // btDisplayToday
            // 
            this.btDisplayToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDisplayToday.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplayToday.Location = new System.Drawing.Point(21, 144);
            this.btDisplayToday.Name = "btDisplayToday";
            this.btDisplayToday.Size = new System.Drawing.Size(150, 35);
            this.btDisplayToday.TabIndex = 5;
            this.btDisplayToday.Text = "Hiển thị hôm nay";
            this.btDisplayToday.UseVisualStyleBackColor = false;
            this.btDisplayToday.Click += new System.EventHandler(this.btDisplayToday_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox1.BackgroundImage = global::TocoMilkTeaShop.Properties.Resources.imp;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btRemove
            // 
            this.btRemove.BackgroundImage = global::TocoMilkTeaShop.Properties.Resources.deleteicon;
            this.btRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRemove.Location = new System.Drawing.Point(1326, 124);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(48, 41);
            this.btRemove.TabIndex = 3;
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackgroundImage = global::TocoMilkTeaShop.Properties.Resources.save_icon;
            this.btUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btUpdate.Location = new System.Drawing.Point(1326, 76);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(48, 42);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAdd.BackgroundImage = global::TocoMilkTeaShop.Properties.Resources.add_icon;
            this.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAdd.Location = new System.Drawing.Point(1326, 23);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(48, 47);
            this.btAdd.TabIndex = 3;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // UCImportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTotalCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btDisplayToday);
            this.Controls.Add(this.btDisplayAll);
            this.Controls.Add(this.btDisplayByMouth);
            this.Controls.Add(this.btDisplayByDate);
            this.Controls.Add(this.dtpSelect);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbShiperName);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.tbImportBilllID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvImportBill);
            this.Name = "UCImportBill";
            this.Size = new System.Drawing.Size(1402, 635);
            this.Load += new System.EventHandler(this.UCImportBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImportBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbImportBilllID;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.TextBox tbShiperName;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiperName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.DateTimePicker dtpSelect;
        private System.Windows.Forms.Button btDisplayByDate;
        private System.Windows.Forms.Button btDisplayByMouth;
        private System.Windows.Forms.Button btDisplayAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.Button btDisplayToday;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
