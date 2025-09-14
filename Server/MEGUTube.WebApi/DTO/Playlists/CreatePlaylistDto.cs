using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Playlists.VideoPlaylists.Commands.CreatePlaylist;
using MEGUTube.Application.CQRS.Playlists.VideoPlaylists.Queries.GetUserPlaylists;

namespace MEGUTube.WebApi.DTO.Playlists {
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
