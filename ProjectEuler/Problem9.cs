using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=9"/>
        /// </summary>
        public static long Problem9()
        {
            const int SUM = 1000;
            const int MAX_PRODUCT = SUM * SUM;
            int a = 1;

            // The hypotenuse of a right triangle must be larger than each of its sides
            // c > a
            // c > b
            // a + b + c = 1000
            // c > 1000/3
            // a < 1000*(2/3)
            // b < 1000*(2/3)
            for (int c = SUM/3; c < SUM; c++)
            {
                for (int b = 1; b < (SUM*2/3); b++)
                {
                    // Calculate A, the only unknown, based on B,C
                    a = SUM - c - b;

                    if (IsPythagoreanTriplet(a,b,c))
                    {
                        Console.WriteLine(a.ToString() + ',' + b.ToString() + ',' + c.ToString());
                        return a * b * c;
                    }
                }
            }

            return -1;
        }

        /// <summary>
        /// Determines if provided integers are a pythagorean triplet
        /// </summary>
        /// <param name="a"> side a </param>
        /// <param name="b"> side b </param>
        /// <param name="c"> hypotenuse </param>
        /// <returns> bool </returns>
        private static bool IsPythagoreanTriplet(int a, int b, int c)
        {
            if (a*a + b*b == c*c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
