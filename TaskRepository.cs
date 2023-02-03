using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public class TaskRepository
    {
        public static void Update(Task task)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Entry(task).State = EntityState.Modified;

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remove(Task task)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Tasks.Attach(task);
                    dbContext.Tasks.Remove(task);

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
