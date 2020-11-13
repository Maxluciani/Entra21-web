using System;
using System.Collections.Generic;

namespace Domain
{
    public class Player
    {
        public Guid Id {get; private set;} = Guid.NewGuid();
        public string Name {get; private set;}
        public int Goals {get; private set}

        public Player(string name)
        {
            Name = name;
        }
        private bool ValidateName()
        {
            if(string.IsNullOrEmpty(Name))
            {
                return false;
            }
            var words = Name.Split(' ');
            if(words.Length <2)
            {
                return false;
            }
            foreach (var word in words)
            {
               if(word.Trim().Length<2)
               {
                   return false;
               } 
               if(word.Any(x => !char.IsLetter(x)))
               {
                   return false;
               }
            }
            return true;
        }
        public (IList<string> errors, bool IsValid) Validate()
        {
            var errors = new List<string>();
            if(!ValidateName())
            {
                errors.Add("Nome invalido.");
            }
            return (errors, errors.Count==0);
        }

    }
}