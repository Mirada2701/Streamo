using MediatR;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.Identity.Users.Commands.ChangeBanner
{
    public class ChangeBannerCommand : IRequest<Unit>
    {
        public Stream? BannerStream { get; set; }
        public ApplicationUser Requester { get; set; }
    }
}
