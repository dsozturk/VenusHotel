using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.Context;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EFCategoryDal:EFEntityRepositoryBase<Category,ApplicationDbContext>
    {
    }
}
