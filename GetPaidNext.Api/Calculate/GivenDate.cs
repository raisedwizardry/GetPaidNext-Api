using System;

namespace GetPaidNext.Api.Calculate
{
    public class GivenDate
    {
        public DateTime parsedGivenDate;
        enum PayType { Biweekly=14, Weekly=7};
        private int frequency;
        public GivenDate(string date)
        {
            parsedGivenDate = DateTime.Parse(date);
        }

        public string BiweeklyNextPayDate()
        {
            frequency = (int)PayType.Biweekly;
            return NextPayDate(parsedGivenDate, frequency);

        }

        public string WeeklyNextPayDate()
        {
            frequency = (int)PayType.Weekly;
            return NextPayDate(parsedGivenDate, frequency);
        }

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
