using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace RaindropsExercise
{
    public class RaindropsTests
    {
        [Given(@"I input a number (.*) which has a single factor")]
        public void GivenIInputANumberWhichHasASingleFactor(int n)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the factor finder method is called")]
        public void WhenTheFactorFinderMethodIsCalled()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result is the appropriate string (.*)")]
        public void ThenTheResultIsTheAppropriateString(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
