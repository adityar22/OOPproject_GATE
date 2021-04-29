using System;

namespace gate_prjct
{
    class Program
    {
        static void Main(string[] args)
        {
            connect data = new connect();
            Console.WriteLine("Welcome to The Gate! \n");
            
            using(data.connection){
                try
                {
                    data.connection.Open();
                    Console.WriteLine("Connection is "+data.connection.State.ToString() + Environment.NewLine);
                    Console.WriteLine("You're connected to GateDB now\n");

                    date_type date = new date_type();
                    date.date();
                    
                    int input = 0;
                    while (input != -1)
                    {
                        Console.WriteLine("GATE's Menu: (1)Menu Calendar;\n (2)Menu Kingdom's Data;\n (3)Menu King's Data;\n (-1) Exit");
                        Console.WriteLine("Input Your Choice: ");
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
                    data.connection.Close();
                    Console.WriteLine("Connection is "+data.connection.State.ToString() + Environment.NewLine);
                    Console.WriteLine("See you next time, Explorer!");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    Console.WriteLine("You're not connected to GateDB\n");
                    Console.WriteLine("Error: "+ex.Message.ToString());
                }finally{
                    
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
            }  
        }
        private static void kalender(){
            MKalender calendar = new MKalender();
            calendar.menu();
        }
        private  static void searchTokoh(){
            MTokoh tokoh = new MTokoh();
            tokoh.menu();
        }
        private static void searchKerajaan(){
           MKerajaan kerajaan = new MKerajaan();
           kerajaan.menu();
        }
    }
}