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
    public partial class UCBC : Form
    {
        public UCBC()
        {
            InitializeComponent();
        }

        private int TimUSCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private int TimBSCNN(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            return Math.Abs(a * b) / TimUSCLN(a, b);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            txtKetQua.Clear();
            if (!int.TryParse(txtA.Text, out int A) || !int.TryParse(txtB.Text, out int B))
            {
                MessageBox.Show("Vui lòng nhập hai số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            int ketQua = 0;
            if (rdoUSCLN.Checked)
            {
                ketQua = TimUSCLN(A, B);
            }
            else if (rdoBSCNN.Checked)
            {
                ketQua = TimBSCNN(A, B);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm USCLN hoặc BSCNN.", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            txtKetQua.Text = ketQua.ToString();
        }
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            txtA.Focus();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtKtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void UCBC_Load(object sender, EventArgs e)
        {
            rdoUSCLN.Checked = true;
        }
    }
}
