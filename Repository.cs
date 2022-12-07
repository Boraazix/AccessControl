using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public class Repository : DbContext
    {
        private static MySqlConnection _databaseConnection;
        public DbSet<User> Users { get; set; } 
        public Repository() : base(GetDbConnection(), false)
        {
            if(Database.CreateIfNotExists())
            {
                Repository repository = this;
                User admDefault = new User();
                admDefault.Name = "Admin";

                Credential crdDefault = new Credential();
            }
        }
        public static MySqlConnection GetDbConnection()
        {
            if(_databaseConnection == null)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ProgVisConnectionString"].ConnectionString;
                _databaseConnection = new MySqlConnection(connectionString);
            }
            return _databaseConnection;
        }
    }
}
