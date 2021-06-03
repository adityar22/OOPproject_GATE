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
                    Console.WriteLine(date.datetext);
                    
                    MLogin login = new MLogin();
                    login.signorlogin();

                    data.connection.Close();
                    Console.WriteLine("Connection is "+data.connection.State.ToString() + Environment.NewLine);
                    Console.WriteLine("See you next time, Explorer!");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    Console.WriteLine("You're not connected to GateDB\n");
                    Console.WriteLine("Error: "+ex.Message.ToString());
                }
                finally{
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
            }  
        }
    }
}