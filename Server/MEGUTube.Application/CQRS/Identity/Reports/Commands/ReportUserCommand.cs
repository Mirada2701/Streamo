using MediatR;
using MEGUTube.Application.Common.Models;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.Identity.Reports.Commands
{
    public class ReportUserCommand : IRequest<Result>
    {
        public int AbuserId { get; set; }

        public int CreatorId { get; set; }

        public Report.TypeOfReport TypeOfReport { get; set; }

        public string Body { get; set; } = string.Empty;
        public int VideoId { get; set; } 
    }
}
