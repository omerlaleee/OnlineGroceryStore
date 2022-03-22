using OnlineGroceryStore.DataAccessLayer.Abstracts;
using OnlineGroceryStore.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineGroceryStore.DataAccessLayer.Concretes
{
    public class ShoppingCartManagerDal : IShoppingCartDal
    {
        private DatabaseConnectionManager connection = new DatabaseConnectionManager();
        IUserDal userManagerDal = new UserManagerDal();
        IProductDal productManagerDal = new ProductManagerDal();
        private DataTable shoppingCartsTable = new DataTable();

        public void add(ShoppingCart itemToPurchase)
        {
            itemToPurchase.amount++;
            connection.Connection();
            connection.OpenConnection();
            SqlCommand command;
            if (itemToPurchase.amount == 1)
            {
                command = new SqlCommand("insert into ShoppingCarts(UserId,ProductId,Amount)values (@UserId,@ProductId,@Amount)", connection.connect);
            }
            else
            {
                command = new SqlCommand("update ShoppingCarts set Amount=@Amount where UserId=@UserId and ProductId=@ProductId", connection.connect);
            }
            command.Parameters.AddWithValue("@UserId", itemToPurchase.user.id);
            command.Parameters.AddWithValue("@ProductId", itemToPurchase.product.id);
            command.Parameters.AddWithValue("@Amount", itemToPurchase.amount);
            command.ExecuteNonQuery();
            connection.CloseConnection();
        }

        public void decreaseAmount(ShoppingCart itemToPurchase)
        {
            itemToPurchase.amount--;
            connection.Connection();
            connection.OpenConnection();
            if (itemToPurchase.amount == 0)
            {
                delete(itemToPurchase);
            }
            else
            {
                SqlCommand command;
                command = new SqlCommand("update ShoppingCarts set Amount=@Amount where UserId=@UserId and ProductId=@ProductId", connection.connect);
                command.Parameters.AddWithValue("@UserId", itemToPurchase.user.id);
                command.Parameters.AddWithValue("@ProductId", itemToPurchase.product.id);
                command.Parameters.AddWithValue("@Amount", itemToPurchase.amount);
                command.ExecuteNonQuery();
            }
            connection.CloseConnection();
        }

        public void delete(ShoppingCart itemToPurchase)
        {
            connection.Connection();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("delete from ShoppingCarts where UserId = @UserId and ProductId=@ProductId", connection.connect);
            command.Parameters.AddWithValue("@UserId", itemToPurchase.user.id);
            command.Parameters.AddWithValue("@ProductId", itemToPurchase.product.id);
            command.ExecuteNonQuery();
            connection.CloseConnection();
        }

        public void deleteAllItemsOfACart(int userId)
        {
            connection.Connection();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("delete from ShoppingCarts where UserId = @UserId", connection.connect);
            command.Parameters.AddWithValue("@UserId", userId);
            command.ExecuteNonQuery();
            connection.CloseConnection();
        }

        public List<ShoppingCart> getAll()
        {
            List<ShoppingCart> allShoppingCarts = new List<ShoppingCart>();
            shoppingCartsTable.Clear();
            connection.Connection();
            connection.OpenConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from ShoppingCarts", connection.connect);
            dataAdapter.Fill(shoppingCartsTable);
            connection.CloseConnection();
            for (int i = 0; i < shoppingCartsTable.Rows.Count; i++)
            {
                ShoppingCart shoppingCart = new ShoppingCart(userManagerDal.getById(Convert.ToInt32(shoppingCartsTable.Rows[i]["UserId"].ToString())), productManagerDal.getById(Convert.ToInt32(shoppingCartsTable.Rows[i]["ProductId"].ToString())), Convert.ToInt32(shoppingCartsTable.Rows[i]["Amount"]));
                allShoppingCarts.Add(shoppingCart);
            }
            return allShoppingCarts;
        }

        public ShoppingCart getAnItemToPurchase(int userId, int productId)
        {
            foreach (ShoppingCart item in getCartOfAnUser(userId))
            {
                if(item.user.id==userId&&item.product.id== productId)
                {
                    return item;
                }
            }
            return null;
        }

        public List<ShoppingCart> getCartOfAnUser(int userId)
        {
            List<ShoppingCart> cartOfAnUser = new List<ShoppingCart>();
            foreach (ShoppingCart item in getAll())
            {
                if (item.user.id == userId)
                {
                    cartOfAnUser.Add(item);
                }
            }
            return cartOfAnUser;
        }

        public ShoppingCart itemAndUserIsExist(int userId, int productId)
        {
            foreach (ShoppingCart item in getAll())
            {
                if (item.user.id == userId && item.product.id == productId)
                {
                    return item;
                }
            }
            return new ShoppingCart(LoginedUser.getInstance().user, productManagerDal.getById(productId), 0);
        }

        public void update(ShoppingCart entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
