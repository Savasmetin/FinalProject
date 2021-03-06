﻿using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             ProductTest();
           // CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManeger = new ProductManager(new EFProductDal());

            foreach (var product in productManeger.GetProductDetails())
            {
                Console.WriteLine(product.ProductName+"/"+ product.CategoryName);

            }
        }
    }
}
