
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
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImportBill
            // 
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
            this.dgvImportBill.Location = new System.Drawing.Point(232, 71);
            this.dgvImportBill.Name = "dgvImportBill";
            this.dgvImportBill.ReadOnly = true;
            this.dgvImportBill.RowHeadersVisible = false;
            this.dgvImportBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImportBill.Size = new System.Drawing.Size(1104, 537);
            this.dgvImportBill.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(32, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên công ty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên người giao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ghi chú";
            // 
            // tbImportBilllID
            // 
            this.tbImportBilllID.Location = new System.Drawing.Point(50, 99);
            this.tbImportBilllID.Name = "tbImportBilllID";
            this.tbImportBilllID.Size = new System.Drawing.Size(140, 20);
            this.tbImportBilllID.TabIndex = 2;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(50, 225);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(140, 20);
            this.tbCompanyName.TabIndex = 2;
            // 
            // tbShiperName
            // 
            this.tbShiperName.Location = new System.Drawing.Point(50, 288);
            this.tbShiperName.Name = "tbShiperName";
            this.tbShiperName.Size = new System.Drawing.Size(140, 20);
            this.tbShiperName.TabIndex = 2;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(54, 339);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(140, 87);
            this.tbNote.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(63, 447);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(106, 30);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(63, 483);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(106, 30);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "Cập nhật";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(63, 519);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(108, 33);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "Xóa";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "dd/MM/yyyy";
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(50, 166);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(140, 20);
            this.dtp.TabIndex = 4;
            // 
            // UCImportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.Size = new System.Drawing.Size(1390, 635);
            this.Load += new System.EventHandler(this.UCImportBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportBill)).EndInit();
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
    }
}
