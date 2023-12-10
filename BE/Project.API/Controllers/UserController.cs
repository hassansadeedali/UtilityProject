using Microsoft.AspNetCore.Mvc;
using Project.API.Model.Domain;
using Project.API.Model.Dto;
using Project.API.Repository.Interface;

namespace Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await userRepository.GetUser(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(UserRequestDto req)
        {
            var user = new User()
            {
                Name = req.Name,
                Email = req.Email
            };
            
            await userRepository.AddUser(user);   

            return Ok(user);
        }
    }
}
