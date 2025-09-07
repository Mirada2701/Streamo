using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Streamo.Domain.Entities;

namespace Streamo.Persistence.Data.Configurations.Notifications {
    internal class NotificationEntityConfiguration : IEntityTypeConfiguration<NotificationEntity> {
        public void Configure(EntityTypeBuilder<NotificationEntity> builder) {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id).IsUnique();

            builder.HasOne(p => p.NotificationIssuer)
                .WithMany()
                .HasForeignKey(p => p.NotificationIssuerId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(n => n.NotificationData)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
