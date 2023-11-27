using OrderSystem.BusinessObjects.Entities;
using OrderSystem.BusinessObjects.Interfaces;
using OrderSystem.Services.Validations;
using OrderSystem.DataLayer;

namespace OrderSystem.Services
{
    public class ProductService
    {
        ProductValidation productValidation = new ProductValidation();
        IProductRepository repository = new ProductRepositoryDapperSQL();
        public string AddProduct(Product product)
        {
            string ResultValidate = string.Empty;
            ResultValidate = productValidation.CamposRequeridos(product);
            ResultValidate += productValidation.DatosValidos(product);
                         

            if (ResultValidate == string.Empty)
            {
                //Aca vamos a permitir guardar el producto
                //repository = new ProductRepositroyJson();
                repository.AddProduct(product);
                
            }


            return ResultValidate;

        }

        public List<Product> GetAll()
        {
            return repository.GetAll();
            //var products = new List<Product>();
            //products.Add(new Product { ProductId = 1, Name = "Prueba", UnitPrice = 5000, Description = "Prueba" });
            //return products;
        }

        public string UpdateProduct(Product product)
        {
            string ResultValidate = string.Empty;
            ResultValidate = productValidation.CamposRequeridos(product);
            ResultValidate += productValidation.DatosValidos(product);


            if (ResultValidate == string.Empty)
            {
                repository.UpdateProduct(product);
            }

            return ResultValidate;
        }
    }
}
