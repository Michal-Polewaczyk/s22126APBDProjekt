using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class CommonDateNotationConverter
    {
        public string FormatDateTimeToApiFriendlyFormat(DateTime date)
        {
            string day = date.Day.ToString();
            string month = date.Month.ToString();
            if (day.Length == 1)
            {
                day = "0" + day;
            }
            if (month.Length == 1)
            {
                month = "0" + month;
            }

            return $"{date.Year}-{month}-{day}";
        }
}
