using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(ShopAppContext context): base(context)
        {
            //buraya gelen context base classa gönderiyorilyor ve ynı zamanda sadece bu consturactor içinde geçerli.Ama bu classın bütünü henüz kullanıllamıyor.eğer kullanılsın istiyor istersek yapmamız gereken işlemler var.
        }
        public Category GetByIdWithProducts()
        {
            throw new NotImplementedException();
        }
    }
}
