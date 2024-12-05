using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Finals;

namespace CharacterCreation
{

    public class CharacterSheetMethod
    {

        CharacSheet cs = new CharacSheet();
        features ft = new features();
        Options opt = new Options();
        public void PlayerName()
        {
            bool placeholder = false;

            while (!placeholder)
            {
                {
                    try
                    {
                        Console.WriteLine("Please enter your name: ");
                        Console.WriteLine("Alphanumeric characters only. Your name is limited to 20 characters only. ");

                        ft.playerName = Console.ReadLine();

                        if (Regex.IsMatch(ft.playerName, @"^[A-Za-z0-9]+$") && ft.playerName.Length <= 20 && ft.playerName.Length >= 1)
                        {
                            Console.WriteLine($"\nWelcome, {ft.playerName}! You're reaching your death.\n");
                            Age();

                            placeholder = true;
                        }
                        else
                        {
                            throw new Exception("Hala ka!");
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }

        public void Age()
        {
            try
            {
                Console.WriteLine("Please enter your age: ");
                Console.WriteLine($"[1] Child {"",-17} | (7 - 13 years old)");
                Console.WriteLine($"[2] Teenager {"",-14} | (14 - 20 years old)");
                Console.WriteLine($"[3] Adult {"",-17} | (21 - 40 years old)");
                Console.WriteLine($"[4] Middle Age {"",-12} | (41 - 55 years old)");
                Console.WriteLine($"[5] Old {"",-19} | (56 years old above)");

                ft.playerAge = Convert.ToInt32(Console.ReadLine());

                if (ft.playerAge < 0 && ft.playerAge > 5)
                {
                    throw new Exception("Josko, par. Wala sa options 'yan e.");
                }
                else
                {
                    Gender();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public void Gender()
        {
            bool placeholder = false;

            while (!placeholder)
            {
                try
                {
                    string[] genderOptions = { "Agender", "Cisgender", "Nonbinary", "Gender Neutral", "Pangender", "Androgyne", "Transgender", "Bigender", "Others" };
                    Console.WriteLine("\nPlease choose the gender you identified with: \n");
                    Console.WriteLine($"{"[A]" }Agender");
                    Console.WriteLine($"{"[B]", -5}Cisgender");
                    Console.WriteLine($"{"[C]", -5}Nonbinary");
                    Console.WriteLine($"{"[D]", -5}Gender Neutral");
                    Console.WriteLine($"{"[E]", -5}Pangender");
                    Console.WriteLine($"{"[F]", -5}Androgyne");
                    Console.WriteLine($"{"[G]", -5}Transgender");
                    Console.WriteLine($"{"[H]", -5}Bigender");
                    Console.WriteLine($"{"[I]", -5}Others");
                    Console.Write("Gender: ");

                    ft.playerGender = Console.ReadLine().ToUpper();

                    switch (ft.playerGender)
                    {
                        case "A":
                            GameType();
                            placeholder = true;
                            break;
                        case "B":
                            GameType();
                            placeholder = true;
                            break;
                        case "C":
                            GameType();
                            placeholder = true;
                            break;
                        case "D":
                            GameType();
                            placeholder = true;
                            break;
                        case "E":
                            GameType();
                            placeholder = true;
                            break;
                        case "F":
                            GameType();
                            placeholder = true;
                            break;
                        case "G":
                            GameType();
                            placeholder = true;
                            break;
                        case "H":
                            GameType();
                            placeholder = true;
                            break;
                        case "I":
                            GameType();
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
        public void GameType()
        {
            bool placeholder = false;

            while (!placeholder)
            {
                string[] choices = { "Hunter", "Survivor" };
                try
                {
                    Console.WriteLine($"{"[A]", -5} Hunter: Hunters are known for eating their prey, " +
                        "claws gritting against their prey’s skin.");
                    Console.WriteLine($"{"[B]", -5} Survivor: You will search for clues regarding the mysterious " +
                        "accident that led you here, undiscovered by the enemy.");
                    Console.WriteLine($"Please choose your team type, {ft.playerName}.\n");

                    char choice = Convert.ToChar(Console.ReadLine().ToUpper());

                    switch (choice)
                    {
                        case 'A':
                            ft.teamType = "Team Type: Hunter";
                            HunterSkills();
                            placeholder = true;
                            break;

                        case 'B':
                            ft.teamType = "Team Type: Survivor";
                            SurvivorSkills();

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
        public void HunterSkills()
        {
            bool ph = false;

            while (!ph)
            {
                try
                {
                    string[] skillChoices = { "Doppelganger", "Poltergeist", "Trickster", "Phantom", "Assassin" };

                    Console.WriteLine("\nPlease choose your skill:");
                    opt.hunterSkills();

                    ft.hunterSkill = Console.ReadLine();

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
        public void SurvivorSkills()
        {
            string[] skillChoices = { "Ace In The Hole", "Blood Pact", "Circle of Healing", "Borrowed Time", "Critical Thinking" };

            Console.WriteLine("\nPlease choose your skill:\n");
            opt.survivorSkills();

            ft.survivorSkill = Console.ReadLine();

            Weapon();
        }
        public void Weapon()
        {
            string[] weaponChoices = { "Rifle", "Machete", "Axe", "Pistol", "Grenade Launcher" };

            Console.WriteLine("\nPlease choose your weapon:");
            opt.weapon();

            ft.weapon = Console.ReadLine();

            Abilities();
        }
        public void Abilities()
        {

            Console.WriteLine("\nPlease choose your ability:\n");
            opt.ability();

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
                    opt.hairStyle();

                    ft.hairStyle = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your hair color:\n");
                    opt.hairColor();

                    ft.hairColor = Console.ReadLine();

                    Console.WriteLine("\nPlease choose your skin color:");
                    opt.skinColor();

                    ft.skinColor = Console.ReadLine();

                    Console.WriteLine("\nPlease choose your eye color:");
                    opt.eyeColor();

                    ft.eyeColor = Console.ReadLine();

                    Console.WriteLine("\nPlease choose your scar:\n");
                    

                    ft.scar = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your face shape:\n");
                    opt.shape();

                    ft.faceShape = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your expression:\n");
                    opt.expression();
                    ft.faceExpression = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your height:\n");
                    opt.heights();
                    ft.height = Console.ReadLine();


                    Console.WriteLine("\nPlease choose your weight:\n");
                    opt.weights();
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
    }
}
              
        
