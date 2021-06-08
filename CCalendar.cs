using System.Data;
using System;
using MySql.Data.MySqlClient;
namespace gate_prjct
{
    public class CCalendar
    {
        private string _title;
        private DateTime _date;
        private string _content;
        public string title{
            get{return _title;}
            set{_title = value;}
        }
        public DateTime date{
            get{return _date;}
            set{_date = value;}
        }
        public string content{
            get{return _content;}
            set{_content = value;}
        }
        public void inSchedule(){
            connect data = new connect();
        }
        public string checkSchedule(){
            connect data = new connect();
            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Select * from tbhari where hDate in ("+date+")";

            MySqlDataReader check = command.ExecuteReader();
            var datview = "[hID]\t[hName]";
            if(check.HasRows){
                datview = check.GetString(1);
            }
            title = datview.ToString();
            return title;
        }
        public string getDetail(){
            return content;
        }
    }
}