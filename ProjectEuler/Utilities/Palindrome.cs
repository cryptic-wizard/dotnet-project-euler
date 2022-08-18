using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Utilities
{
    /// <summary>
    /// Palindrome Helper Class
    /// </summary>
    public static class Palindrome
    {
        /// <summary>
        /// <example>
        /// <code> "AbbA" = true
        ///  "ABCba" = false </code>
        /// </example>
        /// </summary>
        /// <param name="word"></param>
        /// <returns> true | false </returns>
        public static bool IsPalindrome(string word)
        {
            return IsPalindrome(word.ToCharArray());
        }

        /// <summary>
        /// <example>
        /// <code> "AbbA" = true
        ///  "ABCba" = false </code>
        /// </example>
        /// </summary>
        /// <param name="word"></param>
        /// <returns> true | false </returns>
        public static bool IsPalindrome(char[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// <example>
        /// <code> "12,31,12" = true
        ///  "12,31,13" = false </code>
        /// </example>
        /// </summary>
        /// <param name="word"></param>
        /// <returns> true | false </returns>
        public static bool IsPalindrome(byte[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// <example>
        /// <code> "12,31,12" = true
        ///  "12,31,13" = false </code>
        /// </example>
        /// </summary>
        /// <param name="word"></param>
        /// <returns> true | false </returns>
        public static bool IsPalindrome(List<byte> word)
        {
            for (int i = 0; i < word.Count; i++)
            {
                if (word[i] != word[word.Count - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// <example>
        /// <code> "12321" = true
        ///  "12345" = false </code>
        /// </example>
        /// </summary>
        /// <param name="word"></param>
        /// <returns> true | false </returns>
        public static bool IsPalindrome(long word)
        {
            List<byte> byteList = new();

            while (word > 0)
            {
                byteList.Add((byte)(word % 10));
                word /= 10;
            }

            return IsPalindrome(byteList);
        }
    }
}
