using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ProjectEuler.Utilities
{
    /// <summary>
    /// Factorial Helper Class
    /// </summary>
    public static class Factorial
    {
        public static readonly Dictionary<long, BigInteger> FactorialDictionary = new();

        /// <summary>
        /// Gets the factorial of a number
        /// <example>
        /// <code> n! = n * (n-1) * ... * 2 * 1 </code>
        /// </example>
        /// </summary>
        /// <param name="seed"></param>
        /// <returns></returns>
        public static BigInteger GetFactorial(int seed)
        {
            BigInteger factorial;

            if (FactorialDictionary.ContainsKey(seed))
            {
                return FactorialDictionary[seed];
            }
            else if (seed == 1 || seed == 0)
            {
                return 1;
            }
            else
            {
                factorial = seed * GetFactorial(seed - 1);
            }

            if (!FactorialDictionary.ContainsKey(seed))
            {
                FactorialDictionary[seed] = factorial;
            }

            return factorial;
        }
    }
}
