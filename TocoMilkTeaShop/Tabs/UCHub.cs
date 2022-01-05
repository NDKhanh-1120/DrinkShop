using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TocoMilkTeaShop.Models;

namespace TocoMilkTeaShop.Tabs
{
    public partial class UCHub : UserControl
    {
        DB db = new DB();
        int selectedIndex;
        public UCHub()
        {
            InitializeComponent();
        }
        private void UCHub_Load(object sender, EventArgs e)
        {
            dtp.Value = DateTime.Now.Date;
            DisplayInventoryInDate(dtp.Value);
            dgv.ReadOnly = false;
        }
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DisplayInventoryInDate(dtp.Value);
        }
        private void btCreateInventoryToday_Click(object sender, EventArgs e)
        {
            dtp.Value = DateTime.Now.Date;
            HubMaterial exists = db.HubMaterials.FirstOrDefault
                (hm => EntityFunctions.TruncateTime(hm.Times) == dtp.Value );
            if (exists != null) 
            {
                MessageBox.Show("Tồn kho đã được tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                HubMaterial hubmat = new HubMaterial()
                {
                    Times = DateTime.Now
                };
                db.HubMaterials.Add(hubmat);
                db.SaveChanges();
                //
                var materialList = db.Materials.ToList();
                HubDetail hubDetail;
                foreach (Material mat in materialList)
                {
                    hubDetail = new HubDetail()
                    {
                        HubMaterialID = hubmat.HubMaterialID,
                        MaterialID = mat.MaterialID,
                        Quatity = 0
                    };
                    db.HubDetails.Add(hubDetail);
                    db.SaveChanges();
                }
                //
                DisplayInventoryInDate(DateTime.Today);
            }

        }
        private void btRemoveInDate_Click(object sender, EventArgs e)
        {
            
            RemoveHubInDate(dtp.Value);
        }
        private void RemoveHubInDate(DateTime value)
        {
            db.HubMaterials.Remove(db.HubMaterials.FirstOrDefault
                (hub => EntityFunctions.TruncateTime(hub.Times) == dtp.Value.Date));
            db.SaveChanges();
            DisplayInventoryInDate(dtp.Value);
        }
        private void DisplayInventoryInDate(DateTime dateTimeValue)
        {
              var list =
             (from hm in db.HubMaterials
              join hd in db.HubDetails on hm.HubMaterialID equals hd.HubMaterialID
              join mat in db.Materials on hd.MaterialID equals mat.MaterialID
              where EntityFunctions.TruncateTime(hm.Times) == dtp.Value.Date
              select new
              {
                  MaterialID = hd.MaterialID,
                  MaterialName = mat.MaterialName,
                  Quatity = hd.Quatity
              }).ToList();
            dgv.DataSource = list;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
             selectedIndex = Convert.ToInt32( dgv.CurrentRow.Cells["MaterialID"].Value);
        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.CurrentCell.ReadOnly = false;
        }
    }
}
