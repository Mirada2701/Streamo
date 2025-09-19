using MediatR;
using Microsoft.AspNetCore.Identity;
using Streamo.Application.Common.Interfaces;
using Streamo.Application.Common.Models;
using Streamo.Application.Models.Lookups;
using Streamo.Domain.Entities;


namespace Streamo.Application.CQRS.Identity.Reports.Queries
{
    public class GetAllReportsQueryHandler : IRequestHandler<GetAllReportsQuery, IEnumerable<ReportLookup>>
    {
        private readonly IAdminService adminService;
        private readonly IIdentityService _identityService;
        private readonly IMediator _mediator;




        public GetAllReportsQueryHandler(IIdentityService identityService, IJwtService jwtService, IPhotoService photoService, IMediator mediator, IAdminService iadminService)
        {
            _identityService = identityService;
            _mediator = mediator;
            adminService = iadminService;
        }
        public async Task<IEnumerable<ReportLookup>> Handle(GetAllReportsQuery request, CancellationToken cancellationToken)
        {
            return await adminService.GetAllReports(request.Page,request.PageSize);
        }
    }
}
