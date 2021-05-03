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
        public void tulis(string judul, string konten){
            connect data = new connect();

            MySqlCommand cmd = new MySqlCommand("Insert Into tbdiary(dTitle, dDate, dContent) Values('"+judul+"', @1, '"+konten+"')", data.connection);
            cmd.Parameters.AddWithValue("@1", DateTime.Now);
            int i = cmd.ExecuteNonQuery();
            if(i>0){
                MKalender calendar = new MKalender();
                calendar.successupdate();
            }
            cmd.Cancel();
        }
        public void delete(){
            
        }
        public void update(){

        }
    }
}