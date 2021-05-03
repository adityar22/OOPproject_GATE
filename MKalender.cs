using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace gate_prjct
{
    public class MKalender
    {
        public void menu(){
            int option = 0;
            while (option != -1)
            {
                Console.WriteLine("Gate's Day Menu");
                Console.WriteLine("1) Calendar;\n2) Search Diary;\n3) Show List Diary;\n4) Write Diary;\n-1) Back");
                Console.WriteLine("Input your choice: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        cek();
                        break;
                    case 2:
                        cari();
                        break;
                    case 3:
                        tampil();
                        break;
                    case 4:
                        tulis();
                        break;
                    default:
                        break;
                } 
            }
        }
        private void cek(){
            CHBersejarah hari = new CHBersejarah();
            Console.WriteLine("This feature is under construction");
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
                    dataview = reader.GetInt32(3) +"\t"+reader.GetString(0)+"\n"+reader.GetDateTime(0)+"\n"+reader.GetString(0)+Environment.NewLine;
                }
                Console.WriteLine(dataview);
            }
            else{
                Console.WriteLine("Diary tidak ditemukan");
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
                Console.WriteLine("Diary tidak ditemukan");
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
        private void cari(){
            MSearch find = new MSearch();
            Console.WriteLine("Masukkan keyword: ");
            find.keyword = Console.ReadLine();
            find.search("tdiary", "dTitle", "dId");
        }
        private void hapus(){
            CDiary diary = new CDiary();
            diary.delete();
        }
        private void update(){

        }
        public void successupdate(){
            Console.WriteLine("Diary Updated!");
        }
    }
}