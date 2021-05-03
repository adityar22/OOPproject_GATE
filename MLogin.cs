using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace gate_prjct
{
    public class MLogin
    {
        public void signorlogin(){
            int option = 0;
            Console.WriteLine("1) Login\n2) Signup\n-1) Exit");
            Console.WriteLine("Input your choice: ");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    mlogin();
                    break;
                case 2:
                    msignup();
                    break;
                case -1:
                    break;
                default:
                    signorlogin();
                    break;
            }
            
        }
        public void mlogin(){
            Console.WriteLine("Masukkan Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Masukkan Password: ");
            string password = Console.ReadLine();

            CAccount account = new CAccount();
            account.login(username, password);
        }
        public void failedlogin(){
            Console.WriteLine("Login Gagal!");
            mlogin();
        }
        public void succeslogin(){
            Console.WriteLine("Login Berhasil!");
            
            MMenu menu = new MMenu();
            menu.menu();
        }
        public void msignup(){
            Console.WriteLine("Input your username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Input your firstname: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Input your lastname: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Input your email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Input your birth's date (dd): ");
            int date = int.Parse(Console.ReadLine());
            Console.WriteLine("Input your birth's  (mm): ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Input your birth's year (yyyy): ");
            int year = int.Parse(Console.ReadLine());
            DateTime birth = new DateTime(year, month, date);

            Console.WriteLine("input your password: ");
            string password = Console.ReadLine();
            
            CAccount account = new CAccount();
            account.signup(username, password, firstname, lastname, birth, email);
        }
        public void failedsignup(){
            Console.WriteLine("Username atau email telah terdaftar!");
            msignup();
        }
        public void successignup(){
            Console.WriteLine("Your account registered!");
            Console.WriteLine("Please login your account");
            mlogin();
        }
    }
}