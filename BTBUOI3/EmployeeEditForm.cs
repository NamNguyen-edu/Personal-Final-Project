using System;
using System.Windows.Forms;

namespace TDashMiniStore
{
    public partial class EmployeeEditForm : Form
    {
        public Employee Employee { get; private set; }
        public EmployeeEditForm() { InitializeComponent(); }
        public EmployeeEditForm(Employee e) { InitializeComponent(); txtId.Text = e.Id; txtName.Text = e.Name; cbRole.SelectedItem = e.Role; }
        private void btnOk_Click(object? sender, EventArgs e) { Employee = new Employee(){ Id = txtId.Text, Name = txtName.Text, Role = cbRole.SelectedItem?.ToString() ?? "User" }; this.DialogResult = DialogResult.OK; this.Close(); }
    }
}