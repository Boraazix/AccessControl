using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public class UserRepository
    {
        public static void Save(User usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if(usuario.Id == 0)
                    {
                        dbContext.Users.Add(usuario);
                    }
                    else
                    {
                        dbContext.Entry(usuario).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<User> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Users.Include("Credencial").ToList();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        public static User FindById(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Users.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static User FindByIdWCredencial(Int64 id)
        {
            try
            {
                using(Repository dbContext = new Repository())
                {
                    return dbContext.Users.Include("Credencial").Where(u=>u.Id==id).FirstOrDefault<User>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<User> FindByPartialName(String partialName)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Users
                        .Where(u => u.Name.Contains(partialName))
                        .ToList<User>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remove(User usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Users.Attach(usuario);
                    dbContext.Users.Remove(usuario);

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static User FindByEmail(String email)
        {
            try
            {
                using(Repository dbContext = new Repository())
                {
                    return dbContext.Users.Include("Credential").Where(u=> u.Credential.Email==email).FirstOrDefault<User>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
