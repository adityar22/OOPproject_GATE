using System;
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
            CRaja raja = new CRaja();
            raja.tampil("tbraja");
        }
        private void tokoh(){
            CTokohLain tokoh = new CTokohLain();
            tokoh.tampil("tbtokoh");
        }
    }
}