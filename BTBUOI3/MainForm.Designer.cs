using System;
using System.Drawing;
using System.Windows.Forms;

namespace TDashMiniStore
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel slUser;
        private ToolStripStatusLabel slForm;
        private ToolStripStatusLabel slTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private ToolStripTextBox txtSearch;
        private ToolStripButton tsbProducts;
        private ToolStripButton tsbEmployees;
        private ToolStripButton tsbLogin;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem menuLogin;
        private ToolStripMenuItem menuLogout;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem menuEmployee;
        private ToolStripMenuItem menuProduct;
        private ToolStripMenuItem menuInvoice;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem menuAbout;
        private ToolStripMenuItem menuContact;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            menuLogin = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            menuEmployee = new ToolStripMenuItem();
            menuProduct = new ToolStripMenuItem();
            menuInvoice = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            menuAbout = new ToolStripMenuItem();
            menuContact = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbLogin = new ToolStripButton();
            tsbProducts = new ToolStripButton();
            tsbEmployees = new ToolStripButton();
            txtSearch = new ToolStripTextBox();
            statusStrip1 = new StatusStrip();
            slUser = new ToolStripStatusLabel();
            slForm = new ToolStripStatusLabel();
            slTime = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            ctx = new ContextMenuStrip(components);
            thờiTiếtToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, trợGiúpToolStripMenuItem, thờiTiếtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 28);
            menuStrip1.TabIndex = 2;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuLogin, menuLogout, menuExit });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // menuLogin
            // 
            menuLogin.Name = "menuLogin";
            menuLogin.Size = new Size(224, 26);
            menuLogin.Text = "Đăng nhập";
            menuLogin.Click += menuLogin_Click;
            // 
            // menuLogout
            // 
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(224, 26);
            menuLogout.Text = "Đăng xuất";
            menuLogout.Click += menuLogout_Click;
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(224, 26);
            menuExit.Text = "Thoát";
            menuExit.Click += menuExit_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuEmployee, menuProduct, menuInvoice });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(73, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // menuEmployee
            // 
            menuEmployee.Name = "menuEmployee";
            menuEmployee.Size = new Size(224, 26);
            menuEmployee.Text = "Nhân viên";
            menuEmployee.Click += menuEmployee_Click;
            // 
            // menuProduct
            // 
            menuProduct.Name = "menuProduct";
            menuProduct.Size = new Size(224, 26);
            menuProduct.Text = "Sản phẩm";
            menuProduct.Click += menuProduct_Click;
            // 
            // menuInvoice
            // 
            menuInvoice.Name = "menuInvoice";
            menuInvoice.Size = new Size(224, 26);
            menuInvoice.Text = "Hóa đơn";
            menuInvoice.Click += menuInvoice_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuAbout, menuContact });
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(78, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // menuAbout
            // 
            menuAbout.Name = "menuAbout";
            menuAbout.Size = new Size(224, 26);
            menuAbout.Text = "Giới thiệu";
            menuAbout.Click += menuAbout_Click;
            // 
            // menuContact
            // 
            menuContact.Name = "menuContact";
            menuContact.Size = new Size(224, 26);
            menuContact.Text = "Liên hệ";
            menuContact.Click += menuContact_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbLogin, tsbProducts, tsbEmployees, txtSearch });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1000, 27);
            toolStrip1.TabIndex = 1;
            // 
            // tsbLogin
            // 
            tsbLogin.Name = "tsbLogin";
            tsbLogin.Size = new Size(50, 24);
            tsbLogin.Text = "Login";
            tsbLogin.Click += tsbLogin_Click;
            // 
            // tsbProducts
            // 
            tsbProducts.Name = "tsbProducts";
            tsbProducts.Size = new Size(79, 24);
            tsbProducts.Text = "Sản phẩm";
            tsbProducts.Click += tsbProducts_Click;
            // 
            // tsbEmployees
            // 
            tsbEmployees.Name = "tsbEmployees";
            tsbEmployees.Size = new Size(79, 24);
            tsbEmployees.Text = "Nhân viên";
            tsbEmployees.Click += tsbEmployees_Click;
            // 
            // txtSearch
            // 
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 27);
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { slUser, slForm, slTime });
            statusStrip1.Location = new Point(0, 678);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1000, 22);
            statusStrip1.TabIndex = 3;
            // 
            // slUser
            // 
            slUser.Name = "slUser";
            slUser.Size = new Size(0, 16);
            // 
            // slForm
            // 
            slForm.Name = "slForm";
            slForm.Size = new Size(0, 16);
            // 
            // slTime
            // 
            slTime.Name = "slTime";
            slTime.Size = new Size(0, 16);
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = ctx;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "tdash";
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            // 
            // ctx
            // 
            ctx.ImageScalingSize = new Size(20, 20);
            ctx.Name = "ctx";
            ctx.Size = new Size(61, 4);
            // 
            // thờiTiếtToolStripMenuItem
            // 
            thờiTiếtToolStripMenuItem.Name = "thờiTiếtToolStripMenuItem";
            thờiTiếtToolStripMenuItem.Size = new Size(78, 24);
            thờiTiếtToolStripMenuItem.Text = "Thời tiết";
            thờiTiếtToolStripMenuItem.Click += thờiTiếtToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            BackgroundImage = tdash_app.Properties.Resources.Logo;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1000, 700);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "tdash - Quản lý cửa hàng MINI";
            Resize += MainForm_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Cập nhật thời gian lên tiêu đề Form mỗi giây
            this.Text = "TDASH Mini Store - " + DateTime.Now.ToString("HH:mm:ss");
        }
        private ContextMenuStrip ctx;
        private ToolStripMenuItem thờiTiếtToolStripMenuItem;
    }
}