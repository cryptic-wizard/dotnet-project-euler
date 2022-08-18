using System;
using TechTalk.SpecFlow;
using Tests.Drivers;
using NUnit.Framework;
using static ProjectEuler.ProjectEuler;
using ProjectEuler.Utilities;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Tests.StepDefinitions
{
    [Binding]
    public sealed class PalindromeSteps
    {
        private readonly TestFixture testFixture = new();

        public PalindromeSteps(TestFixture testFixture)
        {
            this.testFixture = testFixture;
        }

        [When(@"I check if '(.*)' is a palindrome")]
        public void WhenICheckIfStringIsAPalindrome(string word)
        {
            testFixture.BoolResult = Palindrome.IsPalindrome(word);
        }

        [When(@"I check if (\d+) is a palindrome")]
        public void WhenICheckIfNumberIsAPalindrome(string word)
        {
            testFixture.BoolResult = Palindrome.IsPalindrome(word);
        }

        [When(@"I check if byte array (.*) is a palindrome")]
        public void WhenICheckIfByteArrayIsAPalindrome(string array)
        {
            string[] split = array.Split(',');
            byte[] numbers = new byte[split.Length];

            for(int i = 0; i < split.Length; i++)
            {
                numbers[i] = byte.Parse(split[i]);
            }

            testFixture.BoolResult = Palindrome.IsPalindrome(numbers);
        }

        [When(@"I check if byte list (.*) is a palindrome")]
        public void WhenICheckIfByteListIsAPalindrome(string list)
        {
            string[] split = list.Split(',');
            List<byte> numbers = new();

            for (int i = 0; i < split.Length; i++)
            {
                numbers.Add(byte.Parse(split[i]));
            }

            testFixture.BoolResult = Palindrome.IsPalindrome(numbers);
        }
    }
}
