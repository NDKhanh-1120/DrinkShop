using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TocoMilkTeaShop.Models;

namespace TocoMilkTeaShop.Tabs
{
    public partial class UCProduct : UserControl
    {
        DB db = new DB();
        TocoMilkTeaShop.Models.Menu selectedProduct;
        public UCProduct()
        {
            InitializeComponent();
        }

        private void UCProduct_Load(object sender, EventArgs e)
        {
            DisplayProduct();
            panel.Visible = false;
        }

        private void DisplayProduct()
        {
            dgv.DataSource = db.Menus.ToList();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            TocoMilkTeaShop.Models.Menu product = new TocoMilkTeaShop.Models.Menu()
            {
                ProductName = tbProductName.Text,
                Price = Convert.ToInt32(tbPrice.Text),
                ImagePath = lbImagePath.Text
            };
            db.Menus.Add(product);
            db.SaveChanges();
            DisplayProduct();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            selectedProduct.ProductName = tbProductName.Text;
            selectedProduct.Price = Convert.ToInt32(tbPrice.Text);
            if (pictureBox.Image != null) selectedProduct.ImagePath = lbImagePath.Text;
            db.SaveChanges();
            DisplayProduct();
        }
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            //OpenFileDialog opfDialog = new OpenFileDialog();
            //opfDialog.Filter = "Choose Image(*.jpg;*.png;)|*.jpg;*.png;";
            //if (opfDialog.ShowDialog() == DialogResult.OK)
            //{
            //    pictureBox.Image = Image.FromFile(opfDialog.FileName);
            //}
            //try
            //{
            //    MemoryStream mS = new MemoryStream();
            //    pictureBox.Image.Save(mS, pictureBox.Image.RawFormat);
            //    byte[] img = mS.ToArray();
            //    dgv.Rows.Add(img);
            //}
            //catch(Exception exx) { MessageBox.Show("Loi"); }
            // duong dan chua anh
            string saveDirectory = @"D:\Menu\";
            if (!Directory.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }
            //hien thi file chooser
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // khi nhan ok
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                    string fileName = Path.GetFileName(openFileDialog.FileName);
                    string fileSavePath = Path.Combine(saveDirectory, fileName);
                    lbImagePath.Text = fileSavePath;
                    //copy anh vao duong dan chua anh
                    File.Copy(openFileDialog.FileName, fileSavePath, true);
                }
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            int iD = Convert.ToInt32( dgv.CurrentRow.Cells["ProductID"].Value.ToString());
            selectedProduct = db.Menus.FirstOrDefault(p=>p.ProductID == iD); 
            tbProductName.Text = dgv.CurrentRow.Cells["ProductName"].Value.ToString();
            tbPrice.Text = dgv.CurrentRow.Cells["Price"].Value.ToString();
            //pictureBox.Image = Image.FromFile(dgv.CurrentRow.Cells["ProductImage"].Value.ToString());
                //dgv.CurrentRow.Cells["ProductImage"].Value.
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult dR = MessageBox.Show("Sản phẩm này sẽ bị xóa mất ?", "Xóa", MessageBoxButtons.YesNo);
                if (dR == DialogResult.Yes)
                {
                int iD =Convert.ToInt32( senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                var product = db.Menus.FirstOrDefault(p => p.ProductID == iD);
                db.Menus.Remove(product);
                db.SaveChanges();
                DisplayProduct();
                }
            }
        }
        private void btEdit_Click_1(object sender, EventArgs e)
        {
            if(panel.Visible == false)
            {
                panel.Visible = true;
                tbProductName.Clear();
                tbPrice.Clear();
                dgv.Location = new Point(135, 108);
            }
            else
            {
                panel.Visible = false;
                dgv.Location = new Point(135, 30);
            }
        }
    }
}
