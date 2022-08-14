using System;
using TechTalk.SpecFlow;
using Tests.Drivers;
using NUnit.Framework;
using static ProjectEuler.ProjectEuler;

namespace Tests.StepDefinitions
{
    [Binding]
    public sealed class ProjectEulerSteps
    {
        private readonly TestFixture testFixture = new();

        public ProjectEulerSteps(TestFixture testFixture)
        {
            this.testFixture = testFixture;
        }

        [When(@"I calculate problem (\d+)")]
        public void WhenICalculateProblem(int problem)
        {
            testFixture.ProblemNumber = problem;
            testFixture.SW.Restart();
            testFixture.Answer = CalculateAnswer(problem);
            testFixture.SW.Stop();
        }

        [Then(@"the answer is (-{0,1}\d+)")]
        public void ThenTheAnswerIs(long answer)
        {
            Assert.AreEqual(answer, testFixture.Answer);
        }

        [Then(@"the runtime is less than (\d+) seconds")]
        public void ThenTheRuntimeIsLessThanSeconds(int seconds)
        {
            Assert.Less(testFixture.SW.ElapsedMilliseconds, seconds * 1000);
        }

        [Then(@"the runtime is less than (\d+) ms")]
        public void ThenTheRuntimeIsLessThanMs(int ms)
        {
            Assert.Less(testFixture.SW.ElapsedMilliseconds, ms);
        }

        [Then(@"the runtime is less than (\d+) minutes")]
        public void ThenTheRuntimeIsLessThanMinutes(int ms)
        {
            Assert.Less(testFixture.SW.ElapsedMilliseconds, ms * 1000 * 60);
        }
    }
}
