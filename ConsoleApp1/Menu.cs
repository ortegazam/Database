using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using CharacterCreation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CharacterCreation
{
    public class Menu
    {
        public static void Main(string[] args)
        {
            MainMenu();
        }
        public static void MainMenu() {
            CharacterSheetMethod characInfo = new CharacterSheetMethod();
            Methods method = new Methods();

            bool placeholder = false;

            while (!placeholder)
            {
                Console.WriteLine("REACHING DEATH!");
                Console.WriteLine("\n(1) New Game");
                Console.WriteLine("(2) View Existing Characters");
                Console.WriteLine("(3) Campaign Mode");
                Console.WriteLine("(4) Credits");
                Console.WriteLine("(5) Exit");

                

                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            method.NewGame();
                            placeholder = true;
                            break;
                        case 2:
                            method.CurrentGame();
                            break;
                        case 3:
                            method.CampaignMode();
                            break;
                        case 4:
                            method.Credits();
                            break;
                        case 5:
                            Console.WriteLine("Press any key to confirm exit: ");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        default:
                            throw new Exceptions.InvalidException("GG sayo, par. Mali input mo.\n");

                    }
                }
                catch (Exceptions.InvalidException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
        

