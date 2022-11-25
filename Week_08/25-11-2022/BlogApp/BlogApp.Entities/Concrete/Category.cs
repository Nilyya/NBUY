using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Concrete
{
    public class Category :EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Article> Articles { get; set; }
        //List, arraylist, Array, IList, ICollection yapılarının miras alma özeliğini İnceleyiniz(Microsoftan)
    }
}
