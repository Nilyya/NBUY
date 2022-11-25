using BlogApp.Shared.Data.Abstract;
using BlogApp.Shared.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Data.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class,
        IEntity, 
        new()//T nin kısıtları class olmalı IEntity olmalı bunu yazmazsak program çalışır ama hata yapmamak için kendimize koyduğumuz kurallar
    {
        private readonly DbContext _context;//Bu komutu yaz ctrl+. ile gen yap

        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
           return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().CountAsync(predicate);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });
        }
        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Update(entity); });
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] inculudeProperties)//Dizi tipinde
        {
            IQueryable<TEntity> query=_context.Set<TEntity>();//Burada cntext erişip o entity alıyoruz Iqueryable ibinde alıyoruz ki sonra bunun arkasına where inlcude gibi yapıları
            if(predicate!=null)//predicate boş değil ise where ve query ekliyorum
            {
                query= query.Where(predicate);
            }
            if(inculudeProperties.Any())//Eğer boş değil ise her dizi içinde dönerek her elemenı query'e ekliyoruz
            {
                foreach(var includeProperty in inculudeProperties)
                {
                    query=query.Include(includeProperty);
                }
            }
            return await query.ToListAsync();//Liste döndürür query'i 
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] inculudeProperties)
        {
            IQueryable<TEntity> query= _context.Set<TEntity>().Where(predicate);
            if(inculudeProperties.Any())
            {
                foreach (var includeProperty in inculudeProperties)
                {
                    query=query.Include(includeProperty);
                }
            }


            return await query.FirstOrDefaultAsync() ;//Kayıtların içinden birincisini getirir.
            //return await query.SingleOrDefaultAsync();//Sadece tek bir tane ise döndürme

        }

      
    }
}
