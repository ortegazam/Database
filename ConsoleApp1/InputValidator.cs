using System;
using System.Text.RegularExpressions;

namespace CharacterCreation
{
    public class InputValidator
    {
        public static string ValidateStringInput(string prompt, Func<string, bool> validation, string errorMessage)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    string input = Console.ReadLine();
                    if (validation(input))
                    {
                        return input;
                    }
                    else
                    {
                        throw new ArgumentException(errorMessage);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        public static int ValidateIntInput(string prompt, Func<int, bool> validation, string errorMessage)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (validation(input))
                        return input;

                    throw new ArgumentException(errorMessage);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        public static string ValidateChoice(string prompt, string[] choices, string errorMessage)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    string input = Console.ReadLine();
                    if (Array.Exists(choices, choice => choice.Equals(input, StringComparison.OrdinalIgnoreCase)))
                        return input;

                    throw new ArgumentException(errorMessage);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
        public static string ValidateName(string namePrompt) {
            while (true)
            {
                try
                {
                    if ((Regex.IsMatch(namePrompt, @"^[A-Za-z0-9]+$")) && (namePrompt.Length <= 20) && (namePrompt.Length >= 1))
                    {
                        Console.WriteLine(namePrompt);
                        //string input = Console.ReadLine();
                        //throw new ArgumentException("");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
        }
    }

