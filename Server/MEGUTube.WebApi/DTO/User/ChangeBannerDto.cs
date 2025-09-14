using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Identity.Users.Commands.ChangeBanner;

namespace MEGUTube.WebApi.DTO.User
{
    public class ChangeBannerDto : IMapWith<ChangeBannerCommand>
    {
        public IFormFile? BannerFileId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ChangeBannerDto, ChangeBannerCommand>()
                .ForMember(command => command.BannerStream, opt => opt.MapFrom(dto => dto.BannerFileId.OpenReadStream()));
        }
    }
}
