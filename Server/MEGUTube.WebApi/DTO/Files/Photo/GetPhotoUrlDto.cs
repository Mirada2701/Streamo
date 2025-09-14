using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Files.Photos.Queries.GetPhotoUrl;

namespace MEGUTube.WebApi.DTO.Files.Photo
{
    public class GetPhotoUrlDto : IMapWith<GetPhotoUrlQuery>
    {
        public string PhotoId { get; set; } = string.Empty;
        public int Size { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetPhotoUrlDto, GetPhotoUrlQuery>()
                .ForMember(query => query.Size, opt => opt.MapFrom(dto => dto.Size))
                .ForMember(query => query.PhotoId, opt => opt.MapFrom(dto => dto.PhotoId));
        }
    }
}
