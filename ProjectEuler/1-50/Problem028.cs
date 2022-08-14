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
        /// <see href="https://projecteuler.net/problem=28"/>
        /// </summary>
        public static long Problem028()
        {
            const int NUMBER = 1001;
            long sum = 1, value = 1;

            // 1001 x 1001 grid = 500 rings + center
            for (int ring = 1; ring <= NUMBER/2; ring++)
            {
                // 4 corners per spiral incremented by 2 * ring number
                for (int j = 0; j < 4; j++)
                {
                    value += 2 * ring;
                    sum += value;
                }
            }

            return sum;
        }
    }
}
