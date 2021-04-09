using System;
namespace gate_prjct
{
    public class CKerajaan
    {
        private static int option = 0;
        public void menu(){
            option = 0;
            while (option != -1)
            {
                Console.WriteLine("Piih kategori Kerajaan");
                Console.WriteLine("Menu: (1)Kerajaan Islam; (2)Kerajaan Hindu; (3)Kerajaan Budha; (-1)kembali;");
                Console.WriteLine("Input pilihan: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        kIslam();
                        break;
                    case 2:
                        kHindu();
                        break;
                    case 3:
                        kBudha();
                        break;
                    default:
                        break;
                }
            }
        }
        private void kIslam(){
            CKIslam islam = new CKIslam();
            islam.setData();
            CSearch search = new CSearch();
            search.search();
        }
        private void kHindu(){
            CKHindu hindu = new CKHindu();
            hindu.setData();
            CSearch search = new CSearch();
            search.search();
        }
        private void kBudha(){
            CKBudha budha = new CKBudha();
            budha.setData();
            CSearch search = new CSearch();
            search.search();
        }
        public int opsi(){
            return option;
        }
    }
}