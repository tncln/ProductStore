using StoreProduct.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProduct.DataAccess.Concrete.EntitiyFramework
{
    public class EfGenericDal<T> : IGenericDal<T> where T : class
    {
        private StoreContext context = new StoreContext();
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
          return  context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
