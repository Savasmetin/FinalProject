using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManeger productManeger = new ProductManeger(new EFProductDal());

            foreach (var product in productManeger.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);

            }
         
        }
    }
}
