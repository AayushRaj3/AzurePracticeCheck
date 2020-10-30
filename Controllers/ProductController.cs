using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleProductApi.Models;
using SimpleProductApi.Repository;

namespace SimpleProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IProductRepository repo;
        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
            try
            {
                var details = repo.GetProduct();
                return Ok(details);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product p1)
        {
            try
            {
                var result = repo.AddProduct(p1);
                if(result != null)
                {
                    return Ok(p1);
                }
                else
                {
                    return BadRequest("Product cannot be Added");
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
            
        }
    }
}
