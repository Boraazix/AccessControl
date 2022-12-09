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
        public static Developer DeveloperLogged { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public Repository() : base(GetDbConnection(), false)
        {
            if(Database.CreateIfNotExists())
            {
                Repository repository = this;

                Credential cr1 = new Credential("adm@gmail.com", "jumanji", true, true);
                Developer admDefault = new Developer("Admin",Convert.ToDateTime("2000/01/01"),'A', cr1);

                Credential cr2 = new Credential("jacinto@gmail.com", "orvidal",true, false);
                Developer jacinto = new Developer("Jacinto",Convert.ToDateTime("2005/11/19"),'B', cr2);

                repository.Developers.Add(admDefault);
                repository.Developers.Add(jacinto);
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
