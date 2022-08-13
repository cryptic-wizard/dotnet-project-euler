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
        /// <see href="https://projecteuler.net/problem=17"/>
        /// </summary>
        public static long Problem017()
        {
            Dictionary<int, string> WordDictionary = new()
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three"}, 
                { 4, "four"},
                { 5, "five"},
                { 6, "six"},
                { 7, "seven"},
                { 8, "eight"},
                { 9, "nine"},
                { 10, "ten" },
                { 11, "eleven" },
                { 12, "twelve" },
                { 13, "thirteen" },
                { 14, "fourteen" },
                { 15, "fifteen" },
                { 16, "sixteen" },
                { 17, "seventeen" },
                { 18, "eighteen" },
                { 19, "nineteen" },
                { 20, "twenty" },
                { 30, "thirty" },
                { 40, "forty" },
                { 50, "fifty" },
                { 60, "sixty" },
                { 70, "seventy" },
                { 80, "eighty" },
                { 90, "ninety" },
                { 100, "hundred" },
                { 1000, "thousand" },
            };

            Dictionary<int, int> letterCountDictionary = InitLetterCountDictionary(WordDictionary);
            const int NUMBERS = 1000;
            const int AND_LETTERS = 3;
            long sum = 0, currentNumber;

            for (int i = 1; i <= NUMBERS; i++)
            {
                if (i < 21)
                {
                    sum += letterCountDictionary[i];
                }
                else
                {
                    currentNumber = 0;

                    // Thousands
                    if (i > 999 && ((i/1000)%10 > 0))
                    {
                        currentNumber += letterCountDictionary[(i / 1000) % 10] + letterCountDictionary[1000];
                    }
                    if (i > 99 && ((i/100)%10) > 0)
                    {
                        currentNumber += letterCountDictionary[(i / 100) % 10] + letterCountDictionary[100];
                    }
                    if (i % 100 > 0)
                    {
                        if (i > 99)
                        {
                            currentNumber += AND_LETTERS;
                        }

                        if (i % 100 < 21)
                        {
                            currentNumber += letterCountDictionary[i % 100];
                        }
                        else
                        {
                            currentNumber += letterCountDictionary[(i % 100) - (i%10)];

                            if (i % 10 > 0)
                            {
                                currentNumber += letterCountDictionary[i % 10];
                            }
                        }
                    }
 
                    sum += currentNumber;
                }
            }

            return sum;
        }

        private static Dictionary<int, int> InitLetterCountDictionary(Dictionary<int, string> wordDictionary)
        {
            Dictionary<int, int> letterCountDictionary = new();

            foreach(KeyValuePair<int, string> kvp in wordDictionary)
            {
                letterCountDictionary.Add(kvp.Key, kvp.Value.Length);
            }

            return letterCountDictionary;
        }
    }
}
