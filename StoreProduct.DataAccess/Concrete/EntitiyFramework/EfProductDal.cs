using StoreProduct.DataAccess.Abstract;
using StoreProduct.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProduct.DataAccess.Concrete.EntitiyFramework
{
    public class EfProductDal : EfGenericDal<Product>, IProductDal
    {
        public List<Product> Get5TopProduct()
        {
            throw new NotImplementedException();
        }
    }
}
