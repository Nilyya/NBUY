using DiariesFoodApp.Business.Abstract;
using DiariesFoodApp.Data.Abstract;
using DiariesFoodApp.Entity.Concrete;

namespace DiariesFoodApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(Product product)
        {
            await _unitOfWork.Products.CreateAsync(product);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _unitOfWork.Products.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _unitOfWork.Products.GetByIdAsync(id);
        }

        public void Delete(Product product)
        {
            _unitOfWork.Products.Delete(product);
            _unitOfWork.Save();
        }

        public void Update(Product product)
        {
            _unitOfWork.Products.Update(product);
            _unitOfWork.Save();
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(string category)
        {
            return await _unitOfWork.Products.GetProductsByCategoryAsync(category);
        }

        public async Task<List<Product>> GetHomePageProductsAsync()
        {
            return await _unitOfWork.Products.GetHomePageProductsAsync();
        }

        public async Task<Product> GetProductDetailsByUrlAsync(string productUrl)
        {
            return await _unitOfWork.Products.GetProductDetailsByUrlAsync(productUrl);

        }

        public async Task<List<Product>> GetProductsWithCategories()
        {
            return await _unitOfWork.Products.GetProductsWithCategories();
        }

        // public async Task CreateProductAsync(Product product, int[] selectedCategoryIds)
        // {
        //     await _unitOfWork.Products.CreateProductAsync(product, selectedCategoryIds);
        // }

        // public async Task UpdateProductAsync(Product product, int[] selectedCategoryIds)
        // {
        //     await _unitOfWork.Products.UpdateProductAsync(product, selectedCategoryIds);
        // }

        public async Task<Product> GetProductWithCategories(int id)
        {
            return await _unitOfWork.Products.GetProductWithCategories(id);
        }

        public async Task UpdateIsHomeAsync(Product product)
        {
            await _unitOfWork.Products.UpdateIsHomeAsync(product);
        }

        public async Task UpdateIsApprovedAsync(Product product)
        {
            await _unitOfWork.Products.UpdateIsApprovedAsync(product);
        }

        public Task CreateFoodAsync(Product product, int[] selectedCategoryIds)
        {
            throw new NotImplementedException();
        }

        public Task UpdateFoodAsync(Product product, int[] selectedCategoryIds)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetFoodsByCategoryAsync(string category)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetHomePageFoodsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetFoodDetailsByUrlAsync(string foodUrl)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetFoodsWithCategories()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetFoodWithCategories(int id)
        {
            throw new NotImplementedException();
        }
    }
}