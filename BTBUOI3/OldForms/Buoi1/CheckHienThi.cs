
namespace DOANCANHAN
{
    public partial class CheckHienThi : Form
    {
        public CheckHienThi()
        {
            InitializeComponent();
        }
        // Câu a
        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn mở ứng dụng này không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                Application.Exit();
            }

        }

        // Câu b
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string ND = txtNoiDung.Text;
            MessageBox.Show(
                $"Nội dung bạn đã nhập là: {ND}", "Thông báo",
                MessageBoxButtons.OK);
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        // Câu c
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Alt) == Keys.Alt && e.KeyCode == Keys.H)
            {
                MessageBox.Show("Xin chào khoa CNTTKD", "Thông báo", MessageBoxButtons.OK);
            }
        }
        // Câu d
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Bạn vừa click chuột trái", "Thông báo", MessageBoxButtons.OK);
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Bạn vừa click chuột phải", "Thông báo", MessageBoxButtons.OK);
            }
            else if (e.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Bạn vừa click chuột giữa", "Thông báo", MessageBoxButtons.OK);
            }
        }
        // Câu e
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát không ?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }    
        }
    }
}
