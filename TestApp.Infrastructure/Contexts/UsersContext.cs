using Microsoft.EntityFrameworkCore;
using TestApp.Domain.Models.Users;

namespace TestApp.Infrastructure.Contexts
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}