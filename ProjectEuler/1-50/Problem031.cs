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
        /// <see href="https://projecteuler.net/problem=31"/>
        /// </summary>
        public static long Problem031()
        {
            List<int> coins = new()
            {
                200, // loop of 1
                100, // loop of 2
                50,  // 4
                20,  // 10
                10,  // 20
                5,   // 40
                2,   // 100
                1,   // calculated
            };

            const int TARGET_SUM = 200;
            long combinations = GetCoinCombinations(coins, TARGET_SUM);

            return combinations;
        }

        private static long GetCoinCombinations(List<int> coins, int targetSum, int sum = 0, int index = 0)
        {
            // If the recursion made it to the 1p, there is 1 combination of 1p to make the target sum
            if (index == coins.Count - 1)
            {
                // thisCoinTotal = targetSum - sum;
                return 1;
            }

            long combinations = 0;
            int thisCoinTotal;

            // For each combination of this coin up to the target sum
            for (int i = 0; i <= targetSum/coins[index]; i++)
            {
                // Add this coin combination to the total
                thisCoinTotal = coins[index] * i;
                sum += thisCoinTotal;

                // If sum exceeded, exit this coin early
                if (sum > targetSum)
                {
                    sum -= thisCoinTotal;
                    return combinations;
                }
                else // Get coin combinations of coins smaller than this one
                {
                    combinations += GetCoinCombinations(coins, targetSum, sum, index + 1);
                    sum -= thisCoinTotal;
                }
            }

            return combinations;
        }
    }
}
