using MediatR;

namespace Streamo.Application.CQRS.Videos.Commands.DeleteVideoAsModerator
{
    public class DeleteVideoAsModeratorCommand : IRequest
    {
        public int? VideoId { get; set; } 
    }
}
