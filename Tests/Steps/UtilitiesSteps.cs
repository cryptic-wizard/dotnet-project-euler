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

        [When(@"I get the factorial of (\d+)")]
        public void WhenIGetTheFactorialOf(int seed)
        {
            testFixture.BigIntegerAnswer = Factorial.GetFactorial(seed);
        }

        [When(@"I get the length of the collatz sequence of (\d+)")]
        public void WhenIGetTheLengthOfTheCollatzSequenceOf(int seed)
        {
            CollatzSequence collatz = new();
            testFixture.Answer = collatz.GetLength(seed);
        }

        [When(@"I get the fibonacci number of (\d+)")]
        public void WhenIGetTheFibonacciSequenceTermOf(int seed)
        {
            testFixture.BigIntegerAnswer = Fibonacci.GetNumber(seed);
        }

        [When(@"I get the fibonacci sequence of (\d+)")]
        public void WhenIGetTheFibonacciSequenceOf(int seed)
        {
            testFixture.FibonacciSequence = Fibonacci.GetSequence(seed);
        }

        [Then(@"the factorial is (.*)")]
        public void ThenTheFactorialIs(string factorial)
        {
            Assert.AreEqual(BigInteger.Parse(factorial), testFixture.BigIntegerAnswer);
        }

        [Then(@"the fibonacci number is (\d+)")]
        public void ThenTheFibonacciNumberIs(string value)
        {
            Assert.AreEqual(BigInteger.Parse(value), testFixture.BigIntegerAnswer);
        }

        [Then(@"the fibonacci sequence is (.*)")]
        public void ThenTheFibonacciSequenceIs(string sequenceString)
        {
            List<BigInteger> sequence = sequenceString.Split(',').Select(t => BigInteger.Parse(t)).ToList();
            Assert.AreEqual(sequence, testFixture.FibonacciSequence);
        }

        [Then(@"the bool result is (.*)")]
        public void ThenTheBoolResultIsTrue(bool result)
        {
            Assert.AreEqual(result, testFixture.BoolResult);
        }

    }
}
