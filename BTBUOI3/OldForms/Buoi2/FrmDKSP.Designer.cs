using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DOANCANHAN
{
    partial class FormDangKySanPham
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtTen;
        private ComboBox cmbLoai;
        private NumericUpDown numSoLuong;
        private Button btnLuu, btnXoa, btnLamMoi;
        private DataGridView dataGridView1;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            txtTen = new TextBox();
            cmbLoai = new ComboBox();
            numSoLuong = new NumericUpDown();
            btnLuu = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtTen
            // 
            txtTen.Location = new Point(30, 20);
            txtTen.Name = "txtTen";
            txtTen.PlaceholderText = "Tên sản phẩm";
            txtTen.Size = new Size(255, 27);
            txtTen.TabIndex = 0;
            // 
            // cmbLoai
            // 
            cmbLoai.Items.AddRange(new object[] { "Cà phê", "Trà", "Nước ngọt" });
            cmbLoai.Location = new Point(30, 60);
            cmbLoai.Name = "cmbLoai";
            cmbLoai.Size = new Size(255, 28);
            cmbLoai.TabIndex = 1;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(30, 100);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(255, 27);
            numSoLuong.TabIndex = 2;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(30, 140);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 34);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(120, 140);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 34);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(210, 140);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 34);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView1.Location = new Point(337, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(400, 200);
            dataGridView1.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Tên sản phẩm";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Loại sản phẩm";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // FormDangKySanPham
            // 
            ClientSize = new Size(749, 260);
            Controls.Add(txtTen);
            Controls.Add(cmbLoai);
            Controls.Add(numSoLuong);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(dataGridView1);
            Name = "FormDangKySanPham";
            Text = "Đăng ký sản phẩm";
            Load += FormDangKySanPham_Load;
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        #endregion


    }
}