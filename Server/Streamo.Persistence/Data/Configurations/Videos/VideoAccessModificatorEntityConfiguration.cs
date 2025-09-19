using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Streamo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamo.Persistence.Data.Configurations.Videos
{
    public class VideoAccessModificatorEntityConfiguration : IEntityTypeConfiguration<VideoAccessModificatorEntity>
    {
        public void Configure(EntityTypeBuilder<VideoAccessModificatorEntity> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
