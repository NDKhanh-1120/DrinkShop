using Microsoft.VisualBasic;
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
                     Unit = mat.Unit,
                     Price = imdb.Price,
                     Total = imdb.Quatity * imdb.Price
                 }).ToList();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbbMaterialName.Visible == false) VisibleTextbox(true);
            else
            {
                bool checkExists = db.Materials.Where(mat => mat.MaterialName == cbbMaterialName.Text).Any();
                if (!checkExists)
                {
                    //MessageBox.Show("Tên nguyên liệu không tồn tại ! Bạn cần thêm vào danh sách nguyên liệu ?", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //return;
                    DialogResult dR = MessageBox.Show("Tên nguyên liệu không tồn tại ! Bạn có muốn thêm vào danh sách nguyên liệu ?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dR == DialogResult.Yes)
                    {
                        object unitValue;
                        //
                        unitValue = Interaction.InputBox("Nhập đơn vị tính cho nguyên liệu vừa thêm !", "Nhập", "--nhập tại đây---");
                        if (string.IsNullOrEmpty(unitValue.ToString().Trim()))
                            MessageBox.Show("Bạn chưa nhập !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            Material material = new Material()
                            {
                                MaterialName = cbbMaterialName.Text,
                                Unit = unitValue.ToString()
                            };
                            db.Materials.Add(material);
                            db.SaveChanges();
                            //
                            AddMaterialInImportDetailBill(cbbMaterialName.Text);
                            DisplayImportDetailBill();
                        }
                    }
                }
                else
                {
                    AddMaterialInImportDetailBill(cbbMaterialName.Text);
                    DisplayImportDetailBill();
                }
            }
        }

        private void AddMaterialInImportDetailBill(string materialName)
        {
            if (!int.TryParse(tbPrice.Text, out int Num) || !int.TryParse(tbQuatity.Text, out Num))
            {
                MessageBox.Show("Lỗi nhập dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            //
            int matID = db.Materials.FirstOrDefault(mat => mat.MaterialName == cbbMaterialName.Text).MaterialID;
            //
            if(db.ImportDetailBills.Any(imx=>imx.MaterialID == matID))
            {
                MessageBox.Show("Tên hàng đã có sẵn trong hóa đơn !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ImportDetailBill imDB = new ImportDetailBill()
            {
                ImportID = Convert.ToInt32(lbImportBillID.Text),
                MaterialID = matID,
                Quatity = Convert.ToInt32(tbQuatity.Text),
                Price = Convert.ToInt32(tbPrice.Text)
            };
            db.ImportDetailBills.Add(imDB);
            db.SaveChanges();
        }

        private void VisibleTextbox(bool isvisible)
        {
            cbbMaterialName.Visible = isvisible;
            tbPrice.Visible = isvisible;
            tbQuatity.Visible = isvisible;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0) return;
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
