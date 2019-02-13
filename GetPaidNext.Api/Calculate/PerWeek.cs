using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetPaidNext.Api.Calculate
{
    public class PerWeek : GivenDate
    {
        public PerWeek(string date) : base(date) { }

        public static string NextPayDate(DateTime date, int frequency)
        {
            DateTime calculatedDate = DetermineNextDate(date, frequency);
            var dateString = calculatedDate.ToShortDateString();
            return dateString;
        }

        public static DateTime DetermineNextDate(DateTime date, int frequency)
        {
            while (date <= DateTime.Now)
            {
                date = date.AddDays(frequency);
            }
            return date;
        }
    }
}
