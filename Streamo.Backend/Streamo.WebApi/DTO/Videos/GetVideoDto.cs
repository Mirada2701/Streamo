using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Videos.Queries.GetVideo;

namespace Streamo.WebApi.DTO.Videos
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
