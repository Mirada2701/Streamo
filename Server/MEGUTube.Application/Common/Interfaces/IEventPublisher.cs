using MediatR;

namespace MEGUTube.Application.Common.Interfaces {
    public interface IEventPublisher {
        Task SendEvent(object data);
    }
}
