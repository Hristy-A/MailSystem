using System.Reflection;
using MailSystem.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace MailSystem.Infrastructure.Data
{
    public class MailSystemContext : DbContext
    {
        public DbSet<Email> Emails { get; set; } = null!;

        public MailSystemContext() { }
        public MailSystemContext(DbContextOptions<MailSystemContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}