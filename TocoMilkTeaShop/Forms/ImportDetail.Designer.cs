
namespace TocoMilkTeaShop.Forms
{
    partial class ImportDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportDetail));
            this.label1 = new System.Windows.Forms.Label();
            this.lbImportBillID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbShipperName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbMaterialName = new System.Windows.Forms.TextBox();
            this.tbQuatity = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCloseTB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMaterialName = new System.Windows.Forms.ComboBox();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quatity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteThis = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn :";
            // 
            // lbImportBillID
            // 
            this.lbImportBillID.AutoSize = true;
            this.lbImportBillID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImportBillID.Location = new System.Drawing.Point(178, 55);
            this.lbImportBillID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbImportBillID.Name = "lbImportBillID";
            this.lbImportBillID.Size = new System.Drawing.Size(18, 19);
            this.lbImportBillID.TabIndex = 0;
            this.lbImportBillID.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày giao :";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(659, 80);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(18, 19);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên công ty :";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyName.Location = new System.Drawing.Point(178, 81);
            this.lbCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(18, 19);
            this.lbCompanyName.TabIndex = 0;
            this.lbCompanyName.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên người giao :";
            // 
            // lbShipperName
            // 
            this.lbShipperName.AutoSize = true;
            this.lbShipperName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipperName.Location = new System.Drawing.Point(203, 107);
            this.lbShipperName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShipperName.Name = "lbShipperName";
            this.lbShipperName.Size = new System.Drawing.Size(18, 19);
            this.lbShipperName.TabIndex = 0;
            this.lbShipperName.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(567, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ghi chú :";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(660, 107);
            this.lbNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(18, 19);
            this.lbNote.TabIndex = 0;
            this.lbNote.Text = "...";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialName,
            this.Quatity,
            this.Unit,
            this.Price,
            this.Total,
            this.DeleteThis});
            this.dgv.Location = new System.Drawing.Point(53, 174);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.Size = new System.Drawing.Size(875, 403);
            this.dgv.TabIndex = 5;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // tbMaterialName
            // 
            this.tbMaterialName.Location = new System.Drawing.Point(0, 1);
            this.tbMaterialName.Name = "tbMaterialName";
            this.tbMaterialName.Size = new System.Drawing.Size(28, 24);
            this.tbMaterialName.TabIndex = 2;
            // 
            // tbQuatity
            // 
            this.tbQuatity.Location = new System.Drawing.Point(423, 143);
            this.tbQuatity.Name = "tbQuatity";
            this.tbQuatity.Size = new System.Drawing.Size(95, 24);
            this.tbQuatity.TabIndex = 1;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(524, 143);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(146, 24);
            this.tbPrice.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAdd.Location = new System.Drawing.Point(898, 136);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(31, 33);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCloseTB
            // 
            this.btCloseTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCloseTB.Location = new System.Drawing.Point(937, 137);
            this.btCloseTB.Name = "btCloseTB";
            this.btCloseTB.Size = new System.Drawing.Size(31, 32);
            this.btCloseTB.TabIndex = 3;
            this.btCloseTB.Text = "x";
            this.btCloseTB.UseVisualStyleBackColor = false;
            this.btCloseTB.Click += new System.EventHandler(this.btCloseTB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "CHI TIẾT HÓA ĐƠN NHẬP";
            // 
            // cbbMaterialName
            // 
            this.cbbMaterialName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbMaterialName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMaterialName.FormattingEnabled = true;
            this.cbbMaterialName.Location = new System.Drawing.Point(54, 143);
            this.cbbMaterialName.Name = "cbbMaterialName";
            this.cbbMaterialName.Size = new System.Drawing.Size(363, 27);
            this.cbbMaterialName.TabIndex = 0;
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "MaterialName";
            this.MaterialName.HeaderText = "Tên hàng (nl)";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.Width = 340;
            // 
            // Quatity
            // 
            this.Quatity.DataPropertyName = "Quatity";
            this.Quatity.HeaderText = "Số lượng nhập";
            this.Quatity.Name = "Quatity";
            this.Quatity.Width = 50;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Đơn vị";
            this.Unit.Name = "Unit";
            this.Unit.Width = 80;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá nhập";
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Thành tiền";
            this.Total.Name = "Total";
            this.Total.Width = 200;
            // 
            // DeleteThis
            // 
            this.DeleteThis.HeaderText = "Xóa";
            this.DeleteThis.Name = "DeleteThis";
            this.DeleteThis.Width = 50;
            // 
            // ImportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(978, 593);
            this.Controls.Add(this.cbbMaterialName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCloseTB);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbQuatity);
            this.Controls.Add(this.tbMaterialName);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.lbShipperName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbImportBillID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImportDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết đơn hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportDetail_FormClosing);
            this.Load += new System.EventHandler(this.ImportDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbImportBillID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbShipperName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tbMaterialName;
        private System.Windows.Forms.TextBox tbQuatity;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCloseTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quatity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteThis;
    }
}