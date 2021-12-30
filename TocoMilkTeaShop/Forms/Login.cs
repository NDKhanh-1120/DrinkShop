using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TocoMilkTeaShop.Models;

namespace TocoMilkTeaShop
{
    public partial class Login : Form
    {
        DB db = new DB();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var acc = db.Accounts.FirstOrDefault(ac => ac.UserName == tbUserName.Text && ac.Passwords == tbPassWord.Text);
            if (acc == null) 
            {
                lbNofi.Text = "Tài khoản mất khẩu không chính xác"; 
            }
            //else Close();
            
        }

        private void tbPassWord_TextChanged(object sender, EventArgs e)
        {
            var acc = db.Accounts.FirstOrDefault(ac => ac.UserName == tbUserName.Text && ac.Passwords == tbPassWord.Text);
            if (acc == null)
            {
                pb.BackColor = Color.Red;
            }
            else
            {
                pb.BackColor = Color.FromArgb(75, 255, 0);
                System.Threading.Thread.Sleep(1000);
                Close();
            }
        }
    }
}
