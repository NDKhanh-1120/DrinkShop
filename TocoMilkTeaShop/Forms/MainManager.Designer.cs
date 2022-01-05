
namespace TocoMilkTeaShop
{
    partial class MainManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainManager));
            this.btnOrder = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btSetting = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbAddressName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btStatistical = new System.Windows.Forms.Button();
            this.btImportBill = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btHub = new System.Windows.Forms.Button();
            this.btmaterials = new System.Windows.Forms.Button();
            this.btBill = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOrder.Location = new System.Drawing.Point(0, -1);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(106, 33);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "BÁN HÀNG";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(1285, 14);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(62, 34);
            this.btLogout.TabIndex = 2;
            this.btLogout.Text = "KHÓA";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btSetting
            // 
            this.btSetting.Location = new System.Drawing.Point(1217, 14);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(62, 34);
            this.btSetting.TabIndex = 2;
            this.btSetting.Text = "CÀI ĐẶT";
            this.btSetting.UseVisualStyleBackColor = true;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelHeader.Controls.Add(this.lbAddressName);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.btLogout);
            this.panelHeader.Controls.Add(this.btSetting);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1350, 61);
            this.panelHeader.TabIndex = 3;
            // 
            // lbAddressName
            // 
            this.lbAddressName.AutoSize = true;
            this.lbAddressName.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddressName.Location = new System.Drawing.Point(192, 14);
            this.lbAddressName.Name = "lbAddressName";
            this.lbAddressName.Size = new System.Drawing.Size(143, 28);
            this.lbAddressName.TabIndex = 3;
            this.lbAddressName.Text = "Nguyễn Trãi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(80, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "TocoToco";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelMenu.Controls.Add(this.btStatistical);
            this.panelMenu.Controls.Add(this.btImportBill);
            this.panelMenu.Controls.Add(this.btnEmployee);
            this.panelMenu.Controls.Add(this.btHub);
            this.panelMenu.Controls.Add(this.btmaterials);
            this.panelMenu.Controls.Add(this.btBill);
            this.panelMenu.Controls.Add(this.btnProduct);
            this.panelMenu.Controls.Add(this.btnOrder);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 61);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1350, 33);
            this.panelMenu.TabIndex = 4;
            // 
            // btStatistical
            // 
            this.btStatistical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btStatistical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStatistical.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStatistical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btStatistical.Location = new System.Drawing.Point(794, 0);
            this.btStatistical.Margin = new System.Windows.Forms.Padding(0);
            this.btStatistical.Name = "btStatistical";
            this.btStatistical.Size = new System.Drawing.Size(106, 33);
            this.btStatistical.TabIndex = 2;
            this.btStatistical.Text = "THỐNG KÊ";
            this.btStatistical.UseVisualStyleBackColor = false;
            this.btStatistical.Click += new System.EventHandler(this.btStatistical_Click);
            // 
            // btImportBill
            // 
            this.btImportBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btImportBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImportBill.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImportBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btImportBill.Location = new System.Drawing.Point(315, 0);
            this.btImportBill.Margin = new System.Windows.Forms.Padding(0);
            this.btImportBill.Name = "btImportBill";
            this.btImportBill.Size = new System.Drawing.Size(143, 33);
            this.btImportBill.TabIndex = 2;
            this.btImportBill.Text = "HÓA ĐƠN NHẬP";
            this.btImportBill.UseVisualStyleBackColor = false;
            this.btImportBill.Click += new System.EventHandler(this.btImportBill_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEmployee.Location = new System.Drawing.Point(688, 0);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(106, 33);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "NHÂN SỰ";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btHub
            // 
            this.btHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHub.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btHub.Location = new System.Drawing.Point(582, 0);
            this.btHub.Margin = new System.Windows.Forms.Padding(0);
            this.btHub.Name = "btHub";
            this.btHub.Size = new System.Drawing.Size(106, 33);
            this.btHub.TabIndex = 2;
            this.btHub.Text = "KHO";
            this.btHub.UseVisualStyleBackColor = false;
            this.btHub.Click += new System.EventHandler(this.btHub_Click);
            // 
            // btmaterials
            // 
            this.btmaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btmaterials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmaterials.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmaterials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btmaterials.Location = new System.Drawing.Point(454, 0);
            this.btmaterials.Margin = new System.Windows.Forms.Padding(0);
            this.btmaterials.Name = "btmaterials";
            this.btmaterials.Size = new System.Drawing.Size(128, 33);
            this.btmaterials.TabIndex = 2;
            this.btmaterials.Text = "NGUYÊN LIỆU";
            this.btmaterials.UseVisualStyleBackColor = false;
            this.btmaterials.Click += new System.EventHandler(this.btmaterials_Click);
            // 
            // btBill
            // 
            this.btBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBill.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btBill.Location = new System.Drawing.Point(209, 0);
            this.btBill.Margin = new System.Windows.Forms.Padding(0);
            this.btBill.Name = "btBill";
            this.btBill.Size = new System.Drawing.Size(106, 33);
            this.btBill.TabIndex = 2;
            this.btBill.Text = "HÓA ĐƠN";
            this.btBill.UseVisualStyleBackColor = false;
            this.btBill.Click += new System.EventHandler(this.btBill_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnProduct.Location = new System.Drawing.Point(104, 0);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(106, 33);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "SẢN PHẨM";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelFooter);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 94);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1350, 635);
            this.panelContainer.TabIndex = 5;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 616);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1350, 19);
            this.panelFooter.TabIndex = 0;
            // 
            // MainManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TocoAdmin";
            this.Load += new System.EventHandler(this.MainManager_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btSetting;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btHub;
        private System.Windows.Forms.Button btStatistical;
        private System.Windows.Forms.Button btBill;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btImportBill;
        private System.Windows.Forms.Panel panelFooter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbAddressName;
        private System.Windows.Forms.Button btmaterials;
    }
}

