using ProjectEuler.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=16"/>
        /// </summary>
        public static long Problem16()
        {
            BigInteger product = BigInteger.Pow(2, 1000);
            long sum = 0;
            int digit = 0;

            while (product != BigInteger.Zero)
            {
                digit = (int)(product % 10);
                sum += digit;
                product = product / 10;
            }

            return sum;
        }
    }
}
