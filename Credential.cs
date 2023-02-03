using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControl
{
    [Table("credentials")]
    public class Credential
    {
        public Int64 Id { get; set; }

        public const String SALT = "!@#$%¨&*()_+";

        [Index(IsUnique = true)]
        [MaxLength(250)]
        public String Email { get; set; }
        [MaxLength(64)]
        private String _password;
        public String Password
        {
            get
            {
                return _password;
            }
            set
            {
                if(value.Length>=8 && value.Length<=12)
                {
                    _password = ComputeSHA256(value, SALT);
                }
                else if(value.Length==64)
                {
                    _password = value;
                }
                else
                {
                    throw new Exception("The password must be between 8 and 12 characters!");
                }
            }
        }
        public bool Active { get; set; }
        public bool Administrator { get; set; }
        [Required]
        public Developer Developer { get; set; }

        #region Hashing
        public static String ComputeSHA256(String input)
        {
            return ComputeSHA256(input, null);
        }

        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;

            // 
            // https://learn.microsoft.com/en-us/dotnet/standard/security/cryptographic-services
            // https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256?view=netframework-4.8
            // https://www.techiedelight.com/generate-sha-256-hash-of-string-csharp/
            // 

            // Initialize a SHA256 hash object
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash of the given string
                byte[] hashValue = sha256.ComputeHash(
                    Encoding.UTF8.GetBytes(salt + input));

                // Convert the byte array to string format
                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }
        #endregion
        public Credential() { }
        
        public Credential(String email, String password,bool active, bool adm)
        {
            Email= email;
            Password= password;
            Active= active;
            Administrator = adm;
        }
        public override string ToString()
        {
            return Id + ", " + Email + ", " + Password + ", " +
                (Administrator ? "Administrador" : "Usuário Comum") +
                (this.Developer == null ? "" : ", Usuário: " + Developer.Id) + ".";
        }
    }
}
