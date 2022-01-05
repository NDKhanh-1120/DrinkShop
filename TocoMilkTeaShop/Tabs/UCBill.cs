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
using TocoMilkTeaShop.Models;

namespace TocoMilkTeaShop.Tabs
{
    public partial class UCBill : UserControl
    {
        DB db = new DB();
        public UCBill()
        {
            InitializeComponent();
        }
        private void UCBill_Load(object sender, EventArgs e)
        {
            dtp.Value = DateTime.Today;
            DisplayBillsByDay(dtp.Value);
            CalculateRevenue();
        }
        private void btDisplayAllBills_Click(object sender, EventArgs e)
        {
            DisplayBills();
            CalculateRevenue();
        }
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DisplayBillsByDay(dtp.Value);
            CalculateRevenue();
        }
        private void btDisplayByDay_Click(object sender, EventArgs e)
        {
            DisplayBillsByDay(dtp.Value);
            CalculateRevenue();
        }
        private void btDisplayByMouth_Click(object sender, EventArgs e)
        {
            DisplayBillsByMouth(dtp.Value);
            CalculateRevenue();
        }
        private void DisplayBills()
        {
            lbStatistical.Text = "Tất cả";
            dgv.DataSource =
            (from b in db.Bills
             join o in db.Orders on b.BillID equals o.BillID
             join p in db.Menus on o.ProductID equals p.ProductID
             group new { b, o, p } by new { b.BillID, b.Time} into bop
             orderby bop.Key.Time descending
             select new
             {
                 BillID = bop.Key.BillID,
                 Time = bop.Key.Time,
                 Total = bop.Sum(q=>q.o.Quatity * q.p.Price)  
             }).ToList();
        }
        private void DisplayBillsByDay(DateTime datetime)
        {
            dgv.DataSource =
            (from b in db.Bills
             join o in db.Orders on b.BillID equals o.BillID
             join p in db.Menus on o.ProductID equals p.ProductID
             group new { b, o, p } by new { b.BillID, b.Time} into bop
             where EntityFunctions.TruncateTime(bop.Key.Time) == datetime.Date
             select new
             {
                 BillID = bop.Key.BillID,
                 Time = bop.Key.Time,
                 Total = bop.Sum(q=>q.o.Quatity * q.p.Price)  
             }).ToList();

            lbStatistical.Text = "Thống kê - ngày " + datetime.Day + " / " + datetime.Month +"/ " + datetime.Year ;
        }
        private void DisplayBillsByMouth(DateTime datetime)
        {
            dgv.DataSource =
            (from b in db.Bills
             join o in db.Orders on b.BillID equals o.BillID
             join p in db.Menus on o.ProductID equals p.ProductID
             group new { b, o, p } by new { b.BillID, b.Time } into bop
             where bop.Key.Time.Value.Month == datetime.Month && bop.Key.Time.Value.Year == datetime.Year
             select new
             {
                 BillID = bop.Key.BillID,
                 Time =  bop.Key.Time,
                 Total = bop.Sum(q => q.o.Quatity * q.p.Price)
             }).ToList();
          
            lbStatistical.Text = "Thống kê - tháng " + datetime.Month + " / " + datetime.Year;
        }
        private void CalculateRevenue()
        {
            int sum = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                sum += Convert.ToInt32(row.Cells["Total"].Value.ToString());
            }
            lblTotal.Text = double.Parse(sum.ToString())
                .ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + " VNĐ";
        }

        private void btDisplayToday_Click(object sender, EventArgs e)
        {
            dtp.Value = DateTime.Today;
            DisplayBillsByDay(dtp.Value);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                var senderGrid = (DataGridView)sender;
            //Xoa
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int billID = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["BillID"].Value);
                var selectedBill = db.Bills.FirstOrDefault(o => o.BillID == billID);
                DialogResult dR = MessageBox.Show("Hóa đơn này sẽ bị xóa khỏi hóa đơn ?", "Xóa", MessageBoxButtons.YesNo);
                if (dR == DialogResult.Yes)
                {
                    db.Bills.Remove(selectedBill);
                    db.SaveChanges();
                    DisplayBillsByDay(dtp.Value);
                }
            }

        }
    }
}
