using System;

namespace CharacterCreation
{
    public interface saveOrEdit
    {
        public Options op { get; set; }
        public features ft { get; set; }
        public CharacSheet cs { get; set; }
        public GameStruc gs { get; set; }

        public abstract void Scream();

        public void Save();
        public void Edit();
    }
}