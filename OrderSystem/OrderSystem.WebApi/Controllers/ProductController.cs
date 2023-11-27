using Microsoft.AspNetCore.Mvc;
using OrderSystem.BusinessObjects.Entities;
using OrderSystem.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductService service = new ProductService();
        // GET: api/<ProductController>
        [HttpGet]
        public List<Product> Get()
        {
            return service.GetAll();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post(Product product)
        {
            service.AddProduct(product);
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public void Put(Product product)
        {
            service.UpdateProduct(product);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
