using MediatR;
using Streamo.Application.Models.Lookups;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.Identity.Reports.Queries
{
    public class GetAllReportsFromUserQuery : IRequest<IEnumerable<ReportLookup>>
    {
        public int UserId { get; set; }

        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
