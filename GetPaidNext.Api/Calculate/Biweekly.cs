using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetPaidNext.Api.Calculate
{
    public class Biweekly
    {
        public string NextPayDate(string givenDate)
        {
            DateTime parsedGivenDate = ParseGivenDate(givenDate);
            DateTime calculatedDate = DetermineNextDate(parsedGivenDate);
            var dateString = calculatedDate.ToShortDateString();
            return dateString;
        }

        private string NextMonthPayThreeTimes(string givenDate)
        {
            //notyetimplemented
        }
        private static DateTime ParseGivenDate(string givenDate)
        {
            DateTime parsedGivenDate = DateTime.Parse(givenDate);
            return parsedGivenDate;
        }

        private static DateTime DetermineNextDate(DateTime parsedGivenDate)
        {
            while (parsedGivenDate <= DateTime.Now)
            {
                parsedGivenDate = parsedGivenDate.AddDays(14);
            }   
            return parsedGivenDate;
        }
    }
}
