using ProjectEuler.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=19"/>
        /// </summary>
        public static long Problem19()
        {
            DateTime endDate = new(2000, 12, 31);
            DateTime date = new(1901, 1, 1); // Tuesday
            int sundays = 0;


            if (date.DayOfWeek != DayOfWeek.Sunday)
            {
                date = date.AddDays(7 - (int)date.DayOfWeek);
            }

            while (date.CompareTo(endDate) <= 0)
            {
                if (date.DayOfWeek == DayOfWeek.Sunday && date.Day == 1)
                {
                    sundays++;
                }

                date = date.AddDays(7);
            }

            return sundays;
        }
    }
}
