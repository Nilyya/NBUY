using DiariesFoodApp.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFoodApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task CreateAsync(Product product)
        {
            await _unitOfWork.Products.CreateAsync(product);
            await _unitOfWork.SaveAsync();
        }

        public void Delete(Product product)
        {
            _unitOfWork.Products.Delete(product);
            _unitOfWork.Save();
        }

        public Task<List<Product>> GetAllAsync()
        {
            return await _unitOfWork.Products.GetAllAsync();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            return await _unitOfWork.Products.GetByIdAsync(id);
        }

        public Task<List<Product>> GetHomePageProductsAsync()
        {
            return await _unitOfWork.Products.GetHomePageProductsAsync();
        }

        public List<Product> GetProductsByCategory()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            _unitOfWork.Products.Update(product);
            _unitOfWork.Save();
        }
    }
}
