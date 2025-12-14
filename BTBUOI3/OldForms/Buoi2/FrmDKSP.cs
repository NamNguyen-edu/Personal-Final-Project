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
    public partial class FormDangKySanPham : Form
    {
        public FormDangKySanPham()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtTen.Text, cmbLoai.Text, numSoLuong.Value);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTen.Clear();
            cmbLoai.SelectedIndex = -1;
            numSoLuong.Value = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }

        private void FormDangKySanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
