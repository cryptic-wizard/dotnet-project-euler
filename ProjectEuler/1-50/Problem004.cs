using System;
using System.Collections.Generic;
using ProjectEuler.Utilities;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=4"/>
        /// </summary>
        public static long Problem004()
        {
            const int NUMBER = 1000;
            long product, largestPalindromeProduct = -1;

            for (int i = NUMBER - 1; i > 0; i--)
            {
                for (int j = NUMBER - 1; j > 0; j--)
                {
                    product = i * j;

                    if (product < largestPalindromeProduct)
                    {
                        continue;
                    }
                    else if (Palindrome.IsPalindrome(product.ToString()))
                    {
                        largestPalindromeProduct = product;
                    }
                }
            }

            return largestPalindromeProduct;
        }
    }
}
