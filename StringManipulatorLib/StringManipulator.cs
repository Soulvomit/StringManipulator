namespace StringManipulatorLib
{
    public class StringManipulator
    {
        #region ReverseString
        /// <summary>
        /// Reverses/mirrors a given string. If the string is longer the charLength it will be cut before reversing.
        /// </summary>
        /// <param name="input">String to reverse/mirror.</param>
        /// <param name="charLenght">Maximum allowed length of string. Defaults to byte.MaxValue.</param>
        /// <returns>The reversed/mirrored string.</returns>
        public static string ReverseString(string input, byte charLenght = byte.MaxValue)
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
        #endregion

        #region ToLowerUpperCase
        /// <summary>
        /// Converts english alphabet to lower case.
        /// </summary>
        /// <param name="input">String to lower case.</param>
        /// <returns>Lower cased version on the input.</returns>
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
        /// <summary>
        /// Converts english alphabet to upper case.
        /// </summary>
        /// <param name="input">String to upper case.</param>
        /// <returns>Upper cased version on the input.</returns>
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
        #endregion
    }
}