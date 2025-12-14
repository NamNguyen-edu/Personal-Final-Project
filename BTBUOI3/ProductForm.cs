using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDashMiniStore
{
    public partial class ProductForm : Form
    {
        public ProductForm(string role)
        {
            InitializeComponent();
            this.role = role;
            ApplyRole();
            LoadAllProducts();
            treeCategories.AfterSelect += TreeCategories_AfterSelect;
            lvProducts.DoubleClick += (s, e) => ViewDetail();
            ctxDelete.Click += (s, e) => DeleteProduct();
            ctxView.Click += (s, e) => ViewDetail();
            btnImport.Click += BtnImport_Click;
            btnExportSim.Click += BtnExportSim_Click;
            btnExportRevenue.Click += BtnExportRevenue_Click;
        }

        string role;
        private void ApplyRole()
        {
            bool isAdmin = role == "Admin";
            btnImport.Enabled = isAdmin;
            btnExportSim.Enabled = isAdmin;
            ctxDelete.Enabled = isAdmin;
        }

        private void LoadAllProducts()
        {
            PopulateList(DataRepository.Instance.Products);
        }

        private void TreeCategories_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;
            var cat = e.Node.Text;
            var list = DataRepository.Instance.Products.Where(p => p.Category == cat).ToList();
            PopulateList(list);
        }

        private void PopulateList(System.Collections.Generic.List<Product> list)
        {
            lvProducts.Items.Clear();
            foreach (var p in list)
            {
                var it = new ListViewItem(new[] { p.Id, p.Name, p.Price.ToString("0.00"), p.Stock.ToString() });
                it.Tag = p; lvProducts.Items.Add(it);
            }
        }
        public void Search(string term)
        {
            if (string.IsNullOrWhiteSpace(term)) { LoadAllProducts(); return; }
            term = term.ToLower();
            var list = DataRepository.Instance.Products
                .Where(p => p.Name.ToLower().Contains(term) || p.Id.ToLower().Contains(term))
                .ToList();
            PopulateList(list);
            MessageBox.Show($"Tìm thấy {list.Count} sản phẩm phù hợp.", "Kết quả tìm kiếm");
        }

        private void ViewDetail()
        {
            if (lvProducts.SelectedItems.Count == 0) return;
            var p = lvProducts.SelectedItems[0].Tag as Product;
            MessageBox.Show($"Mã: {p.Id}\nTên: {p.Name}\nGiá: {p.Price}\nTồn kho: {p.Stock}\nDanh mục: {p.Category}", "Chi tiết");
        }

        private void DeleteProduct()
        {
            if (lvProducts.SelectedItems.Count == 0) return;
            var p = lvProducts.SelectedItems[0].Tag as Product;
            if (MessageBox.Show($"Bạn có chắc muốn xóa {p.Name}?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataRepository.Instance.Products.Remove(p);
                LoadAllProducts();
            }
        }

        private void BtnImport_Click(object? sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "CSV files|*.csv|All files|*.*" };
            if (ofd.ShowDialog() != DialogResult.OK) return;
            try
            {
                var lines = File.ReadAllLines(ofd.FileName);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length < 4) continue;
                    DataRepository.Instance.Products.Add(new Product() { Id = parts[0], Name = parts[1], Price = decimal.Parse(parts[2]), Stock = int.Parse(parts[3]), Category = parts.Length > 4 ? parts[4] : "Thực phẩm" });
                }
                MessageBox.Show("Import xong.");
                LoadAllProducts();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi khi import: " + ex.Message); }
        }

        private async void BtnExportSim_Click(object? sender, EventArgs e)
        {
            progressBar1.Visible = true; progressBar1.Value = 0;
            var items = lvProducts.Items.Cast<ListViewItem>().ToList();
            int total = items.Count;
            if (total == 0) { progressBar1.Visible = false; return; }
            for (int i = 0; i < total; i++)
            {
                await Task.Delay(1000);
                progressBar1.Value = (int)((i + 1) * 100.0 / total);
            }
            MessageBox.Show("Mô phỏng Export hoàn tất.");
            progressBar1.Visible = false;
        }

        private void BtnExportRevenue_Click(object? sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "CSV files|*.csv" };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            try
            {
                var rng = new Random();
                using (var sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine("Mã,Tên,Đã bán,Doanh thu");
                    foreach (var p in DataRepository.Instance.Products)
                    {
                        int sold = rng.Next(0, 10);
                        sw.WriteLine($"{p.Id},{p.Name},{sold},{(p.Price * sold):0.00}");
                    }
                }
                MessageBox.Show("Export doanh thu xong.");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

    }
}