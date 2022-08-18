using ProjectEuler.Utilities;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using static ProjectEuler.Utilities.Palindrome;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=36"/>
        /// </summary>
        public static long Problem036()
        {
            const int NUMBER = 1000000;
            long sum = 0;

            for (int i = 0; i < NUMBER; i++)
            {
                if (IsPalindrome(i) && IsPalindrome(ToBase2(i)))
                {
                    sum += i;
                }
            }

            return sum;
        }

        private static List<byte> ToBase2(int number)
        {
            List<byte> byteList = new();

            while (number > 0)
            {
                if (number == 1)
                {
                    byteList.Add(1);
                }
                else if (number % 2 == 1)
                {
                    byteList.Add(1);
                }
                else
                {
                    byteList.Add(0);
                }

                number /= 2;
            }

            byteList.Reverse();

            for (int i = 0; i < byteList.Count; i++)
            {
                if (byteList[i] == 0)
                {
                    byteList.Remove(0);
                }
                else
                {
                    break;
                }
            }

            return byteList;
        }
    }
}
