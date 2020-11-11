namespace Domain
{
    public class UsersService
    {
        public CreatedUserDTO Created(string name, Profile profile)
        {
            var user = new User(name,profile);
            var userValidation = user.Validate();

            if(userValidation.isValid)
            {
                UsersRepository.Add(user);

            return new CreatedUserDTO(user.Id);
            }
            return new CreatedUserDTO(userValidation.errors);
        }
        
    }
}