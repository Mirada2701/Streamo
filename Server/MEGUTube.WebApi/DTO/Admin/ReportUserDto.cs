using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Identity.Reports.Commands;
using MEGUTube.Application.CQRS.Identity.Users.Commands.BanUser;
using MEGUTube.Application.Models.Lookups;
using static MEGUTube.Domain.Entities.Report;

namespace MEGUTube.WebApi.DTO.Admin
{
    public class ReportUserDto : IMapWith<ReportUserCommand>
    {
        public int AbuserId { get; set; }

        public int? VideoId { get; set; } = null; 

        public string Body { get; set; } = string.Empty;

        public TypeOfReport Type { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ReportUserDto, ReportUserCommand>()
            .ForMember(command => command.AbuserId, opt => opt.MapFrom(dto => dto.AbuserId))
            .ForMember(command => command.TypeOfReport, opt => opt.MapFrom(dto => dto.Type))
            .ForMember(command => command.Body, opt => opt.MapFrom(dto => dto.Body))
            .ForMember(command => command.VideoId, opt => opt.MapFrom(dto => dto.VideoId));
        }


    }
}
