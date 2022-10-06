using StringManipulatorLib;
using System;
using TechTalk.SpecFlow;

namespace StringManipulatorSpecFlow.StepDefinitions
{
    [Binding]
    public class ReverseStringStepDefinitions
    {
        private Table? input = null;
        private Table? output = null;
        private Table? maxChars = null;

        [Given(@"a string")]
        public void GivenAString(Table table)
        {
            input = table;
            Assert.AreEqual(1, input.RowCount);
        }

        [When(@"enter or button is pressed")]
        public void WhenEnterOrButtonIsPressed()
        {
            Console.WriteLine("Enter or reverse Button was pressed...");
        }

        [Then(@"a mirrored version of the input should be displayed")]
        public void ThenAMirroredVersionOfTheInputShouldBeDisplayed(Table table)
        {
            output = table;
            Assert.AreEqual(1, output.RowCount);

            if (input != null)
            {
                string reversed = StringManipulator.ReverseString(input.Rows[0]["input"]);
                Assert.AreEqual(reversed, output.Rows[0]["reversed"]);
            }
            else
            {
                Assert.Fail();
            }
        }

        [When(@"the string is above character limit")]
        public void WhenTheStringIsAboveCharacterLimit(Table table)
        {
            maxChars = table;
            Assert.AreEqual(1, maxChars.RowCount);
        }

        [Then(@"a limited and mirrored version of the string should be displayed")]
        public void ThenALimitedAndMirroredVersionOfTheStringShouldBeDisplayed(Table table)
        {
            output = table;
            Assert.AreEqual(1, output.RowCount);

            if (input != null && maxChars != null)
            {
                string limited_reversed = 
                    StringManipulator.ReverseString(input.Rows[0]["input"], byte.Parse(maxChars.Rows[0]["char_length"]));
                Assert.AreEqual(limited_reversed, output.Rows[0]["limited_reversed"]);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
