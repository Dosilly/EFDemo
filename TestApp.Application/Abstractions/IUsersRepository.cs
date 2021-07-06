using System.Collections.Generic;
using System.Threading.Tasks;
using TestApp.Domain.Models.Users;

namespace TestApp.Application.Abstractions
{
    public interface IUsersRepository
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUser(int id);
    }
}