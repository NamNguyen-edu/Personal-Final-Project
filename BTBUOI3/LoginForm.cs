using System;
using System.Windows.Forms;

namespace TDashMiniStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // wire events
            btnLogin.Click += BtnLogin_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            // Ví dụ xác thực đơn giản:
            // admin / 123 -> Admin
            // user / 123  -> User
            if (username.Equals("admin", StringComparison.OrdinalIgnoreCase) && password == "123")
            {
                // gọi MainForm với (username, role)
                var main = new MainForm("admin", "Admin");
                main.Show();
                this.Hide();
                main.FormClosed += (s, a) => this.Close();
            }
            else if (username.Equals("user", StringComparison.OrdinalIgnoreCase) && password == "123")
            {
                var main = new MainForm("user", "User");
                main.Show();
                this.Hide();
                main.FormClosed += (s, a) => this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnExit_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}