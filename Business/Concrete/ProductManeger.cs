using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstruct;
using DataAccess.Concrete.InMemoryProductDal;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManeger:IProductService
    {
        private IProductDal _productDal;

        public ProductManeger(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
