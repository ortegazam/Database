using System;
using System.Text.RegularExpressions;

namespace CharacterCreation
{
    public class InputValidator
    {
        public static string Validation(string prompt, Func<string, bool> validation, string errorMessage)
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

        public static int Validation(string prompt, Func<int, bool> validation, string errorMessage)
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

        public static int Validation(int input )
        {
            while (true)
            {
                try
                {
                    return input;
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
        public static string Validation(string input) {
            while (true)
            {
                try
                {
                    if ((Regex.IsMatch(input, @"^[A-Za-z0-9]+$")) && (input.Length <= 20) && (input.Length >= 7))
                    {
                        return input;
 
                    }
                    else { 
                        throw new ArgumentException("Invalid input. Try again!");
                      
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine("Please enter your name (Alphanumeric, max 20 characters): ");

                    input = Console.ReadLine();
                }
            }
        }
        }
    }

