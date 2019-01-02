﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetPaidNext
{
    public class BiweeklyCalculate
    {
        public static String GiveNextDate(String givenDate)
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

        public static String GiveDayOfWeek(DateTime givenDate)
        {
            String givenDayOfWeek = new String(givenDate.DayOfWeek.ToString());
            return givenDayOfWeek;
        }

        public static DateTime DetermineNextDate(DateTime parsedGivenDate)
        {
            while (parsedGivenDate <= DateTime.Now)
            {
                parsedGivenDate = parsedGivenDate.AddDays(14);
            }   
            return parsedGivenDate;
        }
    }
}
