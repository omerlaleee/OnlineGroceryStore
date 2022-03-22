using OnlineGroceryStore.DataAccessLayer.Abstracts;
using OnlineGroceryStore.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore.DataAccessLayer.Concretes
{
    public class ProductManagerDal : IProductDal
    {
        private DatabaseConnectionManager connection = new DatabaseConnectionManager();
        private DataTable productsTable = new DataTable();

        public void add(Product product)
        {
            connection.Connection();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("insert into Products(ProductName,Price,Description,Image)values (@ProductName,@Price,@Description,@Image)", connection.connect);
            command.Parameters.AddWithValue("@ProductName", product.name);
            command.Parameters.AddWithValue("@Price", product.price);
            command.Parameters.AddWithValue("@Description", product.description);
            command.Parameters.AddWithValue("@Image", product.imagePath);
            command.ExecuteNonQuery();
            product.id = getAll()[getAll().Count - 1].id;
            connection.CloseConnection();
        }

        public void delete(Product product)
        {
            connection.Connection();
            connection.OpenConnection();
            SqlCommand willBeDeletedFromShoppingCartsDB = new SqlCommand("delete from ShoppingCarts where ProductId = @ProductId", connection.connect);
            willBeDeletedFromShoppingCartsDB.Parameters.AddWithValue("@ProductId", product.id);
            willBeDeletedFromShoppingCartsDB.ExecuteNonQuery();
            SqlCommand command = new SqlCommand("delete from Products where Id = @ProductId", connection.connect);
            command.Parameters.AddWithValue("@ProductId", product.id);
            command.ExecuteNonQuery();
            connection.CloseConnection();
        }

        public List<Product> getAll()
        {
            List<Product> allProducts = new List<Product>();
            productsTable.Clear();
            connection.Connection();
            connection.OpenConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Products", connection.connect);
            dataAdapter.Fill(productsTable);
            connection.CloseConnection();
            for (int i = 0; i < productsTable.Rows.Count; i++)
            {
                Product product = new Product(Convert.ToInt32(productsTable.Rows[i]["Id"]), productsTable.Rows[i]["ProductName"].ToString(),float.Parse(productsTable.Rows[i]["Price"].ToString()), productsTable.Rows[i]["Description"].ToString(), productsTable.Rows[i]["Image"].ToString());
                allProducts.Add(product);
            }
            return allProducts;
        }

        public Product getById(int id)
        {
            foreach (Product product in getAll())
            {
                if (product.id == id)
                {
                    return product;
                }
            }
            return null;
        }

        public void update(Product product)
        {
            connection.Connection();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("update Products set ProductName=@ProductName, Price=@Price, Description=@Description, Image=@Image where Id=@ProductId", connection.connect);
            command.Parameters.AddWithValue("@ProductName", product.name);
            command.Parameters.AddWithValue("@Price", product.price);
            command.Parameters.AddWithValue("@Description", product.description);
            command.Parameters.AddWithValue("@Image", product.imagePath);
            command.Parameters.AddWithValue("@ProductId", product.id);
            command.ExecuteNonQuery();
            connection.CloseConnection();
        }
    }
}
