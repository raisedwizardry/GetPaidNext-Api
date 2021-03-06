﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetPaidNext.Api.Calculate
{
    public class Biweekly : PerWeek
    {
        public Biweekly(string date) : base(date) { }

        public string NextPayDate()
        {
            frequency = (int)PayType.Biweekly;
            return NextPayDate(parsedGivenDate, frequency);
        }

    }

}
