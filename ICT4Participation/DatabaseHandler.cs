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
    static class DatabaseHandler
    {
        // Fields

        // connectionstring = "User Id=loginname; Password=password;Data Source=localhost";
        static string connectionstring = "User Id=dbi259530;Password=ZBEB4DKxvr;Data Source=192.168.15.50/fhictora";
        static private OracleConnection con;
        static private OracleCommand cmd;
        static private OracleDataReader dr;

        // Properties

        // Constructor

        // Methods
        public static void Connect()
        {
            con = new OracleConnection();
            con.ConnectionString = connectionstring;
            con.Open();
            Console.WriteLine("CONNECTION SUCCESFULL");

        }

        public static void Disconnect()
        {
            con.Close();
            con.Dispose();
        }

        public static List<User> GetUsers()
        {
            Connect();
            List<User> userList = new List<User>();
            try
            {
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM TUSER"; // QUERY
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Disconnect();
                return null;
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
                    string type;

                    // Read from DB
                    id = dr.GetInt32(0);
                    name = dr.GetString(1);
                    dateOfBirth = dr.GetDateTime(2);
                    gender = dr.GetString(3);
                    city = dr.GetString(4);
                    adress = dr.GetString(5);
                    email = dr.GetString(6);
                    password = dr.GetString(7);

                    type = dr.GetString(8);

                    User toadd;
                    switch (type)
                    {
                        case "CLIENT":
                            Client newClient = new Client(name, dateOfBirth, gender, city, adress, email, password);
                            toadd = newClient;
                            break;
                        case "VOLUNTEER":
                            toadd = null;
                            //Volunteer newUser = new Volunteer(name, dateOfBirth, gender, city, adress, email, password);
                            //toadd = newUser;
                            break;
                        case "ADMIN":
                            Admin newAdmin = new Admin(name, dateOfBirth, gender, city, adress, email, password);
                            toadd = newAdmin;
                            break;
                        default:
                            toadd = null;
                            break;
                    }

                    userList.Add(toadd);
                }
                Disconnect();
                return userList;
            }
            catch (InvalidCastException ex)
            {
                Disconnect();
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
