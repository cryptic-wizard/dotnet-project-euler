using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ProjectEuler.Utilities
{
    /// <summary>
    /// Combination Helper Class
    /// </summary>
    public class Combination
    {
        /// <summary>
        /// Number of values per index
        /// </summary>
        public int Values;
        /// <summary>
        /// Number of indexes
        /// </summary>
        public int Length;
        private int[] Combo;
        private Factorial Factorial = new();
        private Dictionary<int, int> CurrentCombination;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"> Number of values per index </param>
        /// <param name="length"> Number of indexes </param>
        public Combination(int values, int length)
        {
            Values = values;
            Length = length;
            Combo = new int[Length];

            CurrentCombination = new();

            for (int i = 0; i < Values; i++)
            {
                CurrentCombination.Add(i, 0);
            }
        }

        /// <summary>
        /// Gets the total number of permutations with no filter
        /// Note: in permutations, order matters
        /// <example>
        /// <code> Formula: n^r </code>
        /// </example>
        /// </summary>
        /// <returns></returns>
        public BigInteger GetPermutationsWithRepitition()
        {
            return (BigInteger)Math.Pow(Values, Length);
        }

        /// <summary>
        /// <example>
        /// <code> Formula: n!/(n-r)! </code>
        /// </example>
        /// </summary>
        /// <returns></returns>
        public BigInteger GetPermutations()
        {
            return Factorial.GetFactorial(Values) / Factorial.GetFactorial(Values - Length);
        }

        /// <summary>
        /// <example>
        /// <code> Formula: n!/r!(n-r)! </code>
        /// </example>
        /// </summary>
        /// <returns></returns>
        public BigInteger GetCombinations()
        {
            return Factorial.GetFactorial(Values) / (Factorial.GetFactorial(Length) * Factorial.GetFactorial(Values - Length));
        }

        /// <summary>
        /// <example>
        /// <code> Formula: (r+n-1)!/r!(n-1)! </code>
        /// </example>
        /// </summary>
        /// <returns></returns>
        public BigInteger GetCombinationsWithRepitition()
        {
            return Factorial.GetFactorial(Length + Values - 1) / (Factorial.GetFactorial(Length) * Factorial.GetFactorial(Values - 1));
        }

        /// <summary>
        /// <example>
        /// <code> Formula: (r+n)!/r!n! </code>
        /// </example>
        /// </summary>
        /// <returns></returns>
        public BigInteger GetBinomialCoefficient()
        {
            return Factorial.GetFactorial(Length + Values) / (Factorial.GetFactorial(Length) * Factorial.GetFactorial(Values));
        }

        [Obsolete]
        public long GetPermutations(Dictionary<int, int> pattern)
        {
            return GetPermutationsWithPattern(pattern, 0, 0);
        }

        private long GetPermutationsWithPattern(Dictionary<int, int> pattern, long total, int index)
        {
            // Check leaves for valid combination
            if (index == Length)
            {
                if (IsCombinationValid(pattern))
                {
                    return total + 1;
                }
                else
                {
                    return total;
                }
            }
            // Check if this path could lead to valid combinations
            else if (!IsPathValid(pattern))
            {
                return total;
            }

            // Iterate possible values for this index
            for (int i = 0; i < Values; i++)
            {
                Combo[index] = i;
                CurrentCombination[i]++;
                total = GetPermutationsWithPattern(pattern, total, index + 1);
                CurrentCombination[i]--;
            }

            return total;
        }

        private bool IsCombinationValid(Dictionary<int, int> pattern)
        {
            for (int i = 0; i < Values; i++)
            {
                if (!(CurrentCombination[i] == pattern[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsPathValid(Dictionary<int, int> pattern)
        {
            for (int i = 0; i < Values; i++)
            {
                if (CurrentCombination[i] > pattern[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
