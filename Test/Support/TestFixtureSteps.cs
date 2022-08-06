using BoDi;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Support
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
