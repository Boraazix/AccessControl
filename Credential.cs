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
    [Table("credenciais")]
    public class Credential
    {
        public Int64 Id { get; set; }

        public const String SALT = "!@#$%¨&*()_+";

        [Index(IsUnique = true)]
        [StringLength(250)]
        public String Email { get; set; }

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
        public bool Administrator { get; set; }
        [Required]
        public User User { get; set; }

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

        public bool ValidateUser(string email, string password)
        {
            User user = UserRepository.FindByEmail(email);
            if (user != null)
            {
                string passwordDB = user.Credential.Password;
                    password= ComputeSHA256(ComputeSHA256(password, SALT), SALT);
                    if(passwordDB==password)
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
            return Id + ", "+Email+", "+Password+", "+
                (Administrator?"Administrador":"Usuário Comum") + 
                (this.User==null?"": ", Usuário: " + User.Id)+".";
        }
    }
}
