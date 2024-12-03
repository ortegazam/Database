﻿using System.Text.RegularExpressions;

namespace CharacterCreation
{
    public class CharacterSheetMethod
    {
        PrintInfo printPlease = new PrintInfo();
        public string playerName { get; set; }
        public int playerAge { get; set; }
        public string playerGender { get; set; }
        public string teamType { get; set; }
        public string hunterSkill { get; set; }
        public string survivorSkill { get; set; }
        public string weapon { get; set; }
        public string ability { get; set; }
        public string hairStyle { get; set; }
        public string scar { get; set; }
        public string faceShape { get; set; }
        public string faceExpression { get; set; }
        public string hairColor { get; set; }
        public string skinColor { get; set; }
        public string eyeColor { get; set; }
        public string playerTop { get; set; }
        public string playerPants { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string hat { get; set; }
        public string buff { get; set; }
        public string glasses { get; set; }
        public string necklace { get; set; }
        public string bracelet { get; set; }
        public string anklet { get; set; }
        public string armor { get; set; }
        public int stats { get; set; }
        public int health { get; set; }
        public int strength { get; set; }
        public int stamina { get; set; }
        public int speed { get; set; }
        public int energy { get; set; }


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
 
                        playerName = Console.ReadLine();


                        if (Regex.IsMatch(playerName, @"^[A-Za-z0-9]+$") && playerName.Length <= 20 && playerName.Length >= 1)
                        {
                            

                            Console.WriteLine($"\nWelcome, {playerName}! You're reaching your death.\n");
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

                playerAge = Convert.ToInt32(Console.ReadLine());

                if (playerAge < 0  && playerAge > 5)
                {
                    throw new Exceptions.InvalidException("Josko, par. Wala sa options 'yan e.");
                }
                else
                {
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

            playerGender = Console.ReadLine().ToUpper();
   
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
                    Console.WriteLine("[A] Hunters/Ghosts: Hunters are known for eating their prey, " +
                        "claws gritting against their prey’s skin.");
                    Console.WriteLine("[B] Survivor/Detective: You will search for clues regarding the mysterious " +
                        "accident that led you here, undiscovered by the enemy.");
                    Console.WriteLine($"Please choose your team type, {playerName}.\n");

                    char choice = Convert.ToChar(Console.ReadLine().ToUpper());

                    switch (choice)
                    {
                        case 'A':                           
                            teamType = "Team Type: Hunter";
                            HunterSkills();

                            placeholder = true;

                            break;

                        case 'B':                        
                            teamType = "Team Type: Survivor";
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
            string[] skillChoices = { "Doppelganger", "Poltergeist", "Trickster", "Phantom", "Assassin" };

            Console.WriteLine("\nPlease choose your skill:");
            Console.WriteLine($"\nDoppelganger: You can pretend as one of the survivors whom you killed before within a brief period.");
            Console.WriteLine($"Poltergeist: You can be invisible for a brief period. Your steps will still be heard by the survivors.");
            Console.WriteLine($"Trickster: You can trick the survivors that you are dead.");
            Console.WriteLine($"Phantom: Your steps will not be heard by the survivors in a limited time. ");
            Console.WriteLine($"Assassin: Once you spot a survivor, you can kill them despite out of range. ");

            hunterSkill = Console.ReadLine();

            Weapon();
            
        }
        public void SurvivorSkills()
        {
            string[] skillChoices = { "Ace In The Hole", "Blood Pact", "Circle of Healing", "Borrowed Time", "Critical Thinking" };

            Console.WriteLine("\nPlease choose your skill:\n");
            Console.WriteLine($"\nAce In The Hole: You can use any of ‘Blood Pact,’ ‘Circle of Healing,’ Borrowed Time, Critical Thinking.");
            Console.WriteLine($"Blood Pact: You can reduce the Hunter’s health upon casting.");
            Console.WriteLine($"Circle of Healing: You can heal your Health with a random amount");
            Console.WriteLine($"Borrowed Time: You can go back in time, where you are still not eaten by the hunter.");
            Console.WriteLine($"Critical Thinking: You will be given a hint of where to use the clues you currently have.");

            survivorSkill = Console.ReadLine();

            Weapon();
        }
        public void Weapon()
        {
            string[] weaponChoices = { "Rifle", "Machete", "Axe", "Pistol", "Grenade Launcher" };

            Console.WriteLine("\nPlease choose your weapon:");
            Console.WriteLine($"\nRifle: A gun that can slow down the hunter.");
            Console.WriteLine($"Machete: A weapon that can scratch the hunter.");
            Console.WriteLine($"Axe:  A weapon that can scratch the hunter, but it looks like it’s been used before.");
            Console.WriteLine($"Pistol: A gun that can slow down the hunter, but you might run out of ammo soon.");
            Console.WriteLine($"Bow and Arrow: Left by an archer who lost their life inside the mansion.");
            Console.WriteLine($"Grenade Launcher: A weapon that may be able to kill the hunter.");

            weapon = Console.ReadLine();

            Abilities();
        }
        public void Abilities()
        {

            Console.WriteLine("\nPlease choose your ability:\n");
            Console.WriteLine($"Healing: This ability allows the player to recover half of their current health.");
            Console.WriteLine($"Sword Wielder: The player will be able to efficiently wield a sword once obtained.");
            Console.WriteLine($"Marksman: The player will have the ability to shoot the enemy once obtained.");
            Console.WriteLine($"Clairvoyance: The player will be notified if the enemy’s nearby.");
            Console.WriteLine($"Silent Steps: The player will be able to escape the enemy’s range of sight unnoticed.");

            ability = Console.ReadLine();

            Stats();
        }
        public void Stats()
        {
            health = 120;
            strength = 10;
            stamina = 10;
            speed = 10;
            energy = 10;
            stats = 5;

            Console.WriteLine("\nPlease choose where you want to put your (5) free stat points:");

            while (stats > 0)
            {
                Console.WriteLine("1. Health, +15 HP permanently.");
                Console.WriteLine("2. Strength, +5 XP permanently.");
                Console.WriteLine("3. Stamina, +4 XP permanently.");
                Console.WriteLine("4. Speed, +2 XP permanently.");
                Console.WriteLine("5. Energy, +2 XP permanently.");

                Console.Write("\nWhat stat do you wish to increase?");

                int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                health += 15;
                                Console.WriteLine("You added 15 points to HEALTH.");

                                break;
                            case 2:
                                strength += 5;
                                Console.WriteLine("You added 5 points to STRENGTH.");

                                break;
                            case 3:
                                stamina += 4;
                                Console.WriteLine("You added 4 points to STAMINA.");

                                break;
                            case 4:
                                speed += 2;
                                Console.WriteLine("You added 2 points to SPEED.");

                                break;
                            case 5:
                                energy += 2;
                                Console.WriteLine("You added 2 points to ENERGY.");
                                break;
                            default:
                                throw new Exception("Invalid input!");                    
                    }
            }
            PhysicalTraits();
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
            Console.WriteLine("Clean Cut");
            Console.WriteLine("Buzz Cut");
            Console.WriteLine("Fade Cut");
            Console.WriteLine("Wolf Cut");
            Console.WriteLine("Long Hair");

            hairStyle = Console.ReadLine();

            Console.WriteLine("\nPlease choose your hair color:\n");
            Console.WriteLine("Red");
            Console.WriteLine("Black");
            Console.WriteLine("Brown");
            Console.WriteLine("Orange");
            Console.WriteLine("Blonde");

            hairColor = Console.ReadLine();


            Console.WriteLine("\nPlease choose your skin color:");
            Console.WriteLine("Brown");
            Console.WriteLine("Black");
            Console.WriteLine("White");
            Console.WriteLine("Yellow");
            Console.WriteLine("Porcelain");

            skinColor = Console.ReadLine();
            
            Console.WriteLine("\nPlease choose your eye color:");
            Console.WriteLine("Brown");
            Console.WriteLine("Black");
            Console.WriteLine("Red");
            Console.WriteLine("Blue");
            Console.WriteLine("Green");

            eyeColor = Console.ReadLine();
            

            Console.WriteLine("\nPlease choose your scar:\n");
            Console.WriteLine("Eye Scar");
            Console.WriteLine("Leg Scar");
            Console.WriteLine("Arm Scar");
            Console.WriteLine("Chest Scar");
            Console.WriteLine("Shoulder Scar");

            scar = Console.ReadLine();
            

            Console.WriteLine("\nPlease choose your face shape:\n");
            Console.WriteLine("Triangular");
            Console.WriteLine("Oval");
            Console.WriteLine("Circle");
            Console.WriteLine("Square");
            Console.WriteLine("Diamond");

            faceShape = Console.ReadLine();
        

            Console.WriteLine("\nPlease choose your expression:\n");
            Console.WriteLine("Angry, Sad, Smile, Calm, Confused");
            faceExpression = Console.ReadLine();
            

            Console.WriteLine("\nPlease choose your height:\n");
            Console.WriteLine("Short, Average, Tall, Dwarf, Giant");
            height = Console.ReadLine();
            

            Console.WriteLine("\nPlease choose your weight:\n");
            Console.WriteLine("Skinny, Slim, Fit, Plum, Fat");
            weight = Console.ReadLine();
            

            Clothing();
        }
    
        public void Clothing()
        {
            string[] top = { "Shirt", "Jacket", "Long Sleeves", "Dress", "Shoulder split", "Hoodie" };
            string[] pants = { "Cargo", "Shorts", "Jeans", "Leather Pants", "Khaki Pants" };

            Console.WriteLine("\nPlease choose your clothes:\n");
            Console.WriteLine($"Top:\n{string.Join("\n ", top)}");
            playerTop = Console.ReadLine();

            Console.WriteLine($"Pants:\n{string.Join("\n ", pants)}");
            playerPants = Console.ReadLine();

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
            Console.WriteLine($"Hat: \n{string.Join("\n", hats)}");
            hat = Console.ReadLine();

            Console.WriteLine($"Glasses:\n{string.Join("\n", playerGlasses)}");
            glasses = Console.ReadLine();
            
            Console.WriteLine($"Necklace:\n{string.Join("\n", necklaces)}");
            necklace = Console.ReadLine();       

            Console.WriteLine($"Bracelet:\n{string.Join("\n", bracelets)}");
            bracelet = Console.ReadLine();

            Console.WriteLine($"Anklet:\n{string.Join("\n", anklets)}");
            anklet = Console.ReadLine();

            Armor();
        }
        public void Buffs()
        {
            string[] buffs = {"Enhanced Healing", "Increase Attack Speed", "Tough Defense", "Increased Stealth", "Increased Stamina"};

            Console.WriteLine($"Buffs:\n{string.Join("\n ", buffs)}"); ;      
            buff = Console.ReadLine();

            Attitude();

        }
        public void Armor()
        {
            string[] armors = {"Sturdy Armor", "Leather Armor", "Iron Armor", "Chain Armor", "Cloth Armor"};
            
            Console.WriteLine("\nPlease choose your armor:\n");
            Console.WriteLine($"Sturdy Armor: ‘Left by a knight from an unknown era. Does it mean the mansion’s already up by then?’ The hunter will not be able to eat you the first time. Make sure they do not have a second time. ");
            Console.WriteLine($"Leather Armor: ‘Made from an animal’s skin, the animal’s stench remains.’ The hunter might be able to eat you deliciously once you wear this within their radius. However, they might also think it is one of their emergency foods: the hounds. \r\n");
            Console.WriteLine($"Iron Armor: A heavy armor which came from a civilian who also came across the mansion. But also died. His soul remains inside the armor. Upon wearing this, you might feel hallucinations or perhaps, clues to the mansion’s secrets. ");
            Console.WriteLine($"Chain Armor: Because of the heaviness of the armor, the previous owner died because they lost the ability to run. Upon wearing this, your steps will be heavy. But the hunter will believe it is just one of his allies. ");
            Console.WriteLine($"Cloth Armor: Filled with blood, the previous owner’s wrath against the hunters remained inside the armor. Upon wearing this, you will be able to use blood pact occasionally, but with a health rebound. ");

            armor = Console.ReadLine();

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
            Console.WriteLine($"{teamType}\n");

            Console.WriteLine($"Clothes: ");
            Console.WriteLine($"Top: {playerTop}");
            Console.WriteLine($"Pants: {playerPants}\n");

            Console.WriteLine($"Physical Traits: ");
            Console.WriteLine($"Face Shape: {faceShape}");
            Console.WriteLine($"Hair Color: {hairColor}");
            Console.WriteLine($"Hairstyle: {hairStyle}");
            Console.WriteLine($"Skin Color: {skinColor}");
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
            catch (Exceptions.InvalidException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


    }
}
