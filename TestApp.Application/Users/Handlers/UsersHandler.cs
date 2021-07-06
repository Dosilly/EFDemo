using System.Collections.Generic;
using System.Threading.Tasks;
using TestApp.Application.Abstractions;
using TestApp.Application.Users.Abstractions;
using TestApp.Domain.Models.Users;

namespace TestApp.Application.Users.Handlers
{
    public class UsersHandler : IUsersHandler
    {
        private readonly IUsersRepository _usersRepository;

        public UsersHandler(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _usersRepository.GetAllUsers();
        }

        public async Task<User> GetUser(int id)
        {
            return await _usersRepository.GetUser(id);
        }
    }
}