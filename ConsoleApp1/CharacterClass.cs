using System;

namespace CharacterCreation
{
    public class CharacterClass : Characters
    {
        public Options op { get; set; }
        public features ft { get; set; }
        public CharacSheetsCon cs { get; set; }

        public CharacterClass()
        {
            this.op = new Options();
            this.ft = new features();
            this.cs = new CharacSheetsCon();
        }

        public override void Introduction()
        {
            Console.WriteLine("REACHING DEATH!");
            Console.WriteLine("\n(1) New Game");
            Console.WriteLine("(2) View Existing Characters");
            Console.WriteLine("(3) Campaign Mode");
            Console.WriteLine("(4) Credits");
            Console.WriteLine("(5) Exit");
        }

        public void Save()
        {
            Console.WriteLine("Save character?");
        }

        public void Edit()
        {
            Console.WriteLine("Edit character?");
        }
    }
}