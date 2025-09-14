using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MEGUTube.Domain.Entities;
using MEGUTube.Domain.Entities.ManyToMany;

namespace MEGUTube.Application.Common.DbContexts {
    public interface IApplicationDbContext {
        DbSet<VideoEntity> Videos { get; set; }
        DbSet<VideoCommentEntity> VideoComments { get; set; }
        DbSet<VideoAccessModificatorEntity> VideoAccessModificators { get; set; }
        DbSet<VideoReactionEntity> VideoReactions { get; set; }
        DbSet<VideoPlaylistEntity> VideoPlaylists { get; set; }
        DbSet<PlaylistsVideosManyToMany> PlaylistsVideosManyToMany { get; set; }
        DbSet<SubscriptionEntity> Subscriptions { get; set; }
        DbSet<Report> Reports { get; set; }
        DbSet<NotificationEntity> Notifications { get; set; }
        DbSet<UserVideoHistoryEntity> UserVideoHistories { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
