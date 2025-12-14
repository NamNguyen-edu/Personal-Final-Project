using System;
using System.Windows.Forms;

namespace TDashMiniStore
{
    public partial class EmployeeForm : Form
    {
        string role;
        public EmployeeForm(string role)
        {
            InitializeComponent();
            this.role = role;
            ApplyRole();
            LoadEmployees();
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDel.Click += BtnDel_Click;
        }

        private void ApplyRole() { bool isAdmin = role=="Admin"; btnAdd.Enabled = isAdmin; btnEdit.Enabled = isAdmin; btnDel.Enabled = isAdmin; }

        private void LoadEmployees()
        {
            lvEmployees.Items.Clear();
            foreach(var e in DataRepository.Instance.Employees)
            {
                var it = new ListViewItem(new[]{ e.Id, e.Name, e.Role }); it.Tag = e; lvEmployees.Items.Add(it);
            }
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            var f = new EmployeeEditForm(); if (f.ShowDialog() == DialogResult.OK) { DataRepository.Instance.Employees.Add(f.Employee); LoadEmployees(); }
        }
        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            if (lvEmployees.SelectedItems.Count==0) return; var emp = lvEmployees.SelectedItems[0].Tag as Employee;
            var f = new EmployeeEditForm(emp); if (f.ShowDialog()==DialogResult.OK) { emp.Name = f.Employee.Name; emp.Role = f.Employee.Role; LoadEmployees(); }
        }
        private void BtnDel_Click(object? sender, EventArgs e)
        {
            if (lvEmployees.SelectedItems.Count==0) return; var emp = lvEmployees.SelectedItems[0].Tag as Employee;
            if (MessageBox.Show($"Xóa {emp.Name}?","Xóa",MessageBoxButtons.YesNo)==DialogResult.Yes) { DataRepository.Instance.Employees.Remove(emp); LoadEmployees(); }
        }
    }
}