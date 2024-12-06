using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCreation;


namespace CharacterCreation
{
    public class CharacSheetsCon
    {

        public static void Buffs(CharacterClass horrorCharacter)
        {
            string[] buffs = { "Enhanced Healing", "Increase Attack Speed", "Tough Defense", "Increased Stealth", "Increased Stamina" };

            Console.WriteLine($"Buffs:\n{string.Join("\n ", buffs)}"); ;
            horrorCharacter.ft.buff = Console.ReadLine();

            Attitude(horrorCharacter);

        }
        public static void Armor(CharacterClass horrorCharacter)
        {

            bool ph = false;
            while (!ph)
            {
                string[] armors = { "Sturdy Armor", "Leather Armor", "Iron Armor", "Chain Armor", "Cloth Armor" };

                Console.WriteLine("\nPlease choose your armor:\n");
                Options.armors();
                horrorCharacter.ft.armor = Console.ReadLine();

                if (Array.Exists(armors, armors => armors.Equals(horrorCharacter.ft.armor, StringComparison.OrdinalIgnoreCase))) {
                    Buffs(horrorCharacter);
                    ph = true;
                }
                else
                {
                    Console.WriteLine("Invalid input! Try again.");
                }
            }
        }
        public static void Attitude(CharacterClass horrorCharacter)
        {
            bool ph = false;
            while (!ph)
            {
                string[] attitudes = { "Wistful", "Enthusiastic", "Calm", "Scared", "Blank" };

                Options.attitudes();
                horrorCharacter.ft.attitude = Console.ReadLine();

                if (Array.Exists(attitudes, attitude => attitude.Equals(horrorCharacter.ft.armor, StringComparison.OrdinalIgnoreCase)))
                {
                    Buffs(horrorCharacter);
                    ph = true;
                }
                else
                {
                    Console.WriteLine("Invalid input! Try again.");
                }

                PrintAll(horrorCharacter);
            }
        }

        public static void PrintAll(CharacterClass horrorCharacter)
        {
            Console.WriteLine($"\nCharacter Information:");
            Console.WriteLine($"Name: {horrorCharacter.gs.playerName}");
            Console.WriteLine($"Age: {horrorCharacter.gs.playerAge}");
            Console.WriteLine($"Gender: {horrorCharacter.gs.playerGender}");
            Console.WriteLine($"{horrorCharacter.ft.teamType}\n");

            Console.WriteLine($"Clothes: ");
            Console.WriteLine($"Top: {horrorCharacter.ft.playerTop}");
            Console.WriteLine($"Pants: {horrorCharacter.ft.playerPants}\n");

            Console.WriteLine($"Physical Traits: ");
            Console.WriteLine($"Face Shape: {horrorCharacter.ft.faceShape}");
            Console.WriteLine($"Hair Color: {horrorCharacter.ft.hairColor}");
            Console.WriteLine($"Hairstyle: {horrorCharacter.ft.hairStyle}");
            Console.WriteLine($"Skin Color: {horrorCharacter.ft.skinColor}");
            Console.WriteLine($"Eye Color: {horrorCharacter.ft.eyeColor}");
            Console.WriteLine($"Height: {horrorCharacter.ft.height}");
            Console.WriteLine($"Weight: {horrorCharacter.ft.weight}\n");

            Console.WriteLine("Accessories: ");
            Console.WriteLine($"Hat: {horrorCharacter.ft.hat}");
            Console.WriteLine($"Glasses: {horrorCharacter.ft.glasses}");
            Console.WriteLine($"Necklace: {horrorCharacter.ft.necklace}");
            Console.WriteLine($"Bracelet: {horrorCharacter.ft.bracelet}");
            Console.WriteLine($"Anklet: {horrorCharacter.ft.anklet}\n");

            Console.WriteLine($"Character's Unique Traits: ");
            Console.WriteLine($"Hunter Skill: {horrorCharacter.ft.hunterSkill}");
            Console.WriteLine($"Survivor Skill: {horrorCharacter.ft.survivorSkill}");
            Console.WriteLine($"Weapon: {horrorCharacter.ft.weapon}");
            Console.WriteLine($"Ability: {horrorCharacter.ft.ability}");
            Console.WriteLine($"Buff: {horrorCharacter.ft.buff}");
            Console.WriteLine($"Scar: {horrorCharacter.ft.scar}\n");

            Console.WriteLine("\nCharacter's Stats:");
            Console.WriteLine($"Health: {horrorCharacter.ft.health}");
            Console.WriteLine($"Strength: {horrorCharacter.ft.strength}");
            Console.WriteLine($"Stamina: {horrorCharacter.ft.stamina}");
            Console.WriteLine($"Speed: {horrorCharacter.ft.speed}");
            Console.WriteLine($"Energy: {horrorCharacter.ft.energy}");


            try
            {

                Console.WriteLine("\nGo back to main menu?");
                Console.WriteLine("(1) YES");
                Console.WriteLine("(2) NO");

                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Menu.MainMenu(horrorCharacter);
                        break;
                    case 2:
                        PrintAll(horrorCharacter);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    } }

// public void Save()
//{
 //   try
  //  {
  //      Console.WriteLine("Save character?");
  //      Console.WriteLine("(1) YES");
  //      Console.WriteLine("(2) NO");

  //      int choice = Convert.ToInt32(Console.ReadLine());

  //      switch (choice)
   //     {
 //           case 1:
 //               Menu.MainMenu(horrorCharacter);
 //               break;
 //           case 2:

//                break;
 //           default:
//                throw new Exception("Invalid input. Try again!");
//        }
//    }
 //   catch (Exception ex)
 //   {
 //       Console.WriteLine("Error: " + ex.Message);
 //   }
//}
//public void Edit()
//{

 //   try
 //   {
  //      Console.WriteLine("Which trait do you wish to edit?");
  //      Console.WriteLine("[1] Character Information");
   //     Console.WriteLine("[2] Character's Unique Traits");
   //     Console.WriteLine("[3] Character's Stats");
   //     Console.WriteLine("[4] Clothing");
   //     Console.WriteLine("[5] Accessories");
   //     Console.WriteLine("[6] Physical Traits");

   //     throw new ArgumentException("Chosen trait unavailable. Try again!");
  // }
   // catch (ArgumentException ex)
//    {
  //      Console.WriteLine("Error: " + ex.Message);
 //   }
//} 

//}
//}

