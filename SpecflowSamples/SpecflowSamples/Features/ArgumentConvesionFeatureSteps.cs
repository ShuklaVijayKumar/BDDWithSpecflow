using System;
using TechTalk.SpecFlow;

namespace SpecflowSamples.Features
{
    [Binding]
    public class ArgumentConvesionFeatureSteps
    {
        //Below to statments' regex should match.
        //[Given(@"I last changed my password (.* days ago)")]
        //[StepArgumentTransformation(@"(\d+) days ago")]
        [Given(@"I last changed my password (.* days ago)")]
        public void GivenMyPasswordWasCreatedOverDaysAgo(DateTime passwordLastChanged)
        {
            Console.WriteLine(passwordLastChanged.ToString());
        }

        [When(@"I log in successfully")]
        public void WhenILogInSuccessfully()
        {
        }

        [Then(@"I should be asked to enter a new password")]
        public void ThenIShouldBeAskedToEnterANewPassword()
        {
        }

    }
}
