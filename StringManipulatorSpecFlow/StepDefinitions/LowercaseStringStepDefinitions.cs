using StringManipulatorLib;
using System;
using TechTalk.SpecFlow;

namespace StringManipulatorSpecFlow.StepDefinitions
{
    [Binding]
    public class LowercaseStringStepDefinitions
    {
        private Table? input = null;
        private Table? output = null;

        [Given(@"a input string"), Scope(Feature = "Lowercase")]
        public void GivenAInputString(Table table)
        {
            input = table;
            Assert.AreEqual(1, input.RowCount);
        }

        [When(@"enter or toLowerbutton is pressed")]
        public void WhenEnterOrToLowerbuttonIsPressed()
        {
            Console.WriteLine("Enter or toLower Button was pressed...");
        }

        [Then(@"a lowercase version of the input should be displayed")]
        public void ThenALowercaseVersionOfTheInputShouldBeDisplayed(Table table)
        {
            output = table;
            Assert.AreEqual(1, output.RowCount);

            if (input != null)
            {
                string toLower = StringManipulator.ToLower(input.Rows[0]["anycase"]);
                Assert.AreEqual(toLower, output.Rows[0]["lowercase"]);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
