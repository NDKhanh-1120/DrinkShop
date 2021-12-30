using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TocoMilkTeaShop.Forms;
using TocoMilkTeaShop.Models;

namespace TocoMilkTeaShop.Tabs
{
    public partial class UCImportBill : UserControl
    {

        DB db = new DB();
        int selectedImportBillID;
        ImportDetail importDetailchildForm;
        public UCImportBill()
        {
            InitializeComponent();
        }

        private void UCImportBill_Load(object sender, EventArgs e)
        {
            DislayImportBill();
        }

        private void DislayImportBill()
        {
            dgvImportBill.DataSource =
                (from imb in db.ImportBills
                 join imbd in db.ImportDetailBills on imb.ImportID equals imbd.ImportID
                 group new { imb ,imbd } by new { imb.ImportID, imb.Time,imb.CompanyName,imb.ShiperName, imb.Note } into im
                 select new
                 {
                     ImportID = im.Key.ImportID,
                     Time = im.Key.Time,
                     CompanyName = im.Key.CompanyName,
                     ShiperName = im.Key.ShiperName,
                     Total = im.Sum(t=> t.imbd.Quatity * t.imbd.Price),
                     Note = im.Key.Note
                 }).ToList();
        }

        private void dgvImportBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iD = Convert.ToInt32(dgvImportBill.CurrentRow.Cells["ImportID"].Value.ToString());
            //
            DateTime time = Convert.ToDateTime( dgvImportBill.CurrentRow.Cells["Time"].Value.ToString());
            string companyName = dgvImportBill.CurrentRow.Cells["CompanyName"].Value.ToString();
            string shipperName = dgvImportBill.CurrentRow.Cells["ShiperName"].Value.ToString();
            string note = dgvImportBill.CurrentRow.Cells["Note"].Value.ToString();
            //hien thi form
            importDetailchildForm = new ImportDetail(iD, time, companyName, shipperName, note);
            importDetailchildForm.ShowDialog();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            ImportBill imBill = new ImportBill()
            {
                ImportID = Convert.ToInt32(tbImportBilllID.Text),
                Time = dtp.Value,
                CompanyName = tbCompanyName.Text,
                ShiperName = tbShiperName.Text,
                Note = tbNote.Text
            };
            db.ImportBills.Add(imBill);
            db.SaveChanges();
            DislayImportBill();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            ImportBill imBill = db.ImportBills.FirstOrDefault(imb => imb.ImportID == selectedImportBillID);
            db.ImportBills.Remove(imBill);
            db.SaveChanges();
        }

        private void dgvImportBill_SelectionChanged(object sender, EventArgs e)
        {
            selectedImportBillID = Convert.ToInt32(dgvImportBill.CurrentRow.Cells["ImportID"].Value);
            tbImportBilllID.Text = selectedImportBillID.ToString();
            dtp.Value = Convert.ToDateTime( dgvImportBill.CurrentRow.Cells["Time"].Value);
            tbCompanyName.Text = dgvImportBill.CurrentRow.Cells["CompanyName"].Value.ToString();
            tbShiperName.Text = dgvImportBill.CurrentRow.Cells["ShiperName"].Value.ToString();
            tbNote.Text = dgvImportBill.CurrentRow.Cells["Note"].Value.ToString();
        }
    }
}
