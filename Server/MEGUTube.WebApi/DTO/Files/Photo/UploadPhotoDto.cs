using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Files.Photos.Commands.UploadPhoto;

namespace MEGUTube.WebApi.DTO.Files.Photo
{
    public class UploadPhotoDto : IMapWith<UploadPhotoCommand>
    {
        public IFormFile Photo { get; set; } = null!;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UploadPhotoDto, UploadPhotoCommand>()
                .ForMember(command => command.Source, opt => opt.MapFrom(dto => dto.Photo.OpenReadStream()));
        }
    }
}
