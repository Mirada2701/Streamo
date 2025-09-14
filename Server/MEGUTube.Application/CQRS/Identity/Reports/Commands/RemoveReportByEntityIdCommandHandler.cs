using MediatR;
using Microsoft.EntityFrameworkCore;
using MEGUTube.Application.Common.DbContexts;
using MEGUTube.Application.Common.Interfaces;


namespace MEGUTube.Application.CQRS.Identity.Reports.Commands
{
    public class RemoveReportByEntityIdCommandHandler : IRequestHandler<RemoveReportByEntityIdCommand>
    {
        private readonly IAdminService _adminService;


        public RemoveReportByEntityIdCommandHandler(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public async Task Handle(RemoveReportByEntityIdCommand request, CancellationToken cancellationToken)
        {
            var result = await _adminService.RemoveReportById(request.ReportId);
        }
    }
}
