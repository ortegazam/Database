using System;

namespace CharacterCreation
{
    public class Exceptions
    {
        public class InvalidException : Exception
        {
            public InvalidException(string message) : base(message) { }
        }
        
    }
}