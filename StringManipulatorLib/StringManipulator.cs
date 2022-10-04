namespace StringManipulatorLib
{
    public class StringManipulator
    {
        public static string ReverseString(string input, byte charLenght = 255)
        { 
            char[] stringArray = input.ToCharArray()
                                        .Take(charLenght)
                                            .ToArray();

            string reversed_limited = string.Empty;

            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                reversed_limited += stringArray[i];
            }

            return reversed_limited;
        }

        public static string ToLower(string input) 
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    output += (char)(input[i] - 'A' + 'a');
                }
                else
                    output += input[i];
            }
            return output;
        }
        public static string ToUpper(string input) 
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    output += (char)(input[i] - 'a' + 'A');
                }
                else
                    output += input[i];
            }
            return output;
        }
    }
}