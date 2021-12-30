
namespace TocoMilkTeaShop
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.lbNofi = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(117, 38);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(164, 20);
            this.tbUserName.TabIndex = 3;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(117, 82);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '*';
            this.tbPassWord.Size = new System.Drawing.Size(164, 20);
            this.tbPassWord.TabIndex = 4;
            this.tbPassWord.TextChanged += new System.EventHandler(this.tbPassWord_TextChanged);
            // 
            // lbNofi
            // 
            this.lbNofi.AutoSize = true;
            this.lbNofi.ForeColor = System.Drawing.Color.Red;
            this.lbNofi.Location = new System.Drawing.Point(127, 119);
            this.lbNofi.Name = "lbNofi";
            this.lbNofi.Size = new System.Drawing.Size(0, 13);
            this.lbNofi.TabIndex = 5;
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.Red;
            this.pb.Location = new System.Drawing.Point(287, 82);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(19, 20);
            this.pb.TabIndex = 6;
            this.pb.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 158);
            this.ControlBox = false;
            this.Controls.Add(this.pb);
            this.Controls.Add(this.lbNofi);
            this.Controls.Add(this.tbPassWord);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(500, 600);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng  nhập";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Label lbNofi;
        private System.Windows.Forms.PictureBox pb;
    }
}