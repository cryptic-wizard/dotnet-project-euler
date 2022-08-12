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
    public sealed class PrimeSteps
    {
        private readonly TestFixture testFixture = new();

        public PrimeSteps(TestFixture testFixture)
        {
            this.testFixture = testFixture;
        }

        [When(@"I check if (\d*) is prime")]
        public void WhenICheckIfIsPrime(long value)
        {
            testFixture.IsPrime = Prime.IsPrime(value);
        }

        [When(@"I check if (\d*) is composite")]
        public void WhenICheckIfIsComposite(long value)
        {
            testFixture.IsPrime = !Prime.IsComposite(value);
        }

        [When(@"I get the largest prime factor of (\d*)")]
        public void WhenIGetTheLargestPrimeFactorOf(long value)
        {
            testFixture.Answer = Prime.GetLargestPrimeFactor(value);
        }

        [Then(@"the prime result is (.*)")]
        public void ThenThePrimeResultIsTrue(bool truthiness)
        {
            Assert.AreEqual(truthiness, testFixture.IsPrime);
        }
    }
}
