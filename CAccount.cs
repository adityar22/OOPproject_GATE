using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace gate_prjct
{
    public class CAccount
    {
        private string _username;
        private string _password;
        private DateTime _birth;
        private string _firstname;
        private string _lastname;
        private string _email;
        private int _level;

        public string username{
            get{return _username;}
            set{_username = value;}
        }
        public string password{
            get{return _password;}
            set{_password = value;}
        }
        public string firstname{
            get{return _firstname;}
            set{_firstname = value;}
        }
        public string lastname{
            get{return _lastname;}
            set{_lastname = value;}
        }
        public string email{
            get{return _email;}
            set{_email = value;}
        }
        public DateTime birth{
            get{return _birth;}
            set{_birth = value;}
        }
        public int level{
            get{return _level;}
            set{_level = value;}
        }

        public void login(string Username, string Password){
            connect data = new connect();
            MLogin mlogin = new MLogin();

            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Select * from tbuser where username='"+Username+"' and password='"+Password+"'";

            MySqlDataReader login = command.ExecuteReader();
            if(login.HasRows){
                mlogin.succeslogin();
            }else{
                command.Cancel();
                login.Close();
                mlogin.failedlogin();
            }
        }
        public void signup(string Username, string Password, string Firstname, string Lastname, DateTime Birth, string Email){
            username = Username;
            password = Password;
            firstname = Firstname;
            lastname = Lastname;
            email = Email;
            birth = Birth;
            level = 0;

            connect data = new connect();
            MLogin mlogin = new MLogin();

            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Select * from tbuser where username='"+Username+"' and email='"+Email+"'";
            MySqlDataReader cek = command.ExecuteReader();
            if (cek.HasRows)
            {
                mlogin.failedsignup();
            }else{
                MySqlCommand cmd = new MySqlCommand("Insert Into tbuser(username, password, firstname, lastname, email, birth, level) Values('"+username+"', '"+password+"', '"+firstname+"', '"+lastname+"', '"+email+"', '"+birth+"', '"+level+"')", data.connection);
            int i = cmd.ExecuteNonQuery();
            if(i>0){
                mlogin.successignup();
            }cmd.Cancel();
            }
        }
    }
}