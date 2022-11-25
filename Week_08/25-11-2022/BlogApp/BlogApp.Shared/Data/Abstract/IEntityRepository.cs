using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[]inculudeProperties);
        //not-1 not-2

        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null, params Expression<Func<T, object>>[] inculudeProperties);
        //not-3
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
    }
}
/*
 * Not-1
 * Örneğin Id si 12 olan article'ı getirmek istiyoruz
 * var article =repository.GetAsync(x=>x.Id==12);
 *User user=repositoryUser.GetAsync(x=>x.Name=="enginniyazi") 
 *Not-2
 *Örneğin Id si 12 olan article'ı User ve Comment'leri ile birlikte getirmek istiyoruz.
 *Article article=repositoryArticle.GetAsync(x=>x.Id==12, y=>y.User, y=>y.Comments, z=>z.Role)
 *not-3
 *Örneğin tüm Article'ları listelemek istiyoruz
 *var articles=repositoryArticle.GetAllAsync();
 *Örneğin Dotnet Category'sindeki tüm article'ları listelemek istiyoruz
 *var articles=repositoryArticle.GetAllAsync(a=>a.Category.Name=="Dotnet",c=>c.Category)
 *Örneğin ıd'si 12 olan article'ın yorumlarını getirmek istiyoruz
 *var comments=repositoryComment.GetAllAsync(c=>c.Article.Id==12)
 */