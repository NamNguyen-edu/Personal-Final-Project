using System.Windows.Forms;

namespace TDashMiniStore
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListView lvEmployees;
        private Button btnAdd, btnEdit, btnDel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lvEmployees = new ListView();
            this.btnAdd = new Button(); this.btnEdit = new Button(); this.btnDel = new Button();
            this.lvEmployees.Dock = DockStyle.Fill;
            this.lvEmployees.View = View.Details; this.lvEmployees.FullRowSelect = true;
            this.lvEmployees.Columns.AddRange(new ColumnHeader[]{ 
                new ColumnHeader(){Text="Mã",Width=100}, 
                new ColumnHeader(){Text="Tên",Width=300}, 
                new ColumnHeader(){Text="Quyền",Width=150} });
            var panel = new FlowLayoutPanel(){ Dock = DockStyle.Top, Height = 44 };
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnDel.Text = "Xóa";
            this.btnDel.Size = new System.Drawing.Size(100, 30);
            panel.Controls.AddRange(new Control[]{ this.btnAdd, this.btnEdit, this.btnDel });
            this.Controls.Add(this.lvEmployees); this.Controls.Add(panel);
            this.Text = "Nhân viên"; this.ClientSize = new System.Drawing.Size(700,500);
        }
    }
}