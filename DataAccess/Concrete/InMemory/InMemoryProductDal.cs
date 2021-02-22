﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {

        List<Product> _products;
       

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="bardak",Unitprice=15,UnitsInStock=15},
                 new Product{ProductId=2,CategoryId=1,ProductName="kamera",Unitprice=500,UnitsInStock=3},
                  new Product{ProductId=3,CategoryId=2,ProductName="telefon",Unitprice=1500,UnitsInStock=2},
                   new Product{ProductId=4,CategoryId=2,ProductName="klavye",Unitprice=150,UnitsInStock=65},
                    new Product{ProductId=5,CategoryId=2,ProductName="bardak0",Unitprice=85,UnitsInStock=1}

            };
        }
        public void Add(Product product)
        {
            _products.Add( product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int CategoryId)
        {
           return _products.Where(p => p.CategoryId == CategoryId).ToList();

        }

        public void Update(Product product)
        {
            //gonderdiğim  ürün ıd sine ait ürünü listede bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.Unitprice = product.Unitprice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        
        
        }
    }
}