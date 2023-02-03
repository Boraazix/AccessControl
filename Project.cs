using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    [Table("projects")]
    public class Project
    {
        public long Id { get; set; }
        [MaxLength(35)]
        public String Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime PlannedFinish { get; set; }
        public DateTime Finish { get; set; }
        public List<Allocation> Allocations { get; set; }
        public Project() { }
        public Project(string name, DateTime start, DateTime pfinished, DateTime finished)
        {
            Name = name;
            Start = start;
            PlannedFinish = pfinished;
            Finish = finished;
        }
        public override string ToString()
        {
            return Id+": "+(Name.Length>29?Name.Substring(0,29)+"...":Name);
        }
    }
}
