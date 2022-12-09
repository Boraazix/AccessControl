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
        [StringLength(250)]
        public String Email { get; set; }
        [StringLength(64)]
        private String _password;
        public String Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = ComputeSHA256(value, SALT);
            }
        }
        public bool Active { get; set; }
        public bool Administrator { get; set; }
        [Required]
        public Developer User { get; set; }

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
        public static bool ValidateDev(string email, string passwordWR)
        {
            Developer dev = DeveloperRepository.FindByEmail(email);
            if (dev != null)
            {
                string passwordDB = dev.Credential.Password;
                // the password is encrypted two times, when is saved on DB and when 
                // is placed in a object. The entry of user need to be encrypted two times too.
                passwordWR = ComputeSHA256(ComputeSHA256(passwordWR, SALT), SALT);
                if (passwordDB == passwordWR)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("This password is incorrect, please try again", "PASSWORD WRONG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("This email is incorrect, please try again", "EMAIL WRONG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
        public override string ToString()
        {
            return Id + ", " + Email + ", " + Password + ", " +
                (Administrator ? "Administrador" : "Usuário Comum") +
                (this.User == null ? "" : ", Usuário: " + User.Id) + ".";
        }
    }
}
