using MediatR;
using Microsoft.EntityFrameworkCore;
using MEGUTube.Application.Common.DbContexts;
using MEGUTube.Application.Common.Interfaces;
using MEGUTube.Application.Common.Models;
using MEGUTube.Application.CQRS.Comments.VideoComments.Queries.GetVideoCommentsCount;
using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.CQRS.Comments.VideoComments.Queries.GetCommentsList {
    public class GetCommentsListQueryHandler : IRequestHandler<GetCommentsListQuery, GetCommentsListQueryResult> {
        private readonly IDateTimeService _dateTimeService;
        private readonly IApplicationDbContext _dbContext;
        private readonly IMediator _mediator;

        public GetCommentsListQueryHandler(IDateTimeService dateTimeService, IApplicationDbContext dbContext, IMediator mediator) {
            _dateTimeService = dateTimeService;
            _dbContext = dbContext;
            _mediator = mediator;
        }

        public async Task<GetCommentsListQueryResult> Handle(GetCommentsListQuery request, CancellationToken cancellationToken) {
            var query = _dbContext.VideoComments
                .Where(c => c.RepliedTo == null && c.VideoEntity.Id == request.VideoId)
                .OrderByDescending(c => c.DateCreated)
                .Include(c => c.Creator)
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(c => new CommentLookup() {
                    CommentId = c.Id,
                    Content = c.Content,
                    DateCreated = c.DateCreated,
                    Creator = new UserLookup() {
                        UserId = c.Creator.Id,
                        FirstName = c.Creator.FirstName,
                        LastName = c.Creator.LastName,
                        ChannelPhoto = c.Creator.ChannelPhotoFileId.ToString()
                    },
                    RepliesCount = _dbContext.VideoComments.Count(v => v.RepliedTo.Id == c.Id)
                });

            var comments = await query.ToListAsync();

            var totalCount = await _mediator.Send(new GetVideoCommentsCountQuery() {
                VideoId = request.VideoId.Value
            });

            return new GetCommentsListQueryResult() {
                Comments = comments,
                TotalCount = totalCount
            };
        }
    }
}
