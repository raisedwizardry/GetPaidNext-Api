using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetPaidNext.Api.Calculate
{
    public class Monthly : PerMonth
    {
        public Monthly(string date) : base(date) { }

        public string NextPayDate()
        {
            frequency = (int)PayType.Monthly;
            return NextPayDate(parsedGivenDate, frequency);
        }
    }
}
