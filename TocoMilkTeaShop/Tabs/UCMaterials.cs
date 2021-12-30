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

namespace TocoMilkTeaShop.Tabs
{
    public partial class UCMaterials : UserControl
    {
        DB db = new DB();
        int selectedMat;
        public UCMaterials()
        {
            InitializeComponent();
        }

        private void UCMaterials_Load(object sender, EventArgs e)
        {
            DisplayMaterial();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            Material material = new Material()
            {
                MaterialName = tbMaterialName.Text,
                Unit = tbUnit.Text
            };
            db.Materials.Add(material);
            db.SaveChanges();
            DisplayMaterial();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (db.Materials.FirstOrDefault(mat => mat.MaterialID == selectedMat) == null)
                MessageBox.Show("Tên nguyên liệu không tồn tại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Material material = db.Materials.FirstOrDefault(mat => mat.MaterialID == selectedMat);
            material.MaterialName = tbMaterialName.Text;
            material.Unit = tbUnit.Text;
            db.SaveChanges();
            DisplayMaterial();

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận xóa nguyên liệu ?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                if(db.Materials.FirstOrDefault(mat => mat.MaterialID == selectedMat) != null)
                {
                    db.Materials.Remove(db.Materials.FirstOrDefault(mat => mat.MaterialID == selectedMat));
                    db.SaveChanges();
                    DisplayMaterial();
                }
                else
                {
                    MessageBox.Show("Tên nguyên liệu không tồn tại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btClearTB_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
            DisplayMaterial();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            selectedMat = Convert.ToInt32 (dgv.CurrentRow.Cells["MaterialID"].Value.ToString());
            tbMaterialName.Text = dgv.CurrentRow.Cells["MaterialName"].Value.ToString();
            tbUnit.Text = dgv.CurrentRow.Cells["Unit"].Value.ToString();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tbSearch.Text.Trim();
            dgv.DataSource = db.Materials.Where(mat => mat.MaterialName.Contains(search)).ToList();
        }

        private void DisplayMaterial()
        {
            dgv.DataSource = db.Materials.ToList();
        }


    }
}
