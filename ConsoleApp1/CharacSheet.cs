using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCreation;
using Finals;

namespace CharacterCreation
{
    public interface saveOrEdit
    {
        void Save();
        void Edit();
    }

    public class CharacSheet : saveOrEdit
    {
        Options opt = new Options();
        features ft = new features();

        public void Accessories()
        {
            string[] hats = { "Baseball Cap", "Cowboy Hat", "Beret", "Bucket Hat", "Fedora", "None" };
            string[] playerGlasses = { "Square Eyeglasses", "Round Eyeglasses", "Oval Eyeglasses", "Rectangle Eyeglasses", "Sunglasses", "None" };
            string[] necklaces = { "Gold", "Silver", "Chain", "Diamond", "Pearl", "None" };
            string[] bracelets = { "Gold", "Silver", "Chain", "Diamond", "Pearl", "None" };
            string[] anklets = { "Charm Anklet", "Gold Anklet", "Beaded Anklet", "Chain Anklet", "Silver Anklet", "None" };

            Console.WriteLine("\nPlease choose your accessories:\n");
            Console.WriteLine($"Hat: \n{string.Join("\n", hats)}");
            ft.hat = Console.ReadLine();

            Console.WriteLine($"Glasses:\n{string.Join("\n", playerGlasses)}");
            ft.glasses = Console.ReadLine();

            Console.WriteLine($"Necklace:\n{string.Join("\n", necklaces)}");
            ft.necklace = Console.ReadLine();

            Console.WriteLine($"Bracelet:\n{string.Join("\n", bracelets)}");
            ft.bracelet = Console.ReadLine();

            Console.WriteLine($"Anklet:\n{string.Join("\n", anklets)}");
            ft.anklet = Console.ReadLine();

            Armor();
        }
        public void Buffs()
        {
            string[] buffs = { "Enhanced Healing", "Increase Attack Speed", "Tough Defense", "Increased Stealth", "Increased Stamina" };

            Console.WriteLine($"Buffs:\n{string.Join("\n ", buffs)}"); ;
            ft.buff = Console.ReadLine();

            Attitude();

        }
        public void Armor()
        {

            bool ph = false;
            while (!ph)
            {
                string[] armors = { "Sturdy Armor", "Leather Armor", "Iron Armor", "Chain Armor", "Cloth Armor" };
                
                Console.WriteLine("\nPlease choose your armor:\n");
                opt.armors();
                ft.armor = Console.ReadLine();

                if (Array.Exists(armors, armors => armors.Equals(ft.armor, StringComparison.OrdinalIgnoreCase))) {
                    Buffs();
                    ph = true;
                }
                else
                {
                    Console.WriteLine("Invalid input! Try again.");
                }
            }
        }
        public void Attitude()
        {
            bool ph = false;
            while (!ph)
            {
                string[] attitudes = { "Wistful", "Enthusiastic", "Calm", "Scared", "Blank" };

                opt.attitudes();
                ft.attitude = Console.ReadLine();

                if (Array.Exists(attitudes, attitude => attitude.Equals(ft.armor, StringComparison.OrdinalIgnoreCase)))
                {
                    Buffs();
                    ph = true;
                }
                else
                {
                    Console.WriteLine("Invalid input! Try again.");
                }

                PrintAll();
            }
        }
        public virtual void PrintAll()
        {
            Console.WriteLine($"\nCharacter Information:");
            Console.WriteLine($"Name: {ft.playerName}");
            Console.WriteLine($"Age: {ft.playerAge}");
            Console.WriteLine($"Gender: {ft.playerGender}");
            Console.WriteLine($"{ft.teamType}\n");

            Console.WriteLine($"Clothes: ");
            Console.WriteLine($"Top: {ft.playerTop}");
            Console.WriteLine($"Pants: {ft.playerPants}\n");

            Console.WriteLine($"Physical Traits: ");
            Console.WriteLine($"Face Shape: {ft.faceShape}");
            Console.WriteLine($"Hair Color: {ft.hairColor}");
            Console.WriteLine($"Hairstyle: {ft.hairStyle}");
            Console.WriteLine($"Skin Color: {ft.skinColor}");
            Console.WriteLine($"Eye Color: {ft.eyeColor}");
            Console.WriteLine($"Height: {ft.height}");
            Console.WriteLine($"Weight: {ft.weight}\n");

            Console.WriteLine("Accessories: ");
            Console.WriteLine($"Hat: {ft.hat}");
            Console.WriteLine($"Glasses: {ft.glasses}");
            Console.WriteLine($"Necklace: {ft.necklace}");
            Console.WriteLine($"Bracelet: {ft.bracelet}");
            Console.WriteLine($"Anklet: {ft.anklet}\n");

            Console.WriteLine($"Character's Unique Traits: ");
            Console.WriteLine($"Hunter Skill: {ft.hunterSkill}");
            Console.WriteLine($"Survivor Skill: {ft.survivorSkill}");
            Console.WriteLine($"Weapon: {ft.weapon}");
            Console.WriteLine($"Ability: {ft.ability}");
            Console.WriteLine($"Buff:{ft.buff}");
            Console.WriteLine($"Scar: {ft.scar}\n");

            Console.WriteLine("\nCharacter's Stats:");
            Console.WriteLine($"Health: {ft.health}");
            Console.WriteLine($"Strength: {ft.strength}");
            Console.WriteLine($"Stamina: {ft.stamina}");
            Console.WriteLine($"Speed: {ft.speed}");
            Console.WriteLine($"Energy: {ft.energy}");


            try
            {

                Console.WriteLine("\nGo back to main menu?");
                Console.WriteLine("(1) YES");
                Console.WriteLine("(2) NO");

                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Menu.MainMenu();
                        break;
                    case 2:
                        PrintAll();
                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
        public void Save()
        {
            try
            {
                Console.WriteLine("Save character?");
                Console.WriteLine("(1) YES");
                Console.WriteLine("(2) NO");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Menu.MainMenu();
                        break;
                    case 2:

                        break;
                    default:
                        throw new Exception("Invalid input. Try again!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public void Edit()
        {

            try
            {
                Console.WriteLine("Which trait do you wish to edit?");
                Console.WriteLine("[1] Character Information");
                Console.WriteLine("[2] Character's Unique Traits");
                Console.WriteLine("[3] Character's Stats");
                Console.WriteLine("[4] Clothing");
                Console.WriteLine("[5] Accessories");
                Console.WriteLine("[6] Physical Traits");

                throw new ArgumentException("Chosen trait unavailable. Try again!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

