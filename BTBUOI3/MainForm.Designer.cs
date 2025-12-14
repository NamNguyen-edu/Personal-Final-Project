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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new MenuStrip();
            this.toolStrip1 = new ToolStrip();
            this.statusStrip1 = new StatusStrip();
            this.slUser = new ToolStripStatusLabel();
            this.slForm = new ToolStripStatusLabel();
            this.slTime = new ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer();
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.notifyIcon1 = new NotifyIcon(this.components);
            // Menu items
            this.hệThốngToolStripMenuItem = new ToolStripMenuItem("Hệ thống");
            this.menuLogin = new ToolStripMenuItem("Đăng nhập");
            this.menuLogout = new ToolStripMenuItem("Đăng xuất");
            this.menuExit = new ToolStripMenuItem("Thoát");
            this.quảnLýToolStripMenuItem = new ToolStripMenuItem("Quản lý");
            this.menuEmployee = new ToolStripMenuItem("Nhân viên");
            this.menuProduct = new ToolStripMenuItem("Sản phẩm");
            this.menuInvoice = new ToolStripMenuItem("Hóa đơn");
            this.trợGiúpToolStripMenuItem = new ToolStripMenuItem("Trợ giúp");
            this.menuAbout = new ToolStripMenuItem("Giới thiệu");
            this.menuContact = new ToolStripMenuItem("Liên hệ");

            // ToolStrip items
            this.tsbLogin = new ToolStripButton();
            this.tsbProducts = new ToolStripButton();
            this.tsbEmployees = new ToolStripButton();
            this.txtSearch = new ToolStripTextBox();

            // MenuStrip
            this.menuStrip1.Items.AddRange(new ToolStripItem[]{ this.hệThốngToolStripMenuItem, this.quảnLýToolStripMenuItem, this.trợGiúpToolStripMenuItem });
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]{ this.menuLogin, this.menuLogout, new ToolStripSeparator(), this.menuExit });
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]{ this.menuEmployee, this.menuProduct, this.menuInvoice });
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]{ this.menuAbout, this.menuContact });

            // Assign Clicks
            this.menuLogin.Click += (s,e)=> { var f=new LoginForm(); f.Show(); };
            this.menuLogout.Click += (s,e)=> Application.Restart();
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            this.menuEmployee.Click += new System.EventHandler(this.menuEmployee_Click);
            this.menuProduct.Click += new System.EventHandler(this.menuProduct_Click);
            this.menuInvoice.Click += new System.EventHandler(this.menuInvoice_Click);
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            this.menuContact.Click += new System.EventHandler(this.menuContact_Click);

            // ToolStrip
            this.tsbLogin.Text = "Login"; this.tsbLogin.Click += new System.EventHandler(this.tsbLogin_Click);
            this.tsbProducts.Text = "Sản phẩm"; this.tsbProducts.Click += new System.EventHandler(this.tsbProducts_Click);
            this.tsbEmployees.Text = "Nhân viên"; this.tsbEmployees.Click += new System.EventHandler(this.tsbEmployees_Click);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);

            this.toolStrip1.Items.AddRange(new ToolStripItem[]{ this.tsbLogin, this.tsbProducts, this.tsbEmployees, new ToolStripSeparator(), new ToolStripLabel("Tìm:"), this.txtSearch });

            // StatusStrip
            this.statusStrip1.Items.AddRange(new ToolStripItem[]{ this.slUser, new ToolStripSeparator(), this.slForm, new ToolStripStatusLabel(){Spring=true}, this.slTime });

            // NotifyIcon
            this.notifyIcon1.Text = "tdash";
            this.notifyIcon1.Icon = SystemIcons.Application;
            this.notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            var ctx = new ContextMenuStrip();
            ctx.Items.Add("Mở", null, new System.EventHandler(this.Notify_Open));
            ctx.Items.Add("Thoát", null, new System.EventHandler(this.Notify_Exit));
            this.notifyIcon1.ContextMenuStrip = ctx;

            // Form
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.menuStrip1.Dock = DockStyle.Top;
            this.toolStrip1.Dock = DockStyle.Top;
            this.statusStrip1.Dock = DockStyle.Bottom;
            this.Text = "tdash - Quản lý cửa hàng MINI";
            this.Resize += MainForm_Resize;
            this.ClientSize = new System.Drawing.Size(1000, 700);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Cập nhật thời gian lên tiêu đề Form mỗi giây
            this.Text = "TDASH Mini Store - " + DateTime.Now.ToString("HH:mm:ss");
        }
    }
}