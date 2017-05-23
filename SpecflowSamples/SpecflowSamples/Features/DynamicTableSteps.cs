using System;
using System.Text;
using TechTalk.SpecFlow;


namespace SpecflowSamples.Features
{
    [Binding]
    public sealed class DynamicTableSteps
    {
        [Given(@"I have entered (.*) into the calculator event")]
        public void GivenIHaveEnteredIntoTheCalculatorEvent(int p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I should see the passed data into the dynamic table")]
        public void ThenIShouldSeeThePassedDataIntoTheDynamicTable(Table table)
        {
            //dynamic menu = table.
            ScenarioContext.Current.Pending();
        }


    }
}
