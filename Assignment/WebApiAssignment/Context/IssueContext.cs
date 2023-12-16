using Microsoft.EntityFrameworkCore;
using WebApiAssignment.Models;

namespace WebApiAssignment.Context
{
    public class IssueContext : DbContext
    {
        IConfiguration configuration;

        public DbSet<Issue> Issues { get; set; } = null!;

        public IssueContext(DbContextOptions<IssueContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
