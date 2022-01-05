using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        ImportDetailBill selectImportDetail;
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
            InitComboboxMaterialName();
            VisibleTextbox(false);
        }

        private void InitComboboxMaterialName()
        {
            db.Materials.Load();
            cbbMaterialName.DataSource = db.Materials.Local;
            cbbMaterialName.DisplayMember = "MaterialName";
            cbbMaterialName.ValueMember = "MaterialName";

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

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbbMaterialName.Visible == false) VisibleTextbox(true);
            else
            {
                int matID = db.Materials.FirstOrDefault(mat => mat.MaterialName == cbbMaterialName.Text).MaterialID;
                if(matID == null)
                {
                    MessageBox.Show("Tên nguyên liệu không tồn tại ! Bạn cần thêm vào danh sách nguyên liệu ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return;
                }
                //
                ImportDetailBill imDB = new ImportDetailBill()
                {
                    ImportID = Convert.ToInt32(lbImportBillID.Text),
                    MaterialID = matID,
                    Quatity = Convert.ToInt32(tbQuatity.Text),
                    Price = Convert.ToInt32(tbPrice.Text)
                };
                db.ImportDetailBills.Add(imDB);
                db.SaveChanges();
                DisplayImportDetailBill();
            }
        }

        private void VisibleTextbox(bool isvisible)
        {
            cbbMaterialName.Visible = isvisible;
            tbPrice.Visible = isvisible;
            tbQuatity.Visible = isvisible;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int importBillID = Convert.ToInt32(lbImportBillID.Text);
            var matName = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            int matID = db.Materials.FirstOrDefault(p => p.MaterialName == matName).MaterialID;
            selectImportDetail = db.ImportDetailBills.FirstOrDefault(imdb => imdb.ImportID == importBillID && imdb.MaterialID == matID);
            //Xoa
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult dR = MessageBox.Show("Sản phẩm này sẽ bị xóa khỏi hóa đơn nhập ?", "Xóa", MessageBoxButtons.YesNo);
                if (dR == DialogResult.Yes)
                {
                    db.ImportDetailBills.Remove(selectImportDetail);
                    db.SaveChanges();
                    DisplayImportDetailBill();
                }
            }
        }

        private void btCloseTB_Click(object sender, EventArgs e)
        {
            VisibleTextbox(false);
        }

        private void ImportDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dgv.RowCount == 0)
            {
                int imID = Convert.ToInt32(lbImportBillID.Text);
                db.ImportBills.Remove(db.ImportBills.FirstOrDefault(im => im.ImportID == imID));
            }
        }
    }
}
