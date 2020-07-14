using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService:IBaseService<Category>
    {
        List<Category> GetActiveCategories();
    }
}
