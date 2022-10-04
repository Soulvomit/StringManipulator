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

        [Given(@"a string as <somecase>")]
        public void GivenAStringAsSomecase(Table table)
        {
            input = table;

            Console.WriteLine("INPUT:");
            for (int i = 0; i < input.RowCount; i++)
            {
                Console.WriteLine(input.Rows[i]["somecase"]);
            }
        }

        [When(@"enter or toUpperButton is pressed")]
        public void WhenEnterOrToUpperButtonIsPressed()
        {
            Console.WriteLine("enter or toUpperButton is pressed");
        }

        [Then(@"a mirrored version of the input should be displayed as <uppercase>")]
        public void ThenAMirroredVersionOfTheInputShouldBeDisplayedAsUppercase(Table table)
        {
            output = table;
            string[] inputs = new string[5];
            string[] outupts = new string[5];

            if (input != null)
            {
                Console.WriteLine("INPUT:");
                for (int i = 0; i < input.RowCount; i++)
                {
                    Console.WriteLine(input.Rows[i]["somecase"]);
                    inputs[i] = input.Rows[i]["somecase"];
                }
                Console.WriteLine("OUTPUT:");
                for (int i = 0; i < output.RowCount; i++)
                {
                    Console.WriteLine(output.Rows[i]["uppercase"]);
                    outupts[i] = output.Rows[i]["uppercase"];
                }
                for (int i = 0; i < inputs.Length; i++)
                {
                    string toUpper = StringManipulator.ToUpper(inputs[i]);
                    Assert.AreEqual(toUpper, outupts[i]);
                }
            }
            else
                Assert.Fail();
        }
    }
}
