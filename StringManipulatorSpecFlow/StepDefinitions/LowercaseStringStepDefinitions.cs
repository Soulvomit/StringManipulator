using StringManipulatorLib;

namespace StringManipulatorSpecFlow.StepDefinitions
{
    [Binding]
    public class LowercaseStringStepDefinitions
    {
        private Table? _input;
        private Table? _output;

        [Given(@"a input string"), Scope(Feature = "Lowercase")]
        public void GivenAInputString(Table table)
        {
            _input = table;
            Assert.AreEqual(1, _input.RowCount);
            Assert.Fail();
        }

        [When(@"enter or toLower button is pressed")]
        public void WhenEnterOrToLowerButtonIsPressed()
        {
            Console.WriteLine("Enter or toLower Button was pressed...");
        }

        [Then(@"a lowercase version of the input should be displayed")]
        public void ThenALowercaseVersionOfTheInputShouldBeDisplayed(Table table)
        {
            _output = table;
            Assert.AreEqual(1, _output.RowCount);

            if (_input != null)
            {
                string toLower = StringManipulator.ToLower(_input.Rows[0]["anycase"]);
                Assert.AreEqual(toLower, _output.Rows[0]["lowercase"]);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
