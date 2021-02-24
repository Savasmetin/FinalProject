using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Coree.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
        
    }
}
