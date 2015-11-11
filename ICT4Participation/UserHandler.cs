using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    class UserHandler
    {
        // Fields
        private List<User> users;

        // Properties
        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        // Constructor
        public UserHandler()
        {

        }

        // Methods
        public User FindUserByName(string name)
        {
            Synchronize();
            return users.Find(x => x.Name == name);
        }

        public User FindUserByEmail(string email)
        {
            Synchronize();
            return users.Find(x => x.Email == email);
        }

        public bool AddUser(User user)
        {
            try
            {
                DatabaseHandler.AddUser(user);
                return true;
            }
            catch (NullReferenceException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DeleteUser(User user)
        {
            try
            {
                DatabaseHandler.DeleteUser(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Synchronize()
        {
            users = DatabaseHandler.GetAllUsers();
        }

        public Volunteer ExtendVolunteer(Volunteer volun)
        {
            return DatabaseHandler.GetVolunteerDetails(volun);
        }

        public bool UpdateVolunteer(Volunteer volun)
        {
            return DatabaseHandler.UpdateVolunteer(volun);
        }
    }
}
