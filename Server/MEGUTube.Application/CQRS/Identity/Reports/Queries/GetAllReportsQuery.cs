using MediatR;
using MEGUTube.Application.Models.Lookups;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.Identity.Reports.Queries
{
    public class GetAllReportsQuery : IRequest<IEnumerable<ReportLookup>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
