using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;


namespace DOANCANHAN
{
    public partial class MayTinh : Form
    {
        public MayTinh()
        {
            InitializeComponent();
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            Cal("+");
        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            Cal("-");
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            Cal("*");
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            Cal("/");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtST1.Clear();
            txtST2.Clear();
            txtKQ.Clear();
            txtST1.Focus();
        }

        private void txtChiNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtST1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtST2_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }
        private void Cal(string phepToan)
        {
            txtKQ.Text = "";
            if (!double.TryParse(txtST1.Text, out double so1) ||
                !double.TryParse(txtST2.Text, out double so2))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ vào cả hai ô.", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            double ketQua = 0;
            switch (phepToan)
            {
                case "+":
                    ketQua = so1 + so2;
                    break;
                case "-":
                    ketQua = so1 - so2;
                    break;
                case "*":
                    ketQua = so1 * so2;
                    break;
                case "/":
                    if (so2 == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0.", "Lỗi Toán Học", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    ketQua = so1 / so2;
                    break;
            }
            txtKQ.Text = ketQua.ToString();
        }

    }
}
