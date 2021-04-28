using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace gate_prjct
{
    public class CDiary
    {
        private string _judul;
        private string _konten;
        private DateTime _date;
        public string judul{
            get{return _judul;}
            set{_judul = value;}
        }
        public string konten{
            get{return _konten;}
            set{_konten = value;}
        }
        public DateTime date{
            get{return _date;}
            set{_date = value;}
        }
        public void tulis(){
            Console.WriteLine("Masukkan judul diary: ");
            judul = Console.ReadLine();
            Console.WriteLine("Tuliskan diary: ");
            konten = Console.ReadLine();

            date_type dat = new date_type();
            date = dat.today;

            connect data = new connect();

            MySqlCommand cmd = new MySqlCommand("Insert Into tbdiary(dTitle, dDate, dContent) Values('"+judul+"', '"+date+"', '"+konten+"')", data.connection);
            int i = cmd.ExecuteNonQuery();
            if(i>0){
                Console.WriteLine("Diary Updated!");
            }
        }
        public void tampil(){
            connect data = new connect();

            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Select * from tbdiary;";

            MySqlDataReader reader = command.ExecuteReader();

            var dataview = "[dId]\t[dTitle]\t[dDate]n";

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataview = reader.GetInt32(3) +"\t"+reader.GetString(0)+"\n"+reader.GetDateTime(0)+"\n"+reader.GetString(0)+Environment.NewLine;
                }
                Console.WriteLine(dataview);
            }else{
                Console.WriteLine("Diary tidak ditemukan");
            }
        }
        public void baca(int id){
            connect data = new connect();

            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Select * from tbdiary where dId in("+id+")";

            MySqlDataReader reader = command.ExecuteReader();

            var dataview = "[dId]\t[dTitle]\n[dDate]\n[dContent]\n";
            dataview = reader.GetInt32(3) +"\t"+reader.GetString(0)+"\n"+reader.GetDateTime(0)+"\n"+reader.GetString(0)+Environment.NewLine;

            Console.WriteLine(dataview);
        }
    }
}