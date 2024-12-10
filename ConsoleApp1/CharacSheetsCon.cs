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
        public Options op { get; set; }
        public UserFeatures ft { get; set; }
        public CharacSheetsCon cs { get; set; }

        public static void Buffs(CharacterClass horrorCharacter)
        {
            string[] buffs = { "Enhanced Healing", "Increase Attack Speed", "Tough Defense", "Increased Stealth", "Increased Stamina" };

            Console.WriteLine($"Buffs:\n{string.Join("\n ", buffs)}"); ;
            horrorCharacter.ft.Buff = Console.ReadLine();

            Attitude(horrorCharacter);

        }
        public static void Armor(CharacterClass horrorCharacter)
        {

            bool ph = false;
            while (!ph)
            {
                string[] armors = { "Sturdy Armor", "Leather Armor", "Iron Armor", "Chain Armor", "Cloth Armor" };

                Console.WriteLine("\nPlease choose your armor:\n");
                Options.Armors();
                horrorCharacter.ft.Armor = Console.ReadLine();

                if (Array.Exists(armors, armors => armors.Equals(horrorCharacter.ft.Armor, StringComparison.OrdinalIgnoreCase)))
                {
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

                Options.Attitudes();
                horrorCharacter.ft.Attitude = Console.ReadLine();

                if (Array.Exists(attitudes, attitude => attitude.Equals(horrorCharacter.ft.Armor, StringComparison.OrdinalIgnoreCase)))
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
            Console.WriteLine($"{horrorCharacter.ft.TeamType}\n");

            Console.WriteLine($"Clothes: ");
            Console.WriteLine($"Top: {horrorCharacter.ft.PlayerTop}");
            Console.WriteLine($"Pants: {horrorCharacter.ft.PlayerPants}\n");

            Console.WriteLine($"Physical Traits: ");
            Console.WriteLine($"Face Shape: {horrorCharacter.ft.FaceShape}");
            Console.WriteLine($"Hair Color: {horrorCharacter.ft.HairColor}");
            Console.WriteLine($"Hairstyle: {horrorCharacter.ft.HairStyle}");
            Console.WriteLine($"Skin Color: {horrorCharacter.ft.SkinColor}");
            Console.WriteLine($"Eye Color: {horrorCharacter.ft.EyeColor}");
            Console.WriteLine($"Height: {horrorCharacter.ft.Height}");
            Console.WriteLine($"Weight: {horrorCharacter.ft.Weight}\n");

            Console.WriteLine("Accessories: ");
            Console.WriteLine($"Hat: {UserFeatures.Hat}");
            Console.WriteLine($"Glasses: {UserFeatures.Glasses}");
            Console.WriteLine($"Necklace: {UserFeatures.Necklace}");
            Console.WriteLine($"Bracelet: {UserFeatures.Bracelet}");
            Console.WriteLine($"Anklet: {UserFeatures.Anklet}\n");

            Console.WriteLine($"Character's Unique Traits: ");
            Console.WriteLine($"Hunter Skill: {horrorCharacter.ft.HunterSkill}");
            Console.WriteLine($"Survivor Skill: {horrorCharacter.ft.SurvivorSkill}");
            Console.WriteLine($"Weapon: {horrorCharacter.ft.Weapon}");
            Console.WriteLine($"Ability: {horrorCharacter.ft.Ability}");
            Console.WriteLine($"Buff: {horrorCharacter.ft.Buff}");
            Console.WriteLine($"Scar: {horrorCharacter.ft.Scar}\n");

            Console.WriteLine("\nCharacter's Stats:");
            Console.WriteLine($"Health: {horrorCharacter.ft.Health}");
            Console.WriteLine($"Strength: {horrorCharacter.ft.Strength}");
            Console.WriteLine($"Stamina: {horrorCharacter.ft.Stamina}");
            Console.WriteLine($"Speed: {horrorCharacter.ft.Speed}");
            Console.WriteLine($"Energy: {horrorCharacter.ft.Energy}");

            bool ph = false;

            while (!ph)
            {
                try
                {
                    Save();
                    Edit();
                }

                catch (ArgumentException ex) { }
            }

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
        public static void Save()
        {
            Console.WriteLine("Save character?");
        }

        public static void Edit()
        {
            Console.WriteLine("Edit character?");
        }
    }
}

