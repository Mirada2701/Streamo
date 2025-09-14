using MediatR;
using Microsoft.AspNetCore.Identity;
using MEGUTube.Application.Common.Interfaces;
using MEGUTube.Application.Common.Models;
using MEGUTube.Application.Models.Lookups;
using MEGUTube.Domain.Entities;


namespace MEGUTube.Application.CQRS.Identity.Reports.Queries
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
