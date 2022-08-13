using System;
using System.Collections.Generic;
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
            Fibonacci fibonacci = new Fibonacci();
            List<long> sequence;
            long value, sum = 0;

            for (int i = 1; i < MAX_VALUE; i++)
            {
                value = fibonacci.GetNumber(i);

                if (value > MAX_VALUE)
                {
                    sequence = fibonacci.GetSequence(i - 1);

                    foreach (long term in sequence)
                    {
                        if (term % (long)2 == 0 && term <= MAX_VALUE)
                        {
                            sum += term;
                        }
                    }

                    return sum;
                }
            }

            return -1;
        }
    }
}
