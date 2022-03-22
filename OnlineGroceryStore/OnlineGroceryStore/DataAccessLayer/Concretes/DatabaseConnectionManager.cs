using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineGroceryStore.DataAccessLayer.Concretes
{
    public class DatabaseConnectionManager
    {
        private SqlConnection Connect;
        public SqlConnection connect { get => Connect; set => Connect = value; }

        public void Connection()
        {
            // Enter here the connection string after creating database.
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineGroceryStore;Integrated Security=True";
            Connect = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                Connect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nPlease check the connection path is correct in \nDataAccessLayer/Concretes/DatabaseConnectionManager");
            }
        }

        public void CloseConnection()
        {
            try
            {
                Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nPlease check the connection path is correct in \nDataAccessLayer/Concretes/DatabaseConnectionManager");
            }
        }
    }
}
