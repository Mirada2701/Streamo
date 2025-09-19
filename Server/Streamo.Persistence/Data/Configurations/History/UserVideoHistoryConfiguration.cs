using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Streamo.Domain.Entities;

namespace Streamo.Persistence.Data.Configurations.History
{
    public class UserVideoHistoryConfiguration : IEntityTypeConfiguration<UserVideoHistoryEntity>
    {
        public void Configure(EntityTypeBuilder<UserVideoHistoryEntity> builder)
        {
            builder.HasKey(h => h.Id);

            builder
                .HasOne(h => h.User)
                .WithMany()
                .HasForeignKey(h => h.UserId);

            builder.HasOne(h => h.Video)
                .WithMany()
                .HasForeignKey(h => h.VideoId);
        }
    }
}
