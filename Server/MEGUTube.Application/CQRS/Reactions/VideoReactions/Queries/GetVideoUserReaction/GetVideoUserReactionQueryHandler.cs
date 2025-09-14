using Ardalis.GuardClauses;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MEGUTube.Application.Common.DbContexts;
using MEGUTube.Application.Common.Interfaces;
using MEGUTube.Application.Models.Lookups;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoUserReaction {
    public class GetVideoUserReactionQueryHandler : IRequestHandler<GetVideoUserReactionQuery, ReactionLookup?> {
        private readonly IApplicationDbContext _dbContext;

        public GetVideoUserReactionQueryHandler(IDateTimeService dateTimeService, IApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<ReactionLookup?> Handle(GetVideoUserReactionQuery request, CancellationToken cancellationToken) {
            var existingReaction = await _dbContext.VideoReactions
                    .Where((r) =>
                        r.ReactedVideo.Id == request.VideoId &&
                        r.Creator.Id == request.UserId)
                    .Select(r => new ReactionLookup() {
                        ReactionType = r.Type
                    })
                    .SingleOrDefaultAsync();

            if (existingReaction is null)
                throw new NotFoundException(request.VideoId.ToString(), nameof(VideoReactionEntity));

            return existingReaction;
        }
    }
}
