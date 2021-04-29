using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace gate_prjct
{
    public class MSearch
    {
        private string _keyword;
        public string keyword{
            get{return _keyword;}
            set{_keyword = value;}
        }
        public void search(string table, string coloumn, string id){
            connect data = new connect();
            
            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Selcet * from "+table+" where "+coloumn+" ='"+keyword+"'";

            MySqlDataReader search = command.ExecuteReader();
            var datsearch = "["+id+"]\t["+coloumn+"]";

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
    }
}