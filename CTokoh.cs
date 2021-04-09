using System;
namespace gate_prjct
{
    public class CTokoh
    {
        public void menu(){
            int option = 0;
            while (option != -1)
            {
                Console.WriteLine("Pilih Kategori Raja");
                Console.WriteLine("Menu: (1)Raja; (2)Tokoh Lain; (-1)Kembali;");
                Console.WriteLine("Input pilihan: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        raja();
                        break;
                    case 2:
                        tokohLain();
                        break;
                    default:
                        break;
                }  
            }
        }
        private void raja(){
            Console.WriteLine("This Feature is under construction");
        }
        private void tokohLain(){
            Console.WriteLine("This Feature is under construction");
        }
    }
}