namespace Domain
{
    public class PlayersService
    {
        public CreatePlayerDTO Create(string name)
        {
            var player= new Player(name);
            var playerValidation = player.Validate();

            if(playerValidation.IsValid)
            {
                PlayersRepository.Add(player);
                return new CreatePlayerDTO(player.Id);
            }
            return new CreatePlayerDTO(playerValidation.errors);
        }
    }
}