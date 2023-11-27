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
    public class ProductRepositoryDapperSQL : IProductRepository
    {
        string StrConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Desktop\OrderSystem\OrderSystem.DataLayer\Data\LocalOrderSystem.mdf;Integrated Security=True";
        public bool AddProduct(Product product)
        {
            string SqlInsert = "INSERT INTO Products (Name,UnitPrice,Category,Description) Values (@Name,@UnitPrice,@Category,@Description)";
            var affectedRows = 0;
            using (var connection = new SqlConnection(StrConn))
            {
                affectedRows = connection.Execute(SqlInsert,
                    new { Name = product.Name, UnitPrice = product.UnitPrice, Category = product.Category, Description = product.Description });
            }
            return affectedRows > 0? true: false;
        }

        public bool DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            try
            {
                //ConfigurationManager.ConnectionStrings["CustomerConnection"].ConnectionString)
                using (var db = new SqlConnection(StrConn))
                {
                    products = db.Query<Product>("Select * From Products").ToList();
                }
            }
            catch (Exception e)
            {
                string err = e.Message;
                
            }
               
            
            return products;
        }
        
        public bool UpdateProduct(Product product)
        {
            string SqlUpdate = "UPDATE Products SET Name=@Name,UnitPrice=@UnitPrice,Category=@Category,Description=@Description WHERE ProductId=@ProductId";
            var affectedRows = 0;
            using (var connection = new SqlConnection(StrConn))
            {
                affectedRows = connection.Execute(SqlUpdate,
                    new {ProductId = product.ProductId, Name = product.Name, 
                        UnitPrice = product.UnitPrice, Category = product.Category, 
                        Description = product.Description });
            }
            return affectedRows > 0 ? true : false;
        }
    }
}
