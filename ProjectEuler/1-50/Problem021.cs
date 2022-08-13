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
        /// <see href="https://projecteuler.net/problem=21"/>
        /// </summary>
        public static long Problem021()
        {
            const int NUMBER = 10000;
            Dictionary<int, long> sumOfDivisorsDictionary = new();
            long sum = 0;

            // Generate sum of divisor dictionary
            Prime.GetPrimesUpTo(NUMBER);
            for (int i = 0; i < NUMBER; i++)
            {
                sumOfDivisorsDictionary.Add(i, Prime.GetSumOfDivisors(i));
            }

            // Sum the amicable numbers in sum of divisor dictionary
            foreach (KeyValuePair<int, long> a in sumOfDivisorsDictionary)
            {
                // Amicable number conditions
                foreach (KeyValuePair<int, long> b in sumOfDivisorsDictionary
                    .Where(b => b.Value == a.Key && b.Key == a.Value && b.Key != b.Value))
                {
                    sum += a.Key;
                    sum += a.Value;
                    sumOfDivisorsDictionary.Remove(a.Key);
                    sumOfDivisorsDictionary.Remove((int)a.Value);
                }
            }

            return sum;
        }
    }
}
