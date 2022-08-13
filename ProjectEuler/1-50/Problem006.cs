using System;
using System.Collections.Generic;
using System.Numerics;
using ProjectEuler.Utilities;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=6"/>
        /// </summary>
        public static long Problem006()
        {
            const int NUMBER = 100;
            BigInteger sumOfSquares = 0, squareOfSum = 0;
            int sum = 0;

            for (int i = 1; i <= NUMBER; i++)
            {
                sumOfSquares += BigInteger.Pow(i, 2);
                sum += i;
            }

            squareOfSum = BigInteger.Pow(sum, 2);
            return (long)(squareOfSum - sumOfSquares);
        }
    }
}
