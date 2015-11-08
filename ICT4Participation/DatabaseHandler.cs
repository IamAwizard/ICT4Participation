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

        /// <summary>
        /// Connect to the database...
        /// </summary>
        public static void Connect()
        {
            con = new OracleConnection();
            con.ConnectionString = connectionstring;
            con.Open();
            Console.WriteLine("CONNECTION SUCCESFULL");

        }

        /// <summary>
        /// Disconnect from the database...
        /// </summary>
        public static void Disconnect()
        {
            con.Close();
            con.Dispose();
        }

        /// <summary>
        ///  Used to replace null values with string "NULL" values
        ///  not in use as of 5-11-2015
        /// </summary>
        /// <param name="cmd"></param>
        static void PopulateNullParameters(OracleCommand cmd)
        {
            foreach (OracleParameter p in cmd.Parameters)
            {
                if (p.Value == null)
                {
                    p.Value = "NULL";
                }
            }
        }

        /// <summary>
        /// Safely get string values from the oracledatareader if they are null
        /// </summary>
        /// <param name="odr"></param>
        /// <param name="ColIndex"></param>
        /// <returns></returns>
        static string SafeGetValue(OracleDataReader odr, int ColIndex)
        {
            {
                if (!odr.IsDBNull(ColIndex))
                    return odr.GetString(ColIndex);
                else
                    return string.Empty;
            }
        }

        public static List<Question> GetAllQuestions()
        {
            Connect();
            List<Question> questionlist = new List<Question>();
            try
            {
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT QUESTIONID, AUTEUR, VRAAG , BIJZONDERHEID, LOCATIE, AFSTAND , VERVOER , DATUM , OPGELOST FROM TQUESTION"; // QUERY
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
                    var vraag = SafeGetValue(dr, 2);
                    var bijzonderheid = SafeGetValue(dr, 3);
                    var locatie = SafeGetValue(dr, 4);
                    var afstand = SafeGetValue(dr, 5);
                    var vervoer = SafeGetValue(dr, 6);
                    DateTime datum = dr.GetDateTime(7);
                    var opgelost = SafeGetValue(dr, 8);

                    Question toadd;
                    toadd = new Question(null, auteur, locatie, vervoer, afstand, bijzonderheid, vraag, datum, opgelost);
                    toadd.ID = questionid;
                    questionlist.Add(toadd);
                }
                foreach (Question q in questionlist)
                {
                    q.Client = (Client)GetUser(q.Auteur);
                }
                return questionlist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
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

        public static List<User> GetAllUsers()
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
                            toadd.UserID = id;
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

        public static void AddAvatar()
        {

        }

        public static bool AddQuestion(Question newquestion)
        {
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                    "Insert into TQUESTION(AUTEUR, VRAAG, BIJZONDERHEID, LOCATIE, AFSTAND, VERVOER, DATUM, OPGELOST) VALUES (:NewAUTEUR, :NewVRAAG, :NewBIJZONDERHEID, :NewLOCATIE, :NewAFSTAND, :NewVERVOER, :NewDATUM, :NewOPGELOST)";

                cmd.Parameters.Add("NewAUTEUR", OracleDbType.Int32).Value = newquestion.Auteur;
                cmd.Parameters.Add("NewVRAAG", OracleDbType.Varchar2).Value = newquestion.Content;
                cmd.Parameters.Add("NewBIJZONDERHEID", OracleDbType.Varchar2).Value = newquestion.Discrepancy;
                cmd.Parameters.Add("NewLOCATIE", OracleDbType.Varchar2).Value = newquestion.Location;
                cmd.Parameters.Add("NewAFSTAND", OracleDbType.Varchar2).Value = newquestion.Distance;
                cmd.Parameters.Add("NewVERVOER", OracleDbType.Varchar2).Value = newquestion.Transport;
                cmd.Parameters.Add("NewDATUM", OracleDbType.Varchar2).Value = newquestion.Date.ToString("dd-MMM-yy");
                cmd.Parameters.Add("NewOPGELOST", OracleDbType.Varchar2).Value = newquestion.Solved;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }

        }
        

        public static bool UpdateQuestion(Question question)
        {
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                   "UPDATE TQUESTION SET VRAAG = :newContent, BIJZONDERHEID =  :newDiscripancy, LOCATIE = :newLocation, AFSTAND = :newDistance, VERVOER = :newTransport, DATUM = :newDate, OPGELOST =:newSolved WHERE QUESTIONID = :newIDvalue";

                cmd.Parameters.Add("newContent", OracleDbType.Varchar2).Value = question.Content;
                cmd.Parameters.Add("newDiscripancy", OracleDbType.Varchar2).Value = question.Discrepancy;
                cmd.Parameters.Add("newLocation", OracleDbType.Varchar2).Value = question.Location;
                cmd.Parameters.Add("newDistance", OracleDbType.Varchar2).Value = question.Distance;
                cmd.Parameters.Add("newTransport", OracleDbType.Varchar2).Value = question.Transport;
                cmd.Parameters.Add("newDate", OracleDbType.Date).Value = question.Date.ToString("dd-MMM-yy");
                cmd.Parameters.Add("newSolved", OracleDbType.Varchar2).Value = question.Solved;
                cmd.Parameters.Add("newIDvalue", OracleDbType.Int32).Value = question.ID;


                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
                
            }     
        }

        public static bool DeleteUser(User usertodelete)
        {
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                   "DELETE FROM TUSER WHERE USERID = :deleteIDvalue";

                cmd.Parameters.Add("deleteIDvalue", OracleDbType.Varchar2).Value = usertodelete.UserID;
                cmd.ExecuteNonQuery();

                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                   "DELETE FROM TAFSPRAAK WHERE VOLUNTEER = :deleteIDvalue";

                cmd.Parameters.Add("deleteIDvalue", OracleDbType.Varchar2).Value = usertodelete.UserID;
                cmd.ExecuteNonQuery();

                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                   "DELETE FROM TAFSPRAAK WHERE CLIENT = :deleteIDvalue";

                cmd.Parameters.Add("deleteIDvalue", OracleDbType.Varchar2).Value = usertodelete.UserID;
                cmd.ExecuteNonQuery();

                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                   "DELETE FROM TCLIENT WHERE CLIENTID = :deleteIDvalue";

                cmd.Parameters.Add("deleteIDvalue", OracleDbType.Varchar2).Value = usertodelete.UserID;
                cmd.ExecuteNonQuery();

                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                   "DELETE FROM TQUESTION WHERE AUTEUR = :deleteIDvalue";

                cmd.Parameters.Add("deleteIDvalue", OracleDbType.Varchar2).Value = usertodelete.UserID;
                cmd.ExecuteNonQuery();

                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                   "DELETE FROM TREVIEW WHERE CLIENT = :deleteIDvalue";

                cmd.Parameters.Add("deleteIDvalue", OracleDbType.Varchar2).Value = usertodelete.UserID;
                cmd.ExecuteNonQuery();

                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                   "DELETE FROM TREVIEW WHERE VOLUNTEER = :deleteIDvalue";

                cmd.Parameters.Add("deleteIDvalue", OracleDbType.Varchar2).Value = usertodelete.UserID;
                cmd.ExecuteNonQuery();

                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                   "DELETE FROM TROOSTER WHERE VOLUNTEERID = :deleteIDvalue";

                cmd.Parameters.Add("deleteIDvalue", OracleDbType.Varchar2).Value = usertodelete.UserID;
                cmd.ExecuteNonQuery();

                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                   "DELETE FROM TVOLUNTEER WHERE VOLUNTEERID = :deleteIDvalue";

                cmd.Parameters.Add("deleteIDvalue", OracleDbType.Varchar2).Value = usertodelete.UserID;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;

            }
        }
    }
}
