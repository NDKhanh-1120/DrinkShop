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

namespace TocoMilkTeaShop.Forms
{
    public partial class ImportDetail : Form
    {
        DB db = new DB();
        int importBillID;
        public ImportDetail()
        {
            InitializeComponent();
        }
        public ImportDetail(int importID,DateTime time,string companyName,string shipperName, string note)
        {
            InitializeComponent();
            lbImportBillID.Text = importID.ToString();
            lbTime.Text = time.ToString();
            lbCompanyName.Text = companyName;
            lbShipperName.Text = shipperName;
            lbNote.Text = note;

            importBillID = Convert.ToInt32(lbImportBillID.Text);
        }

        private void ImportDetail_Load(object sender, EventArgs e)
        {
            DisplayImportDetailBill();
        }

        private void DisplayImportDetailBill()
        {
            dgv.DataSource =
                (from imdb in db.ImportDetailBills
                 join mat in db.Materials on imdb.MaterialID equals mat.MaterialID
                 where imdb.ImportID == importBillID
                 select new
                 {
                     MaterialName = mat.MaterialName,
                     Quatity = imdb.Quatity,
                     Price = imdb.Price,
                     Total = imdb.Quatity * imdb.Price
                 }).ToList();
        }

        private void lbImportBillID_Click(object sender, EventArgs e)
        {

        }

        private void lbCompanyName_Click(object sender, EventArgs e)
        {

        }

        private void lbShipperName_Click(object sender, EventArgs e)
        {

        }

        private void lbTime_Click(object sender, EventArgs e)
        {

        }

        private void lbNote_Click(object sender, EventArgs e)
        {

        }
    }
}
