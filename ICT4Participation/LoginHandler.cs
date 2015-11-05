using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    class LoginHandler
    {
        // Fields
        UserHandler userhandler;
        // Constructor   
        public LoginHandler()
        {
            userhandler = new UserHandler();
        }

        // Properties

        // Methods
        public bool Authenticate(string email, string password)
        {
            User foo = userhandler.FindUserByEmail(email);
            if (foo != null)
            {
                if (foo.Password == password)
                {
                    return true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(@"Foute email/wachtwoord combinatie");
                    return false;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(@"Email niet gevonden");
                return false;
            }
        }

        public User GetUser(string email)
        {
            return userhandler.FindUserByEmail(email);
        }

        public bool AddClient(Client newclient)
        {
            return false;
        }

        public bool AddVolunteer(Volunteer newvolunteer)
        {
            return false;
        }
    }
}
