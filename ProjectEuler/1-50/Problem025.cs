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
        /// <see href="https://projecteuler.net/problem=25"/>
        /// </summary>
        public static long Problem025()
        {
            const int NUMBER = 1000;
            BigInteger divisor = BigInteger.Pow(10, NUMBER-1);
            BigInteger fibonacci;

            for (int i = 1; i <= int.MaxValue; i++)
            {
                fibonacci = Fibonacci.GetNumber(i);
                fibonacci /= divisor;

                if (fibonacci > 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
