using System;
namespace gate_prjct
{
    public class date_type
    {
        private string _datetext;
        private DateTime _today;
        public DateTime today{
            get{return _today;}
            set{_today = value;}
        }
        public string datetext{
            get{return _datetext;}
            set{_datetext = value;}
        }
        public void date(){
            today = DateTime.Now;
            
            string day = DateTime.Today.ToString("dddd");
            string year = DateTime.Now.Year.ToString("0000");
            string month = DateTime.Now.Month.ToString("00");
            string date = DateTime.Now.Day.ToString("00");
            string month2 = "Januari";

            switch (month)
            {
                case "01":
                    month2 = "Januari";
                    break;
                case "02":
                    month2 = "Februari";
                    break;
                case "03":
                    month2 = "Maret";
                    break;
                case "04":
                    month2 = "April";
                    break;
                case "05":
                    month2 = "Mei";
                    break;
                case "06":
                    month2 = "Juni";
                    break;
                case "07":
                    month2 = "Juli";
                    break;
                case "08":
                    month2 = "Agustus";
                    break;
                case "09":
                    month2 = "September";
                    break;
                case "10":
                    month2 = "Oktober";
                    break;
                case "11":
                    month2 = "November";
                    break;
                case "12":
                    month2 = "Desember";
                    break;
                default:
                    break;
            }            
            datetext = day+", "+date+" "+month2+" "+year;
        }
    }
}