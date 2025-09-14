using MEGUTube.Domain.Entities.Abstract;

namespace MEGUTube.Domain.Entities {
    public class VideoCommentEntity : OwnedEntity {
        public string Content { get; set; } = string.Empty;
        public VideoEntity VideoEntity { get; set; } = null!;
        /// <summary>
        /// null - root comment
        /// </summary>
        public VideoCommentEntity? RepliedTo { get; set; } = null;
    }
}
