using System;
using System.Text.RegularExpressions;

namespace CharacterCreation
{
    public class Validation
    {
        public static int Validate(String input, int key)
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid input. Please try again!");
            }

        }

        public static string Validate(String input, string key)
        {
            string text = "";

            if (Regex.IsMatch(input, @"^[a-zA-Z]+$"))
            {
                text = input;
            }
            else
            {
                throw new FormatException("Invalid input. Please try again!");
            }

            return text;
        }
    }
}
