using System;
using System.Collections.Generic;

namespace Domain
{
    public class Player : person
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public int Goals {get; private set; }

        public Player(string name) : base(name)   {}

        public (IList<string> Errors,bool IsValid) Validate()
        {
            var errors = new List<string>();

            if(!ValidateName())
            {
              errors.Add("Nome invalido");
            }
            return(errors,errors.Count == 0);
        }
    

    }
}