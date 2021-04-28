using System.Data;
using System;
using MySql.Data.MySqlClient;
namespace gate_prjct
{
    public class CHBersejarah
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

        public string cekdate(DateTime Date){
            connect data = new connect();
            
            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Select * from tbhari where hDate in ("+Date+")";
            var datview = Date;
            string day = datview.ToString();
            return day;
        }
    }
}