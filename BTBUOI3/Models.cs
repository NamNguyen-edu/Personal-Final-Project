using System;
using System.Collections.Generic;
using System.Linq;

namespace TDashMiniStore
{
    public class Product { public string Id {get; set;} = ""; public string Name {get; set;} = ""; public decimal Price {get; set;} public int Stock {get; set;} public string Category {get; set;} = ""; }
    public class Employee { public string Id {get; set;} = ""; public string Name {get; set;} = ""; public string Role {get; set;} = ""; }
    public class Invoice { public string Id {get; set;} = ""; public string Customer {get; set;} = ""; public List<Product> Items {get; set;} = new(); public DateTime Created {get; set;} = DateTime.Now; public decimal Total => Items.Sum(i=>i.Price); }
}