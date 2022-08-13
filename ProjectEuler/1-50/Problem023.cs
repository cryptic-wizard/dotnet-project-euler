using ProjectEuler.Utilities;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=23"/>
        /// </summary>
        public static long Problem023()
        {
            const int MAX_VALUE = 28123;
            const int MIN_VALUE = 12;
            Dictionary<int, int> abundantNumbersDictionary = new();
            long sum = 0;
            bool sumFound;

            // Generate abundant numbers dictionary
            Prime.GetPrimesUpTo((long)Math.Sqrt(MAX_VALUE));
            for (int i = 2; i <= MAX_VALUE; i++)
            {
                if (Prime.GetSumOfDivisors(i) > i)
                {
                    abundantNumbersDictionary.Add(i, i);
                }
            }

            // For every number
            for (int i = 1; i <= MAX_VALUE; i++)
            {
                sumFound = false;

                // For every abundant number 
                foreach (int a in abundantNumbersDictionary.Keys)
                {
                    if (a >= i + MIN_VALUE)
                    {
                        break;
                    }

                    // See if the paired abundant number exists
                    if (abundantNumbersDictionary.ContainsKey(i - a))
                    {
                        sumFound = true;
                    }
                }

                if (!sumFound)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
