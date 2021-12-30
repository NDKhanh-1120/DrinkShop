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
            dgv.DataSource =
            (from b in db.Bills
             join o in db.Orders on b.BillID equals o.BillID
             join p in db.Menus on o.ProductID equals p.ProductID
             group new { b, o, p } by new { b.BillID, b.Time} into bop
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
             where System.Data.Entity.Core.Objects.EntityFunctions.TruncateTime(bop.Key.Time) == datetime.Date
             select new
             {
                 BillID = bop.Key.BillID,
                 Time = bop.Key.Time,
                 Total = bop.Sum(q=>q.o.Quatity * q.p.Price)  
             }).ToList();

            lbStatistical.Text = "Thống kê - ngày " + datetime.Day + " / " + datetime.Month ;
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
                 Time = bop.Key.Time,
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
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            lblTotal.Text = double.Parse(sum.ToString()).ToString("#,###", cul.NumberFormat) + " VNĐ";
        }

    }
}
