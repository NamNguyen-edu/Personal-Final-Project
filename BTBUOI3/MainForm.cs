using System;
using System.Windows.Forms;

namespace TDashMiniStore
{
    public partial class MainForm : Form
    {
        private ContextMenuStrip trayMenu;
        string currentUser, currentRole;
        public MainForm(string user, string role)
        {
            currentUser = user; currentRole = role;
            InitializeComponent();
            SetupTrayIcon();
            slUser.Text = $"Người dùng: {currentUser} ({currentRole})";
            timer1.Tick += (s, e) => slTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.MdiChildActivate += (s, e) => { slForm.Text = this.ActiveMdiChild?.Text ?? "-"; };
            repo = DataRepository.Instance; repo.Seed();
        }

        DataRepository repo;
        private void SetupTrayIcon()
        {
            // Menu chuột phải trên khay
            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Mở lại", null, (s, e) => RestoreFromTray());
            trayMenu.Items.Add("Thoát", null, (s, e) => Application.Exit());

            // Gắn menu vào NotifyIcon có sẵn
            notifyIcon1.ContextMenuStrip = trayMenu;
            notifyIcon1.Text = "TDASH Mini Store";
            notifyIcon1.Visible = false;

            // Gắn sự kiện double click
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
        }
        private void RestoreFromTray()
        {
            // Hiện lại form chính
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();

            // Ẩn icon tray (nếu bạn muốn icon biến mất khi form mở lại)
            notifyIcon1.Visible = false;
        }
        private void menuProduct_Click(object sender, EventArgs e) => OpenChild(new ProductForm(currentRole));
        private void menuEmployee_Click(object sender, EventArgs e) => OpenChild(new EmployeeForm(currentRole));
        private void menuInvoice_Click(object sender, EventArgs e) => OpenChild(new InvoiceForm(currentRole));
        private void menuExit_Click(object sender, EventArgs e) => this.Close();
        private void menuAbout_Click(object sender, EventArgs e) => MessageBox.Show("tdash - Ứng dụng Quản lý Cửa hàng MINI", "Giới thiệu");
        private void menuContact_Click(object sender, EventArgs e) => MessageBox.Show("tuannm@ueh.edu.vn", "Liên hệ");

        private void OpenChild(Form f)
        {
            foreach (Form c in this.MdiChildren) if (c.GetType() == f.GetType()) { c.Activate(); return; }
            f.MdiParent = this; f.Show();
        }

        private void tsbProducts_Click(object sender, EventArgs e) => OpenChild(new ProductForm(currentRole));
        private void tsbEmployees_Click(object sender, EventArgs e) => OpenChild(new EmployeeForm(currentRole));
        private void tsbLogin_Click(object sender, EventArgs e) { var f = new LoginForm(); f.Show(); this.Close(); }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var t = txtSearch.Text.Trim();
                if (this.ActiveMdiChild is ProductForm pf) pf.Search(t);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) { this.Hide(); notifyIcon1.Visible = true; notifyIcon1.ShowBalloonTip(300, "tdash", "Ứng dụng đã ẩn vào khay hệ thống", ToolTipIcon.Info); }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show(); this.WindowState = FormWindowState.Normal; notifyIcon1.Visible = false;
        }

        private void Notify_Open(object sender, EventArgs e) { this.Show(); this.WindowState = FormWindowState.Normal; }
        private void Notify_Exit(object sender, EventArgs e) { notifyIcon1.Visible = false; Application.Exit(); }
        private void menuLogin_Click(object sender, EventArgs e)
        {
            var f = new LoginForm();
            f.Show();
        }
        private void menuLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void thờiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}