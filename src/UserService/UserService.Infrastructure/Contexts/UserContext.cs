using Microsoft.EntityFrameworkCore;
using UserService.Domain;

namespace UserService.Infrastructure.Contexts;
public sealed class UserContext: DbContext
{
    public DbSet<User> Users => Set<User>();

    public UserContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }
}
