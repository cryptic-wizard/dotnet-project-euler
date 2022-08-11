using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Utilities
{
    /// <summary>
    /// Collatz Sequence Helper Class
    /// </summary>
    public class Fibonacci
    {
        public readonly Dictionary<long, long> ValueDictionary = new();

        public Fibonacci()
        {
            ValueDictionary.Add(0, 0);
            ValueDictionary.Add(1, 1);
        }

        /// <summary>
        /// Gets the value of the fibonacci sequence using the seed
        /// <example>
        /// <code> f(n) = f(n-1) + f(n-2) </code>
        /// </example>
        /// </summary>
        /// <param name="seed"></param>
        /// <returns></returns>
        public long GetNumber(long seed)
        {
            if (ValueDictionary.ContainsKey(seed))
            {
                return ValueDictionary[seed];
            }
            else
            {
                long value = GetNumber(seed - 1) + GetNumber(seed - 2);
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
        public List<long> GetSequence(long seed)
        {
            GetNumber(seed);
            List<long> sequence = new();

            foreach(long value in ValueDictionary.Values)
            {
                sequence.Add(value);
            }

            return sequence;
        }
    }
}
