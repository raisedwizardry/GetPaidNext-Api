using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetPaidNext.Calculate
{
    public class Weekly
    {
        public static String NextPayDate(String givenDate)
        {
            DateTime parsedGivenDate = ParseGivenDate(givenDate);
            DateTime calculatedDate = DetermineNextDate(parsedGivenDate);
            var dateString = calculatedDate.ToShortDateString();
            return dateString;
        }

        public static DateTime ParseGivenDate(String givenDate)
        {
            DateTime parsedGivenDate = DateTime.Parse(givenDate);
            return parsedGivenDate;
        }

        public static DateTime DetermineNextDate(DateTime parsedGivenDate)
        {
            while (parsedGivenDate <= DateTime.Now)
            {
                parsedGivenDate = parsedGivenDate.AddDays(7);
            }
            return parsedGivenDate;
        }
    }
}
