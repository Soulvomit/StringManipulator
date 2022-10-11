using StringManipulatorLib;

namespace StringManipulatorSpecFlow.StepDefinitions
{
    [Binding]
    public class UppercaseStringStepDefinitions
    {
        private Table? _input;
        private Table? _output;

        [Given(@"a input string"), Scope(Feature = "Uppercase")]
        public void GivenAInputString(Table table)
        {
            _input = table;
            Assert.AreEqual(1, _input.RowCount);
        }

        [When(@"enter or toUpper button is pressed")]
        public void WhenEnterOrToUpperButtonIsPressed()
        {
            Console.WriteLine("Enter or toUpper Button was pressed...");
        }

        [Then(@"a uppercase version of the input should be displayed")]
        public void ThenAUppercaseVersionOfTheInputShouldBeDisplayed(Table table)
        {
            _output = table;
            Assert.AreEqual(1, _output.RowCount);
            if (_input != null)
            {
                string toUpper = StringManipulator.ToUpper(_input.Rows[0]["anycase"]);
                Assert.AreEqual(toUpper, _output.Rows[0]["uppercase"]);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
