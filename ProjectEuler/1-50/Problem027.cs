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
        /// <see href="https://projecteuler.net/problem=27"/>
        /// </summary>
        public static long Problem027()
        {
            const int NUMBER = 1000;
            long primes, maxPrimes = 0;
            long product = 0;
            //Prime.GetPrimesUpTo(2*(long)Math.Pow(NUMBER, 2) + NUMBER);

            // n*n + a*n + b = A_PRIME_NUMBER
            // When n = 0
            // (0)(0) + (a)(0) + b = A_PRIME_NUMBER
            // b = PRIME_NUMBER
            List<long> possibleB = Prime.GetPrimesUpTo(NUMBER);

            for (int a = -NUMBER + 1; a < NUMBER; a++)
            {
                foreach (long b in possibleB)
                {
                    // When n = 1
                    // (1)(1) + (a)(1) + b >= 3 (2nd prime)
                    // 1 + a + b >= 3
                    // a + b >= 2
                    if (a + b < 2)
                    {
                        continue;
                    }

                    primes = GetConsecutivePrimes(a, (int)b);

                    if (primes > maxPrimes)
                    {
                        maxPrimes = primes;
                        product = a * b;
                    }
                }
            }

            return product;
        }

        private static long GetConsecutivePrimes(int a, int b)
        {
            long value, primes = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                value = i * i + a * i + b;

                if (Prime.IsPrime(value))
                {
                    primes++;
                }
                else
                {
                    break;
                }
            }

            return primes;
        }
    }
}
