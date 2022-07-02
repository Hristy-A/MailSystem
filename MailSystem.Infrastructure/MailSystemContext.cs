using MailSystem.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace MailSystem.Infrastructure.Data
{
    public class MailSystemContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; } = null!;

        public MailSystemContext() { }
        public MailSystemContext(DbContextOptions<MailSystemContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}