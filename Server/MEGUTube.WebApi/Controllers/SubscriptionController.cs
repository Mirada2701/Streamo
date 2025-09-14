using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MEGUTube.Application.Common.Interfaces;
using MEGUTube.Application.CQRS.Comments.VideoComments.Commands.AddComment;
using MEGUTube.Application.CQRS.Comments.VideoComments.Commands.DeleteComment;
using MEGUTube.Application.CQRS.Comments.VideoComments.Queries.GetCommentsList;
using MEGUTube.Application.CQRS.SubscriptionUser.AddSubscriptionUser;
using MEGUTube.Application.CQRS.SubscriptionUser.CheckSubscriptionUser;
using MEGUTube.Application.CQRS.SubscriptionUser.DeleteSubscriptionUserCommand;
using MEGUTube.Application.CQRS.SubscriptionUser.Queries;
using MEGUTube.WebApi.DTO.Auth.Subscription;
using MEGUTube.WebApi.DTO.Auth.User;
using MEGUTube.WebApi.DTO.Comments.VideoComments;
using System.Security.Principal;
using WebShop.Domain.Constants;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MEGUTube.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionController : BaseController
    {
       
        private readonly IMapper mapper;

        public SubscriptionController( IMapper mapper)
        {
         
            this.mapper = mapper;
        }
        [Authorize(Roles = Roles.User)]
        [HttpPost("Subscribe")]
        public async Task<IActionResult> Subscribe([FromBody] AddSubscriptionUserDto dto)
        {
            await EnsureCurrentUserAssignedAsync();

            var command = mapper.Map<AddSubscriptionUserCommand>(dto);

            command.User = CurrentUser.Id;

            var result = await Mediator.Send(command);

            return Ok(result);
        }
        [Authorize(Roles = Roles.User)]
        [HttpGet("Subscriptions")]
        public async Task<ActionResult> GetSubscribeList( )
        { 
            var query = new GetSubscriptionListQuery
            {
                SubscriptionUserTo = UserId
            };
            var result = await Mediator.Send(query);
            return Ok(result);
        }
        [Authorize(Roles = Roles.User)]
        [HttpGet("isSubscriptions")]
        public async Task<ActionResult> CheckSubscriber([FromQuery] CheckSubscribeUserDto dto)
        {
            await EnsureCurrentUserAssignedAsync();
            var query = mapper.Map<CheckSubscriptionUserCommand>(dto);
            query.UserID = CurrentUser.Id;
            var result = await Mediator.Send(query);
            return Ok(result);
        }
        [Authorize(Roles = Roles.User)]
        [HttpDelete("UnSubscribe")]
        public async Task<IActionResult> UnSubscribe([FromQuery] DeleteSubscriptionUserDto dto)
        {
            await EnsureCurrentUserAssignedAsync();
            var command = mapper.Map<DeleteSubscriptionUserCommand>(dto);
            command.User = CurrentUser.Id;

            var result = await Mediator.Send(command);

            return Ok(result);
        }

    }
}