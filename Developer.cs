using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    [Table("developers")]
    public class Developer
    {
        public Int64 Id { get; set; }
        [Required]
        [StringLength(45)]
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public char LevelMemory { get; set; }

        [Column("Level", TypeName = "char")]
        [MaxLength(1)]
        public string LevelDB
        {
            get { return LevelMemory.ToString(); }
            set { LevelMemory = value[0]; }
        }
        public Credential Credential { get; set; }
        public Developer() { }
        public Developer(string name)
        {
            Name = name;
        }
        public Developer(string name, DateTime birth, char level, Credential credential)
        {
            Name = name;
            Birth = birth;
            LevelMemory = level;
            Credential = credential;
        }

        public override string ToString()
        {
            return Id+": "+(Name.Length>28?Name.Substring(0,28):Name)+" | "+(this.Credential.Active ? "Active" : "Inactive");
        }
    }
}
