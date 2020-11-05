using System;
using TechTalk.SpecFlow;
using Xunit;

namespace HU7
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double number, result;        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var expected = p0;
            var actual = result;
            Assert.Equal(expected, actual, 5);
        }
        [Given(@"the number is Pi")]
        public void GivenTheNumberIsPi()
        {
            number = Math.PI;
        }

        [When(@"the sinus of number")]
        public void WhenTheSinusOfNumber()
        {
            result = Math.Sin(number);
        }
        [When(@"the cosinus of number")]
        public void WhenTheCosinusOfNumber()
        {
            result = Math.Cos(number);
        }
        [When(@"the tangens of number")]
        public void WhenTheTangensOfNumber()
        {
            result = Math.Tan(number);
        }
    }
}
