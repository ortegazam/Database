using System.Net.Http.Headers;
using System.Text.RegularExpressions;


namespace CharacterCreation
{

    public class CharacterSheetMethod
    {
        public void PlayerName(CharacterClass horrorCharacter)
        {
            string namePrompt = "Please enter your name (Alphanumeric, max 20 characters): ";
            horrorCharacter.ft.playerName = InputValidator.ValidateStringInput(namePrompt, ValidatePlayerName, "HALA KA");    
            Console.WriteLine($"\nWelcome, {horrorCharacter.ft.playerName}! You're reaching your death.\n");
            horrorCharacter.Scream();
            Age(horrorCharacter);
        }

        public void Age(CharacterClass horrorCharacter)
        {
            try
            {
                Console.WriteLine("Please enter your age: ");
                Options.age();

                horrorCharacter.ft.playerAge = Convert.ToInt32(Console.ReadLine());

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

                    horrorCharacter.ft.playerGender = Console.ReadLine().ToUpper();

                    switch (horrorCharacter.ft.playerGender)
                    {
                        case "A":
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "B":
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "C":
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "D":
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "E":
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "F":
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "G":
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "H":
                            GameType(horrorCharacter);
                            placeholder = true;
                            break;
                        case "I":
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
                string[] choices = { "Hunter", "Survivor" };
                try
                {
                    Console.WriteLine($"{"[A]",-5} Hunter: Hunters are known for eating their prey, " +
                        "claws gritting against their prey’s skin.");
                    Console.WriteLine($"{"[B]",-5} Survivor: You will search for clues regarding the mysterious " +
                        "accident that led you here, undiscovered by the enemy.");
                    Console.WriteLine($"Please choose your team type, {horrorCharacter.ft.playerName}.\n");

                    char choice = Convert.ToChar(Console.ReadLine().ToUpper());

                    switch (choice)
                    {
                        case 'A':
                            horrorCharacter.ft.teamType = "Team Type: Hunter";
                            Options.hunterSkills();
                            placeholder = true;
                            break;

                        case 'B':
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
                    string[] skillChoices = { "Doppelganger", "Poltergeist", "Trickster", "Phantom", "Assassin" };

                    Console.WriteLine("\nPlease choose your skill:");
                    Options.hunterSkills();

                    horrorCharacter.ft.hunterSkill = Console.ReadLine();

                    if (Array.Exists(skillChoices, skillChoices => skillChoices.Equals(skillChoices, StringComparison.OrdinalIgnoreCase)))
                    {
                        Weapon(horrorCharacter);
                        ph = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Try again.");
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
            string[] skillChoices = { "Ace In The Hole", "Blood Pact", "Circle of Healing", "Borrowed Time", "Critical Thinking" };

            Console.WriteLine("\nPlease choose your skill:\n");
            Options.survivorSkills();

            horrorCharacter.ft.survivorSkill = Console.ReadLine();

            Weapon(horrorCharacter);
        }
        public void Weapon(CharacterClass horrorCharacter)
        {
            string[] weaponChoices = { "Rifle", "Machete", "Axe", "Pistol", "Grenade Launcher" };

            Console.WriteLine("\nPlease choose your weapon:");
            Options.weapon();

            horrorCharacter.ft.weapon = Console.ReadLine();

            Abilities(horrorCharacter);
        }
        public void Abilities(CharacterClass horrorCharacter)
        {

            Console.WriteLine("\nPlease choose your ability:\n");
            Options.ability();

            horrorCharacter.ft.ability = Console.ReadLine();

            Stats(horrorCharacter);
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
                            Console.WriteLine("Invalid input! Try again.");
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
            Console.WriteLine("here ka na!");
            Console.ReadKey();
            bool ph = false;
            while (!ph)
            {
                try
                {
                    string[] hairStyleChoices = { "Clean Cut", "Buzz Cut", "Fade Cut", "Wolf Cut" };
                    string[] hairColorChoices = { "Red", "Black", "Brown", "Orange", "Blonde" };
                    string[] skinColorChoices = { "Brown", "Black", "White", "Yellow", "Porcelain" };
                    string[] eyeColorChoices = { "Brown", "Black", "Red", "Blue", "Green" };
                    string[] scarChoices = { "Eye scar", "Leg scar", "Arm scar", "Chest scar", "Shoulder scar" };
                    string[] faceShapeChoices = { "Triangular", "Oval", "Circle", "Square", "Diamond" };
                    string[] faceExpressionChoices = { "Angry", "Sad", "Smile", "Calm", "Confused" };
                    string[] heightChoices = { "Short", "Average", "Tall", "Dwarf", "Giant" };
                    string[] weightChoices = { "Skinny", "Slim", "Fit", "Plump", "Fat" };

                    Console.WriteLine("\nPlease choose your hairstyle:\n");
                    Options.hairStyle();

                    horrorCharacter.ft.hairStyle = Console.ReadLine();


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

            CharacSheet.Armor(horrorCharacter);
        }

        private bool ValidatePlayerName(string input)
        {
            return Regex.IsMatch(input, @"^[A-Za-z0-9]+$") && input.Length <= 20 && input.Length > 0;
        }
        
    }
}