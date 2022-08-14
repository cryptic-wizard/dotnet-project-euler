using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Utilities
{
    /// <summary>
    /// Prime helper class
    /// </summary>
    public static class Prime
    {
        private static readonly List<long> PrimeDictionary = new()
        {
            2, 3
        };

        /// <summary>
        /// Gets a list of primes up to the input
        /// </summary>
        /// <param name="seed"></param>
        /// <returns> List of primes </returns>
        public static List<long> GetPrimesUpTo(long seed)
        {
            bool isPrime = true;
            long sqrt;
            List<long> primes = new();

            // Copy known primes
            foreach (long n in PrimeDictionary)
            {
                if (n <= seed)
                {
                    primes.Add(n);
                }
                else
                {
                    break;
                }
            }

            if (PrimeDictionary[PrimeDictionary.Count - 1] >= seed)
            {
                return primes;
            }

            // Calculate new primes
            for (long i = PrimeDictionary[PrimeDictionary.Count - 1] + 2; i <= seed; i += 2)
            {
                sqrt = (long)Math.Sqrt(i);

                // See if the number is divisible by all of the primes less than it
                foreach (long n in PrimeDictionary)
                {
                    // If number is divisible by a prime, it is not a prime
                    if (i % n == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else if (n > sqrt) // Numbers above the square root are redundant
                    {
                        break;
                    }
                }

                // Update prime list
                if (isPrime)
                {
                    primes.Add(i);
                    PrimeDictionary.Add(i);
                }
                else
                {
                    isPrime = true;
                }
            }

            return primes;
        }

        /// <summary>
        /// Calculates a static list of primes up to the value
        /// </summary>
        /// <param name="seed"></param>
        public static void CalculatePrimesUpTo(long seed)
        {
            bool isPrime = true;
            long sqrt;

            // Calculate new primes
            for (long i = PrimeDictionary[PrimeDictionary.Count - 1] + 2; i <= seed; i += 2)
            {
                sqrt = (long)Math.Sqrt(i);

                // See if the number is divisible by all of the primes less than it
                foreach (long n in PrimeDictionary)
                {
                    // If number is divisible by a prime, it is not a prime
                    if (i % n == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else if (n > sqrt) // Numbers above the square root are redundant
                    {
                        break;
                    }
                }

                // Update prime list
                if (isPrime)
                {
                    PrimeDictionary.Add(i);
                }
                else
                {
                    isPrime = true;
                }
            }
        }

        /// <summary>
        /// Gets the largest prime factor of a number
        /// </summary>
        /// <param name="seed"></param>
        /// <returns> Largest prime factor </returns>
        public static long GetLargestPrimeFactor(long seed)
        {
            if (PrimeDictionary[PrimeDictionary.Count - 1] <= Math.Sqrt(seed))
            {
                CalculatePrimesUpTo((long)Math.Sqrt(seed));
            }
            
            long factor = seed;

            // Divide out each occurance of prime number from the seed
            foreach(long n in PrimeDictionary)
            {
                while (factor % n == 0 && factor != n)
                {
                    factor /= n;
                }
            }

            return factor;
        }

        /// <summary>
        /// Gets the sum of all divisors of a number less than the number
        /// </summary>
        /// <param name="seed"></param>
        /// <returns> Sum of Divisors </returns>
        public static long GetSumOfDivisors(long seed)
        {
            if (PrimeDictionary[PrimeDictionary.Count - 1] < Math.Sqrt(seed))
            {
                CalculatePrimesUpTo((long)Math.Sqrt(seed));
            }

            long sum = 1; // 1 is always a factor
            long factor;
            List<long> divisors = new();

            // Find each multiple of prime that is a divisor of seed
            foreach (long n in PrimeDictionary)
            {
                if (n <= Math.Sqrt(seed))
                {
                    for (long i = 1; i < seed / n; i++)
                    {
                        factor = i * n;
                        if (seed % factor == 0 && !divisors.Contains(factor))
                        {
                            divisors.Add(factor);
                            sum += factor;

                            factor = seed / factor;
                            if (!divisors.Contains(factor))
                            {
                                divisors.Add(factor);
                                sum += factor;
                            }
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            return sum;
        }

        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="seed"></param>
        /// <returns> true | false </returns>
        public static bool IsPrime(long seed)
        {
            // Quick lookup
            if (PrimeDictionary.Contains(seed))
            {
                return true;
            }
            else if(seed < PrimeDictionary[PrimeDictionary.Count-1])
            {
                return false;
            }
            else // Calculate if prime
            {
                CalculatePrimesUpTo(seed);

                if(PrimeDictionary.Contains(seed))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Checks if a number is composite
        /// </summary>
        /// <param name="seed"></param>
        /// <returns> true | false </returns>
        public static bool IsComposite(long seed)
        {
            return !IsPrime(seed);
        }
    }
}
