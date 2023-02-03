using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public class AllocationRepository
    {
        public static void Save(Allocation al)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Entry(al.Developer).State = EntityState.Unchanged;
                    dbContext.Entry(al.Project).State = EntityState.Unchanged;
                    if (al.Id==0)
                    {
                        dbContext.Allocations.Add(al);
                    }
                    else
                    {
                        dbContext.Entry(al).State = EntityState.Modified;
                    }
                    foreach(Task task in al.Tasks)
                    {
                        if(task.Id==0)
                        {
                            dbContext.Tasks.Add(task);
                        }
                        else
                        {
                            dbContext.Entry(task).State = EntityState.Modified;
                        }
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Allocation> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Allocations.Include("Developer").Include("Project").Include("Tasks").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Allocation FindById(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Allocations.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Allocation FindByIdAll(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Allocations.Include("Developer").Include("Project").Include("Tasks").Where(a => a.Id == id).FirstOrDefault<Allocation>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Developer> FindDevelopersByProject(Project proj)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    List<Allocation> allocationsInProject = new List<Allocation>();
                    List<Developer> developers = new List<Developer>();

                    allocationsInProject = dbContext.Allocations.Include("Developer").Include("Project")
                    .Where(a => a.Project.Id == proj.Id)
                    .ToList<Allocation>();

                    foreach (Allocation a in allocationsInProject)
                    {
                        developers.Add(DeveloperRepository.FindByIdWCredencial(a.Developer.Id));
                    }
                    return developers;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Allocation FindByDeveloperAndProject(Developer dev, Project proj)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Allocations.Include("Developer").Include("Project").Include("Tasks").Where(a => a.Developer.Id==dev.Id && a.Project.Id==proj.Id).FirstOrDefault<Allocation>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Allocation> FindByPartialName(String partialName)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Allocations.Include("Developer").Include("Project").Include("Tasks")
                        .Where(a => a.Developer.Name.Contains(partialName) || a.Project.Name.Contains(partialName))
                        .ToList<Allocation>();
                }
            }
            catch (Exception)
            {
                throw;  
            }
        }
        public static void Remove(Allocation allocation)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Allocations.Attach(allocation);
                    dbContext.Allocations.Remove(allocation);

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
