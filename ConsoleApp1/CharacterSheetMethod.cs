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
                            Options.HunterSkills();
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
                        Weapon();
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

            Weapon();
        }
        public void Weapon(CharacterClass horrorCharacter)
        {
            string[] weaponChoices = { "Rifle", "Machete", "Axe", "Pistol", "Grenade Launcher" };

            Console.WriteLine("\nPlease choose your weapon:");
            Options.weapon();

            horrorCharacter.ft.weapon = Console.ReadLine();

            Abilities();
        }
        public void Abilities()
        {

            Console.WriteLine("\nPlease choose your ability:\n");
            Options.ability();

            ft.ability = Console.ReadLine();

            Stats();
        }
        public void Stats()
        {
            ft.health = 120;
            ft.strength = 10;
            ft.stamina = 10;
            ft.speed = 10;
            ft.energy = 10;
            ft.stats = 5;

            while (ft.stats > 0)
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
                            ft.health += 15;
                            Console.WriteLine("You added 15 points to HEALTH.");
                            break;
                        case 2:
                            ft.strength += 5;
                            Console.WriteLine("You added 5 points to STRENGTH.");
                            break;
                        case 3:
                            ft.stamina += 4;
                            Console.WriteLine("You added 4 points to STAMINA.");
                            break;
                        case 4:
                            ft.speed += 2;
                            Console.WriteLine("You added 2 points to SPEED.");
                            break;
                        case 5:
                            ft.energy += 2;
                            Console.WriteLine("You added 2 points to ENERGY.");
                            break;
                        default:
                            Console.WriteLine("Invalid input! Try again.");
                            i--;
                            continue;
                    }
                    ft.stats--;

                    if (ft.stats == 0)
                    {

                        PhysicalTraits();
                    }
                }
            }
        }
        public void PhysicalTraits()
        {
            bool ph = false;
            while (ph)
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

                    ft.hairStyle = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your hair color:\n");
                    Options.hairColor();

                    ft.hairColor = Console.ReadLine();

                    Console.WriteLine("\nPlease choose your skin color:");
                    Options.skinColor();

                    ft.skinColor = Console.ReadLine();

                    Console.WriteLine("\nPlease choose your eye color:");
                    Options.eyeColor();

                    ft.eyeColor = Console.ReadLine();

                    Console.WriteLine("\nPlease choose your scar:\n");


                    ft.scar = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your face shape:\n");
                    Options.shape();

                    ft.faceShape = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your expression:\n");
                    Options.expression();
                    ft.faceExpression = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your height:\n");
                    Options.heights();
                    ft.height = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your weight:\n");
                    Options.weights();
                    ft.weight = Console.ReadLine();

                    Clothing();


                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void Clothing()
        {

            string[] top = { "Shirt", "Jacket", "Long Sleeves", "Dress", "Shoulder split", "Hoodie" };
            string[] pants = { "Cargo", "Shorts", "Jeans", "Leather Pants", "Khaki Pants" };

            Console.WriteLine("\nPlease choose your clothes:\n");
            Console.WriteLine($"Top:\n{string.Join("\n ", top)}");
            ft.playerTop = Console.ReadLine();

            Console.WriteLine($"Pants:\n{string.Join("\n ", pants)}");
            ft.playerPants = Console.ReadLine();

            cs.Accessories();
        }
        
        private bool ValidatePlayerName(string input)
        {
            return Regex.IsMatch(input, @"^[A-Za-z0-9]+$") && input.Length <= 20 && input.Length > 0;
        }
        
    }
}