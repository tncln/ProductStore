using StoreProduct.Business.Abstract;
using StoreProduct.DataAccess.Abstract;
using StoreProduct.DataAccess.Concrete.EntitiyFramework;
using StoreProduct.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProduct.Business.Manager
{
    public class ProductManager : IProductManager
    {
        IProductDal _productDal;
        public ProductManager()
        {
            _productDal = new EfProductDal();
        }
        public ResultMessage Add(Product entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            if (entity.Name.Length == 0)
            {
                result.Message = "Ürün Adı Belirtmelisiniz";
                return result;
            }
            if (entity.Name.Length == 50)
            {
                result.Message = "Ürün Adı için fazla karakter girdiniz.";
                return result;
            }

            var _existingProduct = GetAll().Where(i=>i.Name==entity.Name).FirstOrDefault();
            if (_existingProduct!=null)
            {
                result.Message = "Bu ürün ismiyle aynı isim zaten mevcut, Lütfen başka bir isim seçiniz.";
                return result;
            }

            try
            {
                _productDal.Add(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = "Bir Hata Oluştu";
                return result;
            }
            return result;
        }

        public ResultMessage Delete(Product entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            
            try
            {
                _productDal.Delete(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = "Bir Hata Oluştu";
                return result;
            }
            return result;
        }

        public Product Get(int id)
        {
            return _productDal.Get(id);
        }

        public IQueryable<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public ResultMessage Update(Product entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            if (entity.Name.Length == 0)
            {
                result.Message = "Ürün Adı Belirtmelisiniz";
                return result;
            }
            if (entity.Name.Length == 50)
            {
                result.Message = "Ürün Adı için fazla karakter girdiniz.";
                return result;
            }
            try
            {
                _productDal.Update(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = "Bir Hata Oluştu";
                return result;
            }
            return result;
        }
    }
}
