using System;

namespace CharacterCreation
{
    public abstract class Characters : saveOrEdit
    {
        public Options op { get; set; }
        public features ft { get; set; }
        public CharacSheetsCon cs { get; set; }
        public GameStruc gs { get; set; }

        public Characters()
        {
            this.op = new Options();
            this.ft = new features();
        }

        public abstract void Introduction();

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