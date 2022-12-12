using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);//id ye göre entity getirecek
        Task<List<T>> GetAllAsync();// entity ilgili tüm kayıtları getirecek
        Task CreateAsync(T entity);//yeni kayıt yaratılacak
        void Update(T entity);//Kayıt güncelenecek
        void Delete(T entity);//Kayıt silinecek


    }
}
