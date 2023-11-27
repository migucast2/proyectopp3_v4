using OrderSystem.BusinessObjects.Entities;

namespace OrderSystem.BusinessObjects.Interfaces
{
    public interface IProductRepository
    {
        bool AddProduct(Product product);
        List<Product> GetAll();
        bool UpdateProduct(Product product);
        bool DeleteProduct(Product product);

    }
}
