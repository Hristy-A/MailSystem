using MailSystem.Domain.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MailSystem.Infrastructure.Data.Configurations
{
    public class EmailConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.ToTable("emails", "es");

            builder.HasKey(p => p.Id).HasName("pk_email");

            builder.Property(p => p.From)
                .HasMaxLength(320)
                .IsRequired();

            builder.Property(p => p.To)
                .HasMaxLength(320)
                .IsRequired();

            builder.Property(p => p.Cc)
                .HasMaxLength(320)
                .IsRequired(false);

            builder.Property(p => p.Title)
                .HasMaxLength(72)
                .IsRequired();

            builder.Property(p => p.Body)
                .IsRequired(false);

            builder.Property(p => p.IsHtml)
                .HasDefaultValue(false);
        }
    }
}
