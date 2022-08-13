using ProjectEuler.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=20"/>
        /// </summary>
        public static long Problem020()
        {
            const int NUMBER = 100;
            BigInteger factorial = Factorial.GetFactorial(NUMBER);
            int sum = 0;

            while (factorial > 0)
            {
                sum += (int)(factorial % 10);
                factorial /= 10;
            }

            return sum;
        }
    }
}
