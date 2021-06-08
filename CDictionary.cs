
namespace gate_prjct
{
    public class CDictionary
    {
        private string _word;
        private string _mean;
        private string[] _synonim =  new string[10];
        public string word{
            get{return _word;}
            set{_word = value;}
        }
        public string mean{
            get{return _mean;}
            set{_mean = value;}
        }
        public string[] synonym{
            get{return _synonim;}
            set{_synonim = value;}
        }
        public void wordMean(){

        }
        public void wordSynonim(){
            
        }
    }
}