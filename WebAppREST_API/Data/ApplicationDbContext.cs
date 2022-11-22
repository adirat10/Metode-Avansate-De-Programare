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
        public DbSet<Email> Emails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>().HasOne(e => e.From).WithMany(p => p.SentEmails);
            //odelBuilder.Entity<Email>().HasMany(e => e.To).WithMany(p => p.InboxEmails);
        }
    }
}
