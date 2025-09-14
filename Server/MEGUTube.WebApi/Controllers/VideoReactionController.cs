using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebShop.Domain.Constants;
using MEGUTube.Application.CQRS.Comments.VideoComments.Queries.GetCommentsList;
using MEGUTube.Application.CQRS.Comments.VideoComments.Commands.AddComment;
using MEGUTube.Application.CQRS.Comments.VideoComments.Commands.DeleteComment;
using MEGUTube.WebApi.DTO.Comments.VideoComments;
using MEGUTube.Application.CQRS.Comments.VideoComments.Commands.AddCommentReply;
using MEGUTube.Application.CQRS.Comments.VideoComments.Queries.GetCommentRepliesList;
using MEGUTube.Application.CQRS.Reactions.VideoReactions.Commands.SetReaction;
using MEGUTube.Domain.Entities;
using MEGUTube.WebApi.DTO.Reactions.VideoReactions;
using MEGUTube.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoUserReaction;
using MEGUTube.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoCountReactions;
using MEGUTube.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoCountReactionsWithUserReaction;

namespace MEGUTube.WebApi.Controllers {
    [Route("api/Video/Reaction/[action]")]
    public class VideoReactionController : BaseController {
        private readonly IMapper mapper;

        public VideoReactionController(IMapper mapper) {
            this.mapper = mapper;
        }

        [HttpPost]
        [Authorize(Roles = Roles.User)]
        public async Task<ActionResult> ReactVideo([FromBody] ToggleVideoReactionDto dto) {
            await EnsureCurrentUserAssignedAsync();

            var command = mapper.Map<SetReactionCommand>(dto);
            command.Requester = CurrentUser;

            var result = await Mediator.Send(command);

            return Ok(result);
        }

        [HttpGet("{videoId}")]
        [Authorize(Roles = Roles.User)]
        public async Task<ActionResult> GetRequesterReaction([FromRoute] int videoId) {
            var query = new GetVideoUserReactionQuery() {
                UserId = this.UserId,
                VideoId = videoId
            };
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{videoId}")]
        public async Task<ActionResult> GetCountVideoReactions([FromRoute] int videoId) {
            var query = new GetVideoCountReactionsQuery() {
                VideoId = videoId,
            };
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{videoId}")]
        [Authorize(Roles = Roles.User)]
        public async Task<ActionResult> GetCountVideoReactionsWithStatus([FromRoute] int videoId) {
            var query = new GetVideoCountReactionsWithUserReactionQuery() {
                VideoId = videoId,
                RequesterId = UserId
            };
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}
