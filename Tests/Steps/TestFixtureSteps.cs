using BoDi;
using TechTalk.SpecFlow;
using Tests.Drivers;

namespace Tests.StepDefinitions
{
    [Binding]
    public class TestFixtureSteps
    {
        private readonly IObjectContainer objectContainer;

        public TestFixtureSteps(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            objectContainer.RegisterInstanceAs(new TestFixture());
        }

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}
