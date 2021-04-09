using System.Text;
using System;
using System.IO;
namespace gate_prjct
{
    public class date_set
    {
        FileStream stream;
        private string filename = "tgl_diary";
        public void setDate(){
            date_type cek = new date_type();
            workspace work = new workspace();
            stream = new FileStream(work.workspaces+filename+".txt", FileMode.Open);
            using(StreamWriter writer = new StreamWriter(stream, Encoding.UTF8)){
                string datenow = cek.var_date();
                writer.WriteLine(datenow);
            }
            stream.Close();
        }
    }
}