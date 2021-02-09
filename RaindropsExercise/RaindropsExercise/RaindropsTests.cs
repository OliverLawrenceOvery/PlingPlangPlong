using NUnit.Framework;
using Raindrops;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace RaindropsExercise
{
    [Binding]
    public class RaindropsTests
    {
        string result;

        [Given(@"I input a number which has a single factor")]
        public void GivenIInputANumberWhichHasASingleFactor()
        {
           
        }

        [Given(@"I input a number which has two factors")]
        public void GivenIInputANumberWhichHasTwoFactors()
        {

        }

        [Given(@"I input a number which has all three factors")]
        public void GivenIInputANumberWhichHasAllThreeFactors()
        {

        }

        [Given(@"I input zero")]
        public void GivenIInputZero()
        {

        }

        [Given(@"I input a number which has none of the three factors")]
        public void GivenIInputANumberWhichHasNoneOfTheThreeFactors()
        {

        }

        [When(@"the factor finder method is called with (.*)")]
        public void WhenTheFactorFinderMethodIsCalledWith(int n)
        {
            result = RaindropsMethod.FactorFinder(n);
        }

        [Then(@"the result is the appropriate string (.*)")]
        public void ThenTheResultIsTheAppropriateString(string expected)
        {
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
