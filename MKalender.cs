using System;
namespace gate_prjct
{
    public class MKalender
    {
        public void menu(){
            int option = 0;
            while (option != -1)
            {
                Console.WriteLine("Kalender GATE");
                Console.WriteLine("Menu: (1)Cek Hari Bersejarah;\n (2)Baca Diary;\n (3)Tulis Diary;\n (4)Cari Judul Diary;\n (-1)kembali");
                Console.WriteLine("Input pilihan: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        cek();
                        break;
                    case 2:
                        tampil();
                        break;
                    case 3:
                        tulis();
                        break;
                    case 4:
                        cari();
                        break;
                    default:
                        break;
                } 
            }
        }
        private void cek(){
            CHBersejarah hari = new CHBersejarah();
            Console.WriteLine("This feature is under construction");
        }
        private void tampil(){
            CDiary diary = new CDiary();
            diary.tampil();
        }
        private void tulis(){
            CDiary diary = new CDiary();
            diary.tulis();
        }
        private void cari(){
            MSearch find = new MSearch();
            Console.WriteLine("Masukkan keyword: ");
            find.keyword = Console.ReadLine();
            find.search("tdiary", "dTitle", "dId");
        }
    }
}