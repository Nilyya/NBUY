using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFoodApp.Data.Abstract
{
    public interface ICategoryRepository: IRepository<Category>
    {
        Category GetByIdWithProducts();
    }
}
