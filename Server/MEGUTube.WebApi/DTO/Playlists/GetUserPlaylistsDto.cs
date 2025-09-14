using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Playlists.VideoPlaylists.Queries.GetUserPlaylists;

namespace MEGUTube.WebApi.DTO.Playlists {
    public class GetUserPlaylistsDto : IMapWith<GetUserPlaylistsQuery> {
        public int UserId { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<GetUserPlaylistsDto, GetUserPlaylistsQuery>()
                .ForMember(q => q.UserId, opt => opt.MapFrom(dto => dto.UserId))
                .ForMember(q => q.Page, opt => opt.MapFrom(dto => dto.Page))
                .ForMember(q => q.PageSize, opt => opt.MapFrom(dto => dto.PageSize));
        }
    }
}
