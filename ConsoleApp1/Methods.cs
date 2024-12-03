using System;
using System.Diagnostics.Metrics;
using CharacterCreation;


namespace CharacterCreation
{
    public class Methods
    {
        public void NewGame()
        {

            CharacterSheetMethod character = new CharacterSheetMethod();
            

            bool placeholder = false;

            while (!placeholder)
            {
                Console.WriteLine("You have reached death! WELCOME to 'Reaching Death'!");
                Console.WriteLine("(1) Create New Character");
                Console.WriteLine("(2) Return");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    character.PlayerName();
                    placeholder = true;
                }
                if (choice == 2) { 
                    return; }
            }
        }
        public void CurrentGame()
        {
            Console.WriteLine("Wala pa ihh!");
        }
        public void CampaignMode()
        {
            Console.WriteLine("Disoriented and dazed, you wake up to find yourself in a sanguine lobby. The door’s locked shut and you have no way of getting out in your current state. Looking around, it was the famed Redmill Manor, the most haunted building in the city of Nexto. Don’t be happy, as it was said that anyone who set foot in the building was lost forever. The horrors come true as the Hunter roams the building, killing anyone who would try to uncover their secrets which they guarded six-feet-under since. Scramble and look for clues before the Hunter makes you their next victim. Good luck.\r\n");
            
            Console.WriteLine("\nDo you wish to continue?");

            Console.WriteLine("Press Y to continue.");

            string choice = Console.ReadLine();

            if (choice == "Y")
            {
                Console.WriteLine("Invalid. Try again");
                return;
            }
            else
            {
                Console.WriteLine("Hehe, juk onli.");
                Console.WriteLine("\nGo back to main menu?");
                Console.WriteLine("(1) YES");
                Console.WriteLine("(2) NO");

                string choiceOne = Console.ReadLine();
            }



        }
        public void Credits()
        {
            Console.WriteLine("Zam Ortega: Leader, programmer");
            Console.WriteLine("Jomar Cruz: Documentation");
            Console.WriteLine("Ethan Raphael Concepcion: Documentation");

            Console.WriteLine("\nGo back to main menu?");
            Console.WriteLine("(1) YES");
            Console.WriteLine("(2) NO");

            string choice = Console.ReadLine();
        }
    }
        
}


// bool placeholder = false;
// while (!placeholder)
//{
//    try
//    {
//        if (choice < 0 && choice > 2)
//        {
 //           throw new Exceptions.InvalidException("Invalid!");

       // }
       // placeholder = true;

       // if (choice == 1)
       // {
        //    Console.WriteLine("Welcome! Please state your name. Alphanumeric only, limited to 20 characters only. No special characters are allowed.");
       // }
       // if (choice == 2)
       // {

       // }
    //}

//    catch (Exceptions.InvalidException ex)
//    {
//        Console.WriteLine("Error: " + ex.Message);
//    }
//    catch (FormatException ex)
//    {
//        Console.WriteLine("Error: " + ex.Message);
//    }
// } 