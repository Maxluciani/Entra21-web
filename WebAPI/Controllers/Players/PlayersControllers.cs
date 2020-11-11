using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace WebAPI.Controllers.Players
{
    [ApiController]
    [Route("[Controller]")]
    public class PlayersControllers : ControllerBase
    {
        private readonly PlayersService _playersService;
        private readonly UsersService _usersService;
        
        public PlayersController()
        {
            _usersService = new UsersService();
            _playersService = new PlayersService()
        }
        
        [HttpPost]
        public IActionResult Create(CreatedPlayerRequest request)
        {
            StringValues userId;
            if(!Request.Headers.TryGetValue("UserId", out userId ))
            {
                return Unauthorized();
            }
            var user = _usersService.GetById(Guid.Parse(userId));
            if(user == null)
            {
              return Unauthorized();
              // return Forbid("Test");
            }
             var response = _playersService.Create(request.Name);

             if(response.IsValid)
             {
                 return BadRequest(request.Errors);
             }
             return Ok(response.Id);
        }

    }

   
}