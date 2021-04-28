using Internal;
using System;
using MySql.Data.MySqlClient;

namespace gate_prjct
{
    class Program
    {
        static string connectionString = "server=localhost; port=3306; uid=adity;"+"pwd=raveluna03; database=gateBase; charset=utf8; sslMode=none;";
        static MySqlConnection connection = new MySqlConnection(connectionString);
        static void Main(string[] args)
        {
            int input = 0;
            Console.WriteLine("Welcome to The Gate!");
            using(connection){
                try
                {
                    
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                     Console.WriteLine("Error: "+ex.Message.ToString());
                }finally{
                    date_type date = new date_type();
                    date.date();
                    date_check cek = new date_check();
                    cek.check(true);
                    while (input != -1)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Menu GATE: (1)Menu Kalender; (2)cari kerajaan; (3)Cari Raja/Tokoh; (-1) Exit");
                        Console.WriteLine("Input pilihanmu: ");
                        input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                kalender();
                                break;
                            case 2:
                                searchKerajaan();
                                break;
                            case 3:
                                searchTokoh();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }  
        }
        private static void kalender(){
            CKalender kalender = new CKalender();
            kalender.menu();
        }
        private  static void searchTokoh(){
            CTokoh tokoh = new CTokoh();
            tokoh.menu();
        }
        private static void searchKerajaan(){
           CKerajaan kerajaan = new CKerajaan();
           kerajaan.menu();
        }
    }
}