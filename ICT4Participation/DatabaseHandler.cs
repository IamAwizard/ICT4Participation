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
        static string SafeReadString(OracleDataReader odr, int ColIndex)
        {
            {
                if (!odr.IsDBNull(ColIndex))
                    return odr.GetString(ColIndex);
                else
                    return string.Empty;
            }
        }

        static int SafeReadInt(OracleDataReader odr, int ColIndex)
        {
            {
                if (!odr.IsDBNull(ColIndex))
                    return odr.GetInt32(ColIndex);
                else
                    return -1;
            }
        }

        static decimal SafeReadDecimal(OracleDataReader odr, int ColIndex)
        {
            {
                if (!odr.IsDBNull(ColIndex))
                    return odr.GetDecimal(ColIndex);
                else
                    return 0;
            }
        }

        public static List<Question> GetAllQuestions()
        {
            List<Question> questionlist = new List<Question>();
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT QUESTIONID, AUTEUR, VRAAG , BIJZONDERHEID, LOCATIE, AFSTAND , VERVOER , DATUM , OPGELOST, ANTWOORD, VOLUNTEERID FROM TQUESTION"; // QUERY
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
                    var vraag = SafeReadString(dr, 2);
                    var bijzonderheid = SafeReadString(dr, 3);
                    var locatie = SafeReadString(dr, 4);
                    var afstand = SafeReadString(dr, 5);
                    var vervoer = SafeReadString(dr, 6);
                    DateTime datum = dr.GetDateTime(7);
                    var opgelost = SafeReadString(dr, 8);
                    var antwoord = SafeReadString(dr, 9);
                    int volunteerid = SafeReadInt(dr, (10));

                    Question toadd;
                    toadd = new Question(null, auteur, locatie, vervoer, afstand, bijzonderheid, vraag, datum, opgelost);
                    toadd.ID = questionid;
                    toadd.Answer = antwoord;
                    toadd.VolunteerID = volunteerid;
                    questionlist.Add(toadd);
                }
                foreach (Question q in questionlist)
                {
                    q.Client = (Client)GetUser(q.Auteur);
                }

                foreach (Question q in questionlist)
                {
                    if (q.VolunteerID != -1)
                    {
                        q.Volunteer = (Volunteer)GetUser(q.VolunteerID);
                    }
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
            User toadd = null;
            try
            {
                Connect();
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
                            Volunteer newUser = new Volunteer(name, dateOfBirth, gender, city, adress, email, password, false, "Niet Opgegeven", "ONBEKEND", "ONBEKEND");
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

            List<User> userList = new List<User>();
            try
            {
                Connect();
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

                if(newuser is Volunteer)
                {
                    ExtendVolunteer(GetUserID(newuser.Email));
                }
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
                   "UPDATE TQUESTION SET VRAAG = :newContent, BIJZONDERHEID =  :newDiscripancy, LOCATIE = :newLocation, AFSTAND = :newDistance, VERVOER = :newTransport, DATUM = :newDate, OPGELOST =:newSolved, ANTWOORD = :newAnswer, VOLUNTEERID = :newVolunteer WHERE QUESTIONID = :newIDvalue";

                cmd.Parameters.Add("newContent", OracleDbType.Varchar2).Value = question.Content;
                cmd.Parameters.Add("newDiscripancy", OracleDbType.Varchar2).Value = question.Discrepancy;
                cmd.Parameters.Add("newLocation", OracleDbType.Varchar2).Value = question.Location;
                cmd.Parameters.Add("newDistance", OracleDbType.Varchar2).Value = question.Distance;
                cmd.Parameters.Add("newTransport", OracleDbType.Varchar2).Value = question.Transport;
                cmd.Parameters.Add("newDate", OracleDbType.Date).Value = question.Date.ToString("dd-MMM-yy");
                cmd.Parameters.Add("newSolved", OracleDbType.Varchar2).Value = question.Solved;
                cmd.Parameters.Add("newAnswer", OracleDbType.Varchar2).Value = question.Answer;

                if (question.Volunteer == null)
                {
                    cmd.Parameters.Add("newVolunteer", OracleDbType.Int32).Value = null;
                }
                else
                {
                    cmd.Parameters.Add("newVolunteer", OracleDbType.Int32).Value = question.Volunteer.UserID;
                }
                cmd.Parameters.Add("newIDvalue", OracleDbType.Int32).Value = question.ID;

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

        public static bool AddReview(Review newreview)
        {
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                    "Insert into TREVIEW(DATUM, VOLUNTEER, CLIENT, RATING, TEKST) VALUES (:NewDATUM, :NewVOLUNTEER, :NewCLIENT, :NewRATING, :NewTEKST)";

                cmd.Parameters.Add("NewDATUM", OracleDbType.Date).Value = newreview.Date.ToString("dd-MMM-yy");
                cmd.Parameters.Add("NewVOLUNTEER", OracleDbType.Int32).Value = newreview.Targetuser.UserID;
                cmd.Parameters.Add("NewCLIENT", OracleDbType.Int32).Value = newreview.Client.UserID;
                cmd.Parameters.Add("NewRATING", OracleDbType.Int32).Value = newreview.Rating;
                cmd.Parameters.Add("NewTEKST", OracleDbType.Varchar2).Value = newreview.Content;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
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

        public static bool CheckIfHaveChat(User someuser, User anotheruser, out int chatid)
        {
            chatid = -1;
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT GESPREKID FROM TGESPREK WHERE USERID1 = " + someuser.UserID
                    + " AND USERID2 = " + anotheruser.UserID
                    + " OR USERID2 = " + someuser.UserID
                    + " AND USERID1 = " + anotheruser.UserID;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        chatid = dr.GetInt32(0);
                        return true;
                    }
                }
                return false;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            finally
            {
                Disconnect();
            }
        }

        public static bool StartChat(User someuser, User anotheruser)
        {
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                    "Insert into TGESPREK(USERID1, USERID2) VALUES (:NewUser1, :NewUser2)";

                cmd.Parameters.Add("NewUser1", OracleDbType.Int32).Value = someuser.UserID;
                cmd.Parameters.Add("NewUser2", OracleDbType.Int32).Value = anotheruser.UserID;
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

        public static Chat GetChat(int chatid)
        {
            Chat returnchat = new Chat(chatid);
            List<Message> chatmessages = new List<Message>();
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT GESPREKID, BERICHTID, AFZENDER, DATUM, BERICHT FROM (SELECT GESPREKID, BERICHTID, AFZENDER, DATUM, BERICHT FROM TCHATBERICHT WHERE GESPREKID = " + chatid + " ORDER BY BERICHTID DESC) WHERE ROWNUM <= 10" ;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var id = dr.GetInt32(0);
                    var messageid = dr.GetInt32(1);
                    var authorid = dr.GetInt32(2);
                    var date = dr.GetDateTime(3);
                    var content = dr.GetString(4);

                    chatmessages.Add(new Message(id, messageid, authorid, date, content));
                }

                foreach (Message m in chatmessages)
                {
                    m.Author = GetUser(m.AuthorID);
                }

                returnchat.Messages = chatmessages;
                return returnchat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
        }

        public static List<Message> GetNewMessages(int chatid, int berichtid)
        {
            List<Message> chatmessages = new List<Message>();
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT GESPREKID, BERICHTID, AFZENDER, DATUM, BERICHT FROM TCHATBERICHT WHERE GESPREKID = " + chatid + " AND BERICHTID > " + berichtid;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var id = dr.GetInt32(0);
                    var messageid = dr.GetInt32(1);
                    var authorid = dr.GetInt32(2);
                    var date = dr.GetDateTime(3);
                    var content = dr.GetString(4);

                    chatmessages.Add(new Message(id, messageid, authorid, date, content));
                }

                foreach (Message m in chatmessages)
                {
                    m.Author = GetUser(m.AuthorID);
                }

                return chatmessages;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }

        }

        public static bool AddMessage(Message msg)
        {
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                    "Insert into TCHATBERICHT(GESPREKID, DATUM, AFZENDER, BERICHT) VALUES (:newGesprekID, :newDATUM, :newAFZENDER, :newBERICHT)";

                cmd.Parameters.Add("newGesprekID", OracleDbType.Int32).Value = msg.ChatID;
                cmd.Parameters.Add("newDATUM", OracleDbType.Date).Value = msg.Date.ToString("dd-MMM-yy");
                cmd.Parameters.Add("newAFZENDER", OracleDbType.Int32).Value = msg.AuthorID;
                cmd.Parameters.Add("newBERICHT", OracleDbType.Varchar2).Value = msg.Content;
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

        public static List<Review> GetAllReviews()
        {
            List<Review> returnlist = new List<Review>();
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT R.REVIEWID, R.RATING, R.TEKST, R.DATUM, C.USERID, C.NAAM, C.GEBOORTEDATUM, C.GESLACHT, C.WOONPLAATS, C.ADRES, C.EMAIL, C.WACHTWOORD, C.TYPE, "
               + "V.USERID, V.NAAM, V.GEBOORTEDATUM, V.GESLACHT, V.WOONPLAATS, V.ADRES, V.EMAIL, V.WACHTWOORD, V.TYPE FROM TUSER V, TUSER C, TREVIEW R WHERE V.USERID = R.VOLUNTEER AND C.USERID = R.CLIENT";
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var id = dr.GetInt32(0);
                    var rating = dr.GetInt32(1);
                    var content = dr.GetString(2);
                    var date = dr.GetDateTime(3);

                    var clientid = dr.GetInt32(4);
                    var clientname = dr.GetString(5);
                    var clientdob = dr.GetDateTime(6);
                    var clientgender = dr.GetString(7);
                    var clientcity = dr.GetString(8);
                    var clientaddress = dr.GetString(9);
                    var clientemail = dr.GetString(10);
                    var clientpassword = dr.GetString(11);
                    var clientype = dr.GetString(12);

                    var volunid = dr.GetInt32(13);
                    var volunname = dr.GetString(14);
                    var volundob = dr.GetDateTime(15);
                    var volungender = dr.GetString(16);
                    var voluncity = dr.GetString(17);
                    var volunaddress = dr.GetString(18);
                    var volunemail = dr.GetString(19);
                    var volunpassword = dr.GetString(20);
                    var voluntype = dr.GetString(21);

                    Client someclient = new Client(clientname, clientdob, clientgender, clientcity, clientaddress, clientemail, clientpassword);
                    someclient.UserID = clientid;
                    Volunteer somevolun = new Volunteer(volunname, volundob, volungender, voluncity, volunaddress, volunemail, volunpassword, false, "", "", "");
                    somevolun.UserID = volunid;

                    returnlist.Add(new Review(date, someclient, somevolun, rating, content));
                
                    returnlist[returnlist.Count - 1].ReviewID = id;
                }

                return returnlist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
        }

        public static bool DeleteReview(int reviewID)
        {
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                   "DELETE FROM TREVIEW WHERE REVIEWID = " + reviewID;

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

        public static bool DeleteQuestion(int QuestionID)
        {
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                   "DELETE FROM TQUESTION WHERE QUESTIONID = " + QuestionID;

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

        static int GetUserID(string email)
        {
            int returnvalue = -1;
            try
            {
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT USERID FROM TUSER WHERE EMAIL = :findEmail";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("findEmail", OracleDbType.Varchar2).Value = email;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var id = dr.GetInt32(0);
                    returnvalue = id;
                }
                return returnvalue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        static bool ExtendVolunteer(int volun)
        {
            try
            {
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                "Insert into TVOLUNTEER(USERID, RIJBEWIJS, BIOGRAFIE, VOG, FOTO) VALUES (:newUSERID, :newRIJBEWIJS, :newBIOGRAFIE, :newVOG, :newFOTO)";
                cmd.Parameters.Add("newUSERID", OracleDbType.Int32).Value = volun;
                cmd.Parameters.Add("newRIJBEWIJS", OracleDbType.Varchar2).Value = "NEE";
                cmd.Parameters.Add("newBIOGRAFIE", OracleDbType.Varchar2).Value = "Niet opgegeven";
                cmd.Parameters.Add("newVOG", OracleDbType.Varchar2).Value = "Onbekend";
                cmd.Parameters.Add("newFOTO", OracleDbType.Varchar2).Value = "Onbekend";
                cmd.ExecuteNonQuery();

                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                "Insert into TROOSTER(USERID, MAANDAG, DINSDAG, WOENSDAG, DONDERDAG, VRIJDAG, ZATERDAG, ZONDAG) VALUES (:newUSERID, 'Niet Opgegeven', 'Niet Opgegeven', 'Niet Opgegeven', 'Niet Opgegeven', 'Niet Opgegeven', 'Niet Opgegeven', 'Niet Opgegeven')";
                cmd.Parameters.Add("newUSERID", OracleDbType.Int32).Value = volun;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static Volunteer GetVolunteerDetails(Volunteer volun)
        {
            Volunteer toget = volun;
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "select V.BIOGRAFIE, V.FOTO, V.VOG, V.RIJBEWIJS, R.MAANDAG, R.DINSDAG, R.WOENSDAG, R.DONDERDAG, R.VRIJDAG, R.ZATERDAG, R.ZONDAG FROM TVOLUNTEER V, TROOSTER R WHERE V.USERID = " + toget.UserID + " AND R.USERID = " + toget.UserID;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // Read from DB
                    var bio = SafeReadString(dr, 0);
                    var photo = SafeReadString(dr, 1);
                    var vog = SafeReadString(dr, 2);
                    var license = SafeReadString(dr, 3);
                    var monday = SafeReadString(dr, 4);
                    var tuesday = SafeReadString(dr, 5);
                    var wednesday = SafeReadString(dr, 6);
                    var thursday = SafeReadString(dr, 7);
                    var friday = SafeReadString(dr, 8);
                    var saturday = SafeReadString(dr, 9);
                    var sunday = SafeReadString(dr, 10);

                    // Fill
                    toget.Biogragphy = bio;
                    toget.PathToPhoto = photo;
                    toget.PathToVOG = vog;
                    toget.Schedule.Monday = monday;
                    toget.Schedule.Tuesday = tuesday;
                    toget.Schedule.Wednesday = wednesday;
                    toget.Schedule.Thursday = thursday;
                    toget.Schedule.Friday = friday;
                    toget.Schedule.Saturday = saturday;
                    toget.Schedule.Sunday = sunday;
                    if (license == "JA")
                        toget.DrivingLicense = true;
                    else
                        toget.DrivingLicense = false;

                }

                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT ROUND(SUM(RATING)/COUNT(RATING)*2, 1) FROM TREVIEW WHERE VOLUNTEER = " + toget.UserID;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // Read from DB
                    var rating = SafeReadDecimal(dr, 0);

                    // Fill
                    toget.Rating = rating;
                }
                return toget;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                Disconnect();
            }
        }

        public static bool UpdateVolunteer(Volunteer volun)
        {
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                   "UPDATE TVOLUNTEER SET RIJBEWIJS = :newRIJBEWIJS, BIOGRAFIE = :newBIOGRAFIE, VOG = :newVOG, FOTO = :newFOTO WHERE USERID = " + volun.UserID;

                if(volun.DrivingLicense)
                    cmd.Parameters.Add("newRIJBEWIJS", OracleDbType.Varchar2).Value = "JA";
                else
                    cmd.Parameters.Add("newRIJBEWIJS", OracleDbType.Varchar2).Value = "NEE";

                cmd.Parameters.Add("newBIOGRAFIE", OracleDbType.Varchar2).Value = volun.Biogragphy;
                cmd.Parameters.Add("newVOG", OracleDbType.Varchar2).Value = volun.PathToVOG;
                cmd.Parameters.Add("newFOTO", OracleDbType.Varchar2).Value = volun.PathToPhoto;
                cmd.ExecuteNonQuery();

                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                   "UPDATE TROOSTER SET MAANDAG = :newMAANDAG, DINSDAG = :newDINSDAG, WOENSDAG = :newWOENSDAG, DONDERDAG = :newDONDERDAG, VRIJDAG = :newVRIJDAG, ZATERDAG = :newZATERDAG, ZONDAG = :newZONDAG WHERE USERID = " + volun.UserID;

                cmd.Parameters.Add("newMAANDAG", OracleDbType.Varchar2).Value = volun.Schedule.Monday;
                cmd.Parameters.Add("newDINSDAG", OracleDbType.Varchar2).Value = volun.Schedule.Tuesday;
                cmd.Parameters.Add("newWOENSDAG", OracleDbType.Varchar2).Value = volun.Schedule.Wednesday;
                cmd.Parameters.Add("newDONDERDAG", OracleDbType.Varchar2).Value = volun.Schedule.Thursday;
                cmd.Parameters.Add("newVRIJDAG", OracleDbType.Varchar2).Value = volun.Schedule.Friday;
                cmd.Parameters.Add("newZATERDAG", OracleDbType.Varchar2).Value = volun.Schedule.Saturday;
                cmd.Parameters.Add("newZONDAG", OracleDbType.Varchar2).Value = volun.Schedule.Sunday;

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
    }
}
