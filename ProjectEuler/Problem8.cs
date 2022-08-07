using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=8"/>
        /// </summary>
        public static long Problem8()
        {
            const byte ADJACENT_DIGITS = 13;
            const string TEXT =
            @"73167176531330624919225119674426574742355349194934
            96983520312774506326239578318016984801869478851843
            85861560789112949495459501737958331952853208805511
            12540698747158523863050715693290963295227443043557
            66896648950445244523161731856403098711121722383113
            62229893423380308135336276614282806444486645238749
            30358907296290491560440772390713810515859307960866
            70172427121883998797908792274921901699720888093776
            65727333001053367881220235421809751254540594752243
            52584907711670556013604839586446706324415722155397
            53697817977846174064955149290862569321978468622482
            83972241375657056057490261407972968652414535100474
            82166370484403199890008895243450658541227588666881
            16427171479924442928230863465674813919123162824586
            17866458359124566529476545682848912883142607690042
            24219022671055626321111109370544217506941658960408
            07198403850962455444362981230987879927244284909188
            84580156166097919133875499200524063689912560717606
            05886116467109405077541002256983155200055935729725
            71636269561882670428252483600823257530420752963450";

            long answer = 0;
            long possibleAnswer;
            int numbersToSkip = 0;
            byte nextNumber = 0;
            byte[] numbers = GetNumbers(TEXT);

            // For every digit index
            for (int i = 0; i < numbers.Length - ADJACENT_DIGITS; i++)
            {
                possibleAnswer = 1;

                // Calculate the product with the adjacent digits
                for (int j = 0; j < ADJACENT_DIGITS; j++)
                {
                    nextNumber = numbers[i + j];

                    // If a 0 is encountered, several number combinations can be skipped
                    // because the product will be 0 for all of them
                    if (nextNumber == 0)
                    {
                        possibleAnswer = 0;
                        numbersToSkip = j;
                        break;
                    }
                    else
                    {
                        possibleAnswer *= nextNumber;
                    }
                }

                // Skip ahead if zero was found
                if (possibleAnswer == 0)
                {
                    i += numbersToSkip;
                }
                else if (possibleAnswer > answer)
                {
                    answer = possibleAnswer;
                }
            }

            return answer;
        }

        /// <summary>
        /// Converts the text string to a byte array
        /// </summary>
        /// <param name="text"> Provided problem text </param>
        /// <returns> Representation of text as individual digits </returns>
        private static byte[] GetNumbers(string text)
        {
            List<byte> numbers = new();
            char[] chars = text.ToCharArray();

            foreach (char c in chars)
            {
                // Ignore ASCII characters that are not digits
                if (c < 48 || c > 57)
                {
                    continue;
                }

                numbers.Add(ASCIICharToByte(c));
            }

            return numbers.ToArray();
        }

        /// <summary>
        /// Converts from ASCII to byte value
        /// <example>
        /// <code> '7' returns 7 </code>
        /// </example>
        /// </summary>
        /// <param name="c"> ASCII digit character </param>
        /// <returns> 0-9 </returns>
        public static byte ASCIICharToByte(char c)
        {
            return (byte)(c - 48);
        }
    }
}
