using Microsoft.EntityFrameworkCore;
using QuizApp_API.Models;

namespace QuizApp_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; } = default!;
    }
}
