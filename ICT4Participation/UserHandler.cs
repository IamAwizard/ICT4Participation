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

        // Constructor

        // Properties

        // Methods
        public User FindUser(string name)
        {
            return users.Find(x => x.Name == name);
        }

    }
}
