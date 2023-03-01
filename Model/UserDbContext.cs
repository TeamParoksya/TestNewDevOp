using Microsoft.EntityFrameworkCore;

namespace TestNewDev.Model
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> tblDetail { get; set; }
    }
}
