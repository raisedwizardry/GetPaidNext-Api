using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetPaidNext.Api.Calculate
{
    public class Bimonthly : PerMonth
    {
        public Bimonthly(string date) : base(date) { }

        public string NextPayDate()
        {
            frequency = (int)PayType.Bimonthly;
            return NextPayDate(parsedGivenDate, frequency);
        }
    }
}
