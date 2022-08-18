using ProjectEuler.Utilities;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using static ProjectEuler.Utilities.Palindrome;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=37"/>
        /// </summary>
        public static long Problem037()
        {
            const int NUMBER = 1000000;
            const int PRIME_COUNT = 11;
            const int MINIMUM_PRIME = 7;
            long sum = 0, count = 0;
            List<long> primes = Prime.GetPrimesUpTo(NUMBER);

            foreach (long prime in primes)
            {
                if (prime <= MINIMUM_PRIME)
                {
                    continue;
                }

                if (Prime.IsTruncatable(prime))
                {
                    sum += prime;
                    count++;

                    if (count == PRIME_COUNT)
                    {
                        break;
                    }
                }
            }

            return sum;
        }
    }
}
