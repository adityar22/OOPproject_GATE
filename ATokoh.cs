using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace gate_prjct
{
    public abstract class ATokoh
    {
        private string _name;
        private string _kerajaan;
        private string _birth;
        private string _die;
        public void tampil(string tabel){
            connect data = new connect();

            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Select * from "+tabel;

            MySqlDataReader reader = command.ExecuteReader();
            var datview = "[tId]\t[tName]";

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    datview = reader.GetInt32(3)+"\t"+reader.GetString(0)+Environment.NewLine;
                }
                Console.WriteLine(datview);
            }else{
                Console.WriteLine("Data Tidak Ditemukan!");
            }
            command.Cancel();
            reader.Close();
        }
    }
}