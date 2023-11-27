using OrderSystem.BusinessObjects.Entities;
using OrderSystem.BusinessObjects.Interfaces;
using OrderSystem.DataLayer;
using OrderSystem.Services.Validations;

namespace OrderSystem.Services
{
    public class CategoryService
    {
        //ProductValidation productValidation = new ProductValidation();
        ICategoryRepository repository = new CategoryRepositoryDapperSQL();
        public string AddCategory(Category category)
        {
            string ResultValidate = string.Empty;
            //ResultValidate = productValidation.CamposRequeridos(product);
            //ResultValidate += productValidation.DatosValidos(product);


            if (ResultValidate == string.Empty)
            {
                //Aca vamos a permitir guardar el producto
                //repository = new ProductRepositroyJson();
                repository.AddCategory(category);

            }


            return ResultValidate;

        }

        public List<Category> GetAll()
        {
            return repository.GetAll();
            //var products = new List<Product>();
            //products.Add(new Product { ProductId = 1, Name = "Prueba", UnitPrice = 5000, Description = "Prueba" });
            //return products;
        }

        public string UpdateCategory(Category category)
        {
            string ResultValidate = string.Empty;
            //ResultValidate = productValidation.CamposRequeridos(product);
            //ResultValidate += productValidation.DatosValidos(product);


            if (ResultValidate == string.Empty)
            {
                repository.UpdateCategory(category);
            }

            return ResultValidate;
        }
    }
}
