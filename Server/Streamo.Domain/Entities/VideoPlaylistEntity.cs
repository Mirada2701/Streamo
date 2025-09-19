using Streamo.Domain.Entities.Abstract;
using Streamo.Domain.Entities.ManyToMany;

namespace Streamo.Domain.Entities {
    public class VideoPlaylistEntity : OwnedEntity {
        public string Title { get; set; } = null!;
        public Guid? PreviewImage { get; set; }

        public virtual ICollection<PlaylistsVideosManyToMany> PlaylistsVideos { get; set; } = null!;
    }
}
