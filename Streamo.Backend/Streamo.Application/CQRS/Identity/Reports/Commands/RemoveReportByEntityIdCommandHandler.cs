using MediatR;
using Microsoft.EntityFrameworkCore;
using Streamo.Application.Common.DbContexts;
using Streamo.Application.Common.Interfaces;


namespace Streamo.Application.CQRS.Identity.Reports.Commands
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
