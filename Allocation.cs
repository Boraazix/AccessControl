using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    //[Table ("allocation")]
    public class Allocation
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public byte HoursForWeek { get; set; }
        public Decimal Remuneration { get; set; }

        public Developer Developer { get; set; }
        public Project Project { get; set; }

        public List<Task> Tasks { get; set; }
    }
}
