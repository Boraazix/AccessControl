using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public class ProjectRepository
    {
        public static void Save(Project proj)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (proj.Id == 0)
                    {
                        dbContext.Projects.Add(proj);
                    }
                    else
                    {
                        dbContext.Entry(proj).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Project> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Projects.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Project FindById(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Projects.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Project> FindByPartialName(String partialName)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Projects
                        .Where(p => p.Name.Contains(partialName))
                        .ToList<Project>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remove(Project proj)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Projects.Attach(proj);
                    dbContext.Projects.Remove(proj);

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
