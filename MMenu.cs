using System;
namespace gate_prjct
{
    public class MMenu
    {
        public void menu(){
            int input = 0;
                while (input != -1)
                {
                    Console.WriteLine("GATE's Menu:\n (1)Diary & Calendar;\n (2)Kingdom's Data;\n (-1) Logout");
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
                        case -1:
                            MLogin login = new MLogin();
                            login.signorlogin();
                            break;
                        default:
                            Console.WriteLine("Your input is invalid!");
                            menu();
                            break;
                    }
                }
        }
        private static void kalender(){
            MDiary calendar = new MDiary();
            calendar.menu();
        }
        private static void searchKerajaan(){
           MKerajaan kerajaan = new MKerajaan();
           kerajaan.menu();
        }
    }
}