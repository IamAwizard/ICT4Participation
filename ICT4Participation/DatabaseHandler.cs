using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace ICT4Participation
{
    class DatabaseHandler
    {
        // Fields
        private OracleConnection con;
        private OracleCommand cmd;
        private OracleDataReader dr;

        // Properties

        // Constructor
        public DatabaseHandler()
        {
            //Connect();
            //Disconnect();
        }

        // Methods
        public void Connect()
        {
            con = new OracleConnection();
            con.ConnectionString = "User Id=loginname; Password=password;Data Source=localhost";
            con.Open();
            Console.WriteLine("CONNECTION SUCCESFULL");

        }

        public void Disconnect()
        {
            con.Close();
            con.Dispose();
        }

        public List<User> GetUsers()
        {
            List<User> userList = new List<User>();
            try
            {
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM USER"; // QUERY
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            try
            {
                while (dr.Read())
                {
                    // Required Variabeles
                    int id;
                    string name;
                    DateTime dateOfBirth;
                    string gender;
                    string city;
                    string adress;
                    string email;
                    string password;

                    int type;

                    // Read from DB
                    id = dr.GetInt32(0);
                    name = Convert.ToString(dr.GetValue(1));
                    dateOfBirth = dr.GetDateTime(2);
                    gender = dr.GetString(3);
                    city = dr.GetString(4);
                    adress = dr.GetString(5);
                    email = dr.GetString(6);
                    password = dr.GetString(7);

                    type = dr.GetInt32(8);

                    User toadd;
                    switch (type)
                    {
                        case 1:
                            Client newClient = new Client(name, dateOfBirth, gender, city, adress, email, password);
                            toadd = newClient;
                            break;
                        case 2:
                            toadd = null;
                            //Volunteer newUser = new Volunteer(name, dateOfBirth, gender, city, adress, email, password);
                            //toadd = newUser;
                            break;
                        case 3:
                            Admin newAdmin = new Admin(name, dateOfBirth, gender, city, adress, email, password);
                            toadd = newAdmin;
                            break;
                        default:
                            toadd = null;
                            break;
                    }

                    userList.Add(toadd);
                }

                return userList;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return null;

        }
    }
}
