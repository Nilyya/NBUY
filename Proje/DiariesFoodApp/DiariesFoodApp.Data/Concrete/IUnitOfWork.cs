using DiariesFoodApp.Data.Abstract;
using DiariesFoodApp.Data.Concrete.EfCore.Context;
using DiariesFoodApp.Data.Concrete.EfCore.Repositories;

namespace DiariesFoodApp.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DiariesAppContext _context;

        public UnitOfWork(DiariesAppContext context)
        {
            _context = context;
        }

        private EfCoreProductRepository _productRepository;
        private EfCoreCategoryRepository _categoryRepository;



        public IProductRepository Products => _productRepository = _productRepository ?? new EfCoreProductRepository(_context);

        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new EfCoreCategoryRepository(_context);
        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}