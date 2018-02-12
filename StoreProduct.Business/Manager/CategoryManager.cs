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
    public class CategoryManager : ICategoryManager
    {
        ICategoryDal _categoryDal;
        public CategoryManager()
        {
            //Dependecy injection
            _categoryDal = new EfCategoryDal();
        }
        public ResultMessage Add(Category entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            if (entity.Name.Length == 0)
            {
                result.Message = "Kategori Adı Belirtmelisiniz";
                return result;
            }
            if (entity.Name.Length == 50)
            {
                result.Message = "Kategori Adı için fazla karakter girdiniz.";
                return result;
            }
            try
            {
                _categoryDal.Add(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = "Bir Hata Oluştu";
                return result;
            }
            return result;
        }

        public ResultMessage Delete(Category entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

          
            try
            {
                _categoryDal.Delete(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = "Bir Hata Oluştu";
                return result;
            }
            return result;
        }

        public Category Get(int id)
        {
            return _categoryDal.Get(id);
        }

        public IQueryable<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public ResultMessage Update(Category entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            if (entity.Name.Length == 0)
            {
                result.Message = "Kategori Adı Belirtmelisiniz";
                return result;
            }
            if (entity.Name.Length == 50)
            {
                result.Message = "Kategori Adı için fazla karakter girdiniz.";
                return result;
            }
            try
            {
                _categoryDal.Update(entity);
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
