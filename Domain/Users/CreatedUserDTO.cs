using System;
using System.Collections.Generic;

namespace Domain
{
    public class CreatedUserDTO
    {
        public Guid Id{get; private set; }
        public IList<string> Errors {get; set; }
        public bool IsValid {get; set; }

        public CreatedUserDTO(Guid id)
        {
            Id = id;
            IsValid = true;

        }
        public CreatedUserDTO(IList<string> errors)
        {
            //Essa atribuição não é necessaria,pois IsValid é false por padrão.
            IsValid = false;
            Errors = errors;
        }
    }
}