using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        // Sadece oluşucak olan kategori tablosuna ait değerleri tutacak.
        //CategoryId , CategoryDurumu
        // Code first yaklaşımı:C# daki sınıfları alıyor Sqlde birer tabloya,propetyleri alıyor birer sütuna
        // Code first yaklaşımında değerler property olarak gönderilmek zorunda 
        //int x; //field
        //public int MyProperty { get; set; } // property
        //void test()
        //{
        //    int z;   // variable
        //}


        // Id nin birincil karakter olduğunu bildirmek adına Sınıfın ismi birebir aynı yazılmalı sonun Id getirilmeli
        public int CategoryId { get; set; }


        // get ile aynı kategori adlarının baş harfleri büyük gelmesini sağlayabiliriz
        // set ise mesela adı 5 den küçükse kullanıcıya bir uyarı verip default olarak bir kategori adı verebiliriz
        public string CategoryName { get; set; }

        public bool CategoryStatus { get; set; }

        // Producta erişebilmek için 
        public List<Product> Products { get; set; }



    }
}

/*
 Field -Variable-Property

int x; -->Direkt olarak sınıfın içine tanımlanırsa ===> Field

Eğer ki o değişken yapısı sonuna get , set gibi değer alırsa ===> Propert olur 

Eğer ki bir değişken metot içinde tanımlanıyorsa variable olur 
  
 
 */