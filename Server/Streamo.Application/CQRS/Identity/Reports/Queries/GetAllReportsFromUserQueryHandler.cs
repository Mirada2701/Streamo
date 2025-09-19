using MediatR;
using Microsoft.AspNetCore.Identity;
using Streamo.Application.Common.Interfaces;
using Streamo.Application.Common.Models;
using Streamo.Application.Models.Lookups;
using Streamo.Domain.Entities;


namespace Streamo.Application.CQRS.Identity.Reports.Queries
{
    public class GetAllReportsFromUserQueryHandler : IRequestHandler<GetAllReportsFromUserQuery, IEnumerable<ReportLookup>>
    {
        private readonly IAdminService adminService;
        private readonly IIdentityService _identityService;
        private readonly IMediator _mediator;

        public GetAllReportsFromUserQueryHandler(IIdentityService identityService, IJwtService jwtService, IPhotoService photoService, IMediator mediator, IAdminService iadminService)
        {
            _identityService = identityService;
            _mediator = mediator;
            adminService = iadminService;
        }
        public async Task<IEnumerable<ReportLookup>> Handle(GetAllReportsFromUserQuery request, CancellationToken cancellationToken)
        {
            return await adminService.GetAllReportsFromUser(request.UserId,request.Page,request.PageSize);
        }
    }
}
