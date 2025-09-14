using MEGUTube.Application.Common.Interfaces;

namespace MEGUTube.Infrastructure.Services;

public class DateTimeService : IDateTimeService {
    public DateTime Now => DateTime.UtcNow;
}
