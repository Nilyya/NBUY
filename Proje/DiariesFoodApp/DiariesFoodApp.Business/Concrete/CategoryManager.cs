using DiariesFoodApp.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFoodApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task CreateAsync(Category category)
        {
            await _unitOfWork.Categories.CreateAsync(category);
            await _unitOfWork.SaveAsync();
        }

        public void Delete(Category category)
        {
            _unitOfWork.Categories.Delete(category);
            _unitOfWork.Save();
        }

        public Task<List<Category>> GetAllAsync()
        {
            return await _unitOfWork.Categories.GetAllAsync();
        }

        public Task<Category> GetByIdAsync(int id)
        {
            return await _unitOfWork.Categories.GetByIdAsync(id);
        }

        public Category GetByIdWithProducts()
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            _unitOfWork.Categories.Update(category);
            _unitOfWork.Save();
        }
    }
}
