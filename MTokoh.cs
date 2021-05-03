using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace gate_prjct
{
    public class MTokoh
    {
        public void menu(){
            int option = 0;
            while (option != -1)
            {
                Console.WriteLine("Menu Kerajaan");
                Console.WriteLine("Menu: (1)List Raja; (2)List Tokoh Lain; (-1)kembali");
                Console.WriteLine("Input pilihan: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        raja();
                        break;
                    case 2:
                        tokoh();
                        break;
                    default:
                        break;
                } 
            }
        }
        private void raja(){
            
        }
        private void tokoh(){
            
        }
        private void showdata(string tabel){
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