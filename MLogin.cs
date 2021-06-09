using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace gate_prjct
{
    public class MLogin
    {
        public CAccount myaccount;
        public void signorlogin(){
            int option = 0;
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("1) Login\n2) Signup\n-1) Exit");
            Console.WriteLine("----------------------------------------------------\n");
            try{
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
                        Console.WriteLine("Please input a valid option");
                        break;
                }
            }catch(Exception e){
                Console.WriteLine("Error: "+e.ToString());
                signorlogin();
            }  
        }
        public void mlogin(){
            Console.WriteLine("\nInput Username: ");
            string Username = Console.ReadLine();
            Console.WriteLine("Input Password: ");
            string Password = Console.ReadLine();
            
            myaccount = new CAccount(Username, Password);
            myaccount.login();
        }
        public void failedlogin(){
            Console.WriteLine("Login Gagal!");
            mlogin();
        }
        public void succeslogin(){
            Console.WriteLine("\nLogin Berhasil!");
            
            MMenu menu = new MMenu();
            menu.menu();
        }
        public void msignup(){
            Console.WriteLine("\nInput your username: ");
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
            Console.WriteLine("\nUsername atau email telah terdaftar!\n");
            msignup();
        }
        public void successignup(){
            Console.WriteLine("\nYour account registered!");
            Console.WriteLine("Please login your account\n");
            mlogin();
        }
    }
}