using OrderSystem.BusinessObjects.Interfaces;
using OrderSystem.BusinessObjects.Entities;
using System.Text.Json;

namespace OrderSystem.DataLayer
{
    public class ProductRepositroyJson : IProductRepository
    {
        FileService fileService = new FileService();
        List<Product> products = new List<Product>();
        public bool AddProduct(Product product)
        {
            bool Success = false;

            try
            {
                var DataJson = fileService.GetDataFromFileJson("Products.json").Item2;

                products = JsonSerializer.Deserialize<List<Product>>(DataJson);

                products.Add(product);

                var JsonData = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
                if (JsonData != null)
                {
                    Success = fileService.SaveDataToFile(JsonData, "Products.json");
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

            return Success;

        }

        public bool DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> Productos = null;
            (bool, string) Result = fileService.GetDataFromFileJson("Products.json");

            if (Result.Item1 == true)
            {
                Productos = JsonSerializer.Deserialize<List<Product>>(Result.Item2);
            }

            return Productos;
        }

        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
