using StringManipulatorLib;

namespace StringManipulatorSpecFlow.StepDefinitions
{
    [Binding]
    public class ReverseStringStepDefinitions
    {
        private Table? _input;
        private Table? _output;
        private Table? _maxChars;

        [Given(@"a string")]
        public void GivenAString(Table table)
        {
            _input = table;
            Assert.AreEqual(1, _input.RowCount);
        }

        [When(@"enter or button is pressed")]
        public void WhenEnterOrButtonIsPressed()
        {
            Console.WriteLine("Enter or reverse Button was pressed...");
        }

        [Then(@"a mirrored version of the input should be displayed")]
        public void ThenAMirroredVersionOfTheInputShouldBeDisplayed(Table table)
        {
            _output = table;
            Assert.AreEqual(1, _output.RowCount);

            if (_input != null)
            {
                string reversed = StringManipulator.ReverseString(_input.Rows[0]["input"]);
                Assert.AreEqual(_output.Rows[0]["reversed"], reversed);
            }
            else
            {
                Assert.Fail();
            }
        }

        [When(@"the string is above character limit")]
        public void WhenTheStringIsAboveCharacterLimit(Table table)
        {
            _maxChars = table;
            Assert.AreEqual(1, _maxChars.RowCount);
        }

        [Then(@"a limited and mirrored version of the string should be displayed")]
        public void ThenALimitedAndMirroredVersionOfTheStringShouldBeDisplayed(Table table)
        {
            _output = table;
            Assert.AreEqual(1, _output.RowCount);

            if (_input != null && _maxChars != null)
            {
                string limitedReversed = 
                    StringManipulator.ReverseString(_input.Rows[0]["input"], byte.Parse(_maxChars.Rows[0]["char_length"]));
                Assert.AreEqual(_output.Rows[0]["limited_reversed"], limitedReversed);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
