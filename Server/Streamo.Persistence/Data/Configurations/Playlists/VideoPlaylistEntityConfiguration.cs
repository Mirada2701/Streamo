using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Streamo.Domain.Entities;

namespace Streamo.Persistence.Data.Configurations.Playlists {
    public class VideoPlaylistEntityConfiguration : IEntityTypeConfiguration<VideoPlaylistEntity> {
        public void Configure(EntityTypeBuilder<VideoPlaylistEntity> builder) {
            builder.HasKey(x => x.Id);

            builder.HasOne(r => r.Creator)
                .WithMany();
        }
    }
}
