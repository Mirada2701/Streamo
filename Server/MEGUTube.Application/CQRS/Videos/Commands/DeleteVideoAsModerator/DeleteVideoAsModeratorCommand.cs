using MediatR;

namespace MEGUTube.Application.CQRS.Videos.Commands.DeleteVideoAsModerator
{
    public class DeleteVideoAsModeratorCommand : IRequest
    {
        public int? VideoId { get; set; } 
    }
}
