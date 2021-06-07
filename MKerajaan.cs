using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace gate_prjct
{
    public class MKerajaan
    {
        public void menu(){
            int option = 0;
            while (option != -1)
            {
                Console.WriteLine("Nusantara's Kingdoms Menu:");
                Console.WriteLine("1) Hindu's Era Kingdom\n2) Budha's Era Kingdom\n3) Islamic Era Kingdom\n-1) Back");
                Console.WriteLine("Input your choice: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        showdata("tbkhindu");
                        break;
                    case 2:
                        showdata("tbkbudha");
                        break;
                    case 3:
                        showdata("tbkislam");
                        break;
                    default:
                        break;
                } 
            }
        }
        private void showdata(string tabel){
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
                    datview = reader.GetInt32(0)+"\t"+reader.GetString(1)+Environment.NewLine;
                }
                Console.WriteLine(datview);
            }else{
                Console.WriteLine("Data Tidak Ditemukan!");
            }
            command.Cancel();
            reader.Close();
        }
        private void showdetail(){
            
        }
    }
}