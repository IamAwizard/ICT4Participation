using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    public class Client : User
    {
        public Client(string name, DateTime dateOfBirth, string gender, string city, string adress, string email, string password)
            : base(name, dateOfBirth, gender, city, adress, email, password)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
