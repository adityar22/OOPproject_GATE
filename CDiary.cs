using System.Text;
using System;
using System.IO;
namespace gate_prjct
{
    public class CDiary
    {
        private string filename = "diary";
        FileStream stream = null;
        public void tulis(){
            workspace work = new workspace();
            stream = new FileStream(work.workspaces+filename+".txt", FileMode.Open);
            using(StreamWriter writer = new StreamWriter(stream, Encoding.UTF8)){
                string text;
                Console.WriteLine("Masukkan catatan diary: ");
                text = Console.ReadLine();
                writer.WriteLine(text);
            }
            stream.Close();
            date_set set = new date_set();
            set.setDate();
        }
        public void baca(){
            workspace work = new workspace();
            StreamReader txt = new StreamReader(work.workspaces+filename+".txt");
            string line = txt.ReadLine();
            Console.WriteLine("This Feature is under construction");
            txt.Close();
        }
    }
}