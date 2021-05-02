using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace gate_prjct
{
    public class MLogin
    {
        public void signorlogin(){
            int option = 0;
            Console.WriteLine("1) Login\n2) Signup\n3) Exit");
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
            string Username;
            string Password;
            
            Console.WriteLine("Masukkan Username: ");
            Username = Console.ReadLine();
            Console.WriteLine("Masukkan Password: ");
            Password = Console.ReadLine();
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