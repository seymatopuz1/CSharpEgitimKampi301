using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampi301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    public class KampContext : DbContext
    {
        // Db context sınıfı bir tane property alıyor 
        // Bizim veri tabanına yansıyacak sınıflarımız KampContextin içerisinde yer alacak.
        
        //<Category> C# tarafında kullanılıcak olduğumuz sınıfımızın ismi
        //Categories ise Sql'e yansıyacak olan tablomuz olacak
        // Yalın hali class olsun çoğul hali tablo olsun amacımız bu 
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
