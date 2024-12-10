using System;
using System.Diagnostics.Metrics;
using CharacterCreation;


namespace CharacterCreation
{
    public class Choices
    {
        public void NewGame()
        {

            Menu menu = new Menu();
            CharacSheets character = new CharacSheets();
            CharacterClass horrorCharac = new CharacterClass();

            bool placeholder = false;

            while (!placeholder)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("You have reached death! WELCOME to 'Reaching Death'!");
                    Console.WriteLine("(1) Create New Character");
                    Console.WriteLine("(2) Return");

                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        character.PlayerName(horrorCharac);
                        placeholder = true;
                    }
                    if (choice == 2) { Menu.MainMenu(horrorCharac); }

                    else { throw new ArgumentException("Invalid input. Try again!"); }

                }
                catch (ArgumentException ex) 
                { 
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("Press any key to continue. ");
                    Console.ReadKey();
                }
                
            }
        }
        public void CurrentGame()
        {
            Console.WriteLine("Wala pa ihh!");
        }
        public void CampaignMode()
        {
            bool ph = false;

            while (!ph)
            {
                CharacterClass horrorCharacter = new CharacterClass();

                Console.WriteLine("\nDo you wish to continue?");
                Console.WriteLine("Press Y to continue.");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "Y":
                        Menu.MainMenu(horrorCharacter);
                        ph = true;
                        break;
                    case "y":
                        Menu.MainMenu(horrorCharacter);
                        ph = true;
                        break;
                    default:
                        throw new ArgumentException("Invalid input. Please try again!");
                }
            }
        }
     
        public void Credits()
        {
            Console.WriteLine("Zam Ortega: Leader, programmer, pabuhat");
            Console.WriteLine("Jomar Cruz: Documentation");
            Console.WriteLine("Ethan Raphael Concepcion: Documentation");
            Console.WriteLine("Luis Rivera: Pancit Canton");
            Console.WriteLine("Reyn Penus: Certified Pancit Canton");
            Console.WriteLine("Raven Villanueva");
            Console.WriteLine("Emmanuel Caraig");
            Console.WriteLine("\nGo back to main menu?");
            Console.WriteLine("(1) YES");
            Console.WriteLine("(2) NO");

            string choice = Console.ReadLine();
        }
    }
        
}
