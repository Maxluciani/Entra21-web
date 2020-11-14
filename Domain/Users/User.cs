using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class User : person
    {
        public Guid Id {get; set; } =Guid.NewGuid();
                public Profile Profile {get; set; }

        public User(string name,Profile profile) : base(name)
        {
            
            Profile = profile;
        }
        public (IList<string> errors,bool isValid) Validate()
        {
            var errors = new List<string>();
            if(!ValidateName())
            {
                errors.Add("Nome Inválido");
            }
            return (errors,errors.Count == 0);
        }
        
    }
}

