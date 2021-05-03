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
                Console.WriteLine("Menu Kerajaan");
                Console.WriteLine("1) Kerajaan Hindu\n2) Kerajaan Budha\n3) Kerajaan Islam\n-1) Back");
                Console.WriteLine("Input your choice: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        hindu();
                        break;
                    case 2:
                        budha();
                        break;
                    case 3:
                        islam();
                        break;
                    default:
                        break;
                } 
            }
        }

        private void hindu(){
            CKHindu hindu = new CKHindu();

            int option = 0;
            Console.WriteLine("1) Tambah Data\n2) Baca Data\n-1) Back");
            switch (option)
            {
                case 1:
                    adddata();
                    break;
                case 2:
                    showdata("tbkhindu");
                    break;
                default:
                    break;
            }
        }
        private void budha(){
            CKBudha budha = new CKBudha();
            
            int option = 0;
            Console.WriteLine("1) Tambah Data\n2) Baca Data\n-1) Back");
            switch (option)
            {
                case 1:
                    adddata();
                    break;
                case 2:
                    showdata("tbkbudha");
                    break;
                default:
                    break;
            }
        }
        private void islam(){
            CKIslam islam = new CKIslam();
            
            int option = 0;
            Console.WriteLine("1) Tambah Data\n2) Baca Data\n-1) Back");
            switch (option)
            {
                case 1:
                    adddata();
                    break;
                case 2:
                    showdata("tbkislam");
                    break;
                default:
                    break;
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
                    datview = reader.GetInt32(3)+"\t"+reader.GetString(0)+Environment.NewLine;
                }
                Console.WriteLine(datview);
            }else{
                Console.WriteLine("Data Tidak Ditemukan!");
            }
            command.Cancel();
            reader.Close();
        }
        private void adddata(){

        }
    }
}