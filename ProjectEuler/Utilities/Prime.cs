﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Utilities
{
    public static class Prime
    {
        public static readonly List<long> PrimeDictionary = new()
        {
            2, 3
        };

        public static List<long> GetPrimesUpTo(long seed)
        {
            bool isPrime = true;
            long sqrt;

            if (seed <= PrimeDictionary[PrimeDictionary.Count - 1])
            {
                List<long> primes = new();

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

                return primes;
            }

            // For every odd number
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

            return PrimeDictionary;
        }

        public static long GetLargestPrimeFactor(long seed)
        {
            if (PrimeDictionary[PrimeDictionary.Count - 1] <= Math.Sqrt(seed))
            {
                GetPrimesUpTo((long)Math.Sqrt(seed));
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

        public static long GetSumOfDivisors(long seed)
        {
            if (PrimeDictionary[PrimeDictionary.Count - 1] < Math.Sqrt(seed))
            {
                GetPrimesUpTo((long)Math.Sqrt(seed));
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
                GetPrimesUpTo(seed);

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

        public static bool IsComposite(long seed)
        {
            return !IsPrime(seed);
        }
    }
}
