using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace gate_prjct
{
    public abstract class AKerajaan
    {
        private string _kName;
        private string _kLocation;
        private int _kYear;
        private string _kFounder;
        public void tampil(string tabel){
            connect data = new connect();

            MySqlCommand command = data.connection.CreateCommand();
            command.CommandText = CommandType.Text.ToString();
            command.CommandText = "Select * from "+tabel;

            MySqlDataReader reader = command.ExecuteReader();
            var datview = "[kId]\t[kName]";

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