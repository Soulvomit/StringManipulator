using System;
using TechTalk.SpecFlow;

namespace StringManipulatorSpecFlow.StepDefinitions
{
    [Binding]
    public class LowercaseStringStepDefinitions
    {
        private Table? input = null;
        private Table? output = null;

        [Given(@"a string as <anycase>")]
        public void GivenAStringAsAnycase(Table table)
        {
            input = table;

            Console.WriteLine("INPUT:");
            for (int i = 0; i < input.RowCount; i++)
            {
                Console.WriteLine(input.Rows[i]["anycase"]);
            }
        }

        [When(@"enter or toLowerbutton is pressed")]
        public void WhenEnterOrToLowerbuttonIsPressed()
        {
            Console.WriteLine("enter or toLowerButton is pressed");
        }

        [Then(@"a mirrored version of the input should be displayed as <lowercase>")]
        public void ThenAMirroredVersionOfTheInputShouldBeDisplayedAsLowercase(Table table)
        {
            output = table;
            if (input != null)
            {
                Console.WriteLine("INPUT:");
                for (int i = 0; i < input.RowCount; i++)
                {
                    Console.WriteLine(input.Rows[i]["anycase"]);
                }
                Console.WriteLine("OUTPUT:");
                for (int i = 0; i < output.RowCount; i++)
                {
                    Console.WriteLine(output.Rows[i]["lowercase"]);
                }
            }
        }
    }
}
