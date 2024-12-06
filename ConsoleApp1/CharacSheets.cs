using System.Net.Http.Headers;
using System.Text.RegularExpressions;


namespace CharacterCreation
{

    public class CharacSheets
    {
        features ft = new features();
        public void PlayerName(CharacterClass horrorCharacter)
        {
            string namePrompt = "Please enter your name (Alphanumeric, max 20 characters): ";
            horrorCharacter.ft.playerName = InputValidator.Validation(namePrompt, ValidatePlayerName, "HALA KA");    
            Console.WriteLine($"\nWelcome, {horrorCharacter.ft.playerName}! You're reaching your death.\n");

            Age(horrorCharacter);
        }

        public void Age(CharacterClass horrorCharacter)
        {
            try
            {
                Console.WriteLine("Please enter your age: ");
                Options.age();

                int age = Convert.ToInt32(Console.ReadLine());    

                horrorCharacter.ft.playerAge = InputValidator.Validation(age);

                if (horrorCharacter.ft.playerAge < 0 && horrorCharacter.ft.playerAge > 5)
                {
                    
                    throw new Exception("Josko, par. Wala sa options 'yan e.");
                }
                else
                {
                    Gender(horrorCharacter);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
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
                    Options.gender();

                    horrorCharacter.ft.playerGender = Console.ReadLine();

                    switch (horrorCharacter.ft.playerGender)
                    {
                        case "1":
                            ft.playerGender = "Female";
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "2":
                            ft.playerGender = "Male";
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "3":
                            ft.playerGender = "Nonbinary";
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "4":
                            ft.playerGender = "Prefer not to say";
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "5":
                            ft.playerGender = "Others";
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
            horrorCharacter.gs = new GameStruc(horrorCharacter.ft.playerName, horrorCharacter.ft.playerAge, horrorCharacter.ft.playerGender);

            bool placeholder = false;

            while (!placeholder)
            {
                string[] choices = { "1", "2" };
                try
                {
                    Console.WriteLine($"{"[1]",-5} Hunter: Hunters are known for eating their prey, claws gritting against their prey’s skin.");
                    Console.WriteLine($"{"[2]",-5} Survivor: You will search for clues regarding the mysterious accident that led you here, undiscovered by the enemy");
                    Console.WriteLine($"Please choose your team type, {horrorCharacter.ft.playerName}.\n");

                    char choice = Convert.ToChar(Console.ReadLine().ToUpper());

                    switch (choice)
                    {
                        case '1':
                            horrorCharacter.ft.teamType = "Team Type: Hunter";
                            HunterSkills(horrorCharacter);
                            placeholder = true;
                            break;

                        case '2':
                            horrorCharacter.ft.teamType = "Team Type: Survivor";
                            SurvivorSkills(horrorCharacter);

                            placeholder = true;
                            break;

                        default:
                            throw new FormatException("joskopo");

                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}!");
                }
                HunterSkills(horrorCharacter);
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
                    Options.hunterSkills();

                    string choices = Console.ReadLine();

                    switch (choices)
                    {
                        case "1":
                            ft.hunterSkill = "Doppelganger";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "2":
                            ft.hunterSkill = "Poltergeist";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "3":
                            ft.hunterSkill = "Trickster";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "4":
                            ft.hunterSkill = "Phantom";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "5":
                            ft.hunterSkill = "Assassin";
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
                    Options.survivorSkills();

                    horrorCharacter.ft.survivorSkill = Console.ReadLine();


                    switch (horrorCharacter.ft.survivorSkill)
                    {
                        case "1":
                            ft.survivorSkill = "Ace in the Hole";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "2":
                            ft.survivorSkill = "Blood Pact";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "3":
                            ft.survivorSkill = "Circle of Healing";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "4":
                            ft.survivorSkill = "Borrowed Time";
                            Weapon(horrorCharacter);
                            ph = true;
                            break;
                        case "5":
                            ft.survivorSkill = "Critical Thinking";
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
                    Options.weapon();

                    horrorCharacter.ft.weapon = Console.ReadLine();


                    switch (horrorCharacter.ft.weapon)
                    {
                        case "1":
                            ft.weapon = "Ace in the Hole";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "2":
                            ft.weapon = "Blood Pact";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "3":
                            ft.weapon = "Circle of Healing";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "4":
                            ft.weapon = "Borrowed Time";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "5":
                            ft.weapon = "Critical Thinking";
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
                    Options.ability();

                    horrorCharacter.ft.ability = Console.ReadLine();

                    switch (horrorCharacter.ft.ability)
                    {
                        case "1":
                            ft.ability = "Healing";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "2":
                            ft.ability = "Sword Wielder";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "3":
                            ft.ability = "Marksman";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "4":
                            ft.ability = "Clairvoyance";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "5":
                            ft.ability = "Silent Steps";
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
            horrorCharacter.ft.health = 120;
            horrorCharacter.ft.strength = 10;
            horrorCharacter.ft.stamina = 10;
            horrorCharacter.ft.speed = 10;
            horrorCharacter.ft.energy = 10;
            horrorCharacter.ft.stats = 5;

            while (horrorCharacter.ft.stats > 0)
            {
                Console.WriteLine("\nPlease choose where you want to put your (5) free stat points:");

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("1. Health, +15 HP permanently.");
                    Console.WriteLine("2. Strength, +5 XP permanently.");
                    Console.WriteLine("3. Stamina, +4 XP permanently.");
                    Console.WriteLine("4. Speed, +2 XP permanently.");
                    Console.WriteLine("5. Energy, +2 XP permanently.");
                    Console.Write("\nWhat stat do you wish to increase? ");


                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            horrorCharacter.ft.health += 15;
                            Console.WriteLine("You added 15 points to HEALTH.");
                            break;
                        case 2:
                            horrorCharacter.ft.strength += 5;
                            Console.WriteLine("You added 5 points to STRENGTH.");
                            break;
                        case 3:
                            horrorCharacter.ft.stamina += 4;
                            Console.WriteLine("You added 4 points to STAMINA.");
                            break;
                        case 4:
                            horrorCharacter.ft.speed += 2;
                            Console.WriteLine("You added 2 points to SPEED.");
                            break;
                        case 5:
                            horrorCharacter.ft.energy += 2;
                            Console.WriteLine("You added 2 points to ENERGY.");
                            break;
                        default:
                            throw new ArgumentException("Invalid input. Try again!");
                            i--;
                            continue;
                    }
                    horrorCharacter.ft.stats--;

                    if (horrorCharacter.ft.stats == 0)
                    {

                        PhysicalTraits(horrorCharacter);
                    }
                }
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
                    Options.hairStyle();

                    horrorCharacter.ft.hairStyle = Console.ReadLine();

                    switch (horrorCharacter.ft.hairStyle)
                    {
                        case "1":
                            ft.hairStyle = "Healing";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "2":
                            ft.hairStyle = "Sword Wielder";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "3":
                            ft.hairStyle = "Marksman";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "4":
                            ft.hairStyle = "Clairvoyance";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        case "5":
                            ft.hairStyle = "Silent Steps";
                            Abilities(horrorCharacter);
                            ph = true;
                            break;
                        default:
                            throw new ArgumentException("Invalid input. Try again!");
                    }

                    Console.WriteLine("\nPlease choose your hair color:\n");
                    Options.hairColor();

                    horrorCharacter.ft.hairColor = Console.ReadLine();

                    Console.WriteLine("\nPlease choose your skin color:");
                    Options.skinColor();

                    horrorCharacter.ft.skinColor = Console.ReadLine();

                    Console.WriteLine("\nPlease choose your eye color:");
                    Options.eyeColor();

                    horrorCharacter.ft.eyeColor = Console.ReadLine();

                    Console.WriteLine("\nPlease choose your scar:\n");


                    horrorCharacter.ft.scar = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your face shape:\n");
                    Options.shape();

                    horrorCharacter.ft.faceShape = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your expression:\n");
                    Options.expression();
                    horrorCharacter.ft.faceExpression = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your height:\n");
                    Options.heights();
                    horrorCharacter.ft.height = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your weight:\n");
                    Options.weights();
                    horrorCharacter.ft.weight = Console.ReadLine();

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

            string[] top = { "Shirt", "Jacket", "Long Sleeves", "Dress", "Shoulder split", "Hoodie" };
            string[] pants = { "Cargo", "Shorts", "Jeans", "Leather Pants", "Khaki Pants" };

            Console.WriteLine("\nPlease choose your clothes:\n");
            Console.WriteLine($"Top:\n{string.Join("\n ", top)}");
            horrorCharacter.ft.playerTop = Console.ReadLine();

            Console.WriteLine($"Pants:\n{string.Join("\n ", pants)}");
            horrorCharacter.ft.playerPants = Console.ReadLine();

            Accessories(horrorCharacter);
        }

        public static void Accessories(CharacterClass horrorCharacter)
        {
            string[] hats = { "Baseball Cap", "Cowboy Hat", "Beret", "Bucket Hat", "Fedora", "None" };
            string[] playerGlasses = { "Square Eyeglasses", "Round Eyeglasses", "Oval Eyeglasses", "Rectangle Eyeglasses", "Sunglasses", "None" };
            string[] necklaces = { "Gold", "Silver", "Chain", "Diamond", "Pearl", "None" };
            string[] bracelets = { "Gold", "Silver", "Chain", "Diamond", "Pearl", "None" };
            string[] anklets = { "Charm Anklet", "Gold Anklet", "Beaded Anklet", "Chain Anklet", "Silver Anklet", "None" };

            Console.WriteLine("\nPlease choose your accessories:\n");
            Console.WriteLine($"Hat: \n{string.Join("\n", hats)}");
            horrorCharacter.ft.hat = Console.ReadLine();

            Console.WriteLine($"Glasses:\n{string.Join("\n", playerGlasses)}");
            horrorCharacter.ft.glasses = Console.ReadLine();

            Console.WriteLine($"Necklace:\n{string.Join("\n", necklaces)}");
            horrorCharacter.ft.necklace = Console.ReadLine();

            Console.WriteLine($"Bracelet:\n{string.Join("\n", bracelets)}");
            horrorCharacter.ft.bracelet = Console.ReadLine();

            Console.WriteLine($"Anklet:\n{string.Join("\n", anklets)}");
            horrorCharacter.ft.anklet = Console.ReadLine();

            CharacSheetsCon.Armor(horrorCharacter);
        }

        private bool ValidatePlayerName(string input)
        {
            return Regex.IsMatch(input, @"^[A-Za-z0-9]+$") && input.Length <= 20 && input.Length > 0;
        }
        
    }
}