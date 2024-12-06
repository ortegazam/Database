using System;

namespace CharacterCreation
{
    public class CharacterClass : Characters
    {
        public Options op { get; set; }
        public features ft { get; set; }
        public CharacSheet cs { get; set; }

        public CharacterClass()
        {
            this.op = new Options();
            this.ft = new features();
            this.cs = new CharacSheet();
        }

        public override void Scream()
        {
            Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        }

        public void Save()
        {
            Console.WriteLine("SAVEEEE!");
        }

        public void Edit()
        {
            Console.WriteLine("EDITTTTT!");
        }
    }
}