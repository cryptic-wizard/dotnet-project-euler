using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=10"/>
        /// </summary>
        public static long Problem010()
        {
            const uint MAX_VALUE = 2000000;
            long answer = 0;
            List<uint> primes = PrimesUpTo(MAX_VALUE);

            // Calculate sum
            foreach (uint n in primes)
            {
                answer += n;
            }

            return answer;
        }

        /// <summary>
        /// <example>
        /// <code> { 2, 3, 5, 7, 11, 13, 17, 19, ... } </code>
        /// </example>
        /// </summary>
        /// <param name="maxValue"> Upper-bound of primes </param>
        /// <returns> A list of primes </returns>
        public static List<uint> PrimesUpTo(long maxValue)
        {
            List<uint> primes = new();
            bool isPrime = true;
            double sqrt;
            
            primes.Add(2);

            // For every odd number
            for (uint i = 3; i < maxValue; i += 2)
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

                // Update primes list
                if (isPrime)
                {
                    primes.Add(i);
                }
                else
                {
                    isPrime = true;
                }
            }

            return primes;
        }
    }
}
