using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Playlists.VideoPlaylists.Commands.ToggleVideoPlaylist;
using Streamo.Application.CQRS.Playlists.VideoPlaylists.Commands.CreatePlaylist;

namespace Streamo.WebApi.DTO.Playlists {
    public class ChangeVideoPlaylistDto : IMapWith<ToggleVideoPlaylistCommand> {
        public int VideoId { get; set; }
        public int PlaylistId { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<ChangeVideoPlaylistDto, ToggleVideoPlaylistCommand>()
                .ForMember(q => q.VideoId, opt => opt.MapFrom(dto => dto.VideoId))
                .ForMember(q => q.PlaylistId, opt => opt.MapFrom(dto => dto.PlaylistId));
        }
    }
}
