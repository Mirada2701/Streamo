using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Playlists.VideoPlaylists.Commands.CreatePlaylist;
using Streamo.Application.CQRS.Playlists.VideoPlaylists.Queries.GetUserPlaylists;

namespace Streamo.WebApi.DTO.Playlists {
    public class CreatePlaylistDto : IMapWith<CreatePlaylistCommand> {
        public string Title { get; set; } = null!;
        public IFormFile PreviewImage { get; set; } = null!;

        public void Mapping(Profile profile) {
            profile.CreateMap<CreatePlaylistDto, CreatePlaylistCommand>()
                .ForMember(q => q.Title, opt => opt.MapFrom(dto => dto.Title))
                .ForMember(q => q.PreviewImageStream, opt => opt.MapFrom(dto => dto.PreviewImage.OpenReadStream()));
        }
    }
}
