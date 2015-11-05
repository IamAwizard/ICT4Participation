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
        public List<User>Users
        { get { return users; }
        set { users = value; } }

        // Constructor
        public UserHandler()
        {

        }

        // Methods
        public User FindUser(string name)
        {
            return users.Find(x => x.Name == name);
        }

        public bool AddUser(User user)
        {
            users.Add(user);
            return true;
        }

        public void Synchronize()
        {

        }
    }
}
