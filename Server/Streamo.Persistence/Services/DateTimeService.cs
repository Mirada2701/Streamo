using Streamo.Application.Common.Interfaces;

namespace Streamo.Infrastructure.Services;

public class DateTimeService : IDateTimeService {
    public DateTime Now => DateTime.UtcNow;
}
