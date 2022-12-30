using DiariesFoodApp.Data.Abstract;
using DiariesFoodApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFoodApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(DiariesContext context) : base(context)
        {
          
        }
        public Category GetByIdWithProducts()
        {
            throw new NotImplementedException();
        }
    }
}
