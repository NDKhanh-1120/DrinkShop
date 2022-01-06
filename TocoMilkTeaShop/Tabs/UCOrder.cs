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
using System.Data.Entity;
using System.Globalization;

namespace TocoMilkTeaShop
{
    public partial class UCOrder : UserControl
    {
        DB db = new DB();
        List<Orders> listOrder = new List<Orders>();
        Orders selectedOrder;
        public UCOrder()
        {
            InitializeComponent();
        }
        private void UCOrder_Load(object sender, EventArgs e)
        {
            //hien thi danh sach cac san pham ban
            DisplayMenu();
           
        }

        private void SetUPDgvOrder()
        {
            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();

            textColumn.DataPropertyName = "ProductName";
            textColumn.Name = "ProductName";
            textColumn.ReadOnly = true;
            textColumn.HeaderText = "Tên đồ uống";
            textColumn.Width = 175;
            dgvOrder.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.DataPropertyName = "Quatity";
            textColumn.Name = "Quatity";
            textColumn.HeaderText = "Số lượng";
            textColumn.Width = 50;
            textColumn.ReadOnly = true;
            dgvOrder.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.DataPropertyName = "Price";
            textColumn.Name = "Price";
            textColumn.HeaderText = "Đơn giá";
            textColumn.Width = 150;
            textColumn.ReadOnly = true;
            dgvOrder.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.DataPropertyName = "Money";
            textColumn.Name = "Money";
            textColumn.HeaderText = "Thành tiền";
            textColumn.Width = 130;
            textColumn.ReadOnly = true;
            dgvOrder.Columns.Add(textColumn);

            dgvOrder.Columns["DeleteThis"].DisplayIndex = 4;
            dgvOrder.Columns["DeleteThis"].Width = 45;

        }

        private void DisplayMenu()
        {
            dgvProduct.DataSource = db.Menus.ToList();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            //neu dgvOrder = null 
            if (dgvOrder.DataSource == null)
            {
                AddNewBill();
                Bill currentBill = db.Bills.OrderByDescending(b => b.BillID).First();
                lbBillID.Text = currentBill.BillID.ToString();
                lbTime.Text = DateTime.Now.ToString(); 
                AddOrderIntoCurrentBill(e);
                DisplayOrdersOfCurrentBill();
            }
            else
            {
                int currentBillID = Convert.ToInt32(lbBillID.Text);
                int currentProductID = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells["ProductID"].Value.ToString());
                Orders currentOrder = db.Orders.FirstOrDefault(o => o.BillID == currentBillID && o.ProductID == currentProductID);
                                                
                if (currentOrder != null)
                {
                    //tang so luong
                    IncreaseQuatity(currentOrder);
                    //hien thi ra dgvOrder
                    DisplayOrdersOfCurrentBill();
                }
                else
                {
                    AddOrderIntoCurrentBill(e);
                    //hien thi ra dgvOrder
                    DisplayOrdersOfCurrentBill();
                }
            }
            CalcTotalPayment();
        }
        private void tbCustomerGiving_TextChanged(object sender, EventArgs e)
        {
            try { lbGiveBack.Text = ( Convert.ToInt32(tbCustomerGiving.Text) - Convert.ToInt32(lbTotal.Text)).ToString(); }
            catch (Exception ex) { return; }
        }
        private void btClearTB_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
            DisplayMenu();
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            ClearOrders();
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            RemoveCurrentOrdersAndBill();
            ClearOrders();
        }
        private void btPlus_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null) return;
            IncreaseQuatity(selectedOrder);
            DisplayOrdersOfCurrentBill();
            CalcTotalPayment();
        }
        private void btMinus_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null) return;
            DecreaseQuatity(selectedOrder);
            DisplayOrdersOfCurrentBill();
            CalcTotalPayment();
        }
        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int billID = Convert.ToInt32(lbBillID.Text);
            var productName = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            int productID = db.Menus.FirstOrDefault(p => p.ProductName == productName).ProductID;
            selectedOrder = db.Orders.FirstOrDefault(o => o.BillID == billID && o.ProductID == productID);
            //Xoa
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult dR = MessageBox.Show("Sản phẩm này sẽ bị xóa khỏi hóa đơn ?", "Xóa", MessageBoxButtons.YesNo);
                if (dR == DialogResult.Yes)
                {
                    db.Orders.Remove(selectedOrder);
                    db.SaveChanges();
                    DisplayOrdersOfCurrentBill();
                }
            }
        }
        private void AddNewBill()
        {
            //string address = new MainManager().GetAddressName();
            var bill = new Bill()
            {
                Time = DateTime.Now,
            };

            try
            {
                db.Bills.Add(bill);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm bill");
            }
        }
        private void AddOrderIntoCurrentBill(DataGridViewCellEventArgs e)
        {
            var order = new Orders()
            {
                BillID = Convert.ToInt32(lbBillID.Text),
                ProductID = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells["ProductID"].Value.ToString()),
                Quatity = 1
            };
                db.Orders.Add(order);
                db.SaveChanges();

        }
        private void IncreaseQuatity(Orders currentOrder)
        {
            currentOrder.Quatity += 1;
            db.SaveChanges();
            DisplayOrdersOfCurrentBill();
        }
        private void DecreaseQuatity(Orders currentOrder)
        {
            if(currentOrder.Quatity == 1) 
                db.Orders.Remove(currentOrder);
            else
            currentOrder.Quatity -= 1;
            db.SaveChanges();
            DisplayOrdersOfCurrentBill();
        }
        private void DisplayOrdersOfCurrentBill()
        {
            var orderslist = db.Orders
                    .Where(o => o.BillID.ToString() == lbBillID.Text)
                    .Join
                    (
                        db.Menus,
                        o => o.ProductID, p => p.ProductID,
                        (o, p) => new { ProductName = p.ProductName, Quatity = o.Quatity, Price = p.Price, Money = o.Quatity * p.Price }
                    )
                    .ToList();
            dgvOrder.DataSource = orderslist;
        }
        private void CalcTotalPayment()
        {
            double total = 0;
            for(int i = 0; i < dgvOrder.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgvOrder.Rows[i].Cells[4].Value);
            }
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            lbTotal.Text = double.Parse(total.ToString()).ToString("#,###", cul.NumberFormat) + "VNĐ";
        }
        private void ClearOrders()
        {
            lbBillID.Text = "";
            lbTime.Text = "";
            lbTotal.Text = "0";
            tbCustomerGiving.Clear();
            //
            dgvOrder.DataSource = null;
            SetUPDgvOrder();


        }
        private void RemoveCurrentOrdersAndBill()
        {
            if (lbBillID.Text == "") return;
            db.Bills.Remove(db.Bills.FirstOrDefault(b => b.BillID.ToString() == lbBillID.Text));
            db.SaveChanges();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "") 
                DisplayMenu();
            else 
                dgvProduct.DataSource = db.Menus.Where(p => p.ProductName.Contains(tbSearch.Text.Trim())).ToList();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
