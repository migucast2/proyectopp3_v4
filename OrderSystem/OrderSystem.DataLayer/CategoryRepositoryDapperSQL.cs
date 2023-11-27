using Dapper;
using OrderSystem.BusinessObjects.Entities;
using OrderSystem.BusinessObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.DataLayer
{
    public class CategoryRepositoryDapperSQL : ICategoryRepository
    {
        string StrConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Desktop\OrderSystem\OrderSystem.DataLayer\Data\LocalOrderSystem.mdf;Integrated Security=True";
        public bool AddCategory(Category category)
        {
            string SqlInsert = "INSERT INTO Categories (CategoryName,Description) Values (@CategoryName,@Description)";
            var affectedRows = 0;
            using (var connection = new SqlConnection(StrConn))
            {
                affectedRows = connection.Execute(SqlInsert,
                    new { CategoryName = category.CategoryName, Description = category.Description });
            }
            return affectedRows > 0 ? true : false;
        }

        public bool DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            List<Category> categories = new List<Category>();
            try
            {
                //ConfigurationManager.ConnectionStrings["CustomerConnection"].ConnectionString)
                using (var db = new SqlConnection(StrConn))
                {
                    categories = db.Query<Category>("Select * From Categories").ToList();
                }
            }
            catch (Exception e)
            {
                string err = e.Message;

            }


            return categories;
        }

        public bool UpdateCategory(Category category)
        {
            string SqlUpdate = "UPDATE Products SET Name=@Name,UnitPrice=@UnitPrice,Category=@Category,Description=@Description WHERE ProductId=@ProductId";
            var affectedRows = 0;
            using (var connection = new SqlConnection(StrConn))
            {
                affectedRows = connection.Execute(SqlUpdate,
                    new
                    {
                        CategoryId = category.CategoryId,
                        Name = category.CategoryName,
                        Description = category.Description
                    });
            }
            return affectedRows > 0 ? true : false;
        }
    }
}
