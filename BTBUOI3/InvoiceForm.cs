using System;
using System.IO;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace TDashMiniStore
{
    public partial class InvoiceForm : Form
    {
        Invoice current = new Invoice(){ Id = $"INV{DateTime.Now.Ticks}" };
        public InvoiceForm(string role)
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click; btnPrint.Click += BtnPrint_Click; btnSave.Click += BtnSave_Click;
            foreach(var p in DataRepository.Instance.Products)
            {
                var it = new ListViewItem(new[]{ p.Id, p.Name, p.Price.ToString("0.00") }); it.Tag = p; lvProducts.Items.Add(it);
            }
            printDoc.PrintPage += PrintDoc_PrintPage;
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count==0) return;
            var p = lvProducts.SelectedItems[0].Tag as Product; current.Items.Add(p);
            lvInvoice.Items.Add(new ListViewItem(new[]{p.Id,p.Name,p.Price.ToString("0.00")}));
        }

        private void BtnPrint_Click(object? sender, EventArgs e)
        {
            current.Customer = txtCustomer.Text; current.Created = DateTime.Now;
            var pp = new PrintPreviewDialog(){ Document = printDoc, Width = 800, Height = 600 };
            pp.ShowDialog();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            var sfd = new SaveFileDialog(){ Filter = "CSV files|*.csv" };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using(var sw = new StreamWriter(sfd.FileName))
            {
                sw.WriteLine($"Hóa đơn,{current.Id}"); sw.WriteLine($"Khách hàng,{txtCustomer.Text}"); sw.WriteLine("Mã,Tên,Giá");
                foreach(var it in current.Items) sw.WriteLine($"{it.Id},{it.Name},{it.Price}"); sw.WriteLine($",Tổng,{current.Total}");
            }
            MessageBox.Show("Lưu hóa đơn xong.");
        }

        private void PrintDoc_PrintPage(object? sender, PrintPageEventArgs e)
        {
            var g = e.Graphics; int y = 20;
            g.DrawString("HÓA ĐƠN BÁN HÀNG", new System.Drawing.Font("Arial",14,System.Drawing.FontStyle.Bold), 
                System.Drawing.Brushes.Black, 200, y); 
            y+=30;
            g.DrawString($"Khách hàng: {current.Customer}",
                new System.Drawing.Font("Arial",10), System.Drawing.Brushes.Black, 10, y); 
            y+=20;
            g.DrawString($"Ngày: {current.Created}", new System.Drawing.Font("Arial",10), System.Drawing.Brushes.Black, 10, y); 
            y+=30;
            g.DrawString("Mã",new System.Drawing.Font("Arial",10, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Black,10,y); g.DrawString("Tên",new System.Drawing.Font("Arial",10, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Black,80,y); g.DrawString("Giá",new System.Drawing.Font("Arial",10, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Black,380,y); y+=20;
            foreach(var it in current.Items) { g.DrawString(it.Id,new System.Drawing.Font("Arial",10), System.Drawing.Brushes.Black,10,y); g.DrawString(it.Name,new System.Drawing.Font("Arial",10), System.Drawing.Brushes.Black,80,y); g.DrawString(it.Price.ToString("0.00"),new System.Drawing.Font("Arial",10), System.Drawing.Brushes.Black,380,y); y+=20; }
            y+=10; g.DrawString($"Tổng: {current.Total:0.00}", new System.Drawing.Font("Arial",12, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Black, 300, y);
        }

        private PrintDocument printDoc = new PrintDocument();
    }
}