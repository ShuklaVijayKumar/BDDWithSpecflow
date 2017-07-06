using System;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;


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
            dynamic menu = table.CreateDynamicInstance();
            Console.WriteLine("Menu Item 1: {0}", menu.Menu_1);
            Console.WriteLine("Menu Item 2: {0}", menu.Menu_2);
        }
    }
}