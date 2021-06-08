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
                MDiary calendar = new MDiary();
                cmd.Cancel();
                calendar.successupdate();
            }
            cmd.Cancel();
        }
        public void delete(int id){
            connect data = new connect();

            MySqlCommand cmd = new MySqlCommand("Delete from tbdiary where dId = '"+id+"'", data.connection);
            int i = cmd.ExecuteNonQuery();
            if(i>0){
                MDiary calendar = new MDiary();
                calendar.successdelete();
            }
        }
        public void update(int id, string content){
            connect data = new connect();

            MySqlCommand cmd = new MySqlCommand("Update tbdiary set dContent = '"+content+"' where dId = '"+id+"'", data.connection);
            int i = cmd.ExecuteNonQuery();
            if(i>0){
                MDiary calendar = new MDiary();
                calendar.successupdate();
            }
            cmd.Cancel();
        }
    }
}