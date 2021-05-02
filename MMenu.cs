using System;
namespace gate_prjct
{
    public class MMenu
    {
        public void menu(){
            int input = 0;
                while (input != -1)
                {
                    Console.WriteLine("GATE's Menu: (1)Menu Calendar;\n (2)Menu Kingdom's Data;\n (3)Menu King's Data;\n (-1) Exit");
                    Console.WriteLine("Input Your Choice: ");
                    input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            kalender();
                            break;
                        case 2:
                            searchKerajaan();
                            break;
                        case 3:
                            searchTokoh();
                            break;
                        default:
                            Console.WriteLine("Your input is invalid!");
                            menu();
                            break;
                    }
                }
        }
        private static void kalender(){
            MKalender calendar = new MKalender();
            calendar.menu();
        }
        private  static void searchTokoh(){
            MTokoh tokoh = new MTokoh();
            tokoh.menu();
        }
        private static void searchKerajaan(){
           MKerajaan kerajaan = new MKerajaan();
           kerajaan.menu();
        }
    }
}