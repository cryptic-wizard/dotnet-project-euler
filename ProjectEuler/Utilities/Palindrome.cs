using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Utilities
{
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
    }

}
