using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    [Table ("tasks")]
    public class Task
    {
        public long Id { get; set; }
        [MaxLength(200)]
        public String Description { get; set; }
        public Task() { }
        public Task(string desc)
        {
            Description = desc;
        }
        public override string ToString()
        {
            return Description;
        }
    }
}
