using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public class DeveloperRepository
    {
        public static void Save(Developer dev)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if(dev.Id == 0)
                    {
                        dbContext.Developers.Add(dev);
                    }
                    else
                    {
                        dbContext.Entry(dev).State = EntityState.Modified;
                        dbContext.Entry(dev.Credential).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Developer> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers.Include("Credential").ToList();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        public static Developer FindById(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Developer FindByIdWCredencial(Int64 id)
        {
            try
            {
                using(Repository dbContext = new Repository())
                {
                    return dbContext.Developers.Include("Credential").Where(u=>u.Id==id).FirstOrDefault<Developer>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Developer> FindByPartialName(String partialName)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers
                        .Where(u => u.Name.Contains(partialName))
                        .ToList<Developer>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remove(Developer dev)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Developers.Attach(dev);
                    dbContext.Developers.Remove(dev);

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Developer FindByEmail(String email)
        {
            try
            {
                using(Repository dbContext = new Repository())
                {
                    return dbContext.Developers.Include("Credential").Where(d=> d.Credential.Email==email).FirstOrDefault<Developer>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
