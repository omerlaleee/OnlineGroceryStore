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
    public class UserManagerDal : IUserDal
    {
        private DatabaseConnectionManager connection = new DatabaseConnectionManager();
        private DataTable usersTable = new DataTable();

        public void add(User user)
        {
            connection.Connection();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("insert into Users(UserName,Password,ProfilePhoto,Address,PhoneNumber,UserType)values (@UserName,@Password,@ProfilePhoto,@Address,@PhoneNumber,@UserType)", connection.connect);
            command.Parameters.AddWithValue("@UserName", user.userName);
            command.Parameters.AddWithValue("@Password", user.password);
            command.Parameters.AddWithValue("@ProfilePhoto", user.profilePhoto);
            command.Parameters.AddWithValue("@Address", user.address);
            command.Parameters.AddWithValue("@PhoneNumber", user.phoneNumber);
            command.Parameters.AddWithValue("@UserType", user.userType);
            command.ExecuteNonQuery();
            user.id = this.getAll()[getAll().Count - 1].id;
            connection.CloseConnection();
        }

        public void delete(User user)
        {
            connection.Connection();
            connection.OpenConnection();
            SqlCommand willBeDeletedFromShoppingCartsDB = new SqlCommand("delete from ShoppingCarts where UserId = @UserId", connection.connect);
            willBeDeletedFromShoppingCartsDB.Parameters.AddWithValue("@UserId", user.id);
            willBeDeletedFromShoppingCartsDB.ExecuteNonQuery();
            SqlCommand command = new SqlCommand("delete from Users where Id = @UserId", connection.connect);
            command.Parameters.AddWithValue("@UserId", user.id);
            command.ExecuteNonQuery();
            connection.CloseConnection();
        }

        public List<User> getAll()
        {
            List<User> allUsers = new List<User>();
            usersTable.Clear();
            connection.Connection();
            connection.OpenConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Users", connection.connect);
            dataAdapter.Fill(usersTable);
            connection.CloseConnection();
            for (int i = 0; i < usersTable.Rows.Count; i++)
            {
                User user = new User(Convert.ToInt32(usersTable.Rows[i]["Id"]), usersTable.Rows[i]["UserName"].ToString(), usersTable.Rows[i]["Password"].ToString(), usersTable.Rows[i]["ProfilePhoto"].ToString(), usersTable.Rows[i]["Address"].ToString(), usersTable.Rows[i]["PhoneNumber"].ToString(), Convert.ToBoolean(usersTable.Rows[i]["UserType"]));
                allUsers.Add(user);
            }
            return allUsers;
        }

        public User getByUserName(string userName)
        {
            foreach (User user in getAll())
            {
                if (user.userName == userName)
                {
                    return user;
                }
            }
            return null;
        }

        public User getById(int id)
        {
            foreach (User user in getAll())
            {
                if (user.id == id)
                {
                    return user;
                }
            }
            return null;
        }

        public bool isRegistered(User user)
        {
            foreach (User item in getAll())
            {
                if (LoginedUser.getInstance().user != null && item.userName == LoginedUser.getInstance().user.userName)
                {
                    return true;
                }
                if (item.userName == user.userName)
                {
                    return false;
                }
            }
            return true;
        }

        public bool signIn(string userName, string password)
        {
            foreach (User user in getAll())
            {
                if (user.userName == userName && user.password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public void update(User user)
        {
            connection.Connection();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("update Users set UserName=@UserName, Password=@Password, ProfilePhoto=@ProfilePhoto, Address=@Address, PhoneNumber=@PhoneNumber where Id=@Id", connection.connect);
            command.Parameters.AddWithValue("@Id", user.id);
            command.Parameters.AddWithValue("@UserName", user.userName);
            command.Parameters.AddWithValue("@Password", user.password);
            command.Parameters.AddWithValue("@ProfilePhoto", user.profilePhoto);
            command.Parameters.AddWithValue("@Address", user.address);
            command.Parameters.AddWithValue("@PhoneNumber", user.phoneNumber);
            command.ExecuteNonQuery();
            connection.CloseConnection();
        }
    }
}
