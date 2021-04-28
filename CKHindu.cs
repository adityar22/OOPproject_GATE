namespace gate_prjct
{
    public class CKHindu: AKerajaan
    {private string _kName;
        private string _kLocation;
        private int _kYear;
        private string _kFounder;
        public string kName{
            get{return _kName;}
            set{_kName = value;}
        }
        public string kLocation{
            get{return _kLocation;}
            set{_kLocation = value;}
        }
        public int kYear{
            get{return _kYear;}
            set{_kYear = value;}
        }
        public string kFounder{
            get{return _kFounder;}
            set{_kFounder = value;}
        }
    }
}