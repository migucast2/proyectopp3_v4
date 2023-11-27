using Microsoft.AspNetCore.Mvc;
using OrderSystem.BusinessObjects.Entities;
using OrderSystem.Services;

namespace OrderSystem.WebApi.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class CategoryController : ControllerBase
        {
            CategoryService service = new CategoryService();
            // GET: api/<ProductController>
            [HttpGet]
            public List<Category> Get()
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
            public void Post(Category category)
            {
                service.AddCategory(category);
            }

            // PUT api/<ProductController>/5
            [HttpPut]
            public void Put(Category category)
            {
                service.UpdateCategory(category);
            }
            
            // DELETE api/<ProductController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            }
        }
    }

