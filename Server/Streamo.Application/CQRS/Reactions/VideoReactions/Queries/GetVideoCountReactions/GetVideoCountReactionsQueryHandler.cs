using MediatR;
using Microsoft.EntityFrameworkCore;
using Streamo.Application.Common.DbContexts;
using Streamo.Application.Common.Interfaces;

namespace Streamo.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoCountReactions {
    public class GetVideoCountReactionsQueryHandler : IRequestHandler<GetVideoCountReactionsQuery, VideoReactionsCount> {
        private readonly IApplicationDbContext _dbContext;

        public GetVideoCountReactionsQueryHandler(IDateTimeService dateTimeService, IApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<VideoReactionsCount> Handle(GetVideoCountReactionsQuery request, CancellationToken cancellationToken) {
            var likesCount = await _dbContext.VideoReactions
                .Where(r =>
                    r.ReactedVideo.Id == request.VideoId &&
                    r.Type == Domain.Entities.VideoReactionEntity.VideoReactionType.Like)
                .CountAsync();

            var dislikesCount = await _dbContext.VideoReactions
                .Where(r =>
                    r.ReactedVideo.Id == request.VideoId &&
                    r.Type == Domain.Entities.VideoReactionEntity.VideoReactionType.Dislike)
                .CountAsync();

            return new VideoReactionsCount() {
                Dislikes = dislikesCount,
                Likes = likesCount
            };
        }
    }
}
