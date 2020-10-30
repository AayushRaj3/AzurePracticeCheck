using Microsoft.AspNetCore.Mvc;
using SimpleProductApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProductApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        static List<Product> products = new List<Product>()
        {
            new Product {ProductId =1, ProductName="Mobile", ProductCost=50, ProductQuantity=10},
            new Product {ProductId =2, ProductName="Charger", ProductCost=10, ProductQuantity=100},
            new Product {ProductId =3, ProductName="Extension", ProductCost=150, ProductQuantity=80},
            new Product {ProductId =4, ProductName="EarPods", ProductCost=999, ProductQuantity=12},
        };
        
        public List<Product> GetProduct()
        {
            return products.ToList();
        }

        public ActionResult<Product> AddProduct(Product p1)
        {
            products.Add(p1);
            return p1;
        }
    }
}
