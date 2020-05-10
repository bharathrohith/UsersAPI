using Microsoft.EntityFrameworkCore;
using UserDataApi.Models;

namespace UserDataApi.Repository
{
    public class UserProfileContext : DbContext
    {
        public UserProfileContext(DbContextOptions<UserProfileContext> options) : base(options)
        {

        }

        public DbSet<UserProfile> Users { get; set; }
    }
}
