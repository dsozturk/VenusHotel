using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public List<Category> GetActiveCategories()
        {
            return _categoryDal.GetList(i => i.IsDeleted == false);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(i=>i.Id==id);
        }

        public void HardDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public void SoftDelete(Category entity)
        {
            entity.IsDeleted = true;
            entity.DeletedDate = DateTime.Now;
            _categoryDal.Update(entity);
            
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
