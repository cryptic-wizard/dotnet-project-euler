using System;
using System.Collections.Generic;
using ProjectEuler.Utilities;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=7"/>
        /// </summary>
        public static long Problem7()
        {
            List<uint> primes = new();
            const uint TARGET_PRIME = 10001;
            bool isPrime = true;
            double sqrt;
            primes.Add(2);

            // For every odd number
            for (uint i = 3; i < uint.MaxValue; i += 2)
            {
                sqrt = Math.Sqrt(i);

                // See if the number is divisible by all of the primes less than it
                foreach (uint n in primes)
                {
                    // Numbers above the square root are redundant
                    if (n > sqrt)
                    {
                        break;
                    }
                    else if (i % n == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                // Update prime list or return with 10001th prime
                if (isPrime && primes.Count == TARGET_PRIME - 1)
                {
                    return i;
                }
                else if (isPrime)
                {
                    primes.Add(i);
                }
                else
                {
                    isPrime = true;
                }
            }

            return -1;
        }
    }
}
