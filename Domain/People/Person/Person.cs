using System.Linq;

namespace Domain
{
    //abstractpois não deveriamos instanciar a classe Person
    public abstract class person
    {
        public string Name {get; protected set;}
        
        public person(string name)
        {
            Name = name;

        }

        //Este metodo continua sendo privado,porem é acessivel pelos filhos.
        protected bool ValidateName()
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
    }
}