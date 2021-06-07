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
                Console.WriteLine("Input your choice: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        cari();
                        break;
                    case 2:
                        tampil();
                        break;
                    case 3:
                        tulis();
                        break;
                    default:
                        Console.WriteLine("Input a valid option!");
                        break;
                } 
            }
        }
        private void cari(){
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
        private void tampil(){
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
                    dataview = reader.GetInt32(0) +"\t"+reader.GetString(1)+"\t"+reader.GetDateTime(2)+"\t"+reader.GetString(3)+Environment.NewLine;
                }
                Console.WriteLine(dataview);
            }
            else{
                Console.WriteLine("Diary is Empty");
            }reader.Close();
        }
        private void baca(int id){
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
                  dataview = reader.GetInt32(3) +"\t"+reader.GetString(0)+"\n"+reader.GetDateTime(0)+"\n"+reader.GetString(0)+Environment.NewLine;  
                }
                Console.WriteLine(dataview);
            }else{
                Console.WriteLine("Diary's Id is invalid");
            }reader.Close();
        }
        private void tulis(){
            Console.WriteLine("Input diary's title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Input diary's content: ");
            string content = Console.ReadLine();

            CDiary diary = new CDiary();
            diary.tulis(title, content);
        }
        private void hapus(int id){
            CDiary diary = new CDiary();
            diary.delete(id);
        }
        private void update(int id){
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