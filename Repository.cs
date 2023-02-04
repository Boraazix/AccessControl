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
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Allocation> Allocations { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public Repository() : base(GetDbConnection(), false)
        {
            if(Database.CreateIfNotExists())
            {
                Repository repository = this;

                Credential cr1 = new Credential("adm@gmail.com", "12345678", true, true);
                Developer admDefault = new Developer("Admin",Convert.ToDateTime("2000/01/01"),Convert.ToChar('A'), cr1);

                repository.Developers.Add(admDefault);
                repository.SaveChanges();
            }
        }
        // Singleton for DB
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
