using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace gate_prjct
{
    public class MCalendar
    {
        public void menu(){
            int option = 0;
            while(option !=-1){
                Console.WriteLine("\nGATE's Schedule Planner");
                Console.WriteLine("1) Write Schedule\n2)Search Schedule\n-1)Home");
                try
                {
                    Console.WriteLine("Input your choice: ");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            inputSchedule();
                            break;
                        case 2: 
                            searchSchedule();
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please input a valid option");
                }
            }

        }
        private void inputSchedule(){
            try
            {
                Console.WriteLine("Input schedule's date: ");
                int date = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input schedule's month: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input schedule's year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                DateTime sDate = new DateTime(year, month, date);

                Console.WriteLine("Input schedule's title: ");
                string title = Console.ReadLine();
                Console.WriteLine("Input schedule's detail: ");
                string detail = Console.ReadLine();

                CCalendar calendar = new CCalendar(sDate, title, detail);
                calendar.inSchedule();
            }
            catch
            {
                Console.WriteLine("Please input a valid data");
                inputSchedule();
            }
        }
        private void showSchedule(DateTime date){
            connect data = new connect();
            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Select * from tbhari where h_date in('"+date+"')";

            MySqlDataReader reader = command.ExecuteReader();

            var dataview = "[h_Id]\t[h_Title]";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                  dataview = reader.GetInt32(0) +"\t"+reader.GetString(1)+Environment.NewLine;  
                }
                reader.Close();
                Console.WriteLine(dataview);
            }else{
                Console.WriteLine("You dant have any schedule at "+date);
            }reader.Close();
        }
        private void searchSchedule(){
            try
            {
                Console.WriteLine("Input schedule's date: ");
                int date = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input schedule's month: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input schedule's year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                DateTime sDate = new DateTime(year, month, date);

                showSchedule(sDate);
                Console.WriteLine("1) Read Schedule\t2) Delete Schedule\t-1)Back to Menu");
                scheduleOption();
            }
            catch
            {
                Console.WriteLine("Please input a valid date");
                searchSchedule();
            }
        }
        private void scheduleOption(){
            int option = 0;
            try
            {
                while (option != -1)
                {
                    Console.WriteLine("Input your choice: ");
                    option = Convert.ToInt32(Console.ReadLine());
                    if(option != -1){
                        Console.WriteLine("Input schedule's number");
                        int scheduleId = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                readSchedule(scheduleId);
                                break;
                            case 2:
                                deleteSchedule(scheduleId);
                                break;
                            default:
                                Console.WriteLine("Please input a valid option");
                                scheduleOption();
                                break;
                        }
                    }else{
                        menu();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Please input a valid option");
                scheduleOption();
            }
        }
        private void readSchedule(int id){
            connect data = new connect();

            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Select * from tbhari where h_Id in('"+id+"')";

            MySqlDataReader reader = command.ExecuteReader();

            var dataview = "[h_Id]\t[h_Title]\n[h_Date]\n[h_Content]\n";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                  dataview = reader.GetInt32(0) +"\t"+reader.GetString(1)+"\n"+reader.GetDateTime(2)+"\n"+reader.GetString(3)+Environment.NewLine;  
                }
                reader.Close();
                Console.WriteLine(dataview);
            }else{
                Console.WriteLine("Schedule's Id is invalid");
            }reader.Close();
        }
        private void deleteSchedule(int id){
            CCalendar calendar = new CCalendar();
            calendar.deleteSchedule(id);
        }
        public void successupdate(){
            Console.WriteLine("Your schedule has updated!");
        }
        public void successdelete(){
            Console.WriteLine("Your schedule has deleted!");
        }
    }
}