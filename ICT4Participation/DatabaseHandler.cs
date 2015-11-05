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


        public static List<Question> GetQuestions()
        {
            Connect();
            List<Question> questionlist = new List<Question>();
            try
            {
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT QUESTIONID, AUTEUR, VRAAG , BIJZONDERHEID, LOCATIE, AFSTAND , VERVOER , DATUM , OPGELOST  "; // QUERY
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
                    // Read from DB
                    var questionid = dr.GetInt32(0);
                    var auteur = dr.GetInt32(1);
                    var vraag = dr.GetString(2);
                    var bijzonderheid = dr.GetString(3);
                    var locatie = dr.GetString(4);
                    var afstand = dr.GetString(5);
                    var vervoer = dr.GetString(6);
                    var datum = dr.GetDateTime(7);
                    var opgelost = dr.GetString(8);

                    Question toadd;
                    toadd = new Question(null, auteur, locatie, vervoer, afstand, bijzonderheid, vraag, datum, opgelost);
                    questionlist.Add(toadd);
                }
                foreach(Question q in questionlist)
                {
                    q.Client = (Client)GetUser(q.Auteur);
                }
                return questionlist;
            }
            catch
            {
                return null;
                MessageBox.Show(" kap er maar mee he pater");
            }

        }

        public static User GetUser(int ids)
        {
            Connect();
            User toadd = null;
            try
            {
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT USERID, NAAM, GEBOORTEDATUM, GESLACHT, WOONPLAATS, ADRES, EMAIL, WACHTWOORD, TYPE FROM TUSER WHERE USERID = " + ids; // QUERY
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
                    // Read from DB
                    var id = dr.GetInt32(0);
                    var name = dr.GetString(1);
                    var dateOfBirth = dr.GetDateTime(2);
                    var gender = dr.GetString(3);
                    var city = dr.GetString(4);
                    var adress = dr.GetString(5);
                    var email = dr.GetString(6);
                    var password = dr.GetString(7);

                    var type = dr.GetString(8);


                    switch (type)
                    {
                        case "CLIENT":
                            Client newClient = new Client(name, dateOfBirth, gender, city, adress, email, password);
                            toadd = newClient;
                            toadd.UserID = id;
                            break;
                        case "VOLUNTEER":
                            toadd = null;
                            Volunteer newUser = new Volunteer(name, dateOfBirth, gender, city, adress, email, password, false, "", "", "");
                            toadd = newUser;
                            break;
                        case "ADMIN":
                            Admin newAdmin = new Admin(name, dateOfBirth, gender, city, adress, email, password);
                            toadd = newAdmin;
                            toadd.UserID = id;
                            break;
                        default:
                            toadd = null;
                            break;
                    }

                }
                Disconnect();
                return toadd;
            }
            catch (InvalidCastException ex)
            {
                Disconnect();
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static List<User> GetUsers()
        {
            Connect();
            List<User> userList = new List<User>();
            try
            {
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT USERID, NAAM, GEBOORTEDATUM, GESLACHT, WOONPLAATS, ADRES, EMAIL, WACHTWOORD, TYPE FROM TUSER"; // QUERY
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
                    // Read from DB
                    var id = dr.GetInt32(0);
                    var name = dr.GetString(1);
                    var dateOfBirth = dr.GetDateTime(2);
                    var gender = dr.GetString(3);
                    var city = dr.GetString(4);
                    var adress = dr.GetString(5);
                    var email = dr.GetString(6);
                    var password = dr.GetString(7);

                    var type = dr.GetString(8);

                    User toadd;
                    switch (type)
                    {
                        case "CLIENT":
                            Client newClient = new Client(name, dateOfBirth, gender, city, adress, email, password);
                            toadd = newClient;
                            toadd.UserID = id;
                            break;
                        case "VOLUNTEER":
                            toadd = null;
                            Volunteer newUser = new Volunteer(name, dateOfBirth, gender, city, adress, email, password, false, "", "", "");
                            toadd = newUser;
                            break;
                        case "ADMIN":
                            Admin newAdmin = new Admin(name, dateOfBirth, gender, city, adress, email, password);
                            toadd = newAdmin;
                            toadd.UserID = id;
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

        static void Read(string sql)
        {
            try
            {
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AddUser(User newuser)
        {
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                    "Insert into TUSER(NAAM, GEBOORTEDATUM, GESLACHT, WOONPLAATS, ADRES, EMAIL, WACHTWOORD, TYPE) VALUES (:NewNAAM, :NewGEBOORTEDATUM, :NewGESLACHT, :NewWOONPLAATS, :NewADRES, :NewEMAIL, :NewWACHTWOORD, :NewTYPE)";

                cmd.Parameters.Add("NewNAAM", OracleDbType.Varchar2).Value = newuser.Name;
                cmd.Parameters.Add("NewGEBOORTEDATUM", OracleDbType.Date).Value = newuser.DateOfBirth;
                cmd.Parameters.Add("NewGESLACHT", OracleDbType.Varchar2).Value = newuser.Gender; ;
                cmd.Parameters.Add("NewWOONPLAATS", OracleDbType.Varchar2).Value = newuser.City; ;
                cmd.Parameters.Add("NewADRES", OracleDbType.Varchar2).Value = newuser.Adress; ;
                cmd.Parameters.Add("NewEMAIL", OracleDbType.Varchar2).Value = newuser.Email; ;
                cmd.Parameters.Add("NewWACHTWOORD", OracleDbType.Varchar2).Value = newuser.Password;
                if (newuser is Client)
                    cmd.Parameters.Add("NewTYPE", OracleDbType.Varchar2).Value = "CLIENT";
                if (newuser is Volunteer)
                    cmd.Parameters.Add("NewTYPE", OracleDbType.Varchar2).Value = "VOLUNTEER";
                if (newuser is Admin)
                    cmd.Parameters.Add("NewTYPE", OracleDbType.Varchar2).Value = "ADMIN";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
