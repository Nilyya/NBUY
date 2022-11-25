using Abp.Domain.Entities;
using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Concrete
{
    public class Comment : EntityBase, IEntity
{
        public string Text{ get; set; }   
        public string Article { get; set; }
        public int ArticleId { get; set; }

    }
}
