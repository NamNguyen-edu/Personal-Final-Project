using System.Windows.Forms;
using System.Drawing.Printing;

namespace TDashMiniStore
{
    partial class InvoiceForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListView lvProducts;
        private Button btnAdd;
        private TextBox txtCustomer;
        private ListView lvInvoice;
        private Button btnPrint, btnSave;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lvProducts = new ListView(); this.btnAdd = new Button(); this.txtCustomer = new TextBox(); this.lvInvoice = new ListView(); this.btnPrint = new Button(); this.btnSave = new Button();
            this.lvProducts.Dock = DockStyle.Left; this.lvProducts.Width = 400;
            this.lvProducts.View = View.Details; this.lvProducts.FullRowSelect = true; this.lvProducts.Columns.AddRange(new ColumnHeader[]{ new ColumnHeader(){Text="Mã",Width=80}, new ColumnHeader(){Text="Tên",Width=220}, new ColumnHeader(){Text="Giá",Width=80} });
            var panelTop = new FlowLayoutPanel(){ Dock = DockStyle.Top, Height = 44 }; panelTop.Controls.Add(new Label(){ Text="Khách hàng:", AutoSize=true}); panelTop.Controls.Add(this.txtCustomer); this.btnAdd.Text = "Thêm vào hóa đơn"; panelTop.Controls.Add(this.btnAdd);
            this.lvInvoice.Dock = DockStyle.Fill; this.lvInvoice.View = View.Details; 
            this.lvInvoice.Columns.AddRange(new ColumnHeader[]{ new ColumnHeader(){Text="Mã",Width=80}, new ColumnHeader(){Text="Tên",Width=220}, new ColumnHeader(){Text="Giá",Width=80} });
            var panelBottom = new FlowLayoutPanel(){ Dock = DockStyle.Bottom, Height = 44 }; 
            this.btnPrint.Text = "In hóa đơn";
            this.btnPrint.Size = new System.Drawing.Size(200, 50);
            this.btnSave.Text = "Lưu CSV";
            this.btnSave.Size = new System.Drawing.Size(200, 50);
            panelBottom.Controls.AddRange(new Control[]{ this.btnPrint, this.btnSave });
            var rightPanel = new Panel(){ Dock = DockStyle.Fill }; rightPanel.Controls.Add(this.lvInvoice); rightPanel.Controls.Add(panelBottom); rightPanel.Controls.Add(panelTop);
            this.Controls.Add(rightPanel); this.Controls.Add(this.lvProducts);
            this.Text = "Hóa đơn"; this.ClientSize = new System.Drawing.Size(900,600);
        }
    }
}