using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Streamo.Domain.Entities;

namespace Streamo.Persistence.Data.Configurations.Identity
{
    public class SubscriptionEntityConfiguration : IEntityTypeConfiguration<SubscriptionEntity>
    {
        public void Configure(EntityTypeBuilder<SubscriptionEntity> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}