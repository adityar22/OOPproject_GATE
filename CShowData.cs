using System;
using System.IO;
namespace gate_prjct
{
    public class CShowData
    {
        private static string kalimat = "";
        public void showdata(string workfile, int pilihan){
            StreamReader txt = new StreamReader(workfile);
            StreamReader txt2 = new StreamReader(workfile);
            StreamReader txt3 = new StreamReader(workfile);
            StreamReader txt4 = new StreamReader(workfile);
            string nama, lokasi, raja, tahun;
            nama = "";
            for (int i = 0; i < pilihan; i++)
            {
                nama = txt.ReadLine();
            }
            lokasi = "";
            while(lokasi != "-1"){
                lokasi = txt.ReadLine();
            }
            for (int i = 0; i < pilihan; i++)
            {
                lokasi = txt.ReadLine();
            }
            raja = "";
            while(raja != "-2"){
                raja = txt.ReadLine();
            }
            for (int i = 0; i < pilihan; i++)
            {
                raja = txt.ReadLine();
            }
            tahun = "";
            while (tahun != "-3")
            {
                tahun = txt.ReadLine();
            }
            for (int i = 0; i < pilihan; i++)
            {
                tahun = txt.ReadLine();
            }
            kalimat = nama+" merupakan kerajaan yang berlokasi di "+lokasi+" yang berdiri pada tahun "+tahun+", dan didirikan oleh "+raja;
            Console.WriteLine(kalimat);
        }
    }
}