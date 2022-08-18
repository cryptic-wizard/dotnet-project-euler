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
        /// <see href="https://projecteuler.net/problem=35"/>
        /// </summary>
        public static long Problem035()
        {
            const int NUMBER = 1000000;
            List<long> primes = Prime.GetPrimesUpTo(NUMBER - 1);
            long currentPrime;
            bool circularPrime;
            int count = 0;

            foreach (long prime in primes)
            {
                circularPrime = true;
                currentPrime = RotateNumber(prime);

                if (currentPrime != prime)
                {
                    while (currentPrime != prime)
                    {
                        if (!primes.Contains(currentPrime))
                        {
                            circularPrime = false;
                            break;
                        }
                        else
                        {
                            currentPrime = RotateNumber(currentPrime);
                        }
                    }
                }

                if (circularPrime)
                {
                    count++;
                }
            }

            return count;
        }

        private static long RotateNumber(long number)
        {
            long length = 1;
            long onesPlace = number % 10;

            for (int i = 1; i < 32; i++)
            {
                if (number / (long)Math.Pow(10, i) == 0)
                {
                    length = i - 1;
                    break;
                }
            }

            number /= 10;
            number += (onesPlace * (long)Math.Pow(10, length));

            return number;
        }
    }
}
