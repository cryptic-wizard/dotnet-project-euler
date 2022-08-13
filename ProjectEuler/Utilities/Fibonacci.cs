using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ProjectEuler.Utilities
{
    /// <summary>
    /// Collatz Sequence Helper Class
    /// </summary>
    public static class Fibonacci
    {
        private static readonly Dictionary<long, BigInteger> ValueDictionary = new()
        {
            { 0, 0 },
            { 1, 1 },
        };

        /// <summary>
        /// Gets the value of the fibonacci sequence using the seed
        /// <example>
        /// <code> f(n) = f(n-1) + f(n-2) </code>
        /// </example>
        /// </summary>
        /// <param name="seed"></param>
        /// <returns></returns>
        public static BigInteger GetNumber(long seed)
        {
            if (ValueDictionary.ContainsKey(seed))
            {
                return ValueDictionary[seed];
            }
            else
            {
                BigInteger value = GetNumber(seed - 1) + GetNumber(seed - 2);
                ValueDictionary.Add(seed, value);
                return value;
            }
        }

        /// <summary>
        /// <example>
        /// <code> f(n) = f(n-1) + f(n-2)
        ///  { 0, 1, 1, 2, 3, 5, 8, 13 ... } </code>
        /// </example>
        /// </summary>
        /// <param name="seed"></param>
        /// <returns></returns>
        public static List<BigInteger> GetSequence(long seed)
        {
            GetNumber(seed);
            List<BigInteger> sequence = new();

            foreach(KeyValuePair<long, BigInteger> kvp in ValueDictionary)
            {
                if (kvp.Key <= seed)
                {
                    sequence.Add(kvp.Value);
                }
                else
                {
                    break;
                }
            }

            return sequence;
        }
    }
}
