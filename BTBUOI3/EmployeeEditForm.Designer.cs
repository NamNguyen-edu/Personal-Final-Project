using System.Windows.Forms;

namespace TDashMiniStore
{
    partial class EmployeeEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtId, txtName; private ComboBox cbRole; private Button btnOk;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtId = new TextBox();
            txtName = new TextBox();
            cbRole = new ComboBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 27);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 3;
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.Items.AddRange(new object[] { "Admin", "User" });
            cbRole.Location = new Point(100, 100);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(200, 28);
            cbRole.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(100, 140);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 26);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.Click += btnOk_Click;
            // 
            // EmployeeEditForm
            // 
            ClientSize = new Size(340, 200);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(cbRole);
            Controls.Add(btnOk);
            Name = "EmployeeEditForm";
            Text = "Thông tin nhân viên";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}