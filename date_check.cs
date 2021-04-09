using System;
using System.IO;
namespace gate_prjct
{
    public class date_check
    {
        private string filename = "hariBersejarah";
        private static string date_cek;
        public void check(bool today){
            workspace work = new workspace();
            date_type date = new date_type();
            CHBersejarah eventH = new CHBersejarah();
            
            StreamReader txt = new StreamReader(work.workspaces+filename+".txt");
            
            if(today == true){
                date_cek = date.var_date();
            }else{
                date_cek = eventH.rdate();
            }
            string date_now = date.var_date();
            string date_base = txt.ReadLine();
            int count = 0;
            while (date_base != "-1")
            {
                if (date_now == date_base)
                {
                    date_event dayEvent = new date_event();
                    string day = dayEvent.eventDay(count);
                    Console.WriteLine(date_cek+"adalah "+day);
                }
                date_base = txt.ReadLine();
                count++;
            }
            Console.WriteLine("\n");
            txt.Close();
        }
        
    }
}