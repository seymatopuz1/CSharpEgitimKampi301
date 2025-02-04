using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;

namespace CSharpEgitimKampi301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        //nesne türetme işlemi
        KampContext context = new KampContext();
        // bir field örneklemesi - private bir değer - sadece okunur
        private readonly DbSet<T> _object;
        // generic repository çağrıldığında _objecte atama yapmak istiyoruz.
        public GenericRepository()
        {
            _object = context.Set<T>();
        }

        public void Delete(T entity)
        {
            //Entity State içerisinden gelen değere göre kendisi silme işlemini yapar.
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
        public List<T> GetAll()
        {
            return _object.ToList();
        }
        public T GetById(int id)
        {
            return _object.Find(id);
        }
        public void Insert(T entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
        public void Update(T entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
