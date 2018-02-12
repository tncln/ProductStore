using StoreProduct.DataAccess.Abstract;
using StoreProduct.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProduct.DataAccess.Concrete.EntitiyFramework
{
    public class EfOrderDal:EfGenericDal<Order>,IOrderDal
    {
    }
}
