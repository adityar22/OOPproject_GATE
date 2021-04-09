using System;
using System.IO;
namespace gate_prjct
{
    public class date_event
    {
        private string filename = "hariBersejarah";
        public string eventDay(int count){
            workspace work = new workspace();
            StreamReader txt = new StreamReader(work.workspaces+filename+".txt");
            string hari = "";
            while(hari != "-1")
            {
                hari = txt.ReadLine();
            }
            for (int i = 0; i <= count; i++)
            {
                hari = txt.ReadLine();
            }
            return hari;
        }
    }
}