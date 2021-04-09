using System;
namespace gate_prjct
{
    public class CSearch
    {
        private static int pilihan = 0;
        private static int opsi = 0;
        private static string workfile = "";
        public void search(){
            CKerajaan kerajaan = new CKerajaan();
            CKIslam islam = new CKIslam();
            CKBudha budha = new CKBudha();
            CKHindu hindu = new CKHindu();

            Console.WriteLine("Pilih nomor menu: ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            opsi = kerajaan.opsi();
            switch (opsi)
            {
                case 1:
                    workfile = islam.rWorkfile();
                    break;
                case 2:
                    workfile = hindu.rWorkfile();
                    break;
                case 3:
                    workfile = budha.rWorkfile();
                    break;
                default:
                    break;
            }
            CShowData show = new CShowData();
            show.showdata(workfile, pilihan);
        }
    }
}