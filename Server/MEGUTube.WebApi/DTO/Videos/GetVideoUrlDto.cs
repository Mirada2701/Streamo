using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Files.Videos.GetVideoFileUrl;

namespace MEGUTube.WebApi.DTO.Videos
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
