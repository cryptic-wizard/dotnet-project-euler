using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=10"/>
        /// </summary>
        public static long Problem10()
        {
            List<uint> primes = new();
            const uint MAX_VALUE = 2000000;
            bool isPrime = true;
            double sqrt;
            long answer = 0;
            primes.Add(2);

            // For every odd number
            for (uint i = 3; i < MAX_VALUE; i += 2)
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

            // Calculate sum
            foreach (uint n in primes)
            {
                answer += n;
            }

            return answer;
        }
    }
}
