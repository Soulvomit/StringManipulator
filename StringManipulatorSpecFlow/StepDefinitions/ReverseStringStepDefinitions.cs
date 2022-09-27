using System;
using TechTalk.SpecFlow;

namespace StringManipulatorSpecFlow.StepDefinitions
{
    [Binding]
    public class ReverseStringStepDefinitions
    {
        private Table? input = null;
        private Table? output = null;
        private Table? char_length = null;
        private Table? limited_reverse = null;

        [Given(@"a string as <input>")]
        public void GivenAStringAsInput(Table table)
        {
            input = table;

            Console.WriteLine("INPUT:");
            for (int i = 0; i < input.RowCount; i++)
            {
                Console.WriteLine(input.Rows[i]["input"]);
            }
        }

        [When(@"enter or button is pressed")]
        public void WhenEnterOrButtonIsPressed()
        {
            Console.WriteLine("enter or reverseButton is pressed");
        }

        [Then(@"a mirrored version of the input should be displayed in <reverse>")]
        public void ThenAMirroredVersionOfTheInputShouldBeDisplayedInReverse(Table table)
        {
            Assert.Fail(); //input not set at this moment FIX IT
            output = table;
            if (input != null)
            {
                Console.WriteLine("INPUT:");
                for (int i = 0; i < input.RowCount; i++)
                {
                    Console.WriteLine(input.Rows[i]["input"]);
                }
                Console.WriteLine("OUTPUT:");
                for (int i = 0; i < output.RowCount; i++)
                {
                    Console.WriteLine(output.Rows[i]["reverse"]);
                }
            }
        }

        [When(@"the string is above <char_length>")]
        public void WhenTheStringIsAboveChar_Length(Table table)
        {
            char_length = table;

            Console.WriteLine("INPUT:");
            for (int i = 0; i < char_length.RowCount; i++)
            {
                Console.WriteLine(char_length.Rows[i]["char_length"]);
            }
        }

        [Then(@"a limited version of the string should be displayed <limited_reverse>")]
        public void ThenALimitedVersionOfTheStringShouldBeDisplayedLimited_Reverse(Table table)
        {

            limited_reverse = table;
            if (input != null)
            {
                Console.WriteLine("INPUT:");
                for (int i = 0; i < input.RowCount; i++)
                {
                    Console.WriteLine(input.Rows[i]["input"]);
                }
                Console.WriteLine("OUTPUT:");
                for (int i = 0; i < limited_reverse.RowCount; i++)
                {
                    Console.WriteLine(limited_reverse.Rows[i]["limited_reverse"]);
                }
            }
        }
    }
}
