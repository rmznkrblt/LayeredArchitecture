using System;
using Business.Concrete;
using DataAccess.Concrete.InMemoryProductDal;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManeger productManeger=new ProductManeger(new InMemoryPoductDal());
            foreach (var product in productManeger.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
