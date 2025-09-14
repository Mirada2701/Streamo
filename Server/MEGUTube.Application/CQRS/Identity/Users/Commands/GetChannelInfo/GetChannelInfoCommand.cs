using MediatR;



namespace MEGUTube.Application.CQRS.Identity.Users.Commands.GetChannelInfo
{
    public class GetChannelInfoCommand : IRequest<GetChannelInfoCommandResult>
    {
        public int UserId { get; set; }

    }
}
