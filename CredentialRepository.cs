using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControl
{
    public class CredentialRepository
    {
        public static bool ValidateDev(string email, string passwordWR)
        {
            try
            {
                Developer dev;
                using (Repository dbContext = new Repository())
                {
                    dev = dbContext.Developers.Include("Credential").Where(d => d.Credential.Email == email).FirstOrDefault<Developer>();
                }
                if (dev != null)
                {
                    if (!dev.Credential.Active)
                    {
                        throw new Exception("This developer is inactive, needs to be activated at registration");
                    }
                    else
                    {
                        string passwordDB = dev.Credential.Password;
                        passwordWR = Credential.ComputeSHA256(passwordWR, Credential.SALT);

                        if (passwordDB == passwordWR)
                        {
                            FormMain.DeveloperLogged = dev;
                            return true;
                        }
                        else
                        {
                            throw new Exception("This password is incorrect, please try again");
                        }
                    }
                }
                else
                {
                    throw new Exception("This email is incorrect, please try again");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
