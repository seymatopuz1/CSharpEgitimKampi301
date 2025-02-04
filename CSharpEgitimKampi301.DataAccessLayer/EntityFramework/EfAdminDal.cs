using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>,IAdminDal
    {
    }
}
/*
 Entitye özgü olmayan metotlar
 
 Ekle,Sil,Güncelle,Listele ve Id'ye Göre Getir
 // İçinde a harfi geçmeyen kullanıcıları listele
 */
