using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Videos.Queries.GetVideoListChannel;

namespace Streamo.WebApi.DTO.Videos
{
    public class GetVideoListChannelDto : IMapWith<GetVideoListChannelQuery>
    {
        public int ChannelId { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 5;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetVideoListChannelDto, GetVideoListChannelQuery>()
                .ForMember(query => query.ChannelId, opt => opt.MapFrom(dto => dto.ChannelId))
                .ForMember(query => query.Page, opt => opt.MapFrom(dto => dto.Page))
                .ForMember(query => query.PageSize, opt => opt.MapFrom(dto => dto.PageSize));
        }
    }
}
