using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CharacterCreation
{
    public class CharacterSheetMethod
    {
        private string playerName;
        private int playerAge;
        private string playerGender;
        private string teamType;
        private string hunterSkill;
        private string survivorSkill;
        private string weapon;
        private string ability;
        private string hairStyle;
        private string scar;
        private string faceShape;
        private string faceExpression;
        private string hairColor;
        private string skinColor;
        private string eyeColor;
        private string playerTop;
        private string playerPants;
        private string height;
        private string weight;
        private string hat;
        private string buff;
        private string glasses;
        private string necklace;
        private string bracelet;
        private string anklet;
        private int stats;
        private int health;
        private int strength;
        private int stamina;
        private int speed;
        private int energy;
        

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
 
                        string name = Console.ReadLine();


                        if (Regex.IsMatch(name, @"^[A-Za-z0-9]+$") && name.Length <= 20 && name.Length >= 1)
                        {
                            playerName = name;

                            Console.WriteLine($"\nWelcome, {name}! You're reaching your death.\n");
                            Age();

                            placeholder = true;
                        }
                        else
                        {
                            throw new Exceptions.InvalidException("Hala ka!");
                        }

                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);

                        }
                        
                    
                    catch (Exceptions.InvalidException ex)
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

                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 0  && age > 5)
                {
                    throw new Exceptions.InvalidException("Josko, par. Wala sa options 'yan e.");
                }
                else
                {
                    playerAge = age;

                    Gender();
                }
                }
            catch (Exceptions.InvalidException ex) { 
                Console.WriteLine("Error: " + ex.Message);
            }
            }
        public void Gender()
        {
            string[] genderOptions = {"Agender", "Cisgender", "Nonbinary", "Gender Neutral", "Pangender", "Androgyne", "Transgender", "Bigender", "Others"};
            Console.WriteLine("\nPlease choose the gender you identified with: \n");
            Console.WriteLine("[A] \tAgender");
            Console.WriteLine("[B] \tCisgender");
            Console.WriteLine("[C] \tNonbinary");
            Console.WriteLine("[D] \tGender Neutral");
            Console.WriteLine("[E] \tPangender");
            Console.WriteLine("[F] \tAndrogyne");
            Console.WriteLine("[G] \tTransgender");
            Console.WriteLine("[H] \tBigender");
            Console.WriteLine("[I] \tOthers");
            Console.Write("Gender: ");

            string gender = Console.ReadLine().ToUpper();
            
            playerGender = gender;
           
            GameType();

        }
        public void GameType()
        {
            bool placeholder = false;

            while (!placeholder)
            {
                string[] choices = { "Hunter", "Survivor" };
                try
                {
                    Console.WriteLine("Hunters/Ghosts: It is known across the city that citizens who come across the mansion never go out alive. Hunters are known for eating their prey, claws gritting against their prey’s skin. However, unbeknownst to them, hunters kill them to hide their buried secrets. As a hunter, you must guard what is the six-feet-under secret of the mansion. \r\n\n");
                    Console.WriteLine("Survivor/Detective: Waking up inside an eerie abandoned mansion, you must find clues around where you woke up to get out of what is described as a hellhole. While you find and search for clues regarding the mysterious accident that led them here, you must also remain undiscovered by the hunter. Once found, you might not be able to escape because you are dead. As a survivor, you should survive and meticulously act as a detective to retain your freedom. \n");
                    Console.WriteLine($"Please choose your team type, {playerName}.\n");

                    string choice = Console.ReadLine();

                    switch (choice.ToLower())
                    {
                        case "hunter":                           
                            teamType = "Hunter";
                            HunterSkills();

                            placeholder = true;

                            
                            break;

                        case "survivor":                        
                            teamType = "Survivor";
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
        public void PhysicalTraits()
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
            Console.WriteLine("Hairstyle: ");
            Console.WriteLine("Clean Cut");
            Console.WriteLine("Buzz Cut");
            Console.WriteLine("Fade Cut");
            Console.WriteLine("Wolf Cut");
            Console.WriteLine("Long Hair" +
                "");
            string choiceOne = Console.ReadLine();
            hairStyle = choiceOne;

            Console.WriteLine("\nPlease choose your hair color:\n");
            Console.WriteLine("Red, Black, Brown, Orange, Blonde");
            Console.WriteLine();
            string choiceTwo = Console.ReadLine();
            hairColor = choiceTwo;

            Console.WriteLine("\nPlease choose your skin color:\n");
            Console.WriteLine("Brown, Black, White, Yellow, Porcelain");
            string choiceThree = Console.ReadLine();
            skinColor = choiceThree;

            Console.WriteLine("\nPlease choose your eye color\n");
            Console.WriteLine("Brown, Black, Red, Blue, Green");
            string choiceFour = Console.ReadLine();
            eyeColor = choiceFour;

            Console.WriteLine("\nPlease choose your scar:\n");
            Console.WriteLine("Eye scar, Leg scar, Arm scar, Chest scar, Shoulder scar");
            string choiceFive = Console.ReadLine();
            scar = choiceFive;

            Console.WriteLine("\nPlease choose your face shape:\n");
            Console.WriteLine("Triangular, Oval, Circle, Square, Diamond");
            string choiceSix = Console.ReadLine();
            faceShape = choiceSix;

            Console.WriteLine("\nPlease choose your expression:\n");
            Console.WriteLine("Angry, Sad, Smile, Calm, Confused");
            string choiceSeven = Console.ReadLine();
            faceExpression = choiceSeven;

            Console.WriteLine("\nPlease choose your height:\n");
            Console.WriteLine("Short, Average, Tall, Dwarf, Giant");
            string choiceEight = Console.ReadLine();
            height = choiceEight;

            Console.WriteLine("\nPlease choose your weight:\n");
            Console.WriteLine("Skinny, Slim, Fit, Plum, Fat");
            string choiceNine = Console.ReadLine();
            weight = choiceNine;

            Clothing();
        }
        public void Weapon()
        {
            string[] weaponChoices = { "Rifle", "Machete", "Axe", "Pistol", "Grenade Launcher" };

            Console.WriteLine("\nPlease choose your weapon:\n");
            Console.WriteLine($"\nRifle: A gun that can slow down the hunter. Perhaps the hunter has a sturdy body that deflects the bullets");
            Console.WriteLine($"Machete: A weapon that can scratch the hunter. Depending on how severe the hit is, you may be able to leave a long-lasting effect");
            Console.WriteLine($"Axe:  A weapon that can scratch the hunter, but it looks like it’s been used before. Depending on how severe the hit is, you may be able to leave a long-lasting effect. ");
            Console.WriteLine($"Pistol: A gun that can slow down the hunter, but you might run out of ammo soon. Perhaps the hunter has a sturdy body that deflects the bullets");
            Console.WriteLine($"Bow and Arrow: Left by an archer who lost their life inside the mansion, you must avenge them by killing and escaping the mansion");
            Console.WriteLine($"Grenade Launcher: A weapon that may be able to kill the hunter, but aftereffects will be possible. ");

            string choice = Console.ReadLine();

            weapon = choice;
            Abilities();
}
        public void HunterSkills()
        {
            string[] skillChoices = {"Doppelganger", "Poltergeist", "Trickster", "Phantom", "Assassin"};

            Console.WriteLine("\nPlease choose your skill:\n");
            Console.WriteLine($"\nDoppelganger: You can pretend as one of the survivors whom you killed before within a brief period.");
            Console.WriteLine($"Poltergeist: You can be invisible for a brief period. Your steps will still be heard by the survivors.");
            Console.WriteLine($"Trickster: You can trick the survivors that you are dead.");
            Console.WriteLine($"Phantom: Your steps will not be heard by the survivors in a limited time. ");
            Console.WriteLine($"Assassin: Once you spot a survivor, you can kill them despite out of range. ");

            string choice = Console.ReadLine();

            hunterSkill = choice;
            Weapon();
;        }
        public void SurvivorSkills()
        {
            string[] skillChoices = { "Ace In The Hole", "Blood Pact", "Circle of Healing", "Borrowed Time", "Critical Thinking" };

            Console.WriteLine("\nPlease choose your skill:\n");
            Console.WriteLine($"\nAce In The Hole: You can use any of ‘Blood Pact,’ ‘Circle of Healing,’ Borrowed Time, Critical Thinking, -60 Health amount per casting");
            Console.WriteLine($"Blood Pact: You can reduce the Hunter’s health upon casting, causing them to slow down and reduce their sight for 3 seconds. ");
            Console.WriteLine($"Circle of Healing: You can heal your Health with a random amount");
            Console.WriteLine($"Borrowed Time: You can go back in time, where you are still not eaten by the hunter. (You can only use this skill if you meet the hunter.) \r\n");
            Console.WriteLine($"Critical Thinking: You will be given a hint of where to use the clues you currently have.");

            string choice = Console.ReadLine();

            survivorSkill = choice;
            Weapon();
        }
        public void Abilities()
        {

            Console.WriteLine("\nPlease choose your ability:\n");
            Console.WriteLine($"\nHealing: This ability allows the player to recover half of their current health.");
            Console.WriteLine($"Sword Wielder: The player will be able to efficiently wield a sword once obtained, inflicting damage to the enemy; leading to a long-lasting effect.  ");
            Console.WriteLine($"Marksman: The player will have the ability to shoot the enemy once obtained, inflicting damage to the hunter; leading to a long-lasting effect. ");
            Console.WriteLine($"Clairvoyance: The player will be notified if the enemy’s nearby.");
            Console.WriteLine($"Silent Steps: The player will be able to escape the enemy’s range of sight unnoticed.");

            string choice = Console.ReadLine(); 
            ability = choice;
            Stats();
        }
        public void Stats()
        {
            int playerHealth = 120;
            int playerStrength = 10;
            int playerStamina = 10;
            int playerSpeed = 10;
            int playerEnergy = 10;
            int statPoints = 5; 

            Console.WriteLine("\nPlease choose where you want to put your (5) free stat points:");
            while (statPoints > 0)
            {
                Console.WriteLine($"\nYou have {statPoints} points left to distribute.");
                Console.WriteLine("1. Health (the player has 120 HP by default, contributing a point adds 15 HP permanently)");
                Console.WriteLine("2. Strength (the player has 10 XP by default, contributing a point adds 5 XP permanently)");
                Console.WriteLine("3. Stamina (the player has 10 XP by default, contributing a point adds 4 XP permanently)");
                Console.WriteLine("4. Speed (the player has 10 XP by default, contributing a point adds 2 XP permanently)");
                Console.WriteLine("5. Energy (the player has 10 XP by default, contributing a point adds 2 XP permanently)");

                Console.Write("Enter the number corresponding to the stat you want to increase: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 5)
                {
                    switch (choice)
                    {
                        case 1:
                            playerHealth += 15;
                            Console.WriteLine("You added 1 point to Health.");

                            health = playerHealth;
                            break;
                        case 2:
                            playerStrength += 5;
                            Console.WriteLine("You added 1 point to Strength.");

                            strength = playerStrength;
                            break;
                        case 3:
                            playerStamina += 4;
                            Console.WriteLine("You added 1 point to Stamina.");

                            stamina = playerStamina;
                            break;
                        case 4:
                            playerSpeed += 2;
                            Console.WriteLine("You added 1 point to Speed.");

                            speed = playerSpeed;
                            break;
                        case 5:
                            playerEnergy += 2;
                            Console.WriteLine("You added 1 point to Energy.");

                            energy = playerEnergy;
                            break;
                    }
                    statPoints--; 
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again!");
                }
                stats = statPoints;
            }

            PhysicalTraits();
        }
        public void Clothing()
        {
            string[] top = { "Shirt", "Jacket", "Long Sleeves", "Dress", "Shoulder split", "Hoodie" };
            string[] pants = { "Cargo", "Shorts", "Jeans", "Leather Pants", "Khaki Pants" };

            Console.WriteLine("\nPlease choose your clothes:\n");
            Console.WriteLine($"Top:Shirt, Jacket, Long Sleeves, Dress, Shoulder split, Hoodie");
            string playerTops = Console.ReadLine();

            Console.WriteLine($"Pants: Cargo, Shorts, Jeans, Leather Pants, Khaki Pants ");       
            string playerPant = Console.ReadLine();

            playerTop = playerTops;
            playerPants = playerPant;
            Accessories();
            
        }
        public void Accessories()
        {
            string[] hats = { "Baseball Cap", "Cowboy Hat", "Beret", "Bucket Hat", "Fedora", "None" };
            string[] playerGlasses = { "Square Eyeglasses", "Round Eyeglasses", "Oval Eyeglasses", "Rectangle Eyeglasses", "Sunglasses", "None" };
            string[] necklaces = { "Gold", "Silver", "Chain", "Diamond", "Pearl", "None"};
            string[] bracelets = { "Gold", "Silver", "Chain", "Diamond", "Pearl", "None" };
            string[] anklets = { "Charm Anklet", "Gold Anklet", "Beaded Anklet", "Chain Anklet", "Silver Anklet", "None"};

            Console.WriteLine("\nPlease choose your accessories:\n");
            Console.WriteLine($"Hat: {string.Join(", ", hats)}");
            string hatChoice = Console.ReadLine();
            hat = hatChoice;

            Console.WriteLine($"Glasses: {string.Join(", ", playerGlasses)}");
            string glassesChoice = Console.ReadLine();
            glasses = glassesChoice;

            Console.WriteLine($"Necklace: {string.Join(", ", necklaces)}");
            string necklaceChoice = Console.ReadLine();
            necklace = necklaceChoice;

            Console.WriteLine($"Bracelet: {string.Join(", ", bracelets)}");
            string braceletChoice = Console.ReadLine();
            bracelet = braceletChoice;

            Console.WriteLine($"Anklet: {string.Join(", ", anklets)}");
            string ankletChoice = Console.ReadLine();
            anklet = ankletChoice;


            Armor();
        }
        public void Buffs()
        {
            string[] buffs = {"Enhanced Healing", "Increase Attack Speed", "Tough Defense", "Stealth", "Stamina"};
            
            Console.WriteLine("\nPlease choose your buff:\n");
            Console.WriteLine($"\nEnhanced Healing: XP +20");
            Console.WriteLine($"Increase Attack Speed: XP + 15");
            Console.WriteLine($"Tough Defense: XP +15");
            Console.WriteLine($"Stealth: XP +10");
            Console.WriteLine($"Stamina: XP +15");

            string buffChoice = Console.ReadLine();
            buff = buffChoice;

            Attitude();

        }
        public void Armor()
        {
            string[] armors = {"Sturdy Armor", "Leather Armor", "Iron Armor", "Chain Armor", "Cloth Armor"};
            
            Console.WriteLine("\nPlease choose your armor:\n");
            Console.WriteLine($"\nSturdy Armor: ‘Left by a knight from an unknown era. Does it mean the mansion’s already up by then?’ The hunter will not be able to eat you the first time. Make sure they do not have a second time. ");
            Console.WriteLine($"Leather Armor: ‘Made from an animal’s skin, the animal’s stench remains.’ The hunter might be able to eat you deliciously once you wear this within their radius. However, they might also think it is one of their emergency foods: the hounds. \r\n");
            Console.WriteLine($"Iron Armor: A heavy armor which came from a civilian who also came across the mansion. But also died. His soul remains inside the armor. Upon wearing this, you might feel hallucinations or perhaps, clues to the mansion’s secrets. ");
            Console.WriteLine($"Chain Armor: Because of the heaviness of the armor, the previous owner died because they lost the ability to run. Upon wearing this, your steps will be heavy. But the hunter will believe it is just one of his allies. ");
            Console.WriteLine($"Cloth Armor: Filled with blood, the previous owner’s wrath against the hunters remained inside the armor. Upon wearing this, you will be able to use blood pact occasionally, but with a health rebound. ");

            string armorChoice = Console.ReadLine();

            Buffs();
        }
        public void Attitude()
        {
            string[] attitudes = {"Wistful", "Enthusiastic", "Calm", "Scared", "Blank" };
            Console.WriteLine("\nPlease choose your attitude:\n");
            Console.WriteLine($"\nWistful: Because of the sudden accident, you miss your family and friends. No debuffs or buffs will commence upon selection. ");
            Console.WriteLine($"Enthusiastic: You consider the accident as fate. An adventure. No debuffs or buffs will commence upon selection.  ");
            Console.WriteLine($"Calm: You know this is a trial you must overcome to survive in a world much harsher than this. No debuffs or buffs will commence upon selection. ");
            Console.WriteLine($"Scared: You are not a fan of horror, and you hate gore. No debuffs or buffs will commence upon selection. ");
            Console.WriteLine($"Blank: You do not care. No debuffs or buffs will commence upon selection. ");

            string attitude = Console.ReadLine();
            PrintAll();
        }
        public void PrintAll()
        {
            Console.WriteLine($"\nCharacter Information:");
            Console.WriteLine($"Name: {playerName}");
            Console.WriteLine($"Age: {playerAge}");
            Console.WriteLine($"Gender: {playerGender}");
            Console.WriteLine($"Team Type: {teamType}\n");

            Console.WriteLine($"Clothes: ");
            Console.WriteLine($"Top: {playerTop}");
            Console.WriteLine($"Pants: {playerPants}\n");

            Console.WriteLine($"Physical Traits: ");
            Console.WriteLine($"Face Shape: {faceShape}");
            Console.WriteLine($"Hair Color: {hairColor}");
            Console.WriteLine($"Hairstyle: {hairStyle}");
            Console.WriteLine($"Skin Color{skinColor}");
            Console.WriteLine($"Eye Color: {eyeColor}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}\n");

            Console.WriteLine("Accessories: ");
            Console.WriteLine($"Hat: {hat}");
            Console.WriteLine($"Glasses: {glasses}");
            Console.WriteLine($"Necklace: {necklace}");
            Console.WriteLine($"Bracelet: {bracelet}");
            Console.WriteLine($"Anklet: {anklet}\n");
            

            Console.WriteLine($"Character's Unique Traits: ");
            Console.WriteLine($"Hunter Skill: {hunterSkill}");
            Console.WriteLine($"Survivor Skill: {survivorSkill}");
            Console.WriteLine($"Weapon: {weapon}");
            Console.WriteLine($"Ability: {ability}");           
            Console.WriteLine($"Buff:{buff}");
            Console.WriteLine($"Scar: {scar}\n");

            Console.WriteLine("\nCharacter's Stats:");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Strength: {strength}");
            Console.WriteLine($"Stamina: {stamina}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Energy: {energy}");
            try
            {
                Console.WriteLine("\nGo back to main menu?");
                Console.WriteLine("(1) YES");
                Console.WriteLine("(2) NO");
                string choice = Console.ReadLine();
            }
            catch (Exceptions.InvalidException ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}
