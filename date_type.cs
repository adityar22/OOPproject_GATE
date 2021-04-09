using System;
namespace gate_prjct
{
    public class date_type
    {
        public void date(){
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
            Console.WriteLine(day+", "+date+" "+month2+" "+year);
        }
        public string var_date(){
            string dateNow = "";
            string month = DateTime.Now.Month.ToString("00");
            string date = DateTime.Now.Day.ToString("00");
            switch (month)
            {
                case "01":
                    month = "Januari";
                    break;
                case "02":
                    month = "Februari";
                    break;
                case "03":
                    month = "Maret";
                    break;
                case "04":
                    month = "April";
                    break;
                case "05":
                    month = "Mei";
                    break;
                case "06":
                    month = "Juni";
                    break;
                case "07":
                    month = "Juli";
                    break;
                case "08":
                    month = "Agustus";
                    break;
                case "09":
                    month = "September";
                    break;
                case "10":
                    month = "Oktober";
                    break;
                case "11":
                    month = "November";
                    break;
                case "12":
                    month = "Desember";
                    break;
                default:
                    break;
            }
            dateNow = date+" "+month;
            return dateNow;
        }
    }
}