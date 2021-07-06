using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApp.Application.Users.Abstractions;
using TestApp.Domain.Models.Users;

namespace TestApp.WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUsersHandler _handler;

        public UserController(IUsersHandler handler)
        {
            _handler = handler;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _handler.GetAllUsersAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<User> GetUser(int id)
        {
            return await _handler.GetUser(id);
        }
    }
}