using System;
namespace gate_prjct
{
    public class MKerajaan
    {
        public void menu(){
            int option = 0;
            while (option != -1)
            {
                Console.WriteLine("Menu Kerajaan");
                Console.WriteLine("Menu: (1)Kerajaan Hindu; (2)Kerajaan Budha; (3)Kerajaan Islam; (-1)kembali");
                Console.WriteLine("Input pilihan: ");
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
            hindu.tampil("tbkhindu");
        }
        private void budha(){
            CKBudha budha = new CKBudha();
            budha.tampil("tbkbudha");
        }
        private void islam(){
            CKIslam islam = new CKIslam();
            islam.tampil("tbkislam");
        }
    }
}