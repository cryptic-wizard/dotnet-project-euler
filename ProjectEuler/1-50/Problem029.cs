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
        /// <see href="https://projecteuler.net/problem=29"/>
        /// </summary>
        public static long Problem029()
        {
            const int NUMBER = 100;
            BigInteger value;
            Dictionary<BigInteger, BigInteger> sequence = new();

            for (int a = 2; a <= NUMBER; a++)
            {
                // 4 corners per spiral incremented by 2 * ring number
                for (int b = 2; b <= NUMBER; b++)
                {
                    value = BigInteger.Pow(a, b);

                    if (!sequence.ContainsKey(value))
                    {
                        sequence.Add(value, value);
                    }
                }
            }

            return sequence.Count;
        }
    }
}
