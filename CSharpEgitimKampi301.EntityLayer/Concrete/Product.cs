using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        //Her ürünün bir kategorisi olacağı için bir CategoryId eklendi
        public int CategoryId { get; set; }

        // virtual artık Asp.Nette kullanılmıyor ama kullanıcaz
        public virtual Category Category { get; set; }

        public List<Order> Orders { get; set; }

    }
}
