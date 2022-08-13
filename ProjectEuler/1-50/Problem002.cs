using System;
using System.Collections.Generic;
using System.Numerics;
using ProjectEuler.Utilities;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=2"/>
        /// </summary>
        public static long Problem002()
        {
            const long MAX_VALUE = 4000000;
            List<BigInteger> sequence;
            BigInteger sum = 0;
            BigInteger value;

            for (int i = 1; i < MAX_VALUE; i++)
            {
                value = Fibonacci.GetNumber(i);

                if (value > MAX_VALUE)
                {
                    sequence = Fibonacci.GetSequence(i - 1);

                    foreach (BigInteger term in sequence)
                    {
                        if (term % (BigInteger)2 == 0 && term <= MAX_VALUE)
                        {
                            sum += term;
                        }
                    }

                    return (long)sum;
                }
            }

            return -1;
        }
    }
}
