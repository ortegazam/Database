using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;


namespace CharacterCreation
{

    public class CharacSheets
    {
        UserFeatures ft = new UserFeatures();
        public void PlayerName(CharacterClass horrorCharacter)
        {
            bool ph = false;
            while (!ph)
            { 
                    Console.WriteLine("Please enter your name (Alphanumeric, max 20 characters): ");
                    string name = Console.ReadLine();
                    horrorCharacter.ft.PlayerName = InputValidator.Validation(name);
                    ph = true;

                    Console.WriteLine($"\nWelcome, {horrorCharacter.ft.PlayerName}! You're reaching your death.\n");
               
                    Age(horrorCharacter);
  
            }
        }
        public void Age(CharacterClass horrorCharacter)
        {
            bool ph = false;
            while (!ph)
            {
                try
                {
                    Console.WriteLine("Please enter your age: ");
                    Options.Age();

                    horrorCharacter.ft.PlayerAge = Console.ReadLine();

                    switch (horrorCharacter.ft.PlayerAge)
                    {
                        case "1":
                            horrorCharacter.ft.PlayerAge = "Child";
                            ph = true;
                            break;

                        case "2":
                            horrorCharacter.ft.PlayerAge = "Teenager";
                            ph = true;
                            break;

                        case "3":
                            horrorCharacter.ft.PlayerAge = "Adult";
                            ph = true;
                            break;

                        case "4":
                            horrorCharacter.ft.PlayerAge = "Middle";
                            ph = true;
                            break;

                        case "5":
                            horrorCharacter.ft.PlayerAge = "Old";
                            ph = true;
                            break;

                        default:
                            throw new ArgumentException("Invalid input. Please try again!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
      
        public void Gender(CharacterClass horrorCharacter)
        {
            bool placeholder = false;

            while (!placeholder)
            {
                try
                {
                    Console.WriteLine("\nPlease choose the gender you identified with: \n");
                    Options.Gender();

                    horrorCharacter.ft.PlayerGender = Console.ReadLine();

                    switch (horrorCharacter.ft.PlayerGender)
                    {
                        case "1":
                            ft.PlayerGender = "Female";
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "2":
                            ft.PlayerGender = "Male";
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "3":
                            ft.PlayerGender = "Nonbinary";
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "4":
                            ft.PlayerGender = "Prefer not to say";
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "5":
                            ft.PlayerGender = "Others";
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        default:
                            throw new ArgumentException("Invalid input. Try again!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public void GameType(CharacterClass horrorCharacter)
        {
            horrorCharacter.gs = new GameStruc(horrorCharacter.ft.PlayerName, horrorCharacter.ft.PlayerAge, horrorCharacter.ft.PlayerGender);

            bool placeholder = false;

            while (!placeholder)
            {
                try
                {
                    Console.WriteLine($"Please choose your TEAM TYPE, {horrorCharacter.ft.PlayerName}!");
                    Console.WriteLine($"\n{"[1]",-5} Hunter: Hunters are known for eating their prey, claws gritting against their prey’s skin.");
                    Console.WriteLine($"{"[2]",-5} Survivor: You will search for clues regarding the mysterious accident that led you here, undiscovered by the enemy\n");

                    char choice = Convert.ToChar(Console.ReadLine().ToUpper());

                    switch (choice)
                    {
                        case '1':
                            horrorCharacter.ft.TeamType = "Team Type: Hunter";
                            HunterSkills(horrorCharacter);
                            placeholder = true;
                            break;

                        case '2':
                            horrorCharacter.ft.TeamType = "Team Type: Survivor";
                            SurvivorSkills(horrorCharacter);
                            placeholder = true;
                            break;

                        default:
                            throw new FormatException("Invalid input. Please try again!\n");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
        
        public void HunterSkills(CharacterClass horrorCharacter)
        {
            bool ph = false;

            while (!ph)
            {
               
                try
                {
                    Console.WriteLine("\nPlease choose your skill:\n");
                    Options.HunterSkills();

                    string choices = Console.ReadLine();

                    switch (choices)
                    {
                        case "1":
                            ft.HunterSkill = "Doppelganger";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "2":
                            ft.HunterSkill = "Poltergeist";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "3":
                            ft.HunterSkill = "Trickster";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "4":
                            ft.HunterSkill = "Phantom";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "5":
                            ft.HunterSkill = "Assassin";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        default:
                            throw new ArgumentException("Invalid input. Try again!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        public void SurvivorSkills(CharacterClass horrorCharacter)
        {
            bool ph = false;

            while (!ph)
            {
                
                try
                {
                   
                    Console.WriteLine("\nPlease choose your skill:\n");
                    Options.SurvivorSkills();

                    horrorCharacter.ft.SurvivorSkill = Console.ReadLine();


                    switch (horrorCharacter.ft.SurvivorSkill)
                    {
                        case "1":
                            ft.SurvivorSkill = "Ace in the Hole";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "2":
                            ft.SurvivorSkill = "Blood Pact";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "3":
                            ft.SurvivorSkill = "Circle of Healing";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "4":
                            ft.SurvivorSkill = "Borrowed Time";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "5":
                            ft.SurvivorSkill = "Critical Thinking";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        default:
                            throw new ArgumentException("Invalid input. Try again!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        public void Weapon(CharacterClass horrorCharacter)
        {
            
            bool ph = false;

            while (!ph)
            {

                try
                {
                    Console.WriteLine("\nPlease choose your weapon:");
                    Options.Weapon();

                    horrorCharacter.ft.Weapon = Console.ReadLine();

                    switch (horrorCharacter.ft.Weapon)
                    {
                        case "1":
                            ft.Weapon = "Rifle";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "2":
                            ft.Weapon = "Machete";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "3":
                            ft.Weapon = "Axe";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "4":
                            ft.Weapon = "Pistol";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "5":
                            ft.Weapon = "Bow and Arrow";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        default:
                            throw new ArgumentException("Invalid input. Try again!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }
        public void Abilities(CharacterClass horrorCharacter)
        {
            Stats(horrorCharacter);
     
            bool ph = false;

            while (!ph)
            {

                try
                {
                    Console.WriteLine("\nPlease choose your ability:\n");
                    Options.Ability();

                    horrorCharacter.ft.Ability = Console.ReadLine();

                    switch (horrorCharacter.ft.Ability)
                    {
                        case "1":
                            ft.Ability = "Healing";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "2":
                            ft.Ability = "Sword Wielder";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "3":
                            ft.Ability = "Marksman";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "4":
                            ft.Ability = "Clairvoyance";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "5":
                            ft.Ability = "Silent Steps";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        default:
                            throw new ArgumentException("Invalid input. Try again!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }
        public void Stats(CharacterClass horrorCharacter)
        {
            horrorCharacter.ft.Health = 120;
            horrorCharacter.ft.Strength = 10;
            horrorCharacter.ft.Stamina = 10;
            horrorCharacter.ft.Speed = 10;
            horrorCharacter.ft.Energy = 10;
            horrorCharacter.ft.Stats = 5;
            bool ph = false;

            while (!ph)
            {
                try
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write($"\nYou have free {5 - i} stat points. Which stat do you wish to increase? ");
                        Console.WriteLine("\n[1] Health, +15 HP permanently.");
                        Console.WriteLine("[2] Strength, +5 XP permanently.");
                        Console.WriteLine("[3] Stamina, +4 XP permanently.");
                        Console.WriteLine("[4] Speed, +2 XP permanently.");
                        Console.WriteLine("[5] Energy, +2 XP permanently.");

                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                horrorCharacter.ft.Health += 15;
                                Console.WriteLine("You added 15 points to HEALTH.\n");
                                break;
                            case 2:
                                horrorCharacter.ft.Strength += 5;
                                Console.WriteLine("You added 5 points to STRENGTH.\n");
                                break;
                            case 3:
                                horrorCharacter.ft.Stamina += 4;
                                Console.WriteLine("You added 4 points to STAMINA.\n");
                                break;
                            case 4:
                                horrorCharacter.ft.Speed += 2;
                                Console.WriteLine("You added 2 points to SPEED.\n");
                                break;
                            case 5:
                                horrorCharacter.ft.Energy += 2;
                                Console.WriteLine("You added 2 points to ENERGY.\n");
                                break;
                            default:
                                throw new ArgumentException("Invalid input. Try again!");
                        }
                    }
                    PhysicalTraits(horrorCharacter);
                    ph = true;
                }
                catch (ArgumentException ex) { Console.WriteLine("Error: " + ex.Message); }
            }
        }
        public void PhysicalTraits(CharacterClass horrorCharacter)
        {

            bool ph = false;
            while (!ph)
            {
                try
                {
                    
                    Console.WriteLine("\nPlease choose your hairstyle:\n");
                    Options.HairStyle();

                    horrorCharacter.ft.HairStyle = Console.ReadLine();

                    switch (horrorCharacter.ft.HairStyle)
                    {
                        case "1":
                            ft.HairStyle = "Clean Cut";
                            break;

                        case "2":
                            ft.HairStyle = "Buzz Cut";                      
                            break;

                        case "3":
                            ft.HairStyle = "Fade Cut";                       
                            break;

                        case "4":
                            ft.HairStyle = "Wolf Cut";               
                            break;

                        case "5":
                            ft.HairStyle = "Long Hair";
                            break;

                        default:
                            throw new ArgumentException("Invalid input. Try again!");
                    }

                    Console.WriteLine("\nPlease choose your hair color:\n");
                    Options.HairColor();

                    horrorCharacter.ft.HairColor = Console.ReadLine();

                    switch (horrorCharacter.ft.HairColor)
                    {
                        case "1":
                            ft.HairColor = "Red";
                            break;

                        case "2":
                            ft.HairColor = "Black";
                            break;

                        case "3":
                            ft.HairColor = "Brown";
                            break;

                        case "4":
                            ft.HairColor = "Orange";
                            break;

                        case "5":
                            ft.HairColor = "Blonde";
                            break;

                        default:
                            throw new ArgumentException("Invalid input. Try again!");
                    }

                    Console.WriteLine("\nPlease choose your skin color:");
                    Options.SkinColor();

                    horrorCharacter.ft.SkinColor = Console.ReadLine();

                    switch (horrorCharacter.ft.SkinColor)
                    {
                        case "1":
                            ft.HairColor = "Brown";
                            break;

                        case "2":
                            ft.HairColor = "Black";
                            break;

                        case "3":
                            ft.HairColor = "White";
                            break;

                        case "4":
                            ft.HairColor = "Yellow";
                            break;

                        case "5":
                            ft.HairColor = "Porcelain";
                            break;

                        default:
                            throw new ArgumentException("Invalid input. Try again!");
                    }
                    Console.WriteLine("\nPlease choose your eye color:");
                    Options.EyeColor();

                    horrorCharacter.ft.EyeColor = Console.ReadLine();

                    switch (horrorCharacter.ft.EyeColor)
                    {
                        case "1":
                            ft.EyeColor = "Brown";
                            break;

                        case "2":
                            ft.EyeColor = "Black";
                            break;

                        case "3":
                            ft.EyeColor = "Red";
                            break;

                        case "4":
                            ft.EyeColor = "Blue";
                            break;

                        case "5":
                            ft.EyeColor = "Green";
                            break;

                        default:
                            throw new ArgumentException("Invalid input. Try again!");
                    }

                    Console.WriteLine("\nPlease choose your scar:\n");
                    Options.Scar();

                    horrorCharacter.ft.Scar = Console.ReadLine();

                    switch (horrorCharacter.ft.Scar)
                    {
                        case "1":
                            ft.Scar = "Eye Scar";
                            break;

                        case "2":
                            ft.Scar = "Leg Scar";
                            break;

                        case "3":
                            ft.Scar = "Arm Scar";
                            break;

                        case "4":
                            ft.Scar = "Chest Scar";
                            break;

                        case "5":
                            ft.Scar = "Shoulder Scar";
                            break;

                        default:
                            throw new ArgumentException("Invalid input. Try again!");
                    }

                    Console.WriteLine("\nPlease choose your face shape:\n");
                    Options.Shape();

                    horrorCharacter.ft.FaceShape = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your expression:\n");
                    Options.Expression();
                    horrorCharacter.ft.FaceExpression = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your height:\n");
                    Options.Heights();
                    horrorCharacter.ft.Height = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your weight:\n");
                    Options.Weights();
                    horrorCharacter.ft.Weight = Console.ReadLine();

                    Clothing(horrorCharacter);

                    ph = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void Clothing(CharacterClass horrorCharacter)
        {


            Console.WriteLine("\nPlease choose your clothes:\n");
            Options.TopClothes();
            horrorCharacter.ft.PlayerTop = Console.ReadLine();

            Options.PantsClothes();
            horrorCharacter.ft.PlayerPants = Console.ReadLine();

            Accessories(horrorCharacter);
        }

        public static void Accessories(CharacterClass horrorCharacter)
        {

            bool ph = false;

            while (!ph)
            {
                try
                {
                    Console.WriteLine("\nDo you wish to have accessories?");
                    Console.WriteLine("[1] YES");
                    Console.WriteLine("[2] NO");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice != 1 && choice != 2)
                    {
                        Console.WriteLine("Invalid input. Please try again!");
                        continue;  
                    }

                    bool checker = (choice == 1) ? true : false;

                    if (checker == true)
                    {
                        AccessoriesTwo(horrorCharacter);
                    }
                    if (checker == false)
                    {
                        UserFeatures.Hat = "None";
                        UserFeatures.Glasses = "None";
                        UserFeatures.Necklace = "None";
                        UserFeatures.Bracelet = "None";
                        UserFeatures.Anklet = "None";

                        CharacSheetsCon.Armor(horrorCharacter);
                    }
                }

                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            }
        }
        public static void AccessoriesTwo(CharacterClass horrorCharacter)
        {
            try
            {
                Console.WriteLine("Please choose your hat:");
                Options.Hats();

                UserFeatures.Hat = Console.ReadLine();
                switch (horrorCharacter.ft.Scar)
                {
                    case "1":
                        UserFeatures.Hat = "Baseball Cap";
                        break;

                    case "2":
                        UserFeatures.Hat = "Cowboy Hat";
                        break;

                    case "3":
                        UserFeatures.Hat = "Fedora";
                        break;

                    case "4":
                        UserFeatures.Hat = "Bucket Hat";
                        break;

                    case "5":
                        UserFeatures.Hat = "None";
                        break;

                    default:
                        throw new ArgumentException("Invalid input. Try again!");
                }
            }
            catch (ArgumentException ex) { Console.WriteLine(ex.Message); }

            Console.WriteLine("Please choose your glasses:");
            Options.Glasses();

            Console.WriteLine("Please choose your necklace:");
            Options.Necklaces();

            Console.WriteLine("Please choose your bracelet:");
            Options.Bracelet();

            Console.WriteLine("Please choose your anklet:");
            Options.Anklets();

            CharacSheetsCon.Armor(horrorCharacter);
        }
    }
}
//bool ph = false;

//while (!ph) {
//    try
//    {

//    }

//    catch (ArgumentException ex) { } }