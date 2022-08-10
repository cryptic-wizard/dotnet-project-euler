using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Utilities
{
    /// <summary>
    /// Collatz Sequence Helper Class
    /// </summary>
    public class CollatzSequence
    {
        public readonly Dictionary<long, long> LengthDictionary = new();

        /// <summary>
        /// Generates a Collatz Sequence
        /// <example>
        /// <code> n → n/2 (n is even)
        ///  n → 3n + 1 (n is odd) </code>
        /// </example>
        /// </summary>
        /// <param name="seed"></param>
        /// <returns></returns>
        public static List<int> GetSequence(int seed)
        {
            List<int> sequence = new();
            int key = seed;

            while (key != 1)
            {
                if (key % 2 == 0)
                {
                    key = key / 2;
                }
                else
                {
                    key = 3 * key + 1;
                }

                sequence.Add(key);
            }

            return sequence;
        }

        /// <summary>
        /// Gets the length of the sequence using the seed
        /// </summary>
        /// <param name="seed"></param>
        /// <returns></returns>
        public long GetLength(long seed)
        {
            long key = seed;
            long length = 0;

            while (key != 1)
            {
                if (LengthDictionary.ContainsKey(key))
                {
                    length += LengthDictionary[key];
                    return length;
                }

                if (key % 2 == 0)
                {
                    key = key / 2;
                }
                else
                {
                    key = 3 * key + 1;
                }

                length++;
            }
            length++; // 1 is always part of the sequence

            if (!LengthDictionary.ContainsKey(seed))
            {
                LengthDictionary[seed] = length;
            }

            return length;
        }
    }
}
