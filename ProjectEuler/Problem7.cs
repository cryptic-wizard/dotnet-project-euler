using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=7"/>
        /// </summary>
        public static long Problem7()
        {
            List<uint> primes = new List<uint>();
            const uint targetPrime = 10001;
            bool isPrime = true;
            primes.Add(2);

            for (uint i = 3; i < uint.MaxValue; i += 2)
            {      
                foreach (uint n in primes)
                {
                    if (i % n == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime && primes.Count == targetPrime - 1)
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
