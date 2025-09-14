using MediatR;

namespace MEGUTube.Application.CQRS.Identity.Reports.Commands
{
    public class RemoveReportByEntityIdCommand : IRequest
    {
        public int ReportId { get; set; } = 0;
    }
}
