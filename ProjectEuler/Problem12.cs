using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=12"/>
        /// </summary>
        public static long Problem12()
        {
            const int DIVISORS = 500;
            long triangleNumber = 0;

            for (int i = 1; i < int.MaxValue; i++)
            {
                triangleNumber += i;

                if (GetDivisorCount(triangleNumber) > DIVISORS)
                {
                    return triangleNumber;
                }
            }

            return -1;
        }

        /// <summary>
        /// Gets the total number of divisors for a number
        /// <example>
        /// <code> 28 returns 6 (1,2,4,7,14,28) </code>
        /// </example>
        /// </summary>
        /// <param name="value"></param>
        /// <returns> Divisor count </returns>
        public static int GetDivisorCount(long value)
        {
            int divisors = 0;

            // Every divisor below the square root has a corresponding divisor above the square root
            for (int i = 1; i <= Math.Sqrt(value); i++)
            {
                if (value % i == 0)
                {
                    divisors += 2;
                }
                // Square root divisors only count as 1
                if (i == Math.Sqrt(value))
                {
                    divisors -= 1;
                }
            }

            return divisors;
        }
    }
}
