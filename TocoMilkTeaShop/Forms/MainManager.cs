using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TocoMilkTeaShop.Tabs;

namespace TocoMilkTeaShop
{
    public partial class MainManager : Form
    {
        Login loginForm = new Login();
        public MainManager()
        {
            InitializeComponent();
            UCOrder ucOrder = new UCOrder();
            AddTab(ucOrder);
            //loginForm.ShowDialog();
        }
        private void MainManager_Load(object sender, EventArgs e)
        {

        }
        void Linq()
        {
            // from name in db.tablename select new ( prop1 = name.prop01 , prop2 = name.prop02,...)
        }
        void AddTab(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            UCOrder ucOrder = new UCOrder();
            AddTab(ucOrder);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            UCProduct ucProduct = new UCProduct();
            AddTab(ucProduct);
        }

        private void btBill_Click(object sender, EventArgs e)
        {
            UCBill uc = new UCBill();
            AddTab(uc);
        }

        private void btStatistical_Click(object sender, EventArgs e)
        {
            UCStatistical uc = new UCStatistical();
            AddTab(uc);
        }

        private void btImportBill_Click(object sender, EventArgs e)
        {
            UCImportBill uc = new UCImportBill();
            AddTab(uc);
        }

        private void btmaterials_Click(object sender, EventArgs e)
        {
            UCMaterials uc = new UCMaterials();
            AddTab(uc);
        }

        private void btHub_Click(object sender, EventArgs e)
        {
            UCHub uc = new UCHub();
            AddTab(uc);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            UCEmployee uc = new UCEmployee();
            AddTab(uc);
        }
        public string GetAddressName()
        {
            return lbAddressName.Text;
        }

        private void btSetting_Click(object sender, EventArgs e)
        {

        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            loginForm.ShowDialog();
        }
    }
}
