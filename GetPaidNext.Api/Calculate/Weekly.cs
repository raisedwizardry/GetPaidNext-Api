using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetPaidNext.Api.Calculate
{
    public class Weekly : GivenDate
    {
        public Weekly(string date) : base(date) { }

        public string WeeklyNextPayDate()
        {
            frequency = (int)PayType.Weekly;
            return NextPayDate(parsedGivenDate, frequency);
        }

    }

}
