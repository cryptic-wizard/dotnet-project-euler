using ProjectEuler.Utilities;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=30"/>
        /// </summary>
        public static long Problem030()
        {
            int MAX_VALUE;
            int sum, totalSum = 0;
            int value, digit;
            Dictionary<int, int> powers = new();

            // Generate 5th power dictionary
            for (int i = 0; i < 10; i++)
            {
                powers.Add(i, (int)Math.Pow(i, 5));
            }

            MAX_VALUE = 5 * powers[9]; // Max sum = all 9s

            for (int i = 2; i < MAX_VALUE; i++)
            {
                sum = 0;
                value = i;

                // Parse digits
                while (value > 0)
                {
                    digit = value % 10;
                    sum += powers[digit];
                    value /= 10;
                }

                if (sum == i)
                {
                    //Console.WriteLine(sum.ToString());
                    totalSum += sum;
                }
            }

            return totalSum;
        }
    }
}
