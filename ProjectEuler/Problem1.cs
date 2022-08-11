using System;
using System.Collections.Generic;
using ProjectEuler.Utilities;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=1"/>
        /// </summary>
        public static long Problem1()
        {
            const uint MAX_VALUE = 1000;
            long sum = 0;
            
            for (int i = 0; i < MAX_VALUE; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
