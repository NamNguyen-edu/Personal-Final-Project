using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DOANCANHAN
{
    partial class FormQuanLySanPham
    {

        private System.ComponentModel.IContainer components = null;

        private Panel panelLeft, panelRight;
        private TextBox txtTen;
        private ComboBox cmbLoai;
        private NumericUpDown numSoLuong;
        private Button btnThem, btnSua, btnXoa;
        private GroupBox groupBoxTinhTrang;
        private RadioButton rdoCon, rdoHet;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
        private ToolTip toolTip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelLeft = new Panel();
            pictureBox1 = new PictureBox();
            txtTen = new TextBox();
            cmbLoai = new ComboBox();
            numSoLuong = new NumericUpDown();
            groupBoxTinhTrang = new GroupBox();
            rdoCon = new RadioButton();
            rdoHet = new RadioButton();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            panelRight = new Panel();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBoxTinhTrang.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.MintCream;
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Controls.Add(txtTen);
            panelLeft.Controls.Add(cmbLoai);
            panelLeft.Controls.Add(numSoLuong);
            panelLeft.Controls.Add(groupBoxTinhTrang);
            panelLeft.Controls.Add(btnThem);
            panelLeft.Controls.Add(btnSua);
            panelLeft.Controls.Add(btnXoa);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(300, 420);
            panelLeft.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = tdash_app.Properties.Resources._4e6a0ac8_a034_4a97_a130_7e84aaba3ecc;
            pictureBox1.Location = new Point(16, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 163);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(43, 191);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(220, 27);
            txtTen.TabIndex = 0;
            toolTip1.SetToolTip(txtTen, "Nhập tên sản phẩm");
            // 
            // cmbLoai
            // 
            cmbLoai.Items.AddRange(new object[] { "Cà phê", "Trà", "Nước ngọt" });
            cmbLoai.Location = new Point(43, 224);
            cmbLoai.Name = "cmbLoai";
            cmbLoai.Size = new Size(220, 28);
            cmbLoai.TabIndex = 1;
            toolTip1.SetToolTip(cmbLoai, "Chọn loại sản phẩm");
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(43, 258);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(220, 27);
            numSoLuong.TabIndex = 2;
            toolTip1.SetToolTip(numSoLuong, "Nhập số lượng > 0");
            // 
            // groupBoxTinhTrang
            // 
            groupBoxTinhTrang.Controls.Add(rdoCon);
            groupBoxTinhTrang.Controls.Add(rdoHet);
            groupBoxTinhTrang.Location = new Point(43, 291);
            groupBoxTinhTrang.Name = "groupBoxTinhTrang";
            groupBoxTinhTrang.Size = new Size(220, 80);
            groupBoxTinhTrang.TabIndex = 3;
            groupBoxTinhTrang.TabStop = false;
            groupBoxTinhTrang.Text = "Tình trạng sản phẩm";
            // 
            // rdoCon
            // 
            rdoCon.Checked = true;
            rdoCon.Location = new Point(10, 30);
            rdoCon.Name = "rdoCon";
            rdoCon.Size = new Size(76, 24);
            rdoCon.TabIndex = 0;
            rdoCon.TabStop = true;
            rdoCon.Text = "Còn";
            // 
            // rdoHet
            // 
            rdoHet.Location = new Point(100, 30);
            rdoHet.Name = "rdoHet";
            rdoHet.Size = new Size(104, 24);
            rdoHet.TabIndex = 1;
            rdoHet.Text = "Hết";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(24, 377);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 30);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(114, 377);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 30);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(204, 377);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 30);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(dataGridView1);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(300, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(799, 420);
            panelRight.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(799, 420);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Tên sản phẩm";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Loại";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Tình trạng";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 420);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1099, 22);
            statusStrip1.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 16);
            // 
            // FormQuanLySanPham
            // 
            BackColor = Color.White;
            ClientSize = new Size(1099, 442);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(statusStrip1);
            Name = "FormQuanLySanPham";
            Text = "Quản lý sản phẩm cửa hàng Việt Nam";
            WindowState = FormWindowState.Maximized;
            Load += FormQuanLySanPham_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBoxTinhTrang.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private PictureBox pictureBox1;
    }
}