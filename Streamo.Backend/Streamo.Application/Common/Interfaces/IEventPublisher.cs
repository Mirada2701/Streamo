using MediatR;

namespace Streamo.Application.Common.Interfaces {
    public interface IEventPublisher {
        Task SendEvent(object data);
    }
}
