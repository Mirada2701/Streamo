using MediatR;
using Microsoft.EntityFrameworkCore;
using Streamo.Application.Common.DbContexts;
using Streamo.Application.Common.Interfaces;
using Streamo.Application.Models.Lookups;

namespace Streamo.Application.CQRS.Comments.VideoComments.Queries.GetVideoCommentsCount {
    public class GetVideoCommentsCountQueryHandler : IRequestHandler<GetVideoCommentsCountQuery, int> {
        private readonly IApplicationDbContext _dbContext;

        public GetVideoCommentsCountQueryHandler(IApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(GetVideoCommentsCountQuery request, CancellationToken cancellationToken) {
            var count = await _dbContext.VideoComments
                .Where(c => c.VideoEntity.Id == request.VideoId && c.RepliedTo == null)
                .CountAsync();

            return count;
        }
    }
}
