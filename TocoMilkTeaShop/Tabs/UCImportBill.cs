using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
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
            dtp.Value = DateTime.Today;
            DislayImportBill();
            CalculateCostInTable();
        }


        private void dgvImportBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iD = Convert.ToInt32(dgvImportBill.CurrentRow.Cells["ImportID"].Value.ToString());
            //
            DateTime time = Convert.ToDateTime(dgvImportBill.CurrentRow.Cells["Time"].Value.ToString());
            string companyName = dgvImportBill.CurrentRow.Cells["CompanyName"].Value.ToString();
            string shipperName = dgvImportBill.CurrentRow.Cells["ShiperName"].Value.ToString();
            string note = dgvImportBill.CurrentRow.Cells["Note"].Value.ToString();
            //hien thi form
            importDetailchildForm = new ImportDetail(iD, time, companyName, shipperName, note);
            importDetailchildForm.ShowDialog();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int importBill = Convert.ToInt32(tbImportBilllID.Text);
            if (db.ImportBills.FirstOrDefault(im => im.ImportID == importBill) != null)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ImportBill imB = new ImportBill()
            {
                ImportID = Convert.ToInt32(tbImportBilllID.Text),
                Time = dtp.Value,
                CompanyName = tbCompanyName.Text,
                ShiperName = tbShiperName.Text,
                Note = tbNote.Text
            };
            db.ImportBills.Add(imB);
            db.SaveChanges();
            //
            //var list =
            // (from imb in db.ImportBills
            //  orderby imb.Time descending
            //  select new
            //  {
            //      ImportID = imb.ImportID,
            //      Time = imb.Time,
            //      CompanyName = imb.CompanyName,
            //      Total = 0,
            //      ShiperName = imb.ShiperName,
            //      Note = imb.Note
            //  }).Take(1).ToList();
            //dgvImportBill.DataSource = list;
            dgvImportBill.DataSource =
            (from imb in db.ImportBills
             join imbd in db.ImportDetailBills on imb.ImportID equals imbd.ImportID
             group new { imb, imbd } by new { imb.ImportID, imb.Time, imb.CompanyName, imb.ShiperName, imb.Note } into im
             where im.Key.ImportID == importBill
             select new
             {
                 ImportID = im.Key.ImportID,
                 Time = im.Key.Time,
                 CompanyName = im.Key.CompanyName,
                 ShiperName = im.Key.ShiperName,
                 Total = im.Sum(t => t.imbd.Quatity * t.imbd.Price),
                 Note = im.Key.Note
             })
               .Take(1).ToList();

            int iD = Convert.ToInt32( tbImportBilllID.Text);
            //
            DateTime time = Convert.ToDateTime(dtp.Value);
            string companyName = tbCompanyName.Text;
            string shipperName = tbShiperName.Text;
            string note = tbNote.Text;
            //hien thi form
            importDetailchildForm = new ImportDetail(iD, time, companyName, shipperName, note);
            importDetailchildForm.ShowDialog();









        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            int imiD = Convert.ToInt32(tbImportBilllID.Text);
            ImportBill imB = db.ImportBills.FirstOrDefault(iB => iB.ImportID == imiD);
            imB.Time = dtp.Value;
            imB.CompanyName = tbCompanyName.Text;
            imB.ShiperName = tbShiperName.Text;
            imB.Note = tbNote.Text;
            db.SaveChanges();
            DislayImportBill();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            ImportBill imBill = db.ImportBills.FirstOrDefault(imb => imb.ImportID == selectedImportBillID);
            db.ImportBills.Remove(imBill);
            db.SaveChanges();
            DislayImportBill();
        }

        private void dgvImportBill_SelectionChanged(object sender, EventArgs e)
        {
            //selectedImportBillID = Convert.ToInt32(dgvImportBill.CurrentRow.Cells["ImportID"].Value);
            //tbImportBilllID.Text = selectedImportBillID.ToString();
            //dtp.Value = Convert.ToDateTime( dgvImportBill.CurrentRow.Cells["Time"].Value);
            //tbCompanyName.Text = dgvImportBill.CurrentRow.Cells["CompanyName"].Value.ToString();
            //tbShiperName.Text = dgvImportBill.CurrentRow.Cells["ShiperName"].Value.ToString();
            //tbNote.Text = dgvImportBill.CurrentRow.Cells["Note"].Value.ToString();
        }

        private void dtpSelect_ValueChanged(object sender, EventArgs e)
        {
            DislayImportBill(dtpSelect.Value);
            CalculateCostInTable();
        }

        private void btDisplayByDate_Click(object sender, EventArgs e)
        {
            DislayImportBill(dtpSelect.Value);
            CalculateCostInTable();
        }

        private void btDisplayByMouth_Click(object sender, EventArgs e)
        {
            DislayImportBillByMouth(dtpSelect.Value);
            CalculateCostInTable();

        }

        private void btDisplayAll_Click(object sender, EventArgs e)
        {
            DislayImportBill();
            CalculateCostInTable();

        }
        private void CalculateCostInTable()
        {
            int sum = 0;
            foreach (DataGridViewRow row in dgvImportBill.Rows)
            {
                if (Convert.ToInt32(row.Cells["Total"].Value) == 0)
                    sum += 0;
                else
                    sum += Convert.ToInt32(row.Cells["Total"].Value);
            }
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            lbTotalCost.Text = double.Parse(sum.ToString()).ToString("#,###", cul.NumberFormat) + " VNĐ";
        }
        private void DislayImportBill()
        {
            var list1 =
                (from imb in db.ImportBills
                 join imbd in db.ImportDetailBills on imb.ImportID equals imbd.ImportID
                 orderby imb.Time descending
                 group new { imb, imbd } by new { imb.ImportID, imb.Time, imb.CompanyName, imb.ShiperName, imb.Note } into im
                 select new
                 {
                     ImportID = im.Key.ImportID,
                     Time = im.Key.Time,
                     CompanyName = im.Key.CompanyName,
                     ShiperName = im.Key.ShiperName,
                     Total = im.Sum(t => t.imbd.Quatity * t.imbd.Price),
                     Note = im.Key.Note
                 })
                   .ToList();


            dgvImportBill.DataSource = list1;

        }
        private void DislayImportBill(DateTime dateTime)
        {
            dgvImportBill.DataSource =
                (from imb in db.ImportBills
                 join imbd in db.ImportDetailBills on imb.ImportID equals imbd.ImportID
                 group new { imb, imbd } by new { imb.ImportID, imb.Time, imb.CompanyName, imb.ShiperName, imb.Note } into im
                 where EntityFunctions.TruncateTime(im.Key.Time) == dateTime.Date
                 select new
                 {
                     ImportID = im.Key.ImportID,
                     Time = im.Key.Time,
                     CompanyName = im.Key.CompanyName,
                     ShiperName = im.Key.ShiperName,
                     Total = im.Sum(t => t.imbd.Quatity * t.imbd.Price),
                     Note = im.Key.Note
                 }).ToList();
            //dgvImportBill.DataSource =
            //    (from imb in db.ImportBills
            //     select new
            //     {
            //         ImportID = imb.ImportID,
            //         Time = imb.Time,
            //         CompanyName = imb.CompanyName,
            //         ShiperName = imb.ShiperName,
            //         Note = imb.Note
            //     }).ToList();

        }
        private void DislayImportBillByMouth(DateTime dateTime)
        {
            dgvImportBill.DataSource =
                (from imb in db.ImportBills
                 join imbd in db.ImportDetailBills on imb.ImportID equals imbd.ImportID
                 group new { imb, imbd } by new { imb.ImportID, imb.Time, imb.CompanyName, imb.ShiperName, imb.Note } into im
                 where (im.Key.Time.Value.Month == dateTime.Month && im.Key.Time.Value.Year == dateTime.Year)
                 select new
                 {
                     ImportID = im.Key.ImportID,
                     Time = im.Key.Time,
                     CompanyName = im.Key.CompanyName,
                     ShiperName = im.Key.ShiperName,
                     Total = im.Sum(t => t.imbd.Quatity * t.imbd.Price),
                     Note = im.Key.Note
                 }).ToList();
            //dgvImportBill.DataSource =
            //    (from imb in db.ImportBills
            //     select new
            //     {
            //         ImportID = imb.ImportID,
            //         Time = imb.Time,
            //         CompanyName = imb.CompanyName,
            //         ShiperName = imb.ShiperName,
            //         Note = imb.Note
            //     }).ToList();

        }

        private void btDisplayToday_Click(object sender, EventArgs e)
        {
            dtpSelect.Value = DateTime.Today;
            DislayImportBill(dtpSelect.Value);
        }

        private void dgvImportBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedImportBillID = Convert.ToInt32(dgvImportBill.CurrentRow.Cells["ImportID"].Value);
            tbImportBilllID.Text = selectedImportBillID.ToString();
            dtp.Value = Convert.ToDateTime(dgvImportBill.CurrentRow.Cells["Time"].Value);
            tbCompanyName.Text = dgvImportBill.CurrentRow.Cells["CompanyName"].Value.ToString();
            tbShiperName.Text = dgvImportBill.CurrentRow.Cells["ShiperName"].Value.ToString();
            tbNote.Text = dgvImportBill.CurrentRow.Cells["Note"].Value.ToString();
        }
    }
}
