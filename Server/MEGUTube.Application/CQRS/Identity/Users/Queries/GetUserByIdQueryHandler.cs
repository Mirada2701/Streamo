using Ardalis.GuardClauses;
using MediatR;
using Microsoft.AspNetCore.Identity;
using MEGUTube.Application.Common.Interfaces;
using MEGUTube.Application.Common.Models;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.Identity.Users.Queries {
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, ApplicationUser> {
        private readonly UserManager<ApplicationUser> _userManager;

        public GetUserByIdQueryHandler(UserManager<ApplicationUser> userManager) {
            _userManager = userManager;
        }

        public async Task<ApplicationUser> Handle(GetUserByIdQuery request, CancellationToken cancellationToken) {
            var user = await _userManager.FindByIdAsync(request.UserId.ToString());

            if (user is null)
                throw new NotFoundException(request.UserId.ToString(), nameof(ApplicationUser));

            return user;
        }
    }
}
