using System;

namespace GetPaidNext.Api.Calculate
{
    public abstract class GivenDate
    {
        public DateTime parsedGivenDate;
        public enum PayType { Biweekly=14, Weekly=7, Monthly=1, Bimonthly=2 };
        public int frequency;

        public GivenDate(string date)
        {
            parsedGivenDate = DateTime.Parse(date);
        }

    }

}
