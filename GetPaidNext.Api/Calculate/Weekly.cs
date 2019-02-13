using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetPaidNext.Api.Calculate
{
    public class Weekly : PerWeek
    {
        public Weekly(string date) : base(date) { }

        public string NextPayDate()
        {
            frequency = (int)PayType.Weekly;
            return NextPayDate(parsedGivenDate, frequency);
        }

    }

}
