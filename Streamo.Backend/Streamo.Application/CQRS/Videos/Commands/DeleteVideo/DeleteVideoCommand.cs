using MediatR;

namespace Streamo.Application.CQRS.Videos.Commands.DeleteVideo
{
    public class DeleteVideoCommand : IRequest
    {
        public int? VideoId { get; set; } = null!;
        public int? RequesterId { get; set; } = null!;
    }
}
