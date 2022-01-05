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
using System.Windows.Forms.DataVisualization.Charting;
using TocoMilkTeaShop.Models;

namespace TocoMilkTeaShop.Tabs
{
    public partial class UCStatistical : UserControl
    {
        DB db = new DB();
        public UCStatistical()
        {
            InitializeComponent();
        }

        private void UCStatistical_Load(object sender, EventArgs e)
        {
            DisplayChart();
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
            cbbTypeOfTime.SelectedIndex = 0;
            dtpMouth.Value = DateTime.Today;
            StatisticsMouth(dtpMouth.Value);
        }

        private void DisplayChart()
        {
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            chart.Series[2].Points.Clear();
            //
            int nmouth = ((dtpTo.Value.Year - dtpFrom.Value.Year) * 12) + dtpTo.Value.Month - dtpFrom.Value.Month +1;
            int startMouth = dtpFrom.Value.Month;
            int startYear = dtpFrom.Value.Year;
            int endMouth = dtpTo.Value.Month;
            int endYear = dtpTo.Value.Year;
            float re, co;
            //
            for (int i = 0; i < nmouth; i++)
            {
                 re = CalculateRevenueMouth(new DateTime(startYear, startMouth, 1));
                 co = CalculateCostMouth(new DateTime(startYear, startMouth, 1));
                //
                chart.Series["Doanh thu"].Points.AddXY( startMouth + "/" + startYear, re);
                chart.Series["Chi phí"].Points.AddXY( startMouth + "/" + startYear, co);
                chart.Series["Lãi"].Points.AddXY(startMouth + "/" + startYear, re - co);
                //
                if (startMouth == endMouth && startYear == endYear) return;
                else if(startMouth == 12 && startYear < endYear){ startYear++; startMouth = 1;  }
                else 
                //if(startMouth < endMouth && startYear < endYear) 
                    startMouth++;
            }
        }
         private float CalculateRevenueMouth(DateTime dateTime)
        {
            float re = 0f;
            var list = (from b in db.Bills
             join o in db.Orders on b.BillID equals o.BillID
             join p in db.Menus on o.ProductID equals p.ProductID
             group new { b, o, p } by new { b.BillID, b.Time } into bop
             where bop.Key.Time.Value.Month == dateTime.Month && bop.Key.Time.Value.Year == dateTime.Year
             select new
             {
                 BillID = bop.Key.BillID,
                 Time = bop.Key.Time,
                 Total = bop.Sum(q => q.o.Quatity * q.p.Price)
             }).ToList();
            foreach(var item in list)
            {
                re += (float)item.Total;
            }
            return re;
        }
         private float CalculateCostMouth(DateTime dateTime)
        {
            float co = 0f;
            var list = (from imb in db.ImportBills
             join imbd in db.ImportDetailBills on imb.ImportID equals imbd.ImportID
             group new { imb, imbd } by new { imb.ImportID, imb.Time } into im
             where (im.Key.Time.Value.Month == dateTime.Month && im.Key.Time.Value.Year == dateTime.Year)
             select new
             {
                 ImportID = im.Key.ImportID,
                 Time = im.Key.Time,
                 Total = im.Sum(t => t.imbd.Quatity * t.imbd.Price),
             }).ToList();
            foreach(var item in list)
            {
                co += (float)item.Total;
            }
            return co;
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            DisplayChart();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            DisplayChart();
        }

        private void cbbTypeOfTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbTypeOfTime.SelectedIndex)
            {
                case 0 :
                    ShowOptionMouthStatistics();
                    break; 
                case 1 :
                    ShowOptionOverTimeStatistics();
                    break; 
                default: break;
            }
        }

        private void ShowOptionMouthStatistics()
        {
            
            lbChooseMouth.Visible = true;
            dtpMouth.Visible = true;
            lbdtpFrom.Visible = false;
            lbdtpTo.Visible = false;
            dtpFrom.Visible = false;
            dtpTo.Visible = false;
            chart.Visible = false;

        }

        private void ShowOptionOverTimeStatistics()
        {
            lbdtpFrom.Visible = true;
            lbdtpTo.Visible = true;
            dtpFrom.Visible = true;
            dtpTo.Visible = true;
            chart.Visible = true;
            lbChooseMouth.Visible = false;
            dtpMouth.Visible = false;

        }

        private void SwitchToOption2()
        {
            throw new NotImplementedException();
        }

        private void dtpMouth_ValueChanged(object sender, EventArgs e)
        {
            StatisticsMouth(dtpMouth.Value);
        }

        private void StatisticsMouth(DateTime dateTime)
        {
            float re = CalculateRevenueMouth(dateTime);
            float co = CalculateCostMouth(dateTime);
            lbRevenue.Text = re + " VND";
            lbCost.Text = co + " VND";
            lbInterest.Text = (re - co) + " VND";
        }

        private void chart_MouseDown(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart.HitTest(e.X, e.Y);
            if(result.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint selectedDataPoint = (DataPoint)result.Object;
                //MessageBox.Show(result.Series.Name + "Kết quả " + selectedDataPoint.YValues[0]);
                toolTip.ToolTipTitle = selectedDataPoint.YValues[0] + "";
                NumberFormatInfo numberFormat = CultureInfo.GetCultureInfo("vi-VN").NumberFormat;

                //lbRevenue.Text = double.Parse(selectedDataPoint.YValues[0].ToString()).ToString("#,###", numberFormat) + " VNĐ";
                //lbCost.Text = double.Parse(selectedDataPoint.YValues[1].ToString()).ToString("#,###", numberFormat) + " VNĐ";
                //lbInterest.Text = double.Parse(selectedDataPoint.YValues[2].ToString()).ToString("#,###", numberFormat) + " VNĐ";
                //lbRevenue.Text = selectedDataPoint.YValues[0]+" VND";
                //lbCost.Text = selectedDataPoint.YValues[0] + " VND";
                //lbInterest.Text = selectedDataPoint.YValues[0] + " VND";
            }
        }
    }
}
