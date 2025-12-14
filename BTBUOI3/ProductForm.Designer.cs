using System.Windows.Forms;

namespace TDashMiniStore
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private SplitContainer splitContainer1;
        private TreeView treeCategories;
        private ListView lvProducts;
        private Button btnImport;
        private Button btnExportSim;
        private Button btnExportRevenue;
        private ProgressBar progressBar1;
        private ContextMenuStrip ctxMenu;
        private ToolStripMenuItem ctxView;
        private ToolStripMenuItem ctxDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("Thực phẩm");
            TreeNode treeNode2 = new TreeNode("Đồ uống");
            TreeNode treeNode3 = new TreeNode("Gia vị");
            TreeNode treeNode4 = new TreeNode("Đồ gia dụng");
            splitContainer1 = new SplitContainer();
            treeCategories = new TreeView();
            lvProducts = new ListView();
            Mã = new ColumnHeader();
            Tên = new ColumnHeader();
            Giá = new ColumnHeader();
            Tồn = new ColumnHeader();
            ctxMenu = new ContextMenuStrip(components);
            ctxView = new ToolStripMenuItem();
            ctxDelete = new ToolStripMenuItem();
            btnImport = new Button();
            btnExportSim = new Button();
            btnExportRevenue = new Button();
            progressBar1 = new ProgressBar();
            panel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ctxMenu.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeCategories);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lvProducts);
            splitContainer1.Size = new Size(900, 600);
            splitContainer1.SplitterDistance = 300;
            splitContainer1.TabIndex = 1;
            // 
            // treeCategories
            // 
            treeCategories.Dock = DockStyle.Fill;
            treeCategories.Location = new Point(0, 0);
            treeCategories.Name = "treeCategories";
            treeNode1.Name = "";
            treeNode1.Text = "Thực phẩm";
            treeNode2.Name = "";
            treeNode2.Text = "Đồ uống";
            treeNode3.Name = "";
            treeNode3.Text = "Gia vị";
            treeNode4.Name = "";
            treeNode4.Text = "Đồ gia dụng";
            treeCategories.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4 });
            treeCategories.Size = new Size(300, 600);
            treeCategories.TabIndex = 0;
            // 
            // lvProducts
            // 
            lvProducts.Columns.AddRange(new ColumnHeader[] { Mã, Tên, Giá, Tồn });
            lvProducts.ContextMenuStrip = ctxMenu;
            lvProducts.Dock = DockStyle.Fill;
            lvProducts.FullRowSelect = true;
            lvProducts.Location = new Point(0, 0);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(596, 600);
            lvProducts.TabIndex = 0;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            // 
            // Mã
            // 
            Mã.Text = "Mã";
            Mã.Width = 100;
            // 
            // Tên
            // 
            Tên.Text = "Tên";
            Tên.Width = 100;
            // 
            // Giá
            // 
            Giá.Text = "Giá";
            Giá.Width = 100;
            // 
            // Tồn
            // 
            Tồn.Text = "Tồn";
            Tồn.Width = 100;
            // 
            // ctxMenu
            // 
            ctxMenu.ImageScalingSize = new Size(20, 20);
            ctxMenu.Items.AddRange(new ToolStripItem[] { ctxView, ctxDelete });
            ctxMenu.Name = "ctxMenu";
            ctxMenu.Size = new Size(173, 52);
            // 
            // ctxView
            // 
            ctxView.Name = "ctxView";
            ctxView.Size = new Size(172, 24);
            ctxView.Text = "Xem chi tiết";
            // 
            // ctxDelete
            // 
            ctxDelete.Name = "ctxDelete";
            ctxDelete.Size = new Size(172, 24);
            ctxDelete.Text = "Xóa sản phẩm";
            // 
            // btnImport
            // 
            btnImport.Location = new Point(3, 3);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(200, 30);
            btnImport.TabIndex = 0;
            btnImport.Text = "Import CSV";
            // 
            // btnExportSim
            // 
            btnExportSim.Location = new Point(3, 39);
            btnExportSim.Name = "btnExportSim";
            btnExportSim.Size = new Size(200, 30);
            btnExportSim.TabIndex = 1;
            btnExportSim.Text = "[Mô phỏng Export]";
            // 
            // btnExportRevenue
            // 
            btnExportRevenue.Location = new Point(3, 75);
            btnExportRevenue.Name = "btnExportRevenue";
            btnExportRevenue.Size = new Size(200, 30);
            btnExportRevenue.TabIndex = 2;
            btnExportRevenue.Text = "Export doanh thu";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(3, 111);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 3;
            // 
            // panel
            // 
            panel.Controls.Add(btnImport);
            panel.Controls.Add(btnExportSim);
            panel.Controls.Add(btnExportRevenue);
            panel.Controls.Add(progressBar1);
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(200, 100);
            panel.TabIndex = 2;
            // 
            // ProductForm
            // 
            ClientSize = new Size(900, 600);
            Controls.Add(splitContainer1);
            Controls.Add(panel);
            Name = "ProductForm";
            Text = "Sản phẩm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ctxMenu.ResumeLayout(false);
            panel.ResumeLayout(false);
            ResumeLayout(false);
        }
        private FlowLayoutPanel panel;
        private ColumnHeader Mã;
        private ColumnHeader Tên;
        private ColumnHeader Giá;
        private ColumnHeader Tồn;
    }
}