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
        public CCalendar(DateTime Date, string Title, string Content){
            date = Date;
            title = Title;
            content = Content;
        }
        public CCalendar(DateTime Date){
            date = Date;
        }
        public CCalendar(){}
        public void inSchedule(){
            connect data = new connect();
            MySqlCommand cmd = new MySqlCommand("Insert Into tbhari(h_Title, h_Date, h_Content) Values('"+title+"', @1, '"+content+"')", data.connection);
            cmd.Parameters.AddWithValue("@1", date);
            int i = cmd.ExecuteNonQuery();
            if(i>0){
                MCalendar calendar = new MCalendar();
                cmd.Cancel();
                calendar.successupdate();
            }
            cmd.Cancel();
        }
        public string checkSchedule(){
            connect data = new connect();
            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Select * from tbhari where h_Date in ('"+date+"')";

            MySqlDataReader check = command.ExecuteReader();
            var datview = "[h_Title]";
            if(check.HasRows){
                datview = check.GetString(1);
                title = datview.ToString();
                command.Cancel();
                check.Close();
                return title;
            }else{
                command.Cancel();
                check.Close();
                return "You dont have any schedule today";
            }
        }
        public void deleteSchedule(int Id){
            connect data = new connect();

            MySqlCommand cmd = new MySqlCommand("Delete from tbhari where h_Id = '"+Id+"'", data.connection);
            int i = cmd.ExecuteNonQuery();
            if(i>0){
                MCalendar calendar = new MCalendar();
                calendar.successdelete();
            }
        }
    }
}