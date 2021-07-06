using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestApp.Application.Abstractions;
using TestApp.Domain.Models.Users;
using TestApp.Infrastructure.Contexts;

namespace TestApp.Infrastructure.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly UsersContext _usersContext;

        public UsersRepository(UsersContext usersContext)
        {
            _usersContext = usersContext;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _usersContext.Users.ToListAsync();
        }

        public async Task<User> GetUser(int id)
        {
            return await _usersContext.Users.FirstOrDefaultAsync(u => u.UserId == id);
        }
    }
}