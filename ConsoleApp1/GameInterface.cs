using System;

namespace CharacterCreation
{
    public interface saveOrEdit
    {
        public Options op { get; set; }
        public UserFeatures ft { get; set; }
        public CharacSheetsCon cs { get; set; }
        public GameStruc gs { get; set; }

        public abstract void Introduction();

        public void Save();
        public void Edit();
    }
}