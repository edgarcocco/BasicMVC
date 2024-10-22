using BasicMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicMVC.DataLayer
{
    public class BasicDbContext : DbContext
    {
        public DbSet<Message> Messages { get; set; } = null!;
        public BasicDbContext(DbContextOptions<BasicDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Message>().HasData(
                new Message {Id=1, MessageText = "Message One" },
                new Message {Id=2, MessageText = "Message Two" }
            );
        }
    }
}
