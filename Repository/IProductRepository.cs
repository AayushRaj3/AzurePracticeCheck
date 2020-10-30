using Microsoft.AspNetCore.Mvc;
using SimpleProductApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProductApi.Repository
{
    public interface IProductRepository
    {
        public List<Product> GetProduct();

        public ActionResult<Product> AddProduct(Product p1);
    }
}
