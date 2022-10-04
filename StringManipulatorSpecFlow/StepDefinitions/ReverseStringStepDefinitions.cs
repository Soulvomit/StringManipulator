using StringManipulatorLib;
using System;
using TechTalk.SpecFlow;

namespace StringManipulatorSpecFlow.StepDefinitions
{
    [Binding]
    public class ReverseStringStepDefinitions
    {
        private Table? input = null;
        private Table? input_two = null;
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
            output = table;
            string[] inputs = new string[5];
            string[] outupts = new string[5];

            if (input != null)
            {
                Console.WriteLine("INPUT:");
                for (int i = 0; i < input.RowCount; i++)
                {
                    Console.WriteLine(input.Rows[i]["input"]);
                    inputs[i] = input.Rows[i]["input"];
                }
                Console.WriteLine("OUTPUT:");
                for (int i = 0; i < output.RowCount; i++)
                {
                    Console.WriteLine(output.Rows[i]["reverse"]);
                    outupts[i] = output.Rows[i]["reverse"];
                }
                for (int i = 0; i < inputs.Length; i++)
                {
                    string reversed = StringManipulator.ReverseString(inputs[i]);
                    Assert.AreEqual(reversed, outupts[i]);
                }
            }
            else
                Assert.Fail();
        }

        [Given(@"a string as <input_two>")]
        public void GivenAStringAsInput_Two(Table table)
        {
            input_two = table;

            Console.WriteLine("INPUT:");
            for (int i = 0; i < input_two.RowCount; i++)
            {
                Console.WriteLine(input_two.Rows[i]["input_two"]);
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
            string[] inputs = new string[5];
            string[] lengths = new string[5];
            string[] outupts = new string[5];

            if (input_two != null && char_length != null)
            {
                Console.WriteLine("INPUT:");
                for (int i = 0; i < input_two.RowCount; i++)
                {
                    Console.WriteLine(input_two.Rows[i]["input_two"]);
                    inputs[i] = input_two.Rows[i]["input_two"];
                }
                Console.WriteLine("CHAR_LENGTH:");
                for (int i = 0; i < char_length.RowCount; i++)
                {
                    Console.WriteLine(char_length.Rows[i]["char_length"]);
                    lengths[i] = char_length.Rows[i]["char_length"];
                }
                Console.WriteLine("OUTPUT:");
                for (int i = 0; i < limited_reverse.RowCount; i++)
                {
                    Console.WriteLine(limited_reverse.Rows[i]["limited_reverse"]);
                    outupts[i] = limited_reverse.Rows[i]["limited_reverse"];
                }
                for (int i = 0; i < inputs.Length; i++)
                {
                    string reversed = StringManipulator.ReverseString(inputs[i], byte.Parse(char_length.Rows[i]["char_length"]));
                    Assert.AreEqual(reversed, outupts[i]);
                }
            }
            else
                Assert.Fail();
        }
    }
}
