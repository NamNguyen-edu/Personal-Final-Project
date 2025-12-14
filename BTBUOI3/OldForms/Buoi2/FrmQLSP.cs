using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCANHAN
{
    public partial class FormQuanLySanPham : Form
    {
        public FormQuanLySanPham()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                errorProvider1.SetError(txtTen, "Tên sản phẩm không được để trống");
                return;
            }
            if (numSoLuong.Value <= 0)
            {
                errorProvider1.SetError(numSoLuong, "Số lượng phải > 0");
                return;
            }

            string tinhTrang = rdoCon.Checked ? "Còn" : "Hết";
            dataGridView1.Rows.Add(txtTen.Text, cmbLoai.Text, numSoLuong.Value, tinhTrang);
            CapNhatTrangThai();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            CapNhatTrangThai();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                row.Cells[0].Value = txtTen.Text;
                row.Cells[1].Value = cmbLoai.Text;
                row.Cells[2].Value = numSoLuong.Value;
                row.Cells[3].Value = rdoCon.Checked ? "Còn" : "Hết";
            }
            CapNhatTrangThai();
        }

        private void CapNhatTrangThai()
        {
            lblStatus.Text = $"Tổng số sản phẩm: {dataGridView1.Rows.Count}";
        }

        private void FormQuanLySanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
