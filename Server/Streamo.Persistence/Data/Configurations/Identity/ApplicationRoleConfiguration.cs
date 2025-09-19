using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Streamo.Domain.Entities;

namespace Streamo.Persistence.Data.Configurations.Identity
{
    public class ApplicationRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            #region Properties

            #endregion
        }
    }
}
