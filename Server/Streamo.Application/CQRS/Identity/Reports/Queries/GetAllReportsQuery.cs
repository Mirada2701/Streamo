using MediatR;
using Streamo.Application.Models.Lookups;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.Identity.Reports.Queries
{
    public class GetAllReportsQuery : IRequest<IEnumerable<ReportLookup>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
