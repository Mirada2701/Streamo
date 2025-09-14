using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Playlists.VideoPlaylists.Queries.GetPlaylistVideos;

namespace MEGUTube.WebApi.DTO.Playlists {
    public class GetPlaylistVideosDto : IMapWith<GetPlaylistVideosQuery> {
        public int? PlaylistId { get; set; } = null!;
        public int Page { get; set; }
        public int PageSize { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<GetPlaylistVideosDto, GetPlaylistVideosQuery>()
                .ForMember(q => q.PlaylistId, opt => opt.MapFrom(dto => dto.PlaylistId))
                .ForMember(q => q.Page, opt => opt.MapFrom(dto => dto.Page))
                .ForMember(q => q.PageSize, opt => opt.MapFrom(dto => dto.PageSize));
        }
    }
}
