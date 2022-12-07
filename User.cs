using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    [Table("usuarios")]
    public class User
    {
        public Int64 Id { get; set; }
        [Required]
        [StringLength(45)]
        public string Name { get; set; }
        public Credential Credential { get; set; }
        public override string ToString()
        {
            return Id+", "+Name+(this.Credential==null ? ", Credencial: " + Credential.Id : "");
        }
    }
}
