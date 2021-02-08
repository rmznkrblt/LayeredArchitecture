using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstruct;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemoryProductDal
{
    public class InMemoryPoductDal:IProductDal
    {
        List<Product> _product;

        public InMemoryPoductDal()
        {
            _product = new List<Product>
            {
                new Product{ProductId = 1,CategoryId = 1,ProductName = "Laptop",UnitPrice = 3999,UnitsInStock = 2},
                new Product{ProductId = 2,CategoryId = 2,ProductName = "Mouse",UnitPrice = 100,UnitsInStock = 13}
            };
        }


        public List<Product> GetAll()
        {
            return _product;
        }

        public void Add(Product product)
        {
            _product.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _product.SingleOrDefault(p => p.ProductId == product.ProductId);
            _product.Remove(productToDelete);
        }

        public void Update(Product product)
        {
            Product productToUpdate = _product.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _product.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
