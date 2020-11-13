using System;
using System.Collections.Generic;

namespace Domain
{
    public class CreatePlayerDTO
    {
        public Id Guid {get; private set; }
        public IList<string> Errors {get; set;}
        public bool IsValid {get; set;}

        public CreatePlayerDTO(Guid id)
        {
            Id = id;
            IsValid = true;
        }

        public CreatePlayerDTO(IList<string> errors)
        {
         IsValid = false;
         Errors = errors;
      
        }
    }
}