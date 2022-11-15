using Microsoft.EntityFrameworkCore;
using WebAppREST_API.Models;

namespace WebAppREST_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> People { get; set; }
    }
}
