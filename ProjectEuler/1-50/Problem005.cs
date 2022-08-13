using System;
using System.Collections.Generic;
using ProjectEuler.Utilities;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=5"/>
        /// </summary>
        public static long Problem005()
        {
            // Numbers divisible by 20 are also divisible by 2,4,5,10
            // Numbers divisible by 18 are also divisble by 2,3,6,9
            // Numbers divisible by 16 are also divisible by 2,4,8
            // Numbers divisible by 12 are also divisible by 2,3,4,6 which is redundant with 16,18
            const int NUMBER = 20;
            List<long> divisors = new() { 20, 18, 16 };

            // To be divisible by a prime, the number must be a product of the prime
            List<long> primes = Prime.GetPrimesUpTo(NUMBER);
            long primeIncrement = 1;
            
            foreach (long p in primes)
            {
                primeIncrement *= p;
            }

            for (long i = primeIncrement; i < long.MaxValue; i += primeIncrement)
            {
                foreach (long divisor in divisors)
                {
                    if (i%divisor == 0)
                    {
                        if (divisor == divisors[divisors.Count - 1])
                        {
                            return i;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return -1;
        }
    }
}
