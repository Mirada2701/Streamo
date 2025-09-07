using MediatR;
using Microsoft.AspNetCore.Mvc;
using Streamo.Application.CQRS.Identity.Users.Queries;
using Streamo.Domain.Entities;
using Streamo.WebAPI.Common.Exceptions;
using Streamo.WebAPI.Filters;
using System.Security.Claims;

namespace Streamo.WebApi.Controllers {
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiExceptionFilter]
    public abstract class BaseController : ControllerBase {
        private IMediator mediator = null!;

        // if this.mediator is null - get and set it from context.
        protected IMediator Mediator => mediator ??=
            HttpContext.RequestServices.GetService<IMediator>() ??
                throw new ServiceNotRegisteredException(nameof(IMediator));

        // get user id from claims (token).
        // if User or Identity is null - set UserId to empty
        internal int UserId =>
            !User?.Identity?.IsAuthenticated ?? false
            ? -1
          : int.Parse(User.FindFirst("userId")?.Value ?? "");

        internal ApplicationUser? CurrentUser { get; set; }

        /// <summary>
        /// This method must be called in each case of 
        /// usage CurrentUser
        /// </summary>
        /// <returns></returns>
        /// <exception cref="UnauthorizedAccessException">Token not provided by user request</exception>
        protected async Task EnsureCurrentUserAssignedAsync() {
            if (CurrentUser is not null)
                return;

            if (!User?.Identity?.IsAuthenticated ?? false)
                throw new UnauthorizedAccessException();

            CurrentUser = await Mediator.Send(new GetUserByIdQuery() {
                UserId = int.Parse(User?.FindFirst("userId")?.Value ?? "")
            });
        }
    }
}
