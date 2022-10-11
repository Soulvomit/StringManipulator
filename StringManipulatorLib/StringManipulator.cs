using System.Text;

namespace StringManipulatorLib
{
    public static class StringManipulator
    {
        #region ReverseString
        /// <summary>
        /// Reverses/mirrors a given string. If the string is longer the charLength it will be cut before reversing.
        /// </summary>
        /// <param name="input">String to reverse/mirror.</param>
        /// <param name="charLength">Maximum allowed length of string. Defaults to byte.MaxValue.</param>
        /// <returns>The reversed/mirrored string.</returns>
        public static string ReverseString(string input, byte charLength = byte.MaxValue)
        { 
            char[] stringArray = input.ToCharArray()
                                        .Take(charLength)
                                            .ToArray();

            StringBuilder reversedLimited = new StringBuilder(null);

            
            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                reversedLimited.Append(stringArray[i]);
            }

            return reversedLimited.ToString();
        }
        #endregion

        #region ToLowerAndUpperCase
        /// <summary>
        /// Converts english alphabet to lower case.
        /// </summary>
        /// <param name="input">String to lower case.</param>
        /// <returns>Lower cased version on the input.</returns>
        public static string ToLower(string input) 
        {
            StringBuilder output = new StringBuilder(null);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    output.Append((char)(input[i] - 'A' + 'a'));
                }
                else
                    output.Append(input[i]);
            }
            return output.ToString();
        }
        /// <summary>
        /// Converts english alphabet to upper case.
        /// </summary>
        /// <param name="input">String to upper case.</param>
        /// <returns>Upper cased version on the input.</returns>
        public static string ToUpper(string input) 
        {
            StringBuilder output = new StringBuilder(null);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    output.Append((char)(input[i] - 'a' + 'A'));
                }
                else
                    output.Append(input[i]);
            }
            return output.ToString();
        }
        #endregion
    }
}