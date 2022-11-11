using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje.DataAccessLayer;
using Proje.DataAccessLayer.Entities;

namespace Proje.BusinessLayer
{
    public class ProductManager
    {
        private readonly IProductDAL _productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            return _productDAL.GetAll();
        }

        public Product GetByIdProduct(int id)
        {
            return _productDAL.GetById(id); 
        }

        public List<Product> GetProductsByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }
        public List<Product> GetProductsByCategoryId(int id)
        {
            return _productDAL.GetProductsById(id);
        }


    
    }
}

// SELECT P.ProductID,P.ProductName,P.UnitPrice,P.UnitsInStock 
// FROM Products P
// INNER JOIN Categories C
// ON P.CategoryID=C.CategoryID
// WHERE C.CategoryName='Produce'