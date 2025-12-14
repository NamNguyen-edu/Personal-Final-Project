using System;
using System.Collections.Generic;
using System.Linq;

namespace TDashMiniStore
{
    public class DataRepository
    {
        public List<Product> Products { get; set; } = new();
        public List<Employee> Employees { get; set; } = new();
        public List<Invoice> Invoices { get; set; } = new();
        public static DataRepository Instance { get; } = new DataRepository();

        public void Seed()
        {
            if (Products.Count>0) return;
            Products.AddRange(new[]{
                new Product(){Id="P001",Name="Banh mi",Price=1.5m,Stock=50,Category="Thực phẩm"},
                new Product(){Id="P002",Name="Ca phe",Price=3.0m,Stock=30,Category="Đồ uống"},
                new Product(){Id="P003",Name="Nuoc mam",Price=2.0m,Stock=20,Category="Gia vị"},
                new Product(){Id="P004",Name="Xo nuoc",Price=5.0m,Stock=10,Category="Đồ gia dụng"},
            });
            Employees.AddRange(new[]{
                new Employee(){Id="E001",Name="Admin",Role="Admin"},
                new Employee(){Id="E002",Name="User",Role="User"},
            });
        }
    }
}