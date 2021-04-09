using System;
namespace gate_prjct
{
    public class CHBersejarah
    {
        private static string date;
        public void inputDate(){
            Console.WriteLine("Masukkan Tanggal (format dd): ");
            date = Console.ReadLine();
            Console.WriteLine("Masukkan Bulan (format: bulan): ");
            date = date+" "+Console.ReadLine();

            date_check cek = new date_check();
            cek.check(false);
        }
        public string rdate(){
            return date;
        }
    }
}