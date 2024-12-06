using System;

namespace CharacterCreation
{
    public abstract class Characters : saveOrEdit
    {
        public Options op { get; set; }
        public features ft { get; set; }

        public Characters()
        {
            this.op = new Options();
            this.ft = new features();
        }

        public abstract void Scream();

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