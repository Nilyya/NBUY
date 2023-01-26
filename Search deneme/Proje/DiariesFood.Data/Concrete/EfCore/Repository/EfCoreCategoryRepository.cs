using DiariesFood.Data.Abstract;
using DiariesFood.Data.Concrete.EfCore.Contexts;
using DiariesFood.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFood.Data.Concrete.EfCore.Repository
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(DiariesFoodContext context) : base(context)
        {

        }
        public Category GetByIdWithFoods()
        {
            throw new NotImplementedException();
        }
    }
}
