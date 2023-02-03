using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    [Table ("allocations")]
    public class Allocation
    {
        public long Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public byte HoursPerWeek { get; set; }
        public Decimal Remuneration { get; set; }

        public Developer Developer { get; set; }
        public Project Project { get; set; }

        public List<Task> Tasks { get; set; }
        public Allocation()
        {
            Tasks = new List<Task>();
        }
        public Allocation(DateTime start, DateTime finish, byte hoursPerWeek, decimal remuneration, Developer developer, Project project):this()
        {
            Start = start;
            Finish = finish;
            HoursPerWeek = hoursPerWeek;
            Remuneration = remuneration;
            Developer = developer;
            Project = project;
        }
        public override string ToString()
        {
            return Id + ": \"" + (Developer.Name.Length>10?Developer.Name.Substring(0,15):Developer.Name) + "\"" + " allocated in project " + "\"" + (Project.Name.Length > 15 ? Project.Name.Substring(0, 15) : Project.Name) + "\"";
        }
    }
}
