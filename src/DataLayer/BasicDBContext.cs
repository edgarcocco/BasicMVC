using BasicMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicMVC.DataLayer
{
    public class BasicDBContext : DbContext
    {
        public DbSet<Message> Messages { get; set; } = null!;
        public BasicDBContext(DbContextOptions<BasicDBContext> options) : base(options)
        {
        }
    }
}
