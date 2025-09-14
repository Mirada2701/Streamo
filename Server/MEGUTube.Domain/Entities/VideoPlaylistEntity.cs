using MEGUTube.Domain.Entities.Abstract;
using MEGUTube.Domain.Entities.ManyToMany;

namespace MEGUTube.Domain.Entities {
    public class VideoPlaylistEntity : OwnedEntity {
        public string Title { get; set; } = null!;
        public Guid? PreviewImage { get; set; }

        public virtual ICollection<PlaylistsVideosManyToMany> PlaylistsVideos { get; set; } = null!;
    }
}
