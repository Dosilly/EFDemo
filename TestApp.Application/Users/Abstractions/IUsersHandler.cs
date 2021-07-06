using System.Collections.Generic;
using System.Threading.Tasks;
using TestApp.Domain.Models.Users;

namespace TestApp.Application.Users.Abstractions
{
    public interface IUsersHandler
    {
        Task<IEnumerable<User>> GetAllUsersAsync();

        Task<User> GetUser(int id);
    }
}