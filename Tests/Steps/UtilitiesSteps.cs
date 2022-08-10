using System;
using TechTalk.SpecFlow;
using Tests.Drivers;
using NUnit.Framework;
using static ProjectEuler.ProjectEuler;
using ProjectEuler.Utilities;
using System.Numerics;

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
            Factorial factorial = new();
            testFixture.Factorial = factorial.GetFactorial(seed);
        }

        [When(@"I get the length of the collatz sequence of (\d*)")]
        public void WhenIGetTheLengthOfTheCollatzSequenceOf(int seed)
        {
            CollatzSequence collatz = new();
            testFixture.CollatzLength = collatz.GetLength(seed);
        }

        [Then(@"the factorial is (.*)")]
        public void ThenTheFactorialIs(string factorial)
        {
            Assert.AreEqual(BigInteger.Parse(factorial), testFixture.Factorial);
        }

        [Then(@"the length of the collatz sequence is (\d*)")]
        public void ThenTheLengthOfTheCollatzSequenceIs(long length)
        {

            Assert.AreEqual(length, testFixture.CollatzLength);
        }
    }
}
