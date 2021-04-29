using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace gate_prjct
{
    public class MLogin
    {
        private string username;
        private string password;
        public string Username{
            get{return username;}
            set{username = value;}
        }
        public string Password{
            get{return password;}
            set{password = value;}
        }
        public void mlogin(){
            connect data = new connect();
            Console.WriteLine("Masukkan Username: ");
            Username = Console.ReadLine();
            Console.WriteLine("Masukkan Password: ");
            Password = Console.ReadLine();

            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Select * from tbuser where username='"+Username+"' and password='"+Password+"'";

            MySqlDataReader login = command.ExecuteReader();
            if(login.HasRows){
                Console.WriteLine("Login Berhasil!");
            }else{
                Console.WriteLine("Login Gagal!");
                command.Cancel();
                login.Close();
                mlogin();
            }
        }
    }
}