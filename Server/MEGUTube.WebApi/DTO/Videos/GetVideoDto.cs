using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Videos.Queries.GetVideo;

namespace MEGUTube.WebApi.DTO.Videos
{
    public class GetVideoDto : IMapWith<GetVideoQuery>
    {
        public int VideoId { get; set; } = 0;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetVideoDto, GetVideoQuery>()
                .ForMember(query => query.VideoId, opt => opt.MapFrom(dto => dto.VideoId));
        }
    }
}
