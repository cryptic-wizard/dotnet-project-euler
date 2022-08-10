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
        /// <see href="https://projecteuler.net/problem=15"/>
        /// </summary>
        public static long Problem15()
        {
            const int GRID_SIZE_X = 20;
            const int GRID_SIZE_Y = 20;

            Combination combination = new Combination(GRID_SIZE_X, GRID_SIZE_Y);
            return (long)combination.GetBinomialCoefficient();
        }
    }
}
