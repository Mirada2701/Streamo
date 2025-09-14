using MediatR;
using MEGUTube.Application.Models.Lookups;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.Identity.Reports.Queries
{
    public class GetAllReportsFromUserQuery : IRequest<IEnumerable<ReportLookup>>
    {
        public int UserId { get; set; }

        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
