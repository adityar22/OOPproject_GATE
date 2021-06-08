using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace gate_prjct
{
    public class MDiary
    {
        public void menu(){
            int option = 0;
            while (option != -1)
            {
                Console.WriteLine("Gate's Day Menu");
                Console.WriteLine("1) Search Diary;\n2) Show List Diary;\n3) Write Diary;\n-1) Back");
                try
                {
                    Console.WriteLine("Input your choice: ");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            searchDiary();
                            break;
                        case 2:
                            showDiary();
                            break;
                        case 3:
                            writeDiary();
                            break;
                        default:
                            Console.WriteLine("Input a valid option!");
                            break;
                    } 
                }
                catch
                {
                    Console.WriteLine("Please input a valid option");
                }
            }
        }
        private void searchDiary(){
            Console.WriteLine("Masukkan keyword: ");
            string keyword = Console.ReadLine();
            
            connect data = new connect();
            
            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Selcet * from tbdiary where  dTitle ='"+keyword+"'";

            MySqlDataReader search = command.ExecuteReader();
            var datsearch = "[tId]\t[dTitle]";

            if (search.HasRows)
            {
                while (search.Read())
                {
                    datsearch = search.GetInt32(3)+"\t"+search.GetString(0);
                }
                Console.WriteLine(datsearch);
            }else{
                Console.WriteLine("Keyword tidak sesuai");
            }
            command.Cancel();
            search.Close();
        }
        private void showDiary(){
            connect data = new connect();

            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Select * from tbdiary";

            MySqlDataReader reader = command.ExecuteReader();

            var dataview = "[dId]\t[dTitle]\t[dDate]n";

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataview = reader.GetInt32(0) +"\t"+reader.GetString(1)+"\t"+reader.GetDateTime(2)+Environment.NewLine;
                    Console.WriteLine(dataview);
                }
                reader.Close();
                menuDiary();
            }
            else{
                Console.WriteLine("Diary is Empty");
                reader.Close();
            }
        }
        private void menuDiary(){
            Console.WriteLine("\n1)Get Details\n2)Rewrite Diary\n3)Delete Diary\n-1)Back to Menu");
            int option = 0;
            try
            {
                while(option != -1){
                    Console.WriteLine("Input your choice: ");
                    option = Convert.ToInt32(Console.ReadLine());
                    if(option != -1){
                        int diaryId;
                        try
                        {
                            Console.WriteLine("Input diary's number: ");
                            diaryId = Convert.ToInt32(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    readDiary(diaryId);
                                    break;
                                case 2:
                                    rewriteDiary(diaryId);
                                    break;
                                case 3:
                                    deleteDiary(diaryId);
                                    break;
                                default:
                                    Console.WriteLine("Please input a valid option");
                                    break;
                            } 
                        }
                        catch
                        {
                            Console.WriteLine("Please input a valid number");
                        }
                    }else{
                        menu();
                    }
                } 
            }
            catch
            {
                Console.WriteLine("Please input a valid option");
                menuDiary();
            }
        }
        private void readDiary(int id){
            connect data = new connect();

            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Select * from tbdiary where dId in('"+id+"')";

            MySqlDataReader reader = command.ExecuteReader();

            var dataview = "[dId]\t[dTitle]\n[dDate]\n[dContent]\n";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                  dataview = reader.GetInt32(0) +"\t"+reader.GetString(1)+"\n"+reader.GetDateTime(2)+"\n"+reader.GetString(3)+Environment.NewLine;  
                }
                reader.Close();
                Console.WriteLine(dataview);
            }else{
                Console.WriteLine("Diary's Id is invalid");
            }reader.Close();
        }
        private void writeDiary(){
            Console.WriteLine("Input diary's title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Input diary's content: ");
            string content = Console.ReadLine();

            CDiary diary = new CDiary();
            diary.tulis(title, content);
        }
        private void deleteDiary(int id){
            CDiary diary = new CDiary();
            diary.delete(id);
        }
        private void rewriteDiary(int id){
            CDiary diary = new CDiary();
            Console.WriteLine("Input new content: ");
            string content = Console.ReadLine();
            diary.update(id, content);
        }
        public void successupdate(){
            Console.WriteLine("Diary Updated!");
        }
        public void successdelete(){
            Console.WriteLine("Diary Deleted!");
        }
    }
}