using OrderSystem.BusinessObjects.Entities;

namespace OrderSystem.BusinessObjects.Interfaces
{
    public interface ICategoryRepository
    {
        bool AddCategory(Category category);
        List<Category> GetAll();
        bool UpdateCategory(Category category);
        bool DeleteCategory(Category category);
    }
}
