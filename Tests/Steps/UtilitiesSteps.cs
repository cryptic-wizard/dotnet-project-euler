using System;
using TechTalk.SpecFlow;
using Tests.Drivers;
using NUnit.Framework;
using static ProjectEuler.ProjectEuler;
using ProjectEuler.Utilities;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace Tests.StepDefinitions
{
    [Binding]
    public sealed class UtilitiesSteps
    {
        private readonly TestFixture testFixture = new();

        public UtilitiesSteps(TestFixture testFixture)
        {
            this.testFixture = testFixture;
        }

        [When(@"I get the factorial of (\d*)")]
        public void WhenIGetTheFactorialOf(int seed)
        {
            testFixture.Factorial = Factorial.GetFactorial(seed);
        }

        [When(@"I get the length of the collatz sequence of (\d*)")]
        public void WhenIGetTheLengthOfTheCollatzSequenceOf(int seed)
        {
            CollatzSequence collatz = new();
            testFixture.Answer = collatz.GetLength(seed);
        }

        [When(@"I get the fibonacci number of (\d*)")]
        public void WhenIGetTheFibonacciSequenceTermOf(int seed)
        {
            Fibonacci fibonacci = new();
            testFixture.Answer = fibonacci.GetNumber(seed);
        }

        [When(@"I get the fibonacci sequence of (\d*)")]
        public void WhenIGetTheFibonacciSequenceOf(int seed)
        {
            Fibonacci fibonacci = new();
            testFixture.FibonacciSequence = fibonacci.GetSequence(seed);
        }

        [When(@"I check if (.*) is a palindrome")]
        public void WhenICheckIfAbbaIsAPalindrome(string word)
        {
            testFixture.BoolResult = Palindrome.IsPalindrome(word);
        }

        [Then(@"the factorial is (.*)")]
        public void ThenTheFactorialIs(string factorial)
        {
            Assert.AreEqual(BigInteger.Parse(factorial), testFixture.Factorial);
        }

        [Then(@"the length of the collatz sequence is (\d*)")]
        public void ThenTheLengthOfTheCollatzSequenceIs(long length)
        {

            Assert.AreEqual(length, testFixture.Answer);
        }

        [Then(@"the fibonacci number is (\d*)")]
        public void ThenTheFibonacciSequenceTermIs(long value)
        {
            Assert.AreEqual(value, testFixture.Answer);
        }

        [Then(@"the fibonacci sequence is (.*)")]
        public void ThenTheFibonacciSequenceIs(string sequenceString)
        {
            List<long> sequence = sequenceString.Split(',').Select(t => long.Parse(t)).ToList();
            Assert.AreEqual(sequence, testFixture.FibonacciSequence);
        }

        [Then(@"the bool result is (.*)")]
        public void ThenTheBoolResultIsTrue(bool result)
        {
            Assert.AreEqual(result, testFixture.BoolResult);
        }

    }
}
