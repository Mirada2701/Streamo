using AutoMapper;
using Streamo.Application.Common.Mappings;
using Streamo.Application.CQRS.Files.Photos.Commands.UploadPhoto;

namespace Streamo.WebApi.DTO.Files.Photo
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
