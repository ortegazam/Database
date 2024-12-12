using System;
using System.Data.SqlClient;
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

            CharacterClass horrorCharacter = new CharacterClass();
            MainMenu(horrorCharacter);
        }    
        public static void MainMenu(CharacterClass horrorCharacter) {
            CharacSheets characInfo = new CharacSheets();
            Choices choices = new Choices();

            bool placeholder = false;

            while (!placeholder)
            {
                
                horrorCharacter.Introduction();
                

                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            choices.NewGame();
                            placeholder = true;
                            break;
                        case 2:
                            choices.CurrentGame();
                            placeholder = true;
                            break;
                        case 3:
                            choices.CampaignMode();
                            placeholder = true;
                            break;
                        case 4:
                            choices.Credits();
                            placeholder = true;
                            break;
                        case 5:
                            Console.WriteLine("Press any key to confirm exit: ");
                            Console.ReadKey();
                            Environment.Exit(0);
                            placeholder = true;
                            break;
                        default:
                            throw new Exception("Invalid input. Please try again!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }

    }
}
     
