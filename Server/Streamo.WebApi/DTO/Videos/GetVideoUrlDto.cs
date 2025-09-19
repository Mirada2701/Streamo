using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Files.Videos.GetVideoFileUrl;

namespace Streamo.WebApi.DTO.Videos
{
    public class GetVideoUrlDto : IMapWith<GetVideoUrlQuery>
    {
        public string VideoFileId { get; set; } = string.Empty;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetVideoUrlDto, GetVideoUrlQuery>()
                .ForMember(query => query.VideoFileId, opt => opt.MapFrom(dto => dto.VideoFileId));
        }
    }
}
