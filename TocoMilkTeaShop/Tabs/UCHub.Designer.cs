
namespace TocoMilkTeaShop.Tabs
{
    partial class UCHub
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.MaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quatity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCreateInventoryToday = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btRemoveInDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialID,
            this.MaterialName,
            this.Quatity});
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.Location = new System.Drawing.Point(347, 59);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(893, 549);
            this.dgv.TabIndex = 0;
            // 
            // MaterialID
            // 
            this.MaterialID.DataPropertyName = "MaterialID";
            this.MaterialID.HeaderText = "Mã nguyên liệu";
            this.MaterialID.Name = "MaterialID";
            this.MaterialID.Width = 150;
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "MaterialName";
            this.MaterialName.HeaderText = "Tên nguyên liệu";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.Width = 500;
            // 
            // Quatity
            // 
            this.Quatity.DataPropertyName = "Quatity";
            this.Quatity.HeaderText = "Sô lượng tồn";
            this.Quatity.Name = "Quatity";
            this.Quatity.Width = 200;
            // 
            // btCreateInventoryToday
            // 
            this.btCreateInventoryToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCreateInventoryToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCreateInventoryToday.FlatAppearance.BorderSize = 0;
            this.btCreateInventoryToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateInventoryToday.Location = new System.Drawing.Point(57, 136);
            this.btCreateInventoryToday.Name = "btCreateInventoryToday";
            this.btCreateInventoryToday.Size = new System.Drawing.Size(222, 56);
            this.btCreateInventoryToday.TabIndex = 1;
            this.btCreateInventoryToday.Text = "Chốt tồn kho hôm nay";
            this.btCreateInventoryToday.UseVisualStyleBackColor = false;
            this.btCreateInventoryToday.Click += new System.EventHandler(this.btCreateInventoryToday_Click);
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "dd/MM/yyyy";
            this.dtp.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(57, 59);
            this.dtp.Name = "dtp";
            this.dtp.RightToLeftLayout = true;
            this.dtp.Size = new System.Drawing.Size(222, 34);
            this.dtp.TabIndex = 2;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tồn Kho";
            // 
            // btRemoveInDate
            // 
            this.btRemoveInDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btRemoveInDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btRemoveInDate.FlatAppearance.BorderSize = 0;
            this.btRemoveInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveInDate.Location = new System.Drawing.Point(93, 525);
            this.btRemoveInDate.Name = "btRemoveInDate";
            this.btRemoveInDate.Size = new System.Drawing.Size(143, 56);
            this.btRemoveInDate.TabIndex = 1;
            this.btRemoveInDate.Text = "Hủy tồn kho";
            this.btRemoveInDate.UseVisualStyleBackColor = false;
            this.btRemoveInDate.Click += new System.EventHandler(this.btRemoveInDate_Click);
            // 
            // UCHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btRemoveInDate);
            this.Controls.Add(this.btCreateInventoryToday);
            this.Controls.Add(this.dgv);
            this.Name = "UCHub";
            this.Size = new System.Drawing.Size(1350, 635);
            this.Load += new System.EventHandler(this.UCHub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btCreateInventoryToday;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quatity;
        private System.Windows.Forms.Button btRemoveInDate;
    }
}
