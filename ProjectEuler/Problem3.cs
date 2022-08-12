using System;
using System.Collections.Generic;
using ProjectEuler.Utilities;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=3"/>
        /// </summary>
        public static long Problem3()
        {
            const long NUMBER = 600851475143;

            long largestPrimeFactor = Prime.GetLargestPrimeFactor(NUMBER);
            return largestPrimeFactor;
        }
    }
}
