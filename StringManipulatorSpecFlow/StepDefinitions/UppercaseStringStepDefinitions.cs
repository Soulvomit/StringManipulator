using StringManipulatorLib;
using System;
using System.Reflection.PortableExecutable;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace StringManipulatorSpecFlow.StepDefinitions
{
    [Binding]
    public class UppercaseStringStepDefinitions
    {
        private Table? input = null;
        private Table? output = null;

        [Given(@"a input string"), Scope(Feature = "Uppercase")]
        public void GivenAInputString(Table table)
        {
            input = table;
            Assert.AreEqual(1, input.RowCount);
        }

        [When(@"enter or toUpperButton is pressed")]
        public void WhenEnterOrToUpperButtonIsPressed()
        {
            Console.WriteLine("Enter or toUpper Button was pressed...");
        }

        [Then(@"a uppercase version of the input should be displayed")]
        public void ThenAUppercaseVersionOfTheInputShouldBeDisplayed(Table table)
        {
            output = table;
            Assert.AreEqual(1, output.RowCount);
            if (input != null)
            {
                string toUpper = StringManipulator.ToUpper(input.Rows[0]["anycase"]);
                Assert.AreEqual(toUpper, output.Rows[0]["uppercase"]);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
