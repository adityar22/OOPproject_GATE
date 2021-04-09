using System;
using System.IO;
namespace gate_prjct
{
    public abstract class AKerajaan
    {
        private static int totalData;
        public void setArray(string[] kArray, string workspace){
            StreamReader txt = new StreamReader(workspace);
            string line = txt.ReadLine();
            int count = 0;
            while(line != "-1"){
                kArray[count] = line;
                totalData = count;
                count++;
                line = txt.ReadLine();
            }
        }
        public void showArray(string[] kArray, int count){
            count = 0;
            while (kArray[count] != null)
            {
                Console.WriteLine(count+1+" "+kArray[count]);
                count++;
            }
        }
    }
}